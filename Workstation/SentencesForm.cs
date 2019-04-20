using Model;
using System;
using System.Linq;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class SentencesForm : Form
    {
        private Root _root;
        private Sentence _sentence;

        public SentencesForm(Root root)
        {
            InitializeComponent();
            _root = root;
            var panel = GridPanelBuilder.BuildPropertyPanel(root, new Sentence(), root.Sentences);
            panel.GridSelectedChanged += Panel_GridSelectedChanged;
            panel1.Controls.Add(panel);
            panel2.Controls.Add(GridPanelBuilder.BuildPropertyPanel(root, new Category(), 
                root.Categories.FilteredBySentence(Guid.Empty)));
            btnSummCalculation.Enabled = btnCategoryReport.Enabled = panel2.Enabled = false;
        }

        private void Panel_GridSelectedChanged(object obj)
        {
            _sentence = (Sentence)obj;
            if (_sentence != null)
            {
                panel2.Controls.Add(GridPanelBuilder.BuildPropertyPanel(_root, new Category(), _root.Categories,
                    _root.Categories.FilteredBySentence(_sentence.IdSentence), "IdSentence", _sentence.IdSentence));
                btnSummCalculation.Enabled = btnCategoryReport.Enabled = panel2.Enabled = true;
            }
            else
            {
                panel2.Controls.Add(GridPanelBuilder.BuildPropertyPanel(_root, new Category(),
                    _root.Categories.FilteredBySentence(Guid.Empty)));
                btnSummCalculation.Enabled = btnCategoryReport.Enabled = panel2.Enabled = false;
            }
            panel2.Controls.RemoveAt(0);
        }

        private void SentencesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void tsmiEditServices_Click(object sender, System.EventArgs e)
        {
            if (MainForm.ServicesForm == null) MainForm.ServicesForm = new ServicesForm(_root);
            MainForm.ShowForm(MainForm.ServicesForm);
        }

        private void tsmiEditSentenceTypes_Click(object sender, System.EventArgs e)
        {
            if (MainForm.SentenceTypesForm == null) MainForm.SentenceTypesForm = new SentenceTypesForm(_root);
            MainForm.ShowForm(MainForm.SentenceTypesForm);
        }

        private void tsmiProduct_DropDownOpening(object sender, EventArgs e)
        {
            tsmiThisSentenceReport.Enabled = tsmiSummCalculation.Enabled =
                btnSummCalculation.Enabled = btnCategoryReport.Enabled = _sentence != null;
        }

        private void btnSummCalculation_Click(object sender, EventArgs e)
        {
            if (_sentence == null) return;
            _sentence.Price = Helper.CalculateSentencePrice(_sentence);
            // обновить данные
            var panel = GridPanelBuilder.BuildPropertyPanel(_root, new Sentence(), _root.Sentences);
            panel.GridSelectedChanged += Panel_GridSelectedChanged;
            panel1.Controls.Add(panel);
            panel1.Controls.RemoveAt(0);
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
