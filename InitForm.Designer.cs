namespace Key_systemAlpha
{
    partial class InitForm
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
            this.loginBox = new C1.Win.C1Input.C1TextBox();
            this.passBox = new C1.Win.C1Input.C1TextBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.loginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.DisabledForeColor = System.Drawing.Color.Gray;
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.loginBox.Location = new System.Drawing.Point(88, 71);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBox.Name = "loginBox";
            this.loginBox.Padding = new System.Windows.Forms.Padding(4);
            this.loginBox.Size = new System.Drawing.Size(268, 39);
            this.loginBox.TabIndex = 0;
            this.loginBox.Tag = null;
            this.c1ThemeController1.SetTheme(this.loginBox, "(default)");
            this.loginBox.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // passBox
            // 
            this.passBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.DisabledForeColor = System.Drawing.Color.Gray;
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.passBox.Location = new System.Drawing.Point(88, 187);
            this.passBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passBox.Name = "passBox";
            this.passBox.Padding = new System.Windows.Forms.Padding(4);
            this.passBox.Size = new System.Drawing.Size(268, 39);
            this.passBox.TabIndex = 1;
            this.passBox.Tag = null;
            this.c1ThemeController1.SetTheme(this.passBox, "(default)");
            this.passBox.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1Label1
            // 
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1Label1.Location = new System.Drawing.Point(20, 17);
            this.c1Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Padding = new System.Windows.Forms.Padding(4);
            this.c1Label1.Size = new System.Drawing.Size(405, 48);
            this.c1Label1.TabIndex = 2;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Логин";
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1Label1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            this.c1Label1.Click += new System.EventHandler(this.c1Label1_Click);
            // 
            // c1Label2
            // 
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1Label2.Location = new System.Drawing.Point(20, 123);
            this.c1Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Padding = new System.Windows.Forms.Padding(4);
            this.c1Label2.Size = new System.Drawing.Size(413, 58);
            this.c1Label2.TabIndex = 3;
            this.c1Label2.Tag = null;
            this.c1Label2.Text = "Пароль";
            this.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1Label2.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label2, "(default)");
            this.c1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // c1Button1
            // 
            this.c1Button1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Button1.Location = new System.Drawing.Point(156, 244);
            this.c1Button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.c1Button1.Size = new System.Drawing.Size(134, 56);
            this.c1Button1.TabIndex = 5;
            this.c1Button1.Text = "Войти";
            this.c1ThemeController1.SetTheme(this.c1Button1, "(default)");
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 340);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 387);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 387);
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InitForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.loginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1TextBox loginBox;
        private C1.Win.C1Input.C1TextBox passBox;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Button c1Button1;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
    }
}