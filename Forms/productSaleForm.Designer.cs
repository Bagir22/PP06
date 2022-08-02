namespace PopryzhenokPP06
{
    partial class productSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productSaleForm));
            this.realizationListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addProductSaleBtn = new System.Windows.Forms.Button();
            this.deleteProductSaleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // realizationListBox
            // 
            this.realizationListBox.FormattingEnabled = true;
            this.realizationListBox.HorizontalScrollbar = true;
            this.realizationListBox.Location = new System.Drawing.Point(15, 31);
            this.realizationListBox.Name = "realizationListBox";
            this.realizationListBox.Size = new System.Drawing.Size(270, 184);
            this.realizationListBox.TabIndex = 0;
            this.realizationListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.realizationListBox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реализация продукции:";
            // 
            // addProductSaleBtn
            // 
            this.addProductSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductSaleBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductSaleBtn.ForeColor = System.Drawing.Color.Black;
            this.addProductSaleBtn.Location = new System.Drawing.Point(15, 221);
            this.addProductSaleBtn.Name = "addProductSaleBtn";
            this.addProductSaleBtn.Size = new System.Drawing.Size(132, 50);
            this.addProductSaleBtn.TabIndex = 2;
            this.addProductSaleBtn.Text = "Добавить продукцию";
            this.addProductSaleBtn.UseVisualStyleBackColor = true;
            this.addProductSaleBtn.Click += new System.EventHandler(this.addProductSaleBtn_Click);
            // 
            // deleteProductSaleBtn
            // 
            this.deleteProductSaleBtn.Enabled = false;
            this.deleteProductSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductSaleBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProductSaleBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteProductSaleBtn.Location = new System.Drawing.Point(153, 221);
            this.deleteProductSaleBtn.Name = "deleteProductSaleBtn";
            this.deleteProductSaleBtn.Size = new System.Drawing.Size(132, 50);
            this.deleteProductSaleBtn.TabIndex = 3;
            this.deleteProductSaleBtn.Text = "Удалить выбранные продукции";
            this.deleteProductSaleBtn.UseVisualStyleBackColor = true;
            this.deleteProductSaleBtn.Click += new System.EventHandler(this.deleteProductSaleBtn_Click);
            // 
            // productSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 281);
            this.Controls.Add(this.deleteProductSaleBtn);
            this.Controls.Add(this.addProductSaleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.realizationListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productSaleForm";
            this.Text = "Реализация продукции";
            this.Load += new System.EventHandler(this.productSaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox realizationListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProductSaleBtn;
        private System.Windows.Forms.Button deleteProductSaleBtn;
    }
}