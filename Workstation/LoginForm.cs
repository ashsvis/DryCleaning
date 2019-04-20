using Model;
using System;
using System.Linq;
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

        private void btnEnter_Click(object sender, System.EventArgs e)
        {
            if (CheckValidLoginPassword())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show(this, "Логин или пароль пользователя неверны", "Попытка входа в программу",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckValidLoginPassword()
        {
            return _root.Users.Any(item => item.IdEmployee == ((Employee)cbEmployee.SelectedItem).IdEmployee &&
                                   item.Login == tbLogin.Text && item.Password == tbPassword.Text);
        }
    }
}
