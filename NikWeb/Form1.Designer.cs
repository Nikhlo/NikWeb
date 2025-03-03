namespace NikWeb
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backbutton = new System.Windows.Forms.Button();
            this.forwardbutton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chromiumWebBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.newtabbutton = new System.Windows.Forms.Button();
            this.closetabbutton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(0, 1);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(27, 23);
            this.backbutton.TabIndex = 0;
            this.backbutton.Text = "<";
            this.backbutton.UseVisualStyleBackColor = true;
            // 
            // forwardbutton
            // 
            this.forwardbutton.Location = new System.Drawing.Point(24, 1);
            this.forwardbutton.Name = "forwardbutton";
            this.forwardbutton.Size = new System.Drawing.Size(27, 23);
            this.forwardbutton.TabIndex = 1;
            this.forwardbutton.Text = ">";
            this.forwardbutton.UseVisualStyleBackColor = true;
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Location = new System.Drawing.Point(58, 3);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(950, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // searchbutton
            // 
            this.searchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbutton.Location = new System.Drawing.Point(1014, 1);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(76, 23);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "поиск";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 51);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1090, 589);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chromiumWebBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1082, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "google";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chromiumWebBrowser
            // 
            this.chromiumWebBrowser.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.chromiumWebBrowser.Name = "chromiumWebBrowser";
            this.chromiumWebBrowser.Size = new System.Drawing.Size(1076, 557);
            this.chromiumWebBrowser.TabIndex = 0;
            // 
            // newtabbutton
            // 
            this.newtabbutton.Location = new System.Drawing.Point(0, 29);
            this.newtabbutton.Name = "newtabbutton";
            this.newtabbutton.Size = new System.Drawing.Size(92, 23);
            this.newtabbutton.TabIndex = 5;
            this.newtabbutton.Text = "новая вкладка";
            this.newtabbutton.UseVisualStyleBackColor = true;
            this.newtabbutton.Click += new System.EventHandler(this.newtabbutton_Click);
            // 
            // closetabbutton
            // 
            this.closetabbutton.Location = new System.Drawing.Point(89, 29);
            this.closetabbutton.Name = "closetabbutton";
            this.closetabbutton.Size = new System.Drawing.Size(124, 23);
            this.closetabbutton.TabIndex = 6;
            this.closetabbutton.Text = "закрыть вкладку";
            this.closetabbutton.UseVisualStyleBackColor = true;
            this.closetabbutton.Click += new System.EventHandler(this.closetabbutton_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(228, 29);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(126, 23);
            this.settings.TabIndex = 7;
            this.settings.Text = "настройки";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 639);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.closetabbutton);
            this.Controls.Add(this.newtabbutton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.forwardbutton);
            this.Controls.Add(this.backbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NikWeb";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button forwardbutton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button newtabbutton;
        private System.Windows.Forms.Button closetabbutton;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser;
        private System.Windows.Forms.Button settings;
    }
}

