using Model;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class ClientsForm : Form
    {
        public ClientsForm(Root root)
        {
            InitializeComponent();
            panel1.Controls.Add(GridPanelBuilder.BuildPropertyPanel(root, new Client(), root.Clients));
        }

        private void ClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void tsmiClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
