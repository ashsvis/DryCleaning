using Model;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class EmployeesForm : Form
    {
        private Root _root;

        public EmployeesForm(Root root)
        {
            InitializeComponent();
            _root = root;
            panel1.Controls.Add(GridPanelBuilder.BuildPropertyPanel(root, new Employee(), root.Employees));
        }

        private void EmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void tsmiClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void tsmiAppointments_Click(object sender, System.EventArgs e)
        {
            if (MainForm.AppointmentsForm == null) MainForm.AppointmentsForm = new AppointmentsForm(_root);
            MainForm.ShowForm(MainForm.AppointmentsForm);
        }
    }
}
