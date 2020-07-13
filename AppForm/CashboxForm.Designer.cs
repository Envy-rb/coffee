namespace kolyaKurs.AppForm
{
    partial class CashboxForm
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
            this.CashInputBox = new System.Windows.Forms.TextBox();
            this.CoffeePriceBox = new System.Windows.Forms.TextBox();
            this.CashBackBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CashInputBox
            // 
            this.CashInputBox.Location = new System.Drawing.Point(12, 38);
            this.CashInputBox.Name = "CashInputBox";
            this.CashInputBox.Size = new System.Drawing.Size(100, 20);
            this.CashInputBox.TabIndex = 0;
            this.CashInputBox.TextChanged += new System.EventHandler(this.CashInputBox_TextChanged);
            // 
            // CoffeePriceBox
            // 
            this.CoffeePriceBox.Location = new System.Drawing.Point(12, 12);
            this.CoffeePriceBox.Name = "CoffeePriceBox";
            this.CoffeePriceBox.ReadOnly = true;
            this.CoffeePriceBox.Size = new System.Drawing.Size(100, 20);
            this.CoffeePriceBox.TabIndex = 1;
            // 
            // CashBackBox
            // 
            this.CashBackBox.Location = new System.Drawing.Point(12, 64);
            this.CashBackBox.Name = "CashBackBox";
            this.CashBackBox.ReadOnly = true;
            this.CashBackBox.Size = new System.Drawing.Size(100, 20);
            this.CashBackBox.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(25, 170);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Внесено";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сдача";
            // 
            // CashboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CashBackBox);
            this.Controls.Add(this.CoffeePriceBox);
            this.Controls.Add(this.CashInputBox);
            this.Name = "CashboxForm";
            this.Text = "CashboxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CashInputBox;
        private System.Windows.Forms.TextBox CoffeePriceBox;
        private System.Windows.Forms.TextBox CashBackBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}