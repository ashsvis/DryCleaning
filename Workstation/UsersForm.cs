using Model;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class UsersForm : Form
    {
        public UsersForm(Root root)
        {
            InitializeComponent();
            panel1.Controls.Add(GridPanelBuilder.BuildPropertyPanel(root, new User(), root.Users));
        }

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
