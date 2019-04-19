using Model;
using System.Windows.Forms;

namespace Workstation
{
    public partial class MasterForm : Form
    {
        private Root _root;
        private int _tab = 0;
        private ListBox[] _boxes = new ListBox[3];

        public MasterForm(Root root)
        {
            InitializeComponent();
            _root = root;
            _boxes[0] = listBox1;
            _boxes[1] = listBox2;
            _boxes[2] = listBox3;
            foreach (var item in root.Sentences)
                listBox1.Items.Add(item);
            foreach (var item in root.Clients)
                listBox2.Items.Add(item);
            foreach (var item in root.Employees)
                listBox3.Items.Add(item);
            listBox1.SelectedIndexChanged += ListBoxes_SelectedIndexChanged;
            listBox2.SelectedIndexChanged += ListBoxes_SelectedIndexChanged;
            listBox3.SelectedIndexChanged += ListBoxes_SelectedIndexChanged;
        }

        private void ListBoxes_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btnForward.Enabled = _tab < tabControl1.TabCount - 1 && _boxes[_tab - 1].SelectedItem != null;
        }

        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnForward_Click(object sender, System.EventArgs e)
        {
            _tab++;
            tabControl1.SelectTab(_tab);
            btnBack.Enabled = _tab > 0;
            btnForward.Enabled = _tab < tabControl1.TabCount - 1 && _boxes[_tab - 1].SelectedItem != null;
            btnReady.Visible = _tab == tabControl1.TabCount - 1;
            if (_tab == tabControl1.TabCount - 1)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add($"Предмет продажи \"{listBox1.SelectedItem}\"");
                listBox4.Items.Add("");
                listBox4.Items.Add($"Клиент \"{listBox2.SelectedItem}\"");
                listBox4.Items.Add("");
                listBox4.Items.Add($"Сотрудник \"{listBox3.SelectedItem}\"");
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            _tab--;
            tabControl1.SelectTab(_tab);
            btnBack.Enabled = _tab > 0;
            btnForward.Enabled = _tab < tabControl1.TabCount - 1;
            btnReady.Visible = _tab == tabControl1.TabCount - 1;
        }

        private void btnReady_Click(object sender, System.EventArgs e)
        {
            try
            {
                _root.Implementations.Add(
                    new Implementation
                    {
                        IdSentence = ((Sentence)listBox1.SelectedItem).IdSentence,
                        IdClient = ((Client)listBox2.SelectedItem).IdClient,
                        IdEmployee = ((Employee)listBox3.SelectedItem).IdEmployee,
                        ImplementationDate = System.DateTime.Now
                    });
                Close();
            }
            catch
            {
                MessageBox.Show("Данная реализация уже занесена в базу ранее");
            }
        }
    }
}
