﻿namespace kolyaKurs.AppForm
{
    partial class CoffeeForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelBox = new System.Windows.Forms.TextBox();
            this.CoffeeBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Ingredients = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ярлык";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кофе";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelBox
            // 
            this.LabelBox.Location = new System.Drawing.Point(58, 6);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Size = new System.Drawing.Size(100, 20);
            this.LabelBox.TabIndex = 1;
            // 
            // CoffeeBox
            // 
            this.CoffeeBox.FormattingEnabled = true;
            this.CoffeeBox.Location = new System.Drawing.Point(58, 37);
            this.CoffeeBox.Name = "CoffeeBox";
            this.CoffeeBox.Size = new System.Drawing.Size(121, 21);
            this.CoffeeBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сварить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ингредиенты";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ingredients
            // 
            this.Ingredients.FormattingEnabled = true;
            this.Ingredients.Location = new System.Drawing.Point(94, 89);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Ingredients.Size = new System.Drawing.Size(120, 95);
            this.Ingredients.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 333);
            this.Controls.Add(this.Ingredients);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CoffeeBox);
            this.Controls.Add(this.LabelBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CoffeeForm";
            this.Text = "CoffeeForm";
            this.Load += new System.EventHandler(this.CoffeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LabelBox;
        private System.Windows.Forms.ComboBox CoffeeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Ingredients;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}