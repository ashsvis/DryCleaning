using Model;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class ClientsForm : Form
    {
        GridPanel _gridPanel;
        Client _client;

        public ClientsForm(Root root)
        {
            InitializeComponent();
            _gridPanel = GridPanelBuilder.BuildPropertyPanel(root, new Client(), root.Clients);
            panel1.Controls.Add(_gridPanel);
            _gridPanel.GridSelectedChanged += _gridPanel_GridSelectedChanged;
            btnPrintCard.Enabled = false;
        }

        private void _gridPanel_GridSelectedChanged(object obj)
        {
            _client = (Client)obj;
            btnPrintCard.Enabled = _client != null;
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

        private void tsmiClients_DropDownOpening(object sender, System.EventArgs e)
        {
            tsmiClientCard.Enabled = _client != null;
        }
    }
}
