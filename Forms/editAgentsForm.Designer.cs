namespace PopryzhenokPP06
{
    partial class editAgentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editAgentsForm));
            this.agentINNLabel = new System.Windows.Forms.Label();
            this.agentPriorityLabel = new System.Windows.Forms.Label();
            this.agentAddress = new System.Windows.Forms.Label();
            this.agentTypeLabel = new System.Windows.Forms.Label();
            this.agentTitleLabel = new System.Windows.Forms.Label();
            this.agentIcon = new System.Windows.Forms.PictureBox();
            this.agentTitleTextBox = new System.Windows.Forms.TextBox();
            this.agentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.agentPriorityNumUD = new System.Windows.Forms.NumericUpDown();
            this.agentINNNumUD = new System.Windows.Forms.NumericUpDown();
            this.agentKPPNumUD = new System.Windows.Forms.NumericUpDown();
            this.agentKPPLabel = new System.Windows.Forms.Label();
            this.agentLogo = new System.Windows.Forms.Label();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agentPhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.agentPhoneNumberLabel = new System.Windows.Forms.Label();
            this.agentEmailTextbox = new System.Windows.Forms.TextBox();
            this.agentEmailLabel = new System.Windows.Forms.Label();
            this.editAgentBtn = new System.Windows.Forms.Button();
            this.agentDeleteBtn = new System.Windows.Forms.Button();
            this.agentAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.CompanyIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.agentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentPriorityNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentINNNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentKPPNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // agentINNLabel
            // 
            this.agentINNLabel.AutoSize = true;
            this.agentINNLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentINNLabel.ForeColor = System.Drawing.Color.Black;
            this.agentINNLabel.Location = new System.Drawing.Point(12, 271);
            this.agentINNLabel.Name = "agentINNLabel";
            this.agentINNLabel.Size = new System.Drawing.Size(42, 18);
            this.agentINNLabel.TabIndex = 11;
            this.agentINNLabel.Text = "ИНН:";
            // 
            // agentPriorityLabel
            // 
            this.agentPriorityLabel.AutoSize = true;
            this.agentPriorityLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentPriorityLabel.ForeColor = System.Drawing.Color.Black;
            this.agentPriorityLabel.Location = new System.Drawing.Point(12, 105);
            this.agentPriorityLabel.Name = "agentPriorityLabel";
            this.agentPriorityLabel.Size = new System.Drawing.Size(125, 18);
            this.agentPriorityLabel.TabIndex = 10;
            this.agentPriorityLabel.Text = "Приоритет агента:";
            // 
            // agentAddress
            // 
            this.agentAddress.AutoSize = true;
            this.agentAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentAddress.ForeColor = System.Drawing.Color.Black;
            this.agentAddress.Location = new System.Drawing.Point(12, 154);
            this.agentAddress.Name = "agentAddress";
            this.agentAddress.Size = new System.Drawing.Size(94, 18);
            this.agentAddress.TabIndex = 9;
            this.agentAddress.Text = "Адрес агента:";
            // 
            // agentTypeLabel
            // 
            this.agentTypeLabel.AutoSize = true;
            this.agentTypeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.agentTypeLabel.Location = new System.Drawing.Point(12, 58);
            this.agentTypeLabel.Name = "agentTypeLabel";
            this.agentTypeLabel.Size = new System.Drawing.Size(77, 18);
            this.agentTypeLabel.TabIndex = 8;
            this.agentTypeLabel.Text = "Тип агента";
            // 
            // agentTitleLabel
            // 
            this.agentTitleLabel.AutoSize = true;
            this.agentTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.agentTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.agentTitleLabel.Name = "agentTitleLabel";
            this.agentTitleLabel.Size = new System.Drawing.Size(149, 18);
            this.agentTitleLabel.TabIndex = 7;
            this.agentTitleLabel.Text = "Наименование агента:";
            // 
            // agentIcon
            // 
            this.agentIcon.Location = new System.Drawing.Point(240, 101);
            this.agentIcon.Name = "agentIcon";
            this.agentIcon.Size = new System.Drawing.Size(116, 106);
            this.agentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.agentIcon.TabIndex = 6;
            this.agentIcon.TabStop = false;
            this.agentIcon.DoubleClick += new System.EventHandler(this.agentIcon_DoubleClick);
            // 
            // agentTitleTextBox
            // 
            this.agentTitleTextBox.Location = new System.Drawing.Point(15, 31);
            this.agentTitleTextBox.Name = "agentTitleTextBox";
            this.agentTitleTextBox.Size = new System.Drawing.Size(146, 24);
            this.agentTitleTextBox.TabIndex = 12;
            // 
            // agentTypeComboBox
            // 
            this.agentTypeComboBox.BackColor = System.Drawing.Color.White;
            this.agentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentTypeComboBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTypeComboBox.Items.AddRange(new object[] {
            "МКК",
            "ОАО",
            "ООО",
            "ЗАО",
            "МФО",
            "ПАО"});
            this.agentTypeComboBox.Location = new System.Drawing.Point(15, 79);
            this.agentTypeComboBox.Name = "agentTypeComboBox";
            this.agentTypeComboBox.Size = new System.Drawing.Size(146, 23);
            this.agentTypeComboBox.TabIndex = 13;
            // 
            // agentPriorityNumUD
            // 
            this.agentPriorityNumUD.Location = new System.Drawing.Point(15, 127);
            this.agentPriorityNumUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.agentPriorityNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.agentPriorityNumUD.Name = "agentPriorityNumUD";
            this.agentPriorityNumUD.Size = new System.Drawing.Size(146, 24);
            this.agentPriorityNumUD.TabIndex = 14;
            this.agentPriorityNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agentINNNumUD
            // 
            this.agentINNNumUD.Location = new System.Drawing.Point(15, 292);
            this.agentINNNumUD.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.agentINNNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.agentINNNumUD.Name = "agentINNNumUD";
            this.agentINNNumUD.Size = new System.Drawing.Size(146, 24);
            this.agentINNNumUD.TabIndex = 16;
            this.agentINNNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agentKPPNumUD
            // 
            this.agentKPPNumUD.Location = new System.Drawing.Point(15, 340);
            this.agentKPPNumUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.agentKPPNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.agentKPPNumUD.Name = "agentKPPNumUD";
            this.agentKPPNumUD.Size = new System.Drawing.Size(146, 24);
            this.agentKPPNumUD.TabIndex = 18;
            this.agentKPPNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agentKPPLabel
            // 
            this.agentKPPLabel.AutoSize = true;
            this.agentKPPLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentKPPLabel.ForeColor = System.Drawing.Color.Black;
            this.agentKPPLabel.Location = new System.Drawing.Point(12, 319);
            this.agentKPPLabel.Name = "agentKPPLabel";
            this.agentKPPLabel.Size = new System.Drawing.Size(44, 18);
            this.agentKPPLabel.TabIndex = 17;
            this.agentKPPLabel.Text = "КПП:";
            // 
            // agentLogo
            // 
            this.agentLogo.AutoSize = true;
            this.agentLogo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentLogo.ForeColor = System.Drawing.Color.Black;
            this.agentLogo.Location = new System.Drawing.Point(237, 80);
            this.agentLogo.Name = "agentLogo";
            this.agentLogo.Size = new System.Drawing.Size(110, 18);
            this.agentLogo.TabIndex = 19;
            this.agentLogo.Text = "Логотип агента:";
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(240, 246);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(116, 24);
            this.directorTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(237, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Директор:";
            // 
            // agentPhoneNumberTextBox
            // 
            this.agentPhoneNumberTextBox.Location = new System.Drawing.Point(240, 294);
            this.agentPhoneNumberTextBox.Mask = "0(000)0000000";
            this.agentPhoneNumberTextBox.Name = "agentPhoneNumberTextBox";
            this.agentPhoneNumberTextBox.Size = new System.Drawing.Size(116, 24);
            this.agentPhoneNumberTextBox.TabIndex = 22;
            // 
            // agentPhoneNumberLabel
            // 
            this.agentPhoneNumberLabel.AutoSize = true;
            this.agentPhoneNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentPhoneNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.agentPhoneNumberLabel.Location = new System.Drawing.Point(237, 273);
            this.agentPhoneNumberLabel.Name = "agentPhoneNumberLabel";
            this.agentPhoneNumberLabel.Size = new System.Drawing.Size(119, 18);
            this.agentPhoneNumberLabel.TabIndex = 23;
            this.agentPhoneNumberLabel.Text = "Номер телефона:";
            // 
            // agentEmailTextbox
            // 
            this.agentEmailTextbox.Location = new System.Drawing.Point(240, 341);
            this.agentEmailTextbox.Name = "agentEmailTextbox";
            this.agentEmailTextbox.Size = new System.Drawing.Size(116, 24);
            this.agentEmailTextbox.TabIndex = 25;
            // 
            // agentEmailLabel
            // 
            this.agentEmailLabel.AutoSize = true;
            this.agentEmailLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentEmailLabel.ForeColor = System.Drawing.Color.Black;
            this.agentEmailLabel.Location = new System.Drawing.Point(237, 321);
            this.agentEmailLabel.Name = "agentEmailLabel";
            this.agentEmailLabel.Size = new System.Drawing.Size(44, 18);
            this.agentEmailLabel.TabIndex = 24;
            this.agentEmailLabel.Text = "Email:";
            // 
            // editAgentBtn
            // 
            this.editAgentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editAgentBtn.Location = new System.Drawing.Point(15, 370);
            this.editAgentBtn.Name = "editAgentBtn";
            this.editAgentBtn.Size = new System.Drawing.Size(146, 23);
            this.editAgentBtn.TabIndex = 26;
            this.editAgentBtn.Text = "Редактировать агента";
            this.editAgentBtn.UseVisualStyleBackColor = true;
            this.editAgentBtn.Click += new System.EventHandler(this.editAgentBtn_Click);
            // 
            // agentDeleteBtn
            // 
            this.agentDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agentDeleteBtn.Location = new System.Drawing.Point(240, 370);
            this.agentDeleteBtn.Name = "agentDeleteBtn";
            this.agentDeleteBtn.Size = new System.Drawing.Size(116, 23);
            this.agentDeleteBtn.TabIndex = 27;
            this.agentDeleteBtn.Text = "Удалить агента";
            this.agentDeleteBtn.UseVisualStyleBackColor = true;
            this.agentDeleteBtn.Click += new System.EventHandler(this.agentDeleteBtn_Click);
            // 
            // agentAddressTextBox
            // 
            this.agentAddressTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentAddressTextBox.Location = new System.Drawing.Point(15, 172);
            this.agentAddressTextBox.Name = "agentAddressTextBox";
            this.agentAddressTextBox.Size = new System.Drawing.Size(146, 96);
            this.agentAddressTextBox.TabIndex = 28;
            this.agentAddressTextBox.Text = "";
            // 
            // CompanyIcon
            // 
            this.CompanyIcon.Image = ((System.Drawing.Image)(resources.GetObject("CompanyIcon.Image")));
            this.CompanyIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("CompanyIcon.InitialImage")));
            this.CompanyIcon.Location = new System.Drawing.Point(286, 6);
            this.CompanyIcon.Name = "CompanyIcon";
            this.CompanyIcon.Size = new System.Drawing.Size(70, 70);
            this.CompanyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyIcon.TabIndex = 29;
            this.CompanyIcon.TabStop = false;
            this.CompanyIcon.WaitOnLoad = true;
            // 
            // editAgentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 402);
            this.Controls.Add(this.CompanyIcon);
            this.Controls.Add(this.agentAddressTextBox);
            this.Controls.Add(this.agentDeleteBtn);
            this.Controls.Add(this.editAgentBtn);
            this.Controls.Add(this.agentEmailTextbox);
            this.Controls.Add(this.agentEmailLabel);
            this.Controls.Add(this.agentPhoneNumberLabel);
            this.Controls.Add(this.agentPhoneNumberTextBox);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agentLogo);
            this.Controls.Add(this.agentKPPNumUD);
            this.Controls.Add(this.agentKPPLabel);
            this.Controls.Add(this.agentINNNumUD);
            this.Controls.Add(this.agentPriorityNumUD);
            this.Controls.Add(this.agentTypeComboBox);
            this.Controls.Add(this.agentTitleTextBox);
            this.Controls.Add(this.agentINNLabel);
            this.Controls.Add(this.agentPriorityLabel);
            this.Controls.Add(this.agentAddress);
            this.Controls.Add(this.agentTypeLabel);
            this.Controls.Add(this.agentTitleLabel);
            this.Controls.Add(this.agentIcon);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editAgentsForm";
            this.Text = "Редактирование агента";
            this.Load += new System.EventHandler(this.editAgentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentPriorityNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentINNNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentKPPNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label agentINNLabel;
        private System.Windows.Forms.Label agentPriorityLabel;
        private System.Windows.Forms.Label agentAddress;
        private System.Windows.Forms.Label agentTypeLabel;
        private System.Windows.Forms.Label agentTitleLabel;
        private System.Windows.Forms.PictureBox agentIcon;
        private System.Windows.Forms.TextBox agentTitleTextBox;
        private System.Windows.Forms.ComboBox agentTypeComboBox;
        private System.Windows.Forms.NumericUpDown agentPriorityNumUD;
        private System.Windows.Forms.NumericUpDown agentINNNumUD;
        private System.Windows.Forms.NumericUpDown agentKPPNumUD;
        private System.Windows.Forms.Label agentKPPLabel;
        private System.Windows.Forms.Label agentLogo;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox agentPhoneNumberTextBox;
        private System.Windows.Forms.Label agentPhoneNumberLabel;
        private System.Windows.Forms.TextBox agentEmailTextbox;
        private System.Windows.Forms.Label agentEmailLabel;
        private System.Windows.Forms.Button editAgentBtn;
        private System.Windows.Forms.Button agentDeleteBtn;
        private System.Windows.Forms.RichTextBox agentAddressTextBox;
        private System.Windows.Forms.PictureBox CompanyIcon;
    }
}