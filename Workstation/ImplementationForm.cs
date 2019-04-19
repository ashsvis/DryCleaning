using Model;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class ImplementationForm : Form
    {
        public ImplementationForm(Root root)
        {
            InitializeComponent();
            panel1.Controls.Add(GridPanelBuilder.BuildPropertyPanel(root, new Implementation(), root.Implementations));
        }

        private void ImplementationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
