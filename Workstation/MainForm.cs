using Model;
using System;
using System.IO;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class MainForm : Form
    {
        private Root _root = new Root();
        public static ServicesForm ServicesForm;
        public static ClientsForm ClientsForm;
        public static EmployeesForm EmployeesForm;
        public static AppointmentsForm AppointmentsForm;
        public static SentencesForm SentencesForm;

        public MainForm()
        {
            InitializeComponent();
            GridPanelBuilder.Error += GridPanelBuilder_Error;
        }

        private void GridPanelBuilder_Error(string message, string caption)
        {
            MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            // загрузка базы
            var fileName = Path.ChangeExtension(Application.ExecutablePath, ".bin");
            if (File.Exists(fileName))
            {
                _root = SaverLoader.LoadFromFile(fileName);
                _root.RegistryTables();
            }
            // подгрузка заставки
            pnlContainer.Controls.Clear();
            var mainPanel = new MainPanel(_root);
            pnlContainer.Controls.Add(mainPanel);
        }

        private void tsmiDictionaries_DropDownOpening(object sender, EventArgs e)
        {
            tsmiDictionaries.DropDownItems.Clear();
            foreach (var tableName in _root.GetTableNames())
            {
                var tsmi = new ToolStripMenuItem { Text = tableName };
                tsmi.Click += (o, arg) =>
                {
                    pnlContainer.Controls.Clear();
                    var tableItem = _root.GetTableInfo(tableName);
                    if (tableItem != null)
                        pnlContainer.Controls.Add(GridPanelBuilder.BuildPropertyPanel(_root, tableItem.Item, tableItem.Table));
                };
                tsmiDictionaries.DropDownItems.Add(tsmi);
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaverLoader.SaveToFile(Path.ChangeExtension(Application.ExecutablePath, ".bin"), _root);
        }

        private void tsmiServices_Click(object sender, EventArgs e)
        {
            if (ServicesForm == null) ServicesForm = new ServicesForm(_root);
            ShowForm(ServicesForm);
        }

        private void tsmiClients_Click(object sender, EventArgs e)
        {
            if (ClientsForm == null) ClientsForm = new ClientsForm(_root);
            ShowForm(ClientsForm);
        }

        private void tsmiEmployees_Click(object sender, EventArgs e)
        {
            if (EmployeesForm == null) EmployeesForm = new EmployeesForm(_root);
            ShowForm(EmployeesForm);
        }

        public static void ShowForm(Form form)
        {
            form.Show();
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;
            form.BringToFront();
        }

        private void tsmiEditSentences_Click(object sender, EventArgs e)
        {
            if (SentencesForm == null) SentencesForm = new SentencesForm(_root);
            ShowForm(SentencesForm);
        }
    }
}
