﻿namespace Site_open_WinForms
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
            this.webInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KS_Open
            // 
            this.KS_Open.Location = new System.Drawing.Point(48, 54);
            this.KS_Open.Name = "KS_Open";
            this.KS_Open.Size = new System.Drawing.Size(130, 23);
            this.KS_Open.TabIndex = 0;
            this.KS_Open.Text = "Открыть RX";
            this.KS_Open.UseVisualStyleBackColor = true;
            this.KS_Open.Click += new System.EventHandler(this.KS_Open_Click);
            // 
            // webInfo
            // 
            this.webInfo.Location = new System.Drawing.Point(48, 101);
            this.webInfo.Name = "webInfo";
            this.webInfo.Size = new System.Drawing.Size(130, 23);
            this.webInfo.TabIndex = 1;
            this.webInfo.Text = "Справка Веб-Клиент";
            this.webInfo.UseVisualStyleBackColor = true;
            this.webInfo.Click += new System.EventHandler(this.webInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webInfo);
            this.Controls.Add(this.KS_Open);
            this.Name = "MainForm";
            this.Text = "Открытие рабочих сайтов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KS_Open;
        private System.Windows.Forms.Button webInfo;
    }
}

