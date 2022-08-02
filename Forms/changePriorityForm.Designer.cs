namespace PopryzhenokPP06
{
    partial class changePriorityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePriorityForm));
            this.PriorityValue = new System.Windows.Forms.NumericUpDown();
            this.changePriorityBtn = new System.Windows.Forms.Button();
            this.PriorityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityValue)).BeginInit();
            this.SuspendLayout();
            // 
            // PriorityValue
            // 
            this.PriorityValue.Location = new System.Drawing.Point(12, 38);
            this.PriorityValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PriorityValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriorityValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriorityValue.Name = "PriorityValue";
            this.PriorityValue.Size = new System.Drawing.Size(140, 23);
            this.PriorityValue.TabIndex = 0;
            this.PriorityValue.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // changePriorityBtn
            // 
            this.changePriorityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePriorityBtn.Location = new System.Drawing.Point(12, 67);
            this.changePriorityBtn.Name = "changePriorityBtn";
            this.changePriorityBtn.Size = new System.Drawing.Size(140, 36);
            this.changePriorityBtn.TabIndex = 1;
            this.changePriorityBtn.Text = "Изменить приоритет";
            this.changePriorityBtn.UseVisualStyleBackColor = true;
            this.changePriorityBtn.Click += new System.EventHandler(this.changePriorityBtn_Click);
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Location = new System.Drawing.Point(12, 13);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(69, 15);
            this.PriorityLabel.TabIndex = 2;
            this.PriorityLabel.Text = "Приоритет:";
            // 
            // changePriorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(165, 115);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.changePriorityBtn);
            this.Controls.Add(this.PriorityValue);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "changePriorityForm";
            this.Text = "Измение приоритета";
            this.Load += new System.EventHandler(this.changePriorityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriorityValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PriorityValue;
        private System.Windows.Forms.Button changePriorityBtn;
        private System.Windows.Forms.Label PriorityLabel;
    }
}