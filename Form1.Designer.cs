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
            this.label1 = new System.Windows.Forms.Label();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.HandyAddyGroupBox = new System.Windows.Forms.GroupBox();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.SearchBtn = new C1.Win.C1Input.C1Button();
            this.Cleaner_btn = new C1.Win.C1Input.C1Button();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.Status_label = new System.Windows.Forms.Label();
            this.Plabel = new System.Windows.Forms.Label();
            this.Olabel = new System.Windows.Forms.Label();
            this.Ilabel = new System.Windows.Forms.Label();
            this.Flabel = new System.Windows.Forms.Label();
            this.KeySkanLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CamEmpGroup = new System.Windows.Forms.GroupBox();
            this.CamEmpSwitch = new C1.Win.C1Input.C1Button();
            this.EmpSkanLabel = new System.Windows.Forms.Label();
            this.Status_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.HandyAddyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cleaner_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.CamEmpGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamEmpSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "чпонька";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            this.label1.Visible = false;
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(29, 32);
            this.photoBox.Margin = new System.Windows.Forms.Padding(6);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(435, 232);
            this.photoBox.TabIndex = 21;
            this.photoBox.TabStop = false;
            this.photoBox.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(11, 26);
            this.cameraBox.Margin = new System.Windows.Forms.Padding(6);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(469, 404);
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
            this.cboDevice.Location = new System.Drawing.Point(117, 62);
            this.cboDevice.Margin = new System.Windows.Forms.Padding(6);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(219, 33);
            this.cboDevice.TabIndex = 19;
            this.c1ThemeController1.SetTheme(this.cboDevice, "(default)");
            this.cboDevice.Visible = false;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged_1);
            // 
            // HandyAddyGroupBox
            // 
            this.HandyAddyGroupBox.BackColor = System.Drawing.Color.White;
            this.HandyAddyGroupBox.Controls.Add(this.c1Label2);
            this.HandyAddyGroupBox.Controls.Add(this.listBox1);
            this.HandyAddyGroupBox.Controls.Add(this.c1Label1);
            this.HandyAddyGroupBox.Controls.Add(this.c1TextBox1);
            this.HandyAddyGroupBox.Controls.Add(this.SearchBtn);
            this.HandyAddyGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.HandyAddyGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.HandyAddyGroupBox.Location = new System.Drawing.Point(29, 404);
            this.HandyAddyGroupBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.HandyAddyGroupBox.Name = "HandyAddyGroupBox";
            this.HandyAddyGroupBox.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.HandyAddyGroupBox.Size = new System.Drawing.Size(808, 373);
            this.HandyAddyGroupBox.TabIndex = 39;
            this.HandyAddyGroupBox.TabStop = false;
            this.HandyAddyGroupBox.Text = "Ручное добавление";
            this.c1ThemeController1.SetTheme(this.HandyAddyGroupBox, "(default)");
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1Label2.Location = new System.Drawing.Point(15, 94);
            this.c1Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Padding = new System.Windows.Forms.Padding(4);
            this.c1Label2.Size = new System.Drawing.Size(97, 36);
            this.c1Label2.TabIndex = 47;
            this.c1Label2.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1Label2, "(default)");
            this.c1Label2.Value = "Выберите сотрудника";
            this.c1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(15, 136);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 229);
            this.listBox1.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.listBox1, "(default)");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.c1Label1.Location = new System.Drawing.Point(433, 136);
            this.c1Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Padding = new System.Windows.Forms.Padding(4);
            this.c1Label1.Size = new System.Drawing.Size(97, 36);
            this.c1Label1.TabIndex = 46;
            this.c1Label1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.DisabledForeColor = System.Drawing.Color.Gray;
            this.c1TextBox1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1TextBox1.Location = new System.Drawing.Point(12, 47);
            this.c1TextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Padding = new System.Windows.Forms.Padding(4);
            this.c1TextBox1.Size = new System.Drawing.Size(449, 39);
            this.c1TextBox1.TabIndex = 0;
            this.c1TextBox1.Tag = null;
            this.c1TextBox1.Text = "Введите ID или Фамилию";
            this.c1TextBox1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1TextBox1, "(default)");
            this.c1TextBox1.Value = "Введите ID или Фамилию";
            this.c1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.c1TextBox1.Enter += new System.EventHandler(this.c1TextBox1_Enter);
            this.c1TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1TextBox1_KeyDown);
            this.c1TextBox1.Leave += new System.EventHandler(this.c1TextBox1_Leave);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.SearchBtn.Location = new System.Drawing.Point(482, 39);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SearchBtn.Size = new System.Drawing.Size(201, 52);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Поиск";
            this.c1ThemeController1.SetTheme(this.SearchBtn, "(default)");
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Cleaner_btn
            // 
            this.Cleaner_btn.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.Cleaner_btn.Location = new System.Drawing.Point(1220, 700);
            this.Cleaner_btn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Cleaner_btn.Name = "Cleaner_btn";
            this.Cleaner_btn.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Cleaner_btn.Size = new System.Drawing.Size(264, 69);
            this.Cleaner_btn.TabIndex = 6;
            this.Cleaner_btn.Text = "Взять ключи для уборки";
            this.c1ThemeController1.SetTheme(this.Cleaner_btn, "(default)");
            this.Cleaner_btn.UseVisualStyleBackColor = true;
            this.Cleaner_btn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.Cleaner_btn.Click += new System.EventHandler(this.Cleaner_btn_Click);
            // 
            // Status_label
            // 
            this.Status_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Status_label.Location = new System.Drawing.Point(15, 264);
            this.Status_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(822, 83);
            this.Status_label.TabIndex = 42;
            this.Status_label.Text = "Статус доступа";
            this.Status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1ThemeController1.SetTheme(this.Status_label, "(default)");
            this.Status_label.Click += new System.EventHandler(this.acces_label_Click);
            // 
            // Plabel
            // 
            this.Plabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Plabel.Location = new System.Drawing.Point(6, 405);
            this.Plabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Plabel.Name = "Plabel";
            this.Plabel.Size = new System.Drawing.Size(474, 37);
            this.Plabel.TabIndex = 22;
            this.Plabel.Text = "Должность";
            this.c1ThemeController1.SetTheme(this.Plabel, "(default)");
            this.Plabel.Visible = false;
            // 
            // Olabel
            // 
            this.Olabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Olabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Olabel.Location = new System.Drawing.Point(6, 363);
            this.Olabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Olabel.Name = "Olabel";
            this.Olabel.Size = new System.Drawing.Size(474, 37);
            this.Olabel.TabIndex = 22;
            this.Olabel.Text = "Отчество";
            this.c1ThemeController1.SetTheme(this.Olabel, "(default)");
            this.Olabel.Visible = false;
            // 
            // Ilabel
            // 
            this.Ilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ilabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Ilabel.Location = new System.Drawing.Point(6, 322);
            this.Ilabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Ilabel.Name = "Ilabel";
            this.Ilabel.Size = new System.Drawing.Size(463, 37);
            this.Ilabel.TabIndex = 22;
            this.Ilabel.Text = "Имя";
            this.c1ThemeController1.SetTheme(this.Ilabel, "(default)");
            this.Ilabel.Visible = false;
            // 
            // Flabel
            // 
            this.Flabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Flabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Flabel.Location = new System.Drawing.Point(6, 280);
            this.Flabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Flabel.Name = "Flabel";
            this.Flabel.Size = new System.Drawing.Size(474, 37);
            this.Flabel.TabIndex = 22;
            this.Flabel.Text = "Фамилия";
            this.c1ThemeController1.SetTheme(this.Flabel, "(default)");
            this.Flabel.Visible = false;
            // 
            // KeySkanLabel
            // 
            this.KeySkanLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeySkanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.KeySkanLabel.Location = new System.Drawing.Point(5, 56);
            this.KeySkanLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.KeySkanLabel.Name = "KeySkanLabel";
            this.KeySkanLabel.Size = new System.Drawing.Size(805, 83);
            this.KeySkanLabel.TabIndex = 42;
            this.KeySkanLabel.Text = "Просканируйте QR ключ\r\n";
            this.KeySkanLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.c1ThemeController1.SetTheme(this.KeySkanLabel, "(default)");
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(7, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(968, 46);
            this.label8.TabIndex = 42;
            this.label8.Text = "Сотрудник на посту: ";
            this.c1ThemeController1.SetTheme(this.label8, "(default)");
            // 
            // CamEmpGroup
            // 
            this.CamEmpGroup.BackColor = System.Drawing.Color.White;
            this.CamEmpGroup.Controls.Add(this.CamEmpSwitch);
            this.CamEmpGroup.Controls.Add(this.cameraBox);
            this.CamEmpGroup.Controls.Add(this.Plabel);
            this.CamEmpGroup.Controls.Add(this.Olabel);
            this.CamEmpGroup.Controls.Add(this.photoBox);
            this.CamEmpGroup.Controls.Add(this.Ilabel);
            this.CamEmpGroup.Controls.Add(this.Flabel);
            this.CamEmpGroup.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.CamEmpGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CamEmpGroup.Location = new System.Drawing.Point(997, 30);
            this.CamEmpGroup.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.CamEmpGroup.Name = "CamEmpGroup";
            this.CamEmpGroup.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.CamEmpGroup.Size = new System.Drawing.Size(487, 556);
            this.CamEmpGroup.TabIndex = 41;
            this.CamEmpGroup.TabStop = false;
            this.CamEmpGroup.Text = "Камера";
            this.c1ThemeController1.SetTheme(this.CamEmpGroup, "(default)");
            // 
            // CamEmpSwitch
            // 
            this.CamEmpSwitch.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.CamEmpSwitch.Location = new System.Drawing.Point(49, 458);
            this.CamEmpSwitch.Margin = new System.Windows.Forms.Padding(6);
            this.CamEmpSwitch.Name = "CamEmpSwitch";
            this.CamEmpSwitch.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.CamEmpSwitch.Size = new System.Drawing.Size(387, 65);
            this.CamEmpSwitch.TabIndex = 4;
            this.CamEmpSwitch.Text = "Информация по сотруднику";
            this.c1ThemeController1.SetTheme(this.CamEmpSwitch, "(default)");
            this.CamEmpSwitch.UseVisualStyleBackColor = true;
            this.CamEmpSwitch.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.CamEmpSwitch.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpSkanLabel
            // 
            this.EmpSkanLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpSkanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.EmpSkanLabel.Location = new System.Drawing.Point(22, 168);
            this.EmpSkanLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmpSkanLabel.Name = "EmpSkanLabel";
            this.EmpSkanLabel.Size = new System.Drawing.Size(788, 83);
            this.EmpSkanLabel.TabIndex = 42;
            this.EmpSkanLabel.Text = "Просканируйте QR сотрудника\r\n";
            this.EmpSkanLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.c1ThemeController1.SetTheme(this.EmpSkanLabel, "(default)");
            // 
            // Status_timer
            // 
            this.Status_timer.Interval = 1000;
            this.Status_timer.Tick += new System.EventHandler(this.Status_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 803);
            this.Controls.Add(this.Cleaner_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmpSkanLabel);
            this.Controls.Add(this.KeySkanLabel);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.CamEmpGroup);
            this.Controls.Add(this.HandyAddyGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDevice);
            this.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Окно охраны";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.HandyAddyGroupBox.ResumeLayout(false);
            this.HandyAddyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cleaner_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.CamEmpGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CamEmpSwitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox cameraBox;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.GroupBox HandyAddyGroupBox;
        private C1.Win.C1Input.C1Button SearchBtn;
        private C1.Win.C1Input.C1Button Cleaner_btn;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.Label Plabel;
        private System.Windows.Forms.Label Olabel;
        private System.Windows.Forms.Label Ilabel;
        private System.Windows.Forms.Label Flabel;
        private System.Windows.Forms.Label KeySkanLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox CamEmpGroup;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private System.Windows.Forms.Timer Status_timer;
        private C1.Win.C1Input.C1Label c1Label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label EmpSkanLabel;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Button CamEmpSwitch;
    }
}

