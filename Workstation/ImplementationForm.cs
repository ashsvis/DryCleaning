using Model;
using System;
using System.IO;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class ImplementationForm : Form
    {
        private Root _root;
        private GridPanel gridPanel;
        Implementation _implementation;

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
            _implementation = (Implementation)obj;
            btnEditSentence.Enabled = _implementation != null;
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

        private void btnEditSentence_Click(object sender, EventArgs e)
        {
            if (_implementation == null) return;
            var client = Helper.ClientById(_implementation.IdClient);
            if (client == null) return;
            var employee = Helper.EmployeeById(_implementation.IdEmployee);
            if (employee == null) return;
            var sentence = Helper.SentenceById(_implementation.IdSentence);
            if (sentence == null) return;
            try
            {
                var app = new Microsoft.Office.Interop.Excel.Application();
                var filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Reports", "Check.xltx");
                var wb = app.Workbooks.Open(filename, 0, true);
                app.Application.Visible = true;
                var sheet = wb.Sheets[1];
                sheet.Cells[11, 7] = employee.Surname;
                sheet.Cells[12, 7] = employee.FirstName;
                sheet.Cells[13, 7] = employee.LastName;
                sheet.Cells[15, 7] = client.Surname;
                sheet.Cells[16, 7] = client.FirstName;
                sheet.Cells[17, 7] = client.LastName;
                double summ = Convert.ToDouble(sentence.Price);
                sheet.Cells[19, 7] = summ;
                sheet.Cells[19, 19] = Helper.CurrencyToTxt(summ, false);
                Application.OpenForms[0].SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

    }
}
