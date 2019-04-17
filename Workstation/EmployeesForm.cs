using Model;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class EmployeesForm : Form
    {
        private Root _root;
        private Employee _employee;

        public EmployeesForm(Root root)
        {
            InitializeComponent();
            _root = root;
            var panel = GridPanelBuilder.BuildPropertyPanel(root, new Employee(), root.Employees);
            panel.GridSelectedChanged += Panel_GridSelectedChanged;
            panel1.Controls.Add(panel);
        }

        public static Image CreateImage(byte[] imageData)
        {
            Image image;
            using (MemoryStream inStream = new MemoryStream())
            {
                inStream.Write(imageData, 0, imageData.Length);
                image = Bitmap.FromStream(inStream);
            }
            return image;
        }

        public static byte[] CreateByteArray(Image image)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                image.Save(outStream, System.Drawing.Imaging.ImageFormat.Png);
                return outStream.ToArray();
            }
        }

        private void Panel_GridSelectedChanged(object obj)
        {
            if (obj != null)
            {
                btnBuildCard.Enabled = true;
                btnSelectPhoto.Enabled = true;
                _employee = (Employee)obj;
                if (_employee.Photo != null && _employee.Photo.Length > 0)
                    pbPhoto.Image = CreateImage(_employee.Photo);
                else
                    pbPhoto.Image = null;
            }
            else
            {
                _employee = null;
                btnBuildCard.Enabled = false;
                btnSelectPhoto.Enabled = false;
                pbPhoto.Image = null;
            }
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

        private void btnSelectPhoto_Click(object sender, System.EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = @"Файлы графических форматов (.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            var image = Image.FromFile(dlg.FileName);
            pbPhoto.Image = image;
            if (_employee != null)
            {
                _employee.Photo = CreateByteArray(image);
            }
        }
    }
}
