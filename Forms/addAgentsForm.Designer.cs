namespace PopryzhenokPP06
{
    partial class addAgentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAgentsForm));
            this.CompanyIcon = new System.Windows.Forms.PictureBox();
            this.agentAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.addAgentBtn = new System.Windows.Forms.Button();
            this.agentEmailTextbox = new System.Windows.Forms.TextBox();
            this.agentEmailLabel = new System.Windows.Forms.Label();
            this.agentPhoneNumberLabel = new System.Windows.Forms.Label();
            this.agentPhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agentLogo = new System.Windows.Forms.Label();
            this.agentKPPNumUD = new System.Windows.Forms.NumericUpDown();
            this.agentKPPLabel = new System.Windows.Forms.Label();
            this.agentINNNumUD = new System.Windows.Forms.NumericUpDown();
            this.agentPriorityNumUD = new System.Windows.Forms.NumericUpDown();
            this.agentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.agentTitleTextBox = new System.Windows.Forms.TextBox();
            this.agentINNLabel = new System.Windows.Forms.Label();
            this.agentPriorityLabel = new System.Windows.Forms.Label();
            this.agentAddress = new System.Windows.Forms.Label();
            this.agentTypeLabel = new System.Windows.Forms.Label();
            this.agentTitleLabel = new System.Windows.Forms.Label();
            this.agentIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentKPPNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentINNNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentPriorityNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyIcon
            // 
            this.CompanyIcon.Image = ((System.Drawing.Image)(resources.GetObject("CompanyIcon.Image")));
            this.CompanyIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("CompanyIcon.InitialImage")));
            this.CompanyIcon.Location = new System.Drawing.Point(334, 7);
            this.CompanyIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompanyIcon.Name = "CompanyIcon";
            this.CompanyIcon.Size = new System.Drawing.Size(82, 81);
            this.CompanyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyIcon.TabIndex = 52;
            this.CompanyIcon.TabStop = false;
            this.CompanyIcon.WaitOnLoad = true;
            // 
            // agentAddressTextBox
            // 
            this.agentAddressTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentAddressTextBox.Location = new System.Drawing.Point(18, 198);
            this.agentAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.agentAddressTextBox.Name = "agentAddressTextBox";
            this.agentAddressTextBox.Size = new System.Drawing.Size(170, 110);
            this.agentAddressTextBox.TabIndex = 51;
            this.agentAddressTextBox.Text = "";
            // 
            // addAgentBtn
            // 
            this.addAgentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAgentBtn.Location = new System.Drawing.Point(18, 427);
            this.addAgentBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addAgentBtn.Name = "addAgentBtn";
            this.addAgentBtn.Size = new System.Drawing.Size(170, 27);
            this.addAgentBtn.TabIndex = 49;
            this.addAgentBtn.Text = "Добавить агента";
            this.addAgentBtn.UseVisualStyleBackColor = true;
            this.addAgentBtn.Click += new System.EventHandler(this.addAgentBtn_Click_1);
            // 
            // agentEmailTextbox
            // 
            this.agentEmailTextbox.Location = new System.Drawing.Point(280, 393);
            this.agentEmailTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.agentEmailTextbox.Name = "agentEmailTextbox";
            this.agentEmailTextbox.Size = new System.Drawing.Size(135, 23);
            this.agentEmailTextbox.TabIndex = 48;
            // 
            // agentEmailLabel
            // 
            this.agentEmailLabel.AutoSize = true;
            this.agentEmailLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentEmailLabel.ForeColor = System.Drawing.Color.Black;
            this.agentEmailLabel.Location = new System.Drawing.Point(276, 370);
            this.agentEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentEmailLabel.Name = "agentEmailLabel";
            this.agentEmailLabel.Size = new System.Drawing.Size(44, 18);
            this.agentEmailLabel.TabIndex = 47;
            this.agentEmailLabel.Text = "Email:";
            // 
            // agentPhoneNumberLabel
            // 
            this.agentPhoneNumberLabel.AutoSize = true;
            this.agentPhoneNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentPhoneNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.agentPhoneNumberLabel.Location = new System.Drawing.Point(276, 315);
            this.agentPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentPhoneNumberLabel.Name = "agentPhoneNumberLabel";
            this.agentPhoneNumberLabel.Size = new System.Drawing.Size(119, 18);
            this.agentPhoneNumberLabel.TabIndex = 46;
            this.agentPhoneNumberLabel.Text = "Номер телефона:";
            // 
            // agentPhoneNumberTextBox
            // 
            this.agentPhoneNumberTextBox.Location = new System.Drawing.Point(280, 339);
            this.agentPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.agentPhoneNumberTextBox.Mask = "0(000)0000000";
            this.agentPhoneNumberTextBox.Name = "agentPhoneNumberTextBox";
            this.agentPhoneNumberTextBox.Size = new System.Drawing.Size(135, 23);
            this.agentPhoneNumberTextBox.TabIndex = 45;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(280, 284);
            this.directorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(135, 23);
            this.directorTextBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(276, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Директор:";
            // 
            // agentLogo
            // 
            this.agentLogo.AutoSize = true;
            this.agentLogo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentLogo.ForeColor = System.Drawing.Color.Black;
            this.agentLogo.Location = new System.Drawing.Point(276, 92);
            this.agentLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentLogo.Name = "agentLogo";
            this.agentLogo.Size = new System.Drawing.Size(110, 18);
            this.agentLogo.TabIndex = 42;
            this.agentLogo.Text = "Логотип агента:";
            // 
            // agentKPPNumUD
            // 
            this.agentKPPNumUD.Location = new System.Drawing.Point(18, 392);
            this.agentKPPNumUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.agentKPPNumUD.Size = new System.Drawing.Size(170, 23);
            this.agentKPPNumUD.TabIndex = 41;
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
            this.agentKPPLabel.Location = new System.Drawing.Point(14, 368);
            this.agentKPPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentKPPLabel.Name = "agentKPPLabel";
            this.agentKPPLabel.Size = new System.Drawing.Size(44, 18);
            this.agentKPPLabel.TabIndex = 40;
            this.agentKPPLabel.Text = "КПП:";
            // 
            // agentINNNumUD
            // 
            this.agentINNNumUD.Location = new System.Drawing.Point(18, 337);
            this.agentINNNumUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.agentINNNumUD.Size = new System.Drawing.Size(170, 23);
            this.agentINNNumUD.TabIndex = 39;
            this.agentINNNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agentPriorityNumUD
            // 
            this.agentPriorityNumUD.Location = new System.Drawing.Point(18, 147);
            this.agentPriorityNumUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.agentPriorityNumUD.Size = new System.Drawing.Size(170, 23);
            this.agentPriorityNumUD.TabIndex = 38;
            this.agentPriorityNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.agentTypeComboBox.Location = new System.Drawing.Point(18, 91);
            this.agentTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.agentTypeComboBox.Name = "agentTypeComboBox";
            this.agentTypeComboBox.Size = new System.Drawing.Size(170, 23);
            this.agentTypeComboBox.TabIndex = 37;
            // 
            // agentTitleTextBox
            // 
            this.agentTitleTextBox.Location = new System.Drawing.Point(18, 36);
            this.agentTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.agentTitleTextBox.Name = "agentTitleTextBox";
            this.agentTitleTextBox.Size = new System.Drawing.Size(170, 23);
            this.agentTitleTextBox.TabIndex = 36;
            // 
            // agentINNLabel
            // 
            this.agentINNLabel.AutoSize = true;
            this.agentINNLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentINNLabel.ForeColor = System.Drawing.Color.Black;
            this.agentINNLabel.Location = new System.Drawing.Point(14, 313);
            this.agentINNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentINNLabel.Name = "agentINNLabel";
            this.agentINNLabel.Size = new System.Drawing.Size(42, 18);
            this.agentINNLabel.TabIndex = 35;
            this.agentINNLabel.Text = "ИНН:";
            // 
            // agentPriorityLabel
            // 
            this.agentPriorityLabel.AutoSize = true;
            this.agentPriorityLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentPriorityLabel.ForeColor = System.Drawing.Color.Black;
            this.agentPriorityLabel.Location = new System.Drawing.Point(14, 121);
            this.agentPriorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentPriorityLabel.Name = "agentPriorityLabel";
            this.agentPriorityLabel.Size = new System.Drawing.Size(125, 18);
            this.agentPriorityLabel.TabIndex = 34;
            this.agentPriorityLabel.Text = "Приоритет агента:";
            // 
            // agentAddress
            // 
            this.agentAddress.AutoSize = true;
            this.agentAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentAddress.ForeColor = System.Drawing.Color.Black;
            this.agentAddress.Location = new System.Drawing.Point(14, 178);
            this.agentAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentAddress.Name = "agentAddress";
            this.agentAddress.Size = new System.Drawing.Size(94, 18);
            this.agentAddress.TabIndex = 33;
            this.agentAddress.Text = "Адрес агента:";
            // 
            // agentTypeLabel
            // 
            this.agentTypeLabel.AutoSize = true;
            this.agentTypeLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.agentTypeLabel.Location = new System.Drawing.Point(14, 67);
            this.agentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentTypeLabel.Name = "agentTypeLabel";
            this.agentTypeLabel.Size = new System.Drawing.Size(77, 18);
            this.agentTypeLabel.TabIndex = 32;
            this.agentTypeLabel.Text = "Тип агента";
            // 
            // agentTitleLabel
            // 
            this.agentTitleLabel.AutoSize = true;
            this.agentTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.agentTitleLabel.Location = new System.Drawing.Point(14, 10);
            this.agentTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentTitleLabel.Name = "agentTitleLabel";
            this.agentTitleLabel.Size = new System.Drawing.Size(149, 18);
            this.agentTitleLabel.TabIndex = 31;
            this.agentTitleLabel.Text = "Наименование агента:";
            // 
            // agentIcon
            // 
            this.agentIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agentIcon.Location = new System.Drawing.Point(280, 117);
            this.agentIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.agentIcon.Name = "agentIcon";
            this.agentIcon.Size = new System.Drawing.Size(135, 122);
            this.agentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.agentIcon.TabIndex = 30;
            this.agentIcon.TabStop = false;
            this.agentIcon.Click += new System.EventHandler(this.agentIcon_Click);
            this.agentIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.agentIcon_MouseDoubleClick);
            // 
            // addAgentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 462);
            this.Controls.Add(this.CompanyIcon);
            this.Controls.Add(this.agentAddressTextBox);
            this.Controls.Add(this.addAgentBtn);
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
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "addAgentsForm";
            this.Text = "Добавить агента";
            this.Load += new System.EventHandler(this.addAgentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentKPPNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentINNNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentPriorityNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CompanyIcon;
        private System.Windows.Forms.RichTextBox agentAddressTextBox;
        private System.Windows.Forms.Button addAgentBtn;
        private System.Windows.Forms.TextBox agentEmailTextbox;
        private System.Windows.Forms.Label agentEmailLabel;
        private System.Windows.Forms.Label agentPhoneNumberLabel;
        private System.Windows.Forms.MaskedTextBox agentPhoneNumberTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label agentLogo;
        private System.Windows.Forms.NumericUpDown agentKPPNumUD;
        private System.Windows.Forms.Label agentKPPLabel;
        private System.Windows.Forms.NumericUpDown agentINNNumUD;
        private System.Windows.Forms.NumericUpDown agentPriorityNumUD;
        private System.Windows.Forms.ComboBox agentTypeComboBox;
        private System.Windows.Forms.TextBox agentTitleTextBox;
        private System.Windows.Forms.Label agentINNLabel;
        private System.Windows.Forms.Label agentPriorityLabel;
        private System.Windows.Forms.Label agentAddress;
        private System.Windows.Forms.Label agentTypeLabel;
        private System.Windows.Forms.Label agentTitleLabel;
        private System.Windows.Forms.PictureBox agentIcon;
    }
}