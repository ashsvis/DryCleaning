using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Workstation
{
    public partial class MainPanel : UserControl
    {
        private Root _root;

        public MainPanel(Root root)
        {
            InitializeComponent();
            _root = root;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if (MainForm.ClientsForm == null) MainForm.ClientsForm = new ClientsForm(_root);
            MainForm.ShowForm(MainForm.ClientsForm);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (MainForm.EmployeesForm == null) MainForm.EmployeesForm = new EmployeesForm(_root);
            MainForm.ShowForm(MainForm.EmployeesForm);
        }
    }
}
