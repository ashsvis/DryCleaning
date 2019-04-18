﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewGenerator;

namespace Workstation
{
    public partial class SentenceTypesForm : Form
    {
        public SentenceTypesForm(Root root)
        {
            InitializeComponent();
            panel1.Controls.Add(GridPanelBuilder.BuildPropertyPanel(root, new SentenceType(), root.SentenceTypes));
        }

        private void SentenceTypesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
