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
            this.label2 = new System.Windows.Forms.Label();
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enterbtn = new System.Windows.Forms.Button();
            this.applybtn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
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
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(267, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "аккаунт";
            // 
            // logintextBox
            // 
            this.logintextBox.Location = new System.Drawing.Point(273, 97);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(183, 20);
            this.logintextBox.TabIndex = 5;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(272, 148);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(183, 20);
            this.passwordtextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(269, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(269, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "password";
            // 
            // enterbtn
            // 
            this.enterbtn.Location = new System.Drawing.Point(272, 187);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(112, 23);
            this.enterbtn.TabIndex = 9;
            this.enterbtn.Text = "войти";
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // applybtn
            // 
            this.applybtn.Location = new System.Drawing.Point(12, 173);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(75, 23);
            this.applybtn.TabIndex = 10;
            this.applybtn.Text = "приментить";
            this.applybtn.UseVisualStyleBackColor = true;
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // regbtn
            // 
            this.regbtn.Location = new System.Drawing.Point(488, 186);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(106, 23);
            this.regbtn.TabIndex = 11;
            this.regbtn.Text = "регистрация";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // settingsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 469);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.applybtn);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.logintextBox);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.Button applybtn;
        private System.Windows.Forms.Button regbtn;
    }
}