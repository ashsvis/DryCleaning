using Model;
using System;
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
            _employee = (Employee)obj;
            if (_employee != null)
            {
                btnBuildCard.Enabled = true;
                btnSelectPhoto.Enabled = true;
                if (_employee.Photo != null && _employee.Photo.Length > 0)
                    pbPhoto.Image = CreateImage(_employee.Photo);
                else
                    pbPhoto.Image = null;
            }
            else
            {
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

        private void tsmiEmployees_DropDownOpening(object sender, System.EventArgs e)
        {
            tsmiSelectPhoto.Enabled = tsmiEmployeeCard.Enabled = _employee != null;
        }

        private void btnEmployeesReport_Click(object sender, System.EventArgs e)
        {
            try
            {
                var app = new Microsoft.Office.Interop.Word.Application();
                var filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Reports", "Employees.docx");
                var oDoc = app.Documents.Add(filename);
                oDoc.Application.Visible = true;
                var row = 1;
                foreach (var employee in _root.Employees)
                {
                    oDoc.Bookmarks[$"s{row}1"].Range.Text = employee.Surname;
                    oDoc.Bookmarks[$"s{row}2"].Range.Text = employee.FirstName;
                    oDoc.Bookmarks[$"s{row}3"].Range.Text = employee.LastName;
                    oDoc.Bookmarks[$"s{row}4"].Range.Text = employee.ReceiptDate.ToShortDateString();
                    oDoc.Bookmarks[$"s{row}5"].Range.Text = employee.Address;
                    oDoc.Bookmarks[$"s{row}6"].Range.Text = employee.PhoneNumber;
                    oDoc.Bookmarks[$"s{row}7"].Range.Text = employee.Passport;
                    row++;
                }
                Application.OpenForms[0].SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void btnBuildCard_Click(object sender, EventArgs e)
        {
            if (_employee == null) return;
            try
            {
                var app = new Microsoft.Office.Interop.Excel.Application();
                var filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Reports", "Employee.xltx");
                var wb = app.Workbooks.Open(filename, 0, true);
                app.Application.Visible = true;
                var sheet = wb.Sheets[1];
                sheet.Cells[8, 2] = "ООО ФИРМА";
                sheet.Cells[13, 3] = _employee.PersonnelNumber;
                sheet.Cells[13, 4] = _employee.TIN;
                sheet.Cells[13, 5] = _employee.PensionCertificate;
                sheet.Cells[13, 9] = Helper.GenderNameById(_employee.IdGender);
                sheet.Cells[19, 9] = _employee.ReceiptDate.ToShortDateString();
                sheet.Cells[20, 3] = _employee.Surname;
                sheet.Cells[20, 6] = _employee.FirstName;
                sheet.Cells[20, 9] = _employee.LastName;
                sheet.Cells[21, 4] = _employee.BirthDay.ToShortDateString();
                sheet.Cells[23, 4] = _employee.BirthPlace;
                sheet.Cells[26, 4] = _employee.Education;
                sheet.Cells[29, 4] = Helper.AppointmentNameById(_employee.IdAppointment);
                Application.OpenForms[0].SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }
    }
}
