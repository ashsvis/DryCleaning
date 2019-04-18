using Model;
using System;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class SentencesForm : Form
    {
        private Root _root;

        public SentencesForm(Root root)
        {
            InitializeComponent();
            _root = root;
            var panel = GridPanelBuilder.BuildPropertyPanel(root, new Sentence(), root.Sentences);
            panel.GridSelectedChanged += Panel_GridSelectedChanged;
            panel1.Controls.Add(panel);
            panel2.Controls.Add(GridPanelBuilder.BuildPropertyPanel(root, new Category(), 
                root.Categories.FilteredBySentence(Guid.Empty)));
            btnCategoryReport.Enabled = panel2.Enabled = false;
        }

        private void Panel_GridSelectedChanged(object obj)
        {
            var sentence = (Sentence)obj;
            if (sentence != null)
            {
                panel2.Controls.Add(GridPanelBuilder.BuildPropertyPanel(_root, new Category(),
                    _root.Categories.FilteredBySentence(sentence.IdSentence), sentence.IdSentence));
                btnCategoryReport.Enabled = panel2.Enabled = true;
            }
            else
            {
                panel2.Controls.Add(GridPanelBuilder.BuildPropertyPanel(_root, new Category(),
                    _root.Categories.FilteredBySentence(Guid.Empty)));
                btnCategoryReport.Enabled = panel2.Enabled = false;
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
    }
}
