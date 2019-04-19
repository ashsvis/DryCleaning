using Model;
using System;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class ImplementationForm : Form
    {
        private Root _root;
        private GridPanel gridPanel;

        public ImplementationForm(Root root)
        {
            InitializeComponent();
            _root = root;
            gridPanel = GridPanelBuilder.BuildPropertyPanel(root, new Implementation(), root.Implementations);
            panel1.Controls.Add(gridPanel);
            gridPanel.GridSelectedChanged += GridPanel_GridSelectedChanged;
            btnEditSentence.Enabled = false;
        }

        private void GridPanel_GridSelectedChanged(object obj)
        {
            btnEditSentence.Enabled = obj != null;
        }

        private void ImplementationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnEmployeesReport_Click(object sender, System.EventArgs e)
        {
            var frm = new MasterForm(_root);
            frm.ShowDialog(this);
            btnEditSentence.Enabled = false;
        }

        private void ImplementationForm_Activated(object sender, System.EventArgs e)
        {
            gridPanel = GridPanelBuilder.BuildPropertyPanel(_root, new Implementation(), _root.Implementations);
            panel1.Controls.Add(gridPanel);
            gridPanel.GridSelectedChanged += GridPanel_GridSelectedChanged;
            panel1.Controls.RemoveAt(0);
        }
    }
}
