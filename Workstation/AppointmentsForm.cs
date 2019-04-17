using Model;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class AppointmentsForm : Form
    {
        GridPanel gridPanel;

        public AppointmentsForm(Root root)
        {
            InitializeComponent();
            gridPanel = GridPanelBuilder.BuildPropertyPanel(root, new Appointment(), root.Appointments);
            panel1.Controls.Add(gridPanel);
            gridPanel.GridSelectedChanged += GridPanel_GridSelectedChanged;
        }

        private void GridPanel_GridSelectedChanged(object obj)
        {
            if (obj != null)
            {
                var appointment = (Appointment)obj;
                tbDescription.Text = appointment.Description;
                tbJobDescription.Text = appointment.JobDescription;
                btnSaveJobDescriptionToFile.Enabled = true;
            }
            else
            {
                tbDescription.Text = "";
                tbJobDescription.Text = "";
                btnSaveJobDescriptionToFile.Enabled = false;
            }
        }

        private void AppointmentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
