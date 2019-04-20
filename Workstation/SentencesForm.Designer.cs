namespace Workstation
{
    partial class SentencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentencesForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThisSentenceReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSummCalculation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.видыПредложенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditSentenceTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.ассортиментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportAboutServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEmployeesReport = new System.Windows.Forms.Button();
            this.btnEditSentence = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCategoryReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEditServices = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProduct,
            this.видыПредложенийToolStripMenuItem,
            this.ассортиментToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiProduct
            // 
            this.tsmiProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThisSentenceReport,
            this.tsmiSummCalculation,
            this.toolStripMenuItem1,
            this.tsmiClose});
            this.tsmiProduct.Name = "tsmiProduct";
            this.tsmiProduct.Size = new System.Drawing.Size(52, 20);
            this.tsmiProduct.Text = "Товар";
            this.tsmiProduct.DropDownOpening += new System.EventHandler(this.tsmiProduct_DropDownOpening);
            // 
            // tsmiThisSentenceReport
            // 
            this.tsmiThisSentenceReport.Name = "tsmiThisSentenceReport";
            this.tsmiThisSentenceReport.Size = new System.Drawing.Size(256, 22);
            this.tsmiThisSentenceReport.Text = "Отчёт по данному предложению";
            // 
            // tsmiSummCalculation
            // 
            this.tsmiSummCalculation.Name = "tsmiSummCalculation";
            this.tsmiSummCalculation.Size = new System.Drawing.Size(256, 22);
            this.tsmiSummCalculation.Text = "Вычислить сумму";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(256, 22);
            this.tsmiClose.Text = "Закрыть";
            // 
            // видыПредложенийToolStripMenuItem
            // 
            this.видыПредложенийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditSentenceTypes});
            this.видыПредложенийToolStripMenuItem.Name = "видыПредложенийToolStripMenuItem";
            this.видыПредложенийToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.видыПредложенийToolStripMenuItem.Text = "Виды предложений";
            // 
            // tsmiEditSentenceTypes
            // 
            this.tsmiEditSentenceTypes.Name = "tsmiEditSentenceTypes";
            this.tsmiEditSentenceTypes.Size = new System.Drawing.Size(154, 22);
            this.tsmiEditSentenceTypes.Text = "Редактировать";
            this.tsmiEditSentenceTypes.Click += new System.EventHandler(this.tsmiEditSentenceTypes_Click);
            // 
            // ассортиментToolStripMenuItem
            // 
            this.ассортиментToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditServices,
            this.tsmiReportAboutServices});
            this.ассортиментToolStripMenuItem.Name = "ассортиментToolStripMenuItem";
            this.ассортиментToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ассортиментToolStripMenuItem.Text = "Ассортимент";
            // 
            // tsmiEditServices
            // 
            this.tsmiEditServices.Name = "tsmiEditServices";
            this.tsmiEditServices.Size = new System.Drawing.Size(154, 22);
            this.tsmiEditServices.Text = "Редактировать";
            this.tsmiEditServices.Click += new System.EventHandler(this.tsmiEditServices_Click);
            // 
            // tsmiReportAboutServices
            // 
            this.tsmiReportAboutServices.Name = "tsmiReportAboutServices";
            this.tsmiReportAboutServices.Size = new System.Drawing.Size(154, 22);
            this.tsmiReportAboutServices.Text = "Отчёт";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 707);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная форма предоставляет возможность сформировать перечень товаров и услуг орга" +
    "низации";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наименование услуги";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnEmployeesReport);
            this.flowLayoutPanel1.Controls.Add(this.btnEditSentence);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(627, 64);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnEmployeesReport
            // 
            this.btnEmployeesReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeesReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeesReport.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEmployeesReport.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeesReport.Image")));
            this.btnEmployeesReport.Location = new System.Drawing.Point(3, 3);
            this.btnEmployeesReport.Name = "btnEmployeesReport";
            this.btnEmployeesReport.Size = new System.Drawing.Size(306, 58);
            this.btnEmployeesReport.TabIndex = 4;
            this.btnEmployeesReport.Text = "Вычислить сумму по списку";
            this.btnEmployeesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeesReport.UseVisualStyleBackColor = false;
            // 
            // btnEditSentence
            // 
            this.btnEditSentence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditSentence.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditSentence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSentence.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEditSentence.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSentence.Image")));
            this.btnEditSentence.Location = new System.Drawing.Point(315, 3);
            this.btnEditSentence.Name = "btnEditSentence";
            this.btnEditSentence.Size = new System.Drawing.Size(306, 58);
            this.btnEditSentence.TabIndex = 4;
            this.btnEditSentence.Text = "Редактировать типы предложения";
            this.btnEditSentence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSentence.UseVisualStyleBackColor = false;
            this.btnEditSentence.Click += new System.EventHandler(this.tsmiEditSentenceTypes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 101);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Комплект предложения";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btnCategoryReport);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(628, 64);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btnCategoryReport
            // 
            this.btnCategoryReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCategoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategoryReport.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCategoryReport.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryReport.Image")));
            this.btnCategoryReport.Location = new System.Drawing.Point(3, 3);
            this.btnCategoryReport.Name = "btnCategoryReport";
            this.btnCategoryReport.Size = new System.Drawing.Size(306, 58);
            this.btnCategoryReport.TabIndex = 4;
            this.btnCategoryReport.Text = "Отчёт по данному пакету";
            this.btnCategoryReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoryReport.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 11F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(315, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Прайс-лист всех предложений";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(3, 623);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 81);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ассортимент";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnEditServices);
            this.flowLayoutPanel3.Controls.Add(this.button4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(625, 46);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // btnEditServices
            // 
            this.btnEditServices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditServices.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditServices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditServices.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEditServices.Image = ((System.Drawing.Image)(resources.GetObject("btnEditServices.Image")));
            this.btnEditServices.Location = new System.Drawing.Point(3, 3);
            this.btnEditServices.Name = "btnEditServices";
            this.btnEditServices.Size = new System.Drawing.Size(306, 40);
            this.btnEditServices.TabIndex = 4;
            this.btnEditServices.Text = "Редактировать ассортимент";
            this.btnEditServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditServices.UseVisualStyleBackColor = false;
            this.btnEditServices.Click += new System.EventHandler(this.tsmiEditServices_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 11F);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(315, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(306, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Отчёт по ассортименту";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 197);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 197);
            this.panel2.TabIndex = 5;
            // 
            // SentencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 731);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SentencesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тарифы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SentencesForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditSentence;
        private System.Windows.Forms.Button btnEmployeesReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCategoryReport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEditServices;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduct;
        private System.Windows.Forms.ToolStripMenuItem видыПредложенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ассортиментToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportAboutServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditSentenceTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiThisSentenceReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiSummCalculation;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}