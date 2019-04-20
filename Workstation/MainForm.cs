using Model;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class MainForm : Form
    {
        private Root _root = new Root();
        private MainPanel _mainPanel;
        public static ServicesForm ServicesForm;
        public static ClientsForm ClientsForm;
        public static EmployeesForm EmployeesForm;
        public static AppointmentsForm AppointmentsForm;
        public static SentencesForm SentencesForm;
        public static SentenceTypesForm SentenceTypesForm;
        public static ImplementationForm ImplementationForm;
        public static UsersForm UsersForm;
        public static StatisticsForm StatisticsForm;

        private bool _loggedIn = true; // не забудь перевести в false

        public MainForm()
        {
            InitializeComponent();
            Helper.DefineRoot(_root);
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
                Helper.DefineRoot(_root);
                _root.RegistryTables();
            }
            // подгрузка заставки
            pnlContainer.Controls.Clear();
            _mainPanel = new MainPanel(_root);
            pnlContainer.Controls.Add(_mainPanel);
            _mainPanel.Enabled = false;
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

        private void tsmiImplementationOrganization_Click(object sender, EventArgs e)
        {
            if (ImplementationForm == null) ImplementationForm = new ImplementationForm(_root);
            ShowForm(ImplementationForm);
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            if (UsersForm == null) UsersForm = new UsersForm(_root);
            ShowForm(UsersForm);
        }

        private void tsmiMaster_Click(object sender, EventArgs e)
        {
            var frm = new MasterForm(_root);
            frm.ShowDialog(this);
        }

        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            if (_root.Employees.Count > 0)
            {
                var frm = new LoginForm(_root);
                var lastLogin = _loggedIn;
                _loggedIn = frm.ShowDialog(this) == DialogResult.OK;
                if (lastLogin) _loggedIn = lastLogin;
                UpdateInterface();
            }
            else
                MessageBox.Show("Нет ни одной записи в таблице пользователей");
        }

        private void UpdateInterface()
        {
            _mainPanel.Enabled = tsmiMaster.Enabled = tsmiReports.Enabled = tsmiPriceList.Enabled = _loggedIn;
        }

        private void tsmiActions_DropDownOpening(object sender, EventArgs e)
        {
            foreach (var item in tsmiActions.DropDownItems.OfType<ToolStripMenuItem>())
            {
                item.Enabled = _loggedIn;
            }
        }

        private void tsmiPriceList_Click(object sender, EventArgs e)
        {
            try
            {
                var app = new Microsoft.Office.Interop.Word.Application();
                var filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Reports", "Pricelist.docx");
                var oDoc = app.Documents.Add(filename);
                oDoc.Application.Visible = true;
                var row = 1;
                foreach (var sentence in _root.Sentences)
                {
                    oDoc.Bookmarks[$"s{row}1"].Range.Text = sentence.Name;
                    oDoc.Bookmarks[$"s{row}2"].Range.Text = Helper.SentenceTypeNameById(sentence.IdSentenceType);
                    oDoc.Bookmarks[$"s{row}3"].Range.Text = sentence.Price.ToString();
                    row++;
                }
                Application.OpenForms[0].SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void tsmiReports_Click(object sender, EventArgs e)
        {
            if (StatisticsForm == null) StatisticsForm = new StatisticsForm(_root);
            ShowForm(StatisticsForm);
        }
    }
}
