using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workstation
{
    public partial class StatisticsForm : Form
    {
        Root _root;

        public StatisticsForm(Root root)
        {
            InitializeComponent();
            _root = root;
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Report report;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    report = ReportsBuilder.GetEmployeeImplementations(_root, dtpFromDate.Value, dtpToDate.Value);
                    listView1.Items.Clear();
                    foreach (var row in report.ReportRows)
                    {
                        var lvi = new ListViewItem(row.Items[0]);
                        lvi.SubItems.Add(row.Items[1]);
                        listView1.Items.Add(lvi);
                    }
                    break;
                case 1:
                    report = ReportsBuilder.GetImplementationsByClient(_root, dtpFromDate.Value, dtpToDate.Value);
                    listView2.Items.Clear();
                    foreach (var row in report.ReportRows)
                    {
                        var lvi = new ListViewItem(row.Items[0]);
                        lvi.SubItems.Add(row.Items[1]);
                        listView2.Items.Add(lvi);
                    }
                    break;
                case 2:
                    report = ReportsBuilder.GetImplementationsBySentenceTypes(_root, dtpFromDate.Value, dtpToDate.Value);
                    listView3.Items.Clear();
                    foreach (var row in report.ReportRows)
                    {
                        var lvi = new ListViewItem(row.Items[0]);
                        lvi.SubItems.Add(row.Items[1]);
                        listView3.Items.Add(lvi);
                    }
                    break;
                case 3:
                    report = ReportsBuilder.GetImplementationsByServices(_root, dtpFromDate.Value, dtpToDate.Value);
                    listView4.Items.Clear();
                    foreach (var row in report.ReportRows)
                    {
                        var lvi = new ListViewItem(row.Items[0]);
                        lvi.SubItems.Add(row.Items[1]);
                        listView4.Items.Add(lvi);
                    }
                    break;
                case 4:
                    report = ReportsBuilder.GetPayByEmployees(_root, dtpFromDate.Value, dtpToDate.Value);
                    listView5.Items.Clear();
                    foreach (var row in report.ReportRows)
                    {
                        var lvi = new ListViewItem(row.Items[0]);
                        lvi.SubItems.Add(row.Items[1]);
                        lvi.SubItems.Add(row.Items[2]);
                        lvi.SubItems.Add(row.Items[3]);
                        listView5.Items.Add(lvi);
                    }
                    break;
            }
        }
    }
}
