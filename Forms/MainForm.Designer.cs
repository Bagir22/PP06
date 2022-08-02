namespace PopryzhenokPP06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.agentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AscDescComboBox = new System.Windows.Forms.ComboBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SortLabel = new System.Windows.Forms.Label();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.CompanyIcon = new System.Windows.Forms.PictureBox();
            this.addAgentButton = new System.Windows.Forms.Button();
            this.pageView = new System.Windows.Forms.Label();
            this.changePriorityBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(52, 128);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(216, 23);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // sortBox
            // 
            this.sortBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBox.Items.AddRange(new object[] {
            "Наименование агента",
            "Размер скидки",
            "Приоритет агента"});
            this.sortBox.Location = new System.Drawing.Point(276, 128);
            this.sortBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(138, 23);
            this.sortBox.TabIndex = 1;
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterBox.Items.AddRange(new object[] {
            "Все типы",
            "МКК",
            "ОАО",
            "ООО",
            "ЗАО",
            "МФО",
            "ПАО"});
            this.filterBox.Location = new System.Drawing.Point(422, 128);
            this.filterBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(112, 23);
            this.filterBox.TabIndex = 2;
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // agentsPanel
            // 
            this.agentsPanel.AutoScroll = true;
            this.agentsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agentsPanel.Location = new System.Drawing.Point(52, 167);
            this.agentsPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.agentsPanel.Name = "agentsPanel";
            this.agentsPanel.Size = new System.Drawing.Size(666, 452);
            this.agentsPanel.TabIndex = 3;
            // 
            // AscDescComboBox
            // 
            this.AscDescComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AscDescComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AscDescComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AscDescComboBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AscDescComboBox.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.AscDescComboBox.Location = new System.Drawing.Point(542, 128);
            this.AscDescComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AscDescComboBox.Name = "AscDescComboBox";
            this.AscDescComboBox.Size = new System.Drawing.Size(176, 23);
            this.AscDescComboBox.TabIndex = 4;
            this.AscDescComboBox.SelectedIndexChanged += new System.EventHandler(this.AscDescComboBox_SelectedIndexChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Black;
            this.SearchLabel.Location = new System.Drawing.Point(52, 103);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(53, 18);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Поиск:";
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortLabel.ForeColor = System.Drawing.Color.Black;
            this.SortLabel.Location = new System.Drawing.Point(273, 103);
            this.SortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(84, 18);
            this.SortLabel.TabIndex = 6;
            this.SortLabel.Text = "Сортировка:";
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLabel.ForeColor = System.Drawing.Color.Black;
            this.FilterLabel.Location = new System.Drawing.Point(419, 104);
            this.FilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(85, 18);
            this.FilterLabel.TabIndex = 7;
            this.FilterLabel.Text = "Фильтрация:";
            // 
            // CompanyIcon
            // 
            this.CompanyIcon.Image = ((System.Drawing.Image)(resources.GetObject("CompanyIcon.Image")));
            this.CompanyIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("CompanyIcon.InitialImage")));
            this.CompanyIcon.Location = new System.Drawing.Point(52, 18);
            this.CompanyIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompanyIcon.Name = "CompanyIcon";
            this.CompanyIcon.Size = new System.Drawing.Size(82, 81);
            this.CompanyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyIcon.TabIndex = 8;
            this.CompanyIcon.TabStop = false;
            this.CompanyIcon.WaitOnLoad = true;
            // 
            // addAgentButton
            // 
            this.addAgentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAgentButton.ForeColor = System.Drawing.Color.Black;
            this.addAgentButton.Location = new System.Drawing.Point(52, 639);
            this.addAgentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addAgentButton.Name = "addAgentButton";
            this.addAgentButton.Size = new System.Drawing.Size(143, 27);
            this.addAgentButton.TabIndex = 9;
            this.addAgentButton.Text = "Добавить агента";
            this.addAgentButton.UseVisualStyleBackColor = true;
            this.addAgentButton.Click += new System.EventHandler(this.addAgentButton_Click);
            // 
            // pageView
            // 
            this.pageView.AutoSize = true;
            this.pageView.ForeColor = System.Drawing.Color.Black;
            this.pageView.Location = new System.Drawing.Point(52, 673);
            this.pageView.Name = "pageView";
            this.pageView.Size = new System.Drawing.Size(36, 15);
            this.pageView.TabIndex = 10;
            this.pageView.Text = "label1";
            // 
            // changePriorityBtn
            // 
            this.changePriorityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePriorityBtn.ForeColor = System.Drawing.Color.Black;
            this.changePriorityBtn.Location = new System.Drawing.Point(203, 639);
            this.changePriorityBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changePriorityBtn.Name = "changePriorityBtn";
            this.changePriorityBtn.Size = new System.Drawing.Size(143, 27);
            this.changePriorityBtn.TabIndex = 11;
            this.changePriorityBtn.Text = "Изменить приоритет";
            this.changePriorityBtn.UseVisualStyleBackColor = true;
            this.changePriorityBtn.Visible = false;
            this.changePriorityBtn.Click += new System.EventHandler(this.changePriorityBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 699);
            this.Controls.Add(this.changePriorityBtn);
            this.Controls.Add(this.pageView);
            this.Controls.Add(this.addAgentButton);
            this.Controls.Add(this.CompanyIcon);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.AscDescComboBox);
            this.Controls.Add(this.agentsPanel);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.searchBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Попрыженок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.FlowLayoutPanel agentsPanel;
        private System.Windows.Forms.ComboBox AscDescComboBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.PictureBox CompanyIcon;
        private System.Windows.Forms.Button addAgentButton;
        private System.Windows.Forms.Label pageView;
        private System.Windows.Forms.Button changePriorityBtn;
    }
}

