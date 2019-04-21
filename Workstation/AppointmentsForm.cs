using Model;
using System.IO;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class AppointmentsForm : Form
    {
        GridPanel gridPanel;
        Appointment _appointment;

        public AppointmentsForm(Root root)
        {
            InitializeComponent();
            gridPanel = GridPanelBuilder.BuildPropertyPanel(root, new Appointment(), root.Appointments);
            panel1.Controls.Add(gridPanel);
            gridPanel.GridSelectedChanged += GridPanel_GridSelectedChanged;
        }

        private void GridPanel_GridSelectedChanged(object obj)
        {
            _appointment = (Appointment)obj;
            if (_appointment != null)
            {
                tbDescription.Text = _appointment.Description;
                tbJobDescription.Text = _appointment.JobDescription;
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

        private void btnSaveJobDescriptionToFile_Click(object sender, System.EventArgs e)
        {
            if (_appointment == null) return;
            var dlg = new SaveFileDialog
            {
                Filter = @"Текстовый файл|*.txt",
                FileName = $"{_appointment.Name} (должностная инструкция).txt"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(dlg.FileName, _appointment.JobDescription);
        }
    }
}
