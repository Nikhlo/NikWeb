namespace NikWeb
{
    partial class settingsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsform));
            this.label1 = new System.Windows.Forms.Label();
            this.google = new System.Windows.Forms.RadioButton();
            this.yandex = new System.Windows.Forms.RadioButton();
            this.bing = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "поисковая система";
            // 
            // google
            // 
            this.google.AutoSize = true;
            this.google.Location = new System.Drawing.Point(12, 63);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(57, 17);
            this.google.TabIndex = 1;
            this.google.TabStop = true;
            this.google.Text = "google";
            this.google.UseVisualStyleBackColor = true;
            this.google.CheckedChanged += new System.EventHandler(this.google_CheckedChanged);
            // 
            // yandex
            // 
            this.yandex.AutoSize = true;
            this.yandex.Location = new System.Drawing.Point(12, 100);
            this.yandex.Name = "yandex";
            this.yandex.Size = new System.Drawing.Size(59, 17);
            this.yandex.TabIndex = 2;
            this.yandex.TabStop = true;
            this.yandex.Text = "yandex";
            this.yandex.UseVisualStyleBackColor = true;
            this.yandex.CheckedChanged += new System.EventHandler(this.yandex_CheckedChanged);
            // 
            // bing
            // 
            this.bing.AutoSize = true;
            this.bing.Location = new System.Drawing.Point(12, 139);
            this.bing.Name = "bing";
            this.bing.Size = new System.Drawing.Size(45, 17);
            this.bing.TabIndex = 3;
            this.bing.TabStop = true;
            this.bing.Text = "bing";
            this.bing.UseVisualStyleBackColor = true;
            this.bing.CheckedChanged += new System.EventHandler(this.bing_CheckedChanged);
            // 
            // settingsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 469);
            this.Controls.Add(this.bing);
            this.Controls.Add(this.yandex);
            this.Controls.Add(this.google);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsform";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton google;
        private System.Windows.Forms.RadioButton yandex;
        private System.Windows.Forms.RadioButton bing;
    }
}