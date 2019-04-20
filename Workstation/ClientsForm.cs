using Model;
using System;
using System.IO;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class ClientsForm : Form
    {
        GridPanel _gridPanel;
        Root _root;
        Client _client;

        public ClientsForm(Root root)
        {
            InitializeComponent();
            _root = root;
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

        private void btnClientsReport_Click(object sender, System.EventArgs e)
        {
            try
            {
                var app = new Microsoft.Office.Interop.Word.Application();
                var filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Reports", "Clients.docx");
                var oDoc = app.Documents.Add(filename);
                oDoc.Application.Visible = true;
                var row = 1;
                foreach (var client in _root.Clients)
                {
                    oDoc.Bookmarks[$"s{row}1"].Range.Text = client.Surname;
                    oDoc.Bookmarks[$"s{row}2"].Range.Text = client.FirstName;
                    oDoc.Bookmarks[$"s{row}3"].Range.Text = client.LastName;
                    oDoc.Bookmarks[$"s{row}4"].Range.Text = client.Address;
                    oDoc.Bookmarks[$"s{row}5"].Range.Text = client.Passport;
                    oDoc.Bookmarks[$"s{row}6"].Range.Text = client.RegistrationDate.ToShortDateString();
                    row++;
                }
                Application.OpenForms[0].SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void btnPrintCard_Click(object sender, EventArgs e)
        {
            if (_client == null) return;
            try
            {
                var app = new Microsoft.Office.Interop.Excel.Application();
                var filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Reports", "Client.xltx");
                var wb = app.Workbooks.Open(filename, 0, true);
                app.Application.Visible = true;
                var sheet = wb.Sheets[1];
                sheet.Cells[8, 2] = "ООО ФИРМА";
                sheet.Cells[20, 3] = _client.Surname;
                sheet.Cells[20, 6] = _client.FirstName;
                sheet.Cells[20, 9] = _client.LastName;
                sheet.Cells[21, 4] = _client.RegistrationDate.ToShortDateString();
                sheet.Cells[23, 4] = _client.Passport;
                sheet.Cells[25, 4] = _client.Address;
                Application.OpenForms[0].SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }
    }
}
