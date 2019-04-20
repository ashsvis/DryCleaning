namespace Workstation
{
    partial class MainPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnRealisation = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatistics.Font = new System.Drawing.Font("Arial", 11F);
            this.btnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Image")));
            this.btnStatistics.Location = new System.Drawing.Point(436, 0);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(176, 73);
            this.btnStatistics.TabIndex = 0;
            this.btnStatistics.Text = "Статистика";
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployees.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.Location = new System.Drawing.Point(436, 79);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(176, 73);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClients.Font = new System.Drawing.Font("Arial", 11F);
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.Location = new System.Drawing.Point(436, 158);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(176, 73);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Клиенты";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnRealisation
            // 
            this.btnRealisation.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRealisation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRealisation.Font = new System.Drawing.Font("Arial", 11F);
            this.btnRealisation.Image = ((System.Drawing.Image)(resources.GetObject("btnRealisation.Image")));
            this.btnRealisation.Location = new System.Drawing.Point(7, 239);
            this.btnRealisation.Name = "btnRealisation";
            this.btnRealisation.Size = new System.Drawing.Size(283, 82);
            this.btnRealisation.TabIndex = 3;
            this.btnRealisation.Text = "Реализация";
            this.btnRealisation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealisation.UseVisualStyleBackColor = false;
            this.btnRealisation.Click += new System.EventHandler(this.btnRealisation_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Gainsboro;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServices.Font = new System.Drawing.Font("Arial", 11F);
            this.btnServices.Image = ((System.Drawing.Image)(resources.GetObject("btnServices.Image")));
            this.btnServices.Location = new System.Drawing.Point(329, 239);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(283, 82);
            this.btnServices.TabIndex = 4;
            this.btnServices.Text = "Товары и услуги";
            this.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnRealisation);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(617, 329);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnRealisation;
        private System.Windows.Forms.Button btnServices;
    }
}
