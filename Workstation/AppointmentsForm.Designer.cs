namespace Workstation
{
    partial class AppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveJobDescriptionToFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbJobDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveJobDescriptionToFile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 500);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 225);
            this.panel1.TabIndex = 1;
            // 
            // btnSaveJobDescriptionToFile
            // 
            this.btnSaveJobDescriptionToFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveJobDescriptionToFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveJobDescriptionToFile.Enabled = false;
            this.btnSaveJobDescriptionToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveJobDescriptionToFile.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSaveJobDescriptionToFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveJobDescriptionToFile.Image")));
            this.btnSaveJobDescriptionToFile.Location = new System.Drawing.Point(3, 332);
            this.btnSaveJobDescriptionToFile.Name = "btnSaveJobDescriptionToFile";
            this.btnSaveJobDescriptionToFile.Size = new System.Drawing.Size(164, 66);
            this.btnSaveJobDescriptionToFile.TabIndex = 3;
            this.btnSaveJobDescriptionToFile.Text = "Сохранить инструкцию в файл";
            this.btnSaveJobDescriptionToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveJobDescriptionToFile.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(173, 234);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 263);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbDescription);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Описание должности";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbJobDescription);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Должностная инструкция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Location = new System.Drawing.Point(3, 3);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDescription.Size = new System.Drawing.Size(584, 229);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.WordWrap = false;
            // 
            // tbJobDescription
            // 
            this.tbJobDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tbJobDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbJobDescription.Location = new System.Drawing.Point(3, 3);
            this.tbJobDescription.Multiline = true;
            this.tbJobDescription.Name = "tbJobDescription";
            this.tbJobDescription.ReadOnly = true;
            this.tbJobDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbJobDescription.Size = new System.Drawing.Size(584, 229);
            this.tbJobDescription.TabIndex = 1;
            this.tbJobDescription.WordWrap = false;
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AppointmentsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Должности";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppointmentsForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveJobDescriptionToFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbJobDescription;
    }
}