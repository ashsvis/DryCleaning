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
        }

        private void Panel_GridSelectedChanged(object obj)
        {
            throw new NotImplementedException();
        }

        private void SentencesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
