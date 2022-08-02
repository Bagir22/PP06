namespace PopryzhenokPP06
{
    partial class addProductSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProductSaleForm));
            this.agentName = new System.Windows.Forms.TextBox();
            this.productsList = new System.Windows.Forms.ComboBox();
            this.productSaleDate = new System.Windows.Forms.DateTimePicker();
            this.productCountNUD = new System.Windows.Forms.NumericUpDown();
            this.agentLabel = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.productSaleDateLabel = new System.Windows.Forms.Label();
            this.productCount = new System.Windows.Forms.Label();
            this.addRealizationBtn = new System.Windows.Forms.Button();
            this.productSearchLabel = new System.Windows.Forms.Label();
            this.productSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productCountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // agentName
            // 
            this.agentName.Enabled = false;
            this.agentName.Location = new System.Drawing.Point(13, 24);
            this.agentName.Margin = new System.Windows.Forms.Padding(4);
            this.agentName.Name = "agentName";
            this.agentName.Size = new System.Drawing.Size(184, 24);
            this.agentName.TabIndex = 0;
            // 
            // productsList
            // 
            this.productsList.FormattingEnabled = true;
            this.productsList.Location = new System.Drawing.Point(13, 71);
            this.productsList.Margin = new System.Windows.Forms.Padding(4);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(184, 25);
            this.productsList.TabIndex = 1;
            // 
            // productSaleDate
            // 
            this.productSaleDate.Location = new System.Drawing.Point(15, 170);
            this.productSaleDate.Margin = new System.Windows.Forms.Padding(4);
            this.productSaleDate.Name = "productSaleDate";
            this.productSaleDate.Size = new System.Drawing.Size(182, 24);
            this.productSaleDate.TabIndex = 2;
            // 
            // productCountNUD
            // 
            this.productCountNUD.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCountNUD.Location = new System.Drawing.Point(15, 219);
            this.productCountNUD.Margin = new System.Windows.Forms.Padding(4);
            this.productCountNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.productCountNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCountNUD.Name = "productCountNUD";
            this.productCountNUD.Size = new System.Drawing.Size(182, 24);
            this.productCountNUD.TabIndex = 3;
            this.productCountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agentLabel
            // 
            this.agentLabel.AutoSize = true;
            this.agentLabel.Location = new System.Drawing.Point(10, 3);
            this.agentLabel.Name = "agentLabel";
            this.agentLabel.Size = new System.Drawing.Size(71, 17);
            this.agentLabel.TabIndex = 4;
            this.agentLabel.Text = "ID Агента:";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(10, 52);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(61, 17);
            this.ProductName.TabIndex = 5;
            this.ProductName.Text = "Продукт:";
            // 
            // productSaleDateLabel
            // 
            this.productSaleDateLabel.AutoSize = true;
            this.productSaleDateLabel.Location = new System.Drawing.Point(12, 149);
            this.productSaleDateLabel.Name = "productSaleDateLabel";
            this.productSaleDateLabel.Size = new System.Drawing.Size(111, 17);
            this.productSaleDateLabel.TabIndex = 6;
            this.productSaleDateLabel.Text = "Дата реализации:";
            // 
            // productCount
            // 
            this.productCount.AutoSize = true;
            this.productCount.Location = new System.Drawing.Point(12, 198);
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(147, 17);
            this.productCount.TabIndex = 7;
            this.productCount.Text = "Количество продукции:";
            // 
            // addRealizationBtn
            // 
            this.addRealizationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRealizationBtn.Location = new System.Drawing.Point(15, 250);
            this.addRealizationBtn.Name = "addRealizationBtn";
            this.addRealizationBtn.Size = new System.Drawing.Size(182, 55);
            this.addRealizationBtn.TabIndex = 8;
            this.addRealizationBtn.Text = "Добавить реализацию продукции";
            this.addRealizationBtn.UseVisualStyleBackColor = true;
            this.addRealizationBtn.Click += new System.EventHandler(this.addRealizationBtn_Click);
            // 
            // productSearchLabel
            // 
            this.productSearchLabel.AutoSize = true;
            this.productSearchLabel.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productSearchLabel.Location = new System.Drawing.Point(10, 100);
            this.productSearchLabel.Name = "productSearchLabel";
            this.productSearchLabel.Size = new System.Drawing.Size(80, 13);
            this.productSearchLabel.TabIndex = 9;
            this.productSearchLabel.Text = "Поиск продукта:";
            // 
            // productSearch
            // 
            this.productSearch.Font = new System.Drawing.Font("Comic Sans MS", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productSearch.Location = new System.Drawing.Point(13, 121);
            this.productSearch.Margin = new System.Windows.Forms.Padding(4);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(184, 17);
            this.productSearch.TabIndex = 10;
            this.productSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // addProductSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(212, 321);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.productSearchLabel);
            this.Controls.Add(this.addRealizationBtn);
            this.Controls.Add(this.productCount);
            this.Controls.Add(this.productSaleDateLabel);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.agentLabel);
            this.Controls.Add(this.productCountNUD);
            this.Controls.Add(this.productSaleDate);
            this.Controls.Add(this.productsList);
            this.Controls.Add(this.agentName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addProductSaleForm";
            this.Text = "Добавление реализации продукции";
            this.Load += new System.EventHandler(this.addProductSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productCountNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox agentName;
        private System.Windows.Forms.ComboBox productsList;
        private System.Windows.Forms.DateTimePicker productSaleDate;
        private System.Windows.Forms.NumericUpDown productCountNUD;
        private System.Windows.Forms.Label agentLabel;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label productSaleDateLabel;
        private System.Windows.Forms.Label productCount;
        private System.Windows.Forms.Button addRealizationBtn;
        private System.Windows.Forms.Label productSearchLabel;
        private System.Windows.Forms.TextBox productSearch;
    }
}