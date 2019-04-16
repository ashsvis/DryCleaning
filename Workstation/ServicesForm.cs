using Model;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class ServicesForm : Form
    {
        public ServicesForm(Root _root)
        {
            InitializeComponent();
            panel1.Controls.Add(GridPanelBuilder.BuildPropertyPanel(_root, new Service(), _root.Services));
        }

        private void ServicesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
