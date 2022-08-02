namespace PopryzhenokPP06
{
    partial class AgentUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.agentIcon = new System.Windows.Forms.PictureBox();
            this.agentTitle = new System.Windows.Forms.Label();
            this.agentSales = new System.Windows.Forms.Label();
            this.agentPhoneNumber = new System.Windows.Forms.Label();
            this.agentPriority = new System.Windows.Forms.Label();
            this.agentDiscount = new System.Windows.Forms.Label();
            this.productSaleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // agentIcon
            // 
            this.agentIcon.BackColor = System.Drawing.Color.White;
            this.agentIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agentIcon.ErrorImage = null;
            this.agentIcon.Location = new System.Drawing.Point(3, 3);
            this.agentIcon.Name = "agentIcon";
            this.agentIcon.Size = new System.Drawing.Size(116, 106);
            this.agentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.agentIcon.TabIndex = 0;
            this.agentIcon.TabStop = false;
            // 
            // agentTitle
            // 
            this.agentTitle.AutoSize = true;
            this.agentTitle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTitle.ForeColor = System.Drawing.Color.Black;
            this.agentTitle.Location = new System.Drawing.Point(125, 18);
            this.agentTitle.Name = "agentTitle";
            this.agentTitle.Size = new System.Drawing.Size(44, 18);
            this.agentTitle.TabIndex = 1;
            this.agentTitle.Text = "label1";
            // 
            // agentSales
            // 
            this.agentSales.AutoSize = true;
            this.agentSales.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentSales.ForeColor = System.Drawing.Color.Black;
            this.agentSales.Location = new System.Drawing.Point(125, 36);
            this.agentSales.Name = "agentSales";
            this.agentSales.Size = new System.Drawing.Size(46, 18);
            this.agentSales.TabIndex = 2;
            this.agentSales.Text = "label2";
            // 
            // agentPhoneNumber
            // 
            this.agentPhoneNumber.AutoSize = true;
            this.agentPhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.agentPhoneNumber.Location = new System.Drawing.Point(125, 54);
            this.agentPhoneNumber.Name = "agentPhoneNumber";
            this.agentPhoneNumber.Size = new System.Drawing.Size(44, 18);
            this.agentPhoneNumber.TabIndex = 3;
            this.agentPhoneNumber.Text = "label1";
            // 
            // agentPriority
            // 
            this.agentPriority.AutoSize = true;
            this.agentPriority.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentPriority.ForeColor = System.Drawing.Color.Black;
            this.agentPriority.Location = new System.Drawing.Point(125, 75);
            this.agentPriority.Name = "agentPriority";
            this.agentPriority.Size = new System.Drawing.Size(87, 18);
            this.agentPriority.TabIndex = 4;
            this.agentPriority.Text = "agentPriority";
            // 
            // agentDiscount
            // 
            this.agentDiscount.AutoSize = true;
            this.agentDiscount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentDiscount.ForeColor = System.Drawing.Color.Black;
            this.agentDiscount.Location = new System.Drawing.Point(498, 18);
            this.agentDiscount.Name = "agentDiscount";
            this.agentDiscount.Size = new System.Drawing.Size(44, 18);
            this.agentDiscount.TabIndex = 5;
            this.agentDiscount.Text = "label1";
            // 
            // productSaleBtn
            // 
            this.productSaleBtn.BackColor = System.Drawing.Color.White;
            this.productSaleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.productSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSaleBtn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productSaleBtn.ForeColor = System.Drawing.Color.Black;
            this.productSaleBtn.Location = new System.Drawing.Point(379, 73);
            this.productSaleBtn.Name = "productSaleBtn";
            this.productSaleBtn.Size = new System.Drawing.Size(160, 23);
            this.productSaleBtn.TabIndex = 6;
            this.productSaleBtn.Text = "Реализация продукции";
            this.productSaleBtn.UseVisualStyleBackColor = false;
            this.productSaleBtn.Click += new System.EventHandler(this.productSaleBtn_Click);
            // 
            // AgentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.productSaleBtn);
            this.Controls.Add(this.agentDiscount);
            this.Controls.Add(this.agentPriority);
            this.Controls.Add(this.agentPhoneNumber);
            this.Controls.Add(this.agentSales);
            this.Controls.Add(this.agentTitle);
            this.Controls.Add(this.agentIcon);
            this.Name = "AgentUC";
            this.Size = new System.Drawing.Size(542, 110);
            this.Load += new System.EventHandler(this.AgentUC_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AgentUC_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgentUC_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.agentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox agentIcon;
        private System.Windows.Forms.Label agentTitle;
        private System.Windows.Forms.Label agentSales;
        private System.Windows.Forms.Label agentPhoneNumber;
        private System.Windows.Forms.Label agentPriority;
        private System.Windows.Forms.Label agentDiscount;
        private System.Windows.Forms.Button productSaleBtn;
    }
}
