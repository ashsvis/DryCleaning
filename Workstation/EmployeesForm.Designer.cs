namespace Workstation
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmployeesReport = new System.Windows.Forms.Button();
            this.btnBuildCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectPhoto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeCard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAppointmentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(167, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 309);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 451);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.btnEmployeesReport);
            this.groupBox1.Controls.Add(this.btnBuildCard);
            this.groupBox1.Location = new System.Drawing.Point(3, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчёты";
            // 
            // btnEmployeesReport
            // 
            this.btnEmployeesReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeesReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeesReport.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEmployeesReport.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeesReport.Image")));
            this.btnEmployeesReport.Location = new System.Drawing.Point(416, 22);
            this.btnEmployeesReport.Name = "btnEmployeesReport";
            this.btnEmployeesReport.Size = new System.Drawing.Size(244, 66);
            this.btnEmployeesReport.TabIndex = 3;
            this.btnEmployeesReport.Text = "Отчёт по персоналу";
            this.btnEmployeesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeesReport.UseVisualStyleBackColor = false;
            // 
            // btnBuildCard
            // 
            this.btnBuildCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuildCard.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuildCard.Enabled = false;
            this.btnBuildCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuildCard.Font = new System.Drawing.Font("Arial", 11F);
            this.btnBuildCard.Image = ((System.Drawing.Image)(resources.GetObject("btnBuildCard.Image")));
            this.btnBuildCard.Location = new System.Drawing.Point(157, 22);
            this.btnBuildCard.Name = "btnBuildCard";
            this.btnBuildCard.Size = new System.Drawing.Size(244, 66);
            this.btnBuildCard.TabIndex = 3;
            this.btnBuildCard.Text = "Сформировать личную карточку";
            this.btnBuildCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuildCard.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(873, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная форма представляет возможность ввода и редактирования данных о сотрудниках" +
    "\r\nВозможно сформировать отчёты, просмотреть личные карточки и вывести их в Excel" +
    "";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnSelectPhoto);
            this.groupBox2.Controls.Add(this.pbPhoto);
            this.groupBox2.Location = new System.Drawing.Point(3, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фотография";
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Enabled = false;
            this.btnSelectPhoto.Location = new System.Drawing.Point(28, 177);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(105, 23);
            this.btnSelectPhoto.TabIndex = 5;
            this.btnSelectPhoto.Text = "Выбрать фото";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.SystemColors.Window;
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(9, 22);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(143, 133);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 4;
            this.pbPhoto.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployees,
            this.tsmiAppointmentsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiEmployees
            // 
            this.tsmiEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectPhoto,
            this.tsmiEmployeeCard,
            this.tsmiEmployeeReport,
            this.toolStripMenuItem1,
            this.tsmiClose});
            this.tsmiEmployees.Name = "tsmiEmployees";
            this.tsmiEmployees.Size = new System.Drawing.Size(85, 20);
            this.tsmiEmployees.Text = "Сотрудники";
            // 
            // tsmiSelectPhoto
            // 
            this.tsmiSelectPhoto.Name = "tsmiSelectPhoto";
            this.tsmiSelectPhoto.Size = new System.Drawing.Size(161, 22);
            this.tsmiSelectPhoto.Text = "Выбрать фото...";
            // 
            // tsmiEmployeeCard
            // 
            this.tsmiEmployeeCard.Name = "tsmiEmployeeCard";
            this.tsmiEmployeeCard.Size = new System.Drawing.Size(161, 22);
            this.tsmiEmployeeCard.Text = "Карточка";
            // 
            // tsmiEmployeeReport
            // 
            this.tsmiEmployeeReport.Name = "tsmiEmployeeReport";
            this.tsmiEmployeeReport.Size = new System.Drawing.Size(161, 22);
            this.tsmiEmployeeReport.Text = "Отчёт";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(161, 22);
            this.tsmiClose.Text = "Закрыть";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiAppointmentsMenu
            // 
            this.tsmiAppointmentsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAppointments});
            this.tsmiAppointmentsMenu.Name = "tsmiAppointmentsMenu";
            this.tsmiAppointmentsMenu.Size = new System.Drawing.Size(82, 20);
            this.tsmiAppointmentsMenu.Text = "Должности";
            // 
            // tsmiAppointments
            // 
            this.tsmiAppointments.Name = "tsmiAppointments";
            this.tsmiAppointments.Size = new System.Drawing.Size(192, 22);
            this.tsmiAppointments.Text = "К списку должностей";
            this.tsmiAppointments.Click += new System.EventHandler(this.tsmiAppointments_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "EmployeesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeesForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmployeesReport;
        private System.Windows.Forms.Button btnBuildCard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployees;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeCard;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeReport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectPhoto;
        private System.Windows.Forms.ToolStripMenuItem tsmiAppointmentsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAppointments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
    }
}