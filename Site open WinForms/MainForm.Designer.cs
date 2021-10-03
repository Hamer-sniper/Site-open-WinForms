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
            this.KS_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KS_Open
            // 
            this.KS_Open.Location = new System.Drawing.Point(48, 54);
            this.KS_Open.Name = "KS_Open";
            this.KS_Open.Size = new System.Drawing.Size(88, 23);
            this.KS_Open.TabIndex = 0;
            this.KS_Open.Text = "Открыть RX";
            this.KS_Open.UseVisualStyleBackColor = true;
            this.KS_Open.Click += new System.EventHandler(this.KS_Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KS_Open);
            this.Name = "Form1";
            this.Text = "Открытие рабочих сайтов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KS_Open;
    }
}

