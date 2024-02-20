namespace Key_systemAlpha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_Into_History = new C1.Win.C1Input.C1Button();
            this.c1Label4 = new C1.Win.C1Input.C1Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.c1List1 = new C1.Win.C1List.C1List();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Into_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(1217, 528);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "чпонька";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            this.label1.Visible = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.infoLabel.Location = new System.Drawing.Point(1096, 339);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(155, 24);
            this.infoLabel.TabIndex = 22;
            this.infoLabel.Text = "Сотрудник/ключ";
            this.c1ThemeController1.SetTheme(this.infoLabel, "(default)");
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(1062, 20);
            this.photoBox.Margin = new System.Windows.Forms.Padding(6);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(390, 284);
            this.photoBox.TabIndex = 21;
            this.photoBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(635, 20);
            this.cameraBox.Margin = new System.Windows.Forms.Padding(6);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(384, 284);
            this.cameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cameraBox.TabIndex = 20;
            this.cameraBox.TabStop = false;
            // 
            // cboDevice
            // 
            this.cboDevice.CausesValidation = false;
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(1183, 561);
            this.cboDevice.Margin = new System.Windows.Forms.Padding(6);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(218, 33);
            this.cboDevice.TabIndex = 19;
            this.c1ThemeController1.SetTheme(this.cboDevice, "(default)");
            this.cboDevice.Visible = false;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged_1);
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1Label1.Location = new System.Drawing.Point(16, 28);
            this.c1Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Padding = new System.Windows.Forms.Padding(4);
            this.c1Label1.Size = new System.Drawing.Size(97, 36);
            this.c1Label1.TabIndex = 35;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "c1Label1";
            this.c1Label1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            this.c1Label1.Value = "Сотрудник на посту: ";
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1Label2.Location = new System.Drawing.Point(16, 146);
            this.c1Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Padding = new System.Windows.Forms.Padding(4);
            this.c1Label2.Size = new System.Drawing.Size(97, 36);
            this.c1Label2.TabIndex = 36;
            this.c1Label2.Tag = null;
            this.c1Label2.Text = "c1Label2";
            this.c1Label2.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label2, "(default)");
            this.c1Label2.Value = "Доступ к помещению";
            this.c1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.DisabledForeColor = System.Drawing.Color.Gray;
            this.c1TextBox1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1TextBox1.Location = new System.Drawing.Point(55, 97);
            this.c1TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Padding = new System.Windows.Forms.Padding(4);
            this.c1TextBox1.Size = new System.Drawing.Size(157, 39);
            this.c1TextBox1.TabIndex = 37;
            this.c1TextBox1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1TextBox1, "(default)");
            this.c1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1Label3.Location = new System.Drawing.Point(74, 44);
            this.c1Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Padding = new System.Windows.Forms.Padding(4);
            this.c1Label3.Size = new System.Drawing.Size(97, 36);
            this.c1Label3.TabIndex = 38;
            this.c1Label3.Tag = null;
            this.c1Label3.Text = "c1Label3";
            this.c1Label3.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label3, "(default)");
            this.c1Label3.Value = "Введите Id";
            this.c1Label3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Add_Into_History);
            this.groupBox1.Controls.Add(this.c1TextBox1);
            this.groupBox1.Controls.Add(this.c1Label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 359);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(272, 265);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ручное добавление";
            this.c1ThemeController1.SetTheme(this.groupBox1, "(default)");
            // 
            // Add_Into_History
            // 
            this.Add_Into_History.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.Add_Into_History.Location = new System.Drawing.Point(55, 169);
            this.Add_Into_History.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Into_History.Name = "Add_Into_History";
            this.Add_Into_History.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Add_Into_History.Size = new System.Drawing.Size(157, 58);
            this.Add_Into_History.TabIndex = 39;
            this.Add_Into_History.Text = "Добавить";
            this.c1ThemeController1.SetTheme(this.Add_Into_History, "(default)");
            this.Add_Into_History.UseVisualStyleBackColor = true;
            this.Add_Into_History.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1Label4
            // 
            this.c1Label4.AutoSize = true;
            this.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label4.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1Label4.Location = new System.Drawing.Point(46, 216);
            this.c1Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Padding = new System.Windows.Forms.Padding(4);
            this.c1Label4.Size = new System.Drawing.Size(97, 36);
            this.c1Label4.TabIndex = 40;
            this.c1Label4.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1Label4, "(default)");
            this.c1Label4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.c1Button1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox2.Location = new System.Drawing.Point(326, 359);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(275, 265);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Явление убобрщицы";
            this.c1ThemeController1.SetTheme(this.groupBox2, "(default)");
            // 
            // c1Button1
            // 
            this.c1Button1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Button1.Location = new System.Drawing.Point(25, 83);
            this.c1Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.c1Button1.Size = new System.Drawing.Size(224, 112);
            this.c1Button1.TabIndex = 0;
            this.c1Button1.Text = "Взять все ключи";
            this.c1ThemeController1.SetTheme(this.c1Button1, "(default)");
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1List1
            // 
            this.c1List1.BackColor = System.Drawing.Color.White;
            this.c1List1.Caption = "Доступ по сотруднику";
            this.c1List1.DeadAreaBackColor = System.Drawing.Color.White;
            this.c1List1.FlatStyle = C1.Win.C1List.FlatModeEnum.Flat;
            this.c1List1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1List1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1List1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1List1.Images"))));
            this.c1List1.Location = new System.Drawing.Point(635, 325);
            this.c1List1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1List1.MatchEntryTimeout = ((long)(2000));
            this.c1List1.Name = "c1List1";
            this.c1List1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1List1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1List1.PreviewInfo.ZoomFactor = 75D;
            this.c1List1.RowDivider.Color = System.Drawing.Color.Gainsboro;
            this.c1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.Single;
            this.c1List1.RowSubDividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1List1.Size = new System.Drawing.Size(382, 299);
            this.c1List1.TabIndex = 42;
            this.c1List1.Text = "Д";
            this.c1ThemeController1.SetTheme(this.c1List1, "(default)");
            this.c1List1.PropBag = resources.GetString("c1List1.PropBag");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 640);
            this.Controls.Add(this.c1List1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.c1Label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.cboDevice);
            this.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Окно охраны";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Into_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox cameraBox;
        private System.Windows.Forms.ComboBox cboDevice;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1Input.C1Label c1Label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1Input.C1Button Add_Into_History;
        private C1.Win.C1Input.C1Label c1Label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private C1.Win.C1Input.C1Button c1Button1;
        private C1.Win.C1List.C1List c1List1;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
    }
}

