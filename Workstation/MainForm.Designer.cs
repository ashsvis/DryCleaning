namespace Workstation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мастерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClients = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServices = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПредложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDictionaries = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.документыToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.tsmiDictionaries});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мастерToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // мастерToolStripMenuItem
            // 
            this.мастерToolStripMenuItem.Name = "мастерToolStripMenuItem";
            this.мастерToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.мастерToolStripMenuItem.Text = "Мастер";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(115, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // прайслистToolStripMenuItem
            // 
            this.прайслистToolStripMenuItem.Name = "прайслистToolStripMenuItem";
            this.прайслистToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.прайслистToolStripMenuItem.Text = "Прайс-лист";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClients,
            this.редактироватьСотрудниковToolStripMenuItem,
            this.tsmiServices,
            this.редактироватьПредложенияToolStripMenuItem,
            this.оформитьЗаказToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // tsmiClients
            // 
            this.tsmiClients.Name = "tsmiClients";
            this.tsmiClients.Size = new System.Drawing.Size(232, 22);
            this.tsmiClients.Text = "Работа с клиентами";
            this.tsmiClients.Click += new System.EventHandler(this.tsmiClients_Click);
            // 
            // редактироватьСотрудниковToolStripMenuItem
            // 
            this.редактироватьСотрудниковToolStripMenuItem.Name = "редактироватьСотрудниковToolStripMenuItem";
            this.редактироватьСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.редактироватьСотрудниковToolStripMenuItem.Text = "Редактировать сотрудников";
            this.редактироватьСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.tsmiEmployees_Click);
            // 
            // tsmiServices
            // 
            this.tsmiServices.Name = "tsmiServices";
            this.tsmiServices.Size = new System.Drawing.Size(232, 22);
            this.tsmiServices.Text = "Редактировать ассортимент";
            this.tsmiServices.Click += new System.EventHandler(this.tsmiServices_Click);
            // 
            // редактироватьПредложенияToolStripMenuItem
            // 
            this.редактироватьПредложенияToolStripMenuItem.Name = "редактироватьПредложенияToolStripMenuItem";
            this.редактироватьПредложенияToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.редактироватьПредложенияToolStripMenuItem.Text = "Редактировать предложения";
            // 
            // оформитьЗаказToolStripMenuItem
            // 
            this.оформитьЗаказToolStripMenuItem.Name = "оформитьЗаказToolStripMenuItem";
            this.оформитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.оформитьЗаказToolStripMenuItem.Text = "Оформить заказ";
            // 
            // tsmiDictionaries
            // 
            this.tsmiDictionaries.Name = "tsmiDictionaries";
            this.tsmiDictionaries.Size = new System.Drawing.Size(67, 20);
            this.tsmiDictionaries.Text = "Словари";
            this.tsmiDictionaries.Visible = false;
            this.tsmiDictionaries.DropDownOpening += new System.EventHandler(this.tsmiDictionaries_DropDownOpening);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(616, 328);
            this.pnlContainer.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 352);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Химчистка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDictionaries;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мастерToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem прайслистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClients;
        private System.Windows.Forms.ToolStripMenuItem редактироватьСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiServices;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПредложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьЗаказToolStripMenuItem;
    }
}

