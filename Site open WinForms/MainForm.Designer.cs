namespace Site_open_WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.KS_Open = new System.Windows.Forms.Button();
            this.webInfo = new System.Windows.Forms.Button();
            this.dvelopInfo = new System.Windows.Forms.Button();
            this.knowledge = new System.Windows.Forms.Button();
            this.service = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabPropeties = new System.Windows.Forms.TabPage();
            this.textBoxDevelop = new System.Windows.Forms.TextBox();
            this.textBoxWeb = new System.Windows.Forms.TextBox();
            this.labelDevelop = new System.Windows.Forms.Label();
            this.labelWeb = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPropeties.SuspendLayout();
            this.SuspendLayout();
            // 
            // KS_Open
            // 
            this.KS_Open.Location = new System.Drawing.Point(300, 105);
            this.KS_Open.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.KS_Open.Name = "KS_Open";
            this.KS_Open.Size = new System.Drawing.Size(412, 65);
            this.KS_Open.TabIndex = 0;
            this.KS_Open.Text = "Открыть RX";
            this.KS_Open.UseVisualStyleBackColor = true;
            this.KS_Open.Click += new System.EventHandler(this.KS_Open_Click);
            // 
            // webInfo
            // 
            this.webInfo.Location = new System.Drawing.Point(300, 235);
            this.webInfo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.webInfo.Name = "webInfo";
            this.webInfo.Size = new System.Drawing.Size(412, 65);
            this.webInfo.TabIndex = 1;
            this.webInfo.Text = "Справка Веб-Клиент";
            this.webInfo.UseVisualStyleBackColor = true;
            this.webInfo.Click += new System.EventHandler(this.WebInfo_Click);
            // 
            // dvelopInfo
            // 
            this.dvelopInfo.Location = new System.Drawing.Point(300, 365);
            this.dvelopInfo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dvelopInfo.Name = "dvelopInfo";
            this.dvelopInfo.Size = new System.Drawing.Size(412, 65);
            this.dvelopInfo.TabIndex = 2;
            this.dvelopInfo.Text = "Справка разработчик";
            this.dvelopInfo.UseVisualStyleBackColor = true;
            this.dvelopInfo.Click += new System.EventHandler(this.DvelopInfo_Click);
            // 
            // knowledge
            // 
            this.knowledge.Location = new System.Drawing.Point(300, 495);
            this.knowledge.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.knowledge.Name = "knowledge";
            this.knowledge.Size = new System.Drawing.Size(412, 65);
            this.knowledge.TabIndex = 3;
            this.knowledge.Text = "База знаний";
            this.knowledge.UseVisualStyleBackColor = true;
            this.knowledge.Click += new System.EventHandler(this.knowledge_Click);
            // 
            // service
            // 
            this.service.Location = new System.Drawing.Point(300, 625);
            this.service.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(412, 65);
            this.service.TabIndex = 4;
            this.service.Text = "Тех поддержка";
            this.service.UseVisualStyleBackColor = true;
            this.service.Click += new System.EventHandler(this.service_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabPropeties);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 890);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 5;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.service);
            this.tabMain.Controls.Add(this.KS_Open);
            this.tabMain.Controls.Add(this.knowledge);
            this.tabMain.Controls.Add(this.webInfo);
            this.tabMain.Controls.Add(this.dvelopInfo);
            this.tabMain.Location = new System.Drawing.Point(12, 58);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1054, 820);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Основное";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabPropeties
            // 
            this.tabPropeties.Controls.Add(this.textBoxDevelop);
            this.tabPropeties.Controls.Add(this.textBoxWeb);
            this.tabPropeties.Controls.Add(this.labelDevelop);
            this.tabPropeties.Controls.Add(this.labelWeb);
            this.tabPropeties.Location = new System.Drawing.Point(12, 58);
            this.tabPropeties.Name = "tabPropeties";
            this.tabPropeties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPropeties.Size = new System.Drawing.Size(1054, 820);
            this.tabPropeties.TabIndex = 1;
            this.tabPropeties.Text = "Параметры";
            this.tabPropeties.UseVisualStyleBackColor = true;
            // 
            // textBoxDevelop
            // 
            this.textBoxDevelop.Location = new System.Drawing.Point(377, 362);
            this.textBoxDevelop.Name = "textBoxDevelop";
            this.textBoxDevelop.Size = new System.Drawing.Size(671, 44);
            this.textBoxDevelop.TabIndex = 3;
            this.textBoxDevelop.TextChanged += new System.EventHandler(this.textBoxDevelop_TextChanged);
            // 
            // textBoxWeb
            // 
            this.textBoxWeb.Location = new System.Drawing.Point(377, 227);
            this.textBoxWeb.Name = "textBoxWeb";
            this.textBoxWeb.Size = new System.Drawing.Size(671, 44);
            this.textBoxWeb.TabIndex = 2;
            this.textBoxWeb.TextChanged += new System.EventHandler(this.textBoxWeb_TextChanged);
            // 
            // labelDevelop
            // 
            this.labelDevelop.AutoSize = true;
            this.labelDevelop.Location = new System.Drawing.Point(6, 365);
            this.labelDevelop.Name = "labelDevelop";
            this.labelDevelop.Size = new System.Drawing.Size(330, 37);
            this.labelDevelop.TabIndex = 1;
            this.labelDevelop.Text = "Справка разработчик";
            // 
            // labelWeb
            // 
            this.labelWeb.AutoSize = true;
            this.labelWeb.Location = new System.Drawing.Point(6, 235);
            this.labelWeb.Name = "labelWeb";
            this.labelWeb.Size = new System.Drawing.Size(311, 37);
            this.labelWeb.TabIndex = 0;
            this.labelWeb.Text = "Справка Веб-Клиент";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1102, 914);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Открытие рабочих сайтов";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPropeties.ResumeLayout(false);
            this.tabPropeties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KS_Open;
        private System.Windows.Forms.Button webInfo;
        private System.Windows.Forms.Button dvelopInfo;
        private System.Windows.Forms.Button knowledge;
        private System.Windows.Forms.Button service;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPropeties;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Label labelDevelop;
        private System.Windows.Forms.Label labelWeb;
        private System.Windows.Forms.TextBox textBoxWeb;
        private System.Windows.Forms.TextBox textBoxDevelop;
    }
}

