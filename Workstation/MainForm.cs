﻿using Model;
using System;
using System.IO;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class MainForm : Form
    {
        private Root _root = new Root();

        public MainForm()
        {
            InitializeComponent();
            GridPanelBuilder.Error += GridPanelBuilder_Error;
        }

        private void GridPanelBuilder_Error(string message, string caption)
        {
            MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            var fileName = Path.ChangeExtension(Application.ExecutablePath, ".bin");
            if (File.Exists(fileName))
            {
                _root = SaverLoader.LoadFromFile(fileName);
                _root.RegistryTables();
            }
        }

        private void tsmiDictionaries_DropDownOpening(object sender, EventArgs e)
        {
            tsmiDictionaries.DropDownItems.Clear();
            foreach (var tableName in _root.GetTableNames())
            {
                var tsmi = new ToolStripMenuItem { Text = tableName };
                tsmi.Click += (o, arg) =>
                {
                    pnlContainer.Controls.Clear();
                    var tableItem = _root.GetTableInfo(tableName);
                    if (tableItem != null)
                        pnlContainer.Controls.Add(GridPanelBuilder.BuildPropertyPanel(_root, tableItem.Item, tableItem.Table));
                };
                tsmiDictionaries.DropDownItems.Add(tsmi);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaverLoader.SaveToFile(Path.ChangeExtension(Application.ExecutablePath, ".bin"), _root);
        }
    }
}
