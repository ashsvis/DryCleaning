using Model;
using System.Windows.Forms;

namespace Workstation
{
    public partial class LoginForm : Form
    {
        private readonly Root _root;

        public LoginForm(Root root)
        {
            InitializeComponent();
            _root = root;
            foreach (var employee in _root.Employees)
            {
                cbEmployee.Items.Add(employee);
            }
        }

        private void cbEmployee_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            btnEnter.Enabled = cbEmployee.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(tbLogin.Text) &&
                !string.IsNullOrWhiteSpace(tbPassword.Text);
        }
    }
}
