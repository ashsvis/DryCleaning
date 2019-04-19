namespace Workstation
{
    partial class ImplementationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImplementationForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEmployeesReport = new System.Windows.Forms.Button();
            this.btnEditSentence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 561);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оформление";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Воспользуйтесь мастером для быстрой и эффективной работы";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnEmployeesReport);
            this.flowLayoutPanel1.Controls.Add(this.btnEditSentence);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 64);
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
            this.btnEmployeesReport.Size = new System.Drawing.Size(206, 58);
            this.btnEmployeesReport.TabIndex = 4;
            this.btnEmployeesReport.Text = "Мастер";
            this.btnEmployeesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeesReport.UseVisualStyleBackColor = false;
            this.btnEmployeesReport.Click += new System.EventHandler(this.btnEmployeesReport_Click);
            // 
            // btnEditSentence
            // 
            this.btnEditSentence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditSentence.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditSentence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSentence.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEditSentence.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSentence.Image")));
            this.btnEditSentence.Location = new System.Drawing.Point(215, 3);
            this.btnEditSentence.Name = "btnEditSentence";
            this.btnEditSentence.Size = new System.Drawing.Size(206, 58);
            this.btnEditSentence.TabIndex = 4;
            this.btnEditSentence.Text = "Оформить чек";
            this.btnEditSentence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSentence.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная форма представляет возможность оформления и редактирования продаж товаров " +
    "и услуг";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 423);
            this.panel1.TabIndex = 1;
            // 
            // ImplementationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ImplementationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Реализация";
            this.Activated += new System.EventHandler(this.ImplementationForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImplementationForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEmployeesReport;
        private System.Windows.Forms.Button btnEditSentence;
    }
}