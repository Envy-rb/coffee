namespace kolyaKurs
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CoffeeList = new System.Windows.Forms.ListBox();
            this.CoffeeDescription = new System.Windows.Forms.Label();
            this.MakeCoffeeButton = new System.Windows.Forms.Button();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.RemoveCoffeeButton = new System.Windows.Forms.Button();
            this.IngredientList = new System.Windows.Forms.ListBox();
            this.RemoveIngredientButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DraftList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CoffeePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CoffeeList
            // 
            this.CoffeeList.FormattingEnabled = true;
            this.CoffeeList.Location = new System.Drawing.Point(339, 13);
            this.CoffeeList.Name = "CoffeeList";
            this.CoffeeList.Size = new System.Drawing.Size(120, 238);
            this.CoffeeList.TabIndex = 1;
            this.CoffeeList.SelectedIndexChanged += new System.EventHandler(this.CoffeeList_SelectedIndexChanged);
            // 
            // CoffeeDescription
            // 
            this.CoffeeDescription.AutoEllipsis = true;
            this.CoffeeDescription.AutoSize = true;
            this.CoffeeDescription.BackColor = System.Drawing.Color.Transparent;
            this.CoffeeDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoffeeDescription.Location = new System.Drawing.Point(480, 13);
            this.CoffeeDescription.MaximumSize = new System.Drawing.Size(200, 0);
            this.CoffeeDescription.Name = "CoffeeDescription";
            this.CoffeeDescription.Size = new System.Drawing.Size(0, 13);
            this.CoffeeDescription.TabIndex = 2;
            // 
            // MakeCoffeeButton
            // 
            this.MakeCoffeeButton.Location = new System.Drawing.Point(12, 257);
            this.MakeCoffeeButton.Name = "MakeCoffeeButton";
            this.MakeCoffeeButton.Size = new System.Drawing.Size(100, 113);
            this.MakeCoffeeButton.TabIndex = 3;
            this.MakeCoffeeButton.Text = "Сделать кофе";
            this.MakeCoffeeButton.UseVisualStyleBackColor = true;
            this.MakeCoffeeButton.Click += new System.EventHandler(this.MakeCoffeeButton_Click);
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(118, 257);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(100, 113);
            this.AddIngredientButton.TabIndex = 3;
            this.AddIngredientButton.Text = "Добавить ингридиент";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // RemoveCoffeeButton
            // 
            this.RemoveCoffeeButton.Location = new System.Drawing.Point(339, 257);
            this.RemoveCoffeeButton.Name = "RemoveCoffeeButton";
            this.RemoveCoffeeButton.Size = new System.Drawing.Size(120, 113);
            this.RemoveCoffeeButton.TabIndex = 3;
            this.RemoveCoffeeButton.Text = "Удалить выбранный кофе";
            this.RemoveCoffeeButton.UseVisualStyleBackColor = true;
            this.RemoveCoffeeButton.Click += new System.EventHandler(this.RemoveCoffeeButton_Click);
            // 
            // IngredientList
            // 
            this.IngredientList.FormattingEnabled = true;
            this.IngredientList.Location = new System.Drawing.Point(224, 257);
            this.IngredientList.Name = "IngredientList";
            this.IngredientList.Size = new System.Drawing.Size(109, 56);
            this.IngredientList.TabIndex = 1;
            this.IngredientList.SelectedIndexChanged += new System.EventHandler(this.CoffeeList_SelectedIndexChanged);
            // 
            // RemoveIngredientButton
            // 
            this.RemoveIngredientButton.Location = new System.Drawing.Point(224, 319);
            this.RemoveIngredientButton.Name = "RemoveIngredientButton";
            this.RemoveIngredientButton.Size = new System.Drawing.Size(109, 51);
            this.RemoveIngredientButton.TabIndex = 3;
            this.RemoveIngredientButton.Text = "Удалить выбранный ингредиент";
            this.RemoveIngredientButton.UseVisualStyleBackColor = true;
            this.RemoveIngredientButton.Click += new System.EventHandler(this.RemoveIngredientButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(466, 257);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(148, 67);
            this.SellButton.TabIndex = 4;
            this.SellButton.Text = "Продать кофе";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // Cash
            // 
            this.Cash.Location = new System.Drawing.Point(620, 324);
            this.Cash.Name = "Cash";
            this.Cash.ReadOnly = true;
            this.Cash.Size = new System.Drawing.Size(59, 20);
            this.Cash.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Состояние кассы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DraftList
            // 
            this.DraftList.Location = new System.Drawing.Point(620, 257);
            this.DraftList.Name = "DraftList";
            this.DraftList.Size = new System.Drawing.Size(59, 67);
            this.DraftList.TabIndex = 4;
            this.DraftList.Text = "Чеки";
            this.DraftList.UseVisualStyleBackColor = true;
            this.DraftList.Click += new System.EventHandler(this.DraftList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::kolyaKurs.Properties.Resources.CatPicture;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(465, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 239);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CoffeePicture
            // 
            this.CoffeePicture.ImageLocation = "Resources\\Pictures\\CoffeePicture.png";
            this.CoffeePicture.Location = new System.Drawing.Point(11, 13);
            this.CoffeePicture.Name = "CoffeePicture";
            this.CoffeePicture.Size = new System.Drawing.Size(322, 238);
            this.CoffeePicture.TabIndex = 0;
            this.CoffeePicture.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(684, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.DraftList);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.AddIngredientButton);
            this.Controls.Add(this.RemoveIngredientButton);
            this.Controls.Add(this.RemoveCoffeeButton);
            this.Controls.Add(this.MakeCoffeeButton);
            this.Controls.Add(this.CoffeeDescription);
            this.Controls.Add(this.IngredientList);
            this.Controls.Add(this.CoffeeList);
            this.Controls.Add(this.CoffeePicture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CoffeePicture;
        private System.Windows.Forms.ListBox CoffeeList;
        private System.Windows.Forms.Label CoffeeDescription;
        private System.Windows.Forms.Button MakeCoffeeButton;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.Button RemoveCoffeeButton;
        private System.Windows.Forms.ListBox IngredientList;
        private System.Windows.Forms.Button RemoveIngredientButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.TextBox Cash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DraftList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

