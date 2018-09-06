namespace ProjectXtestpilot
{
    partial class Food_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food_Menu));
            this.Food_Menu_Label = new System.Windows.Forms.Label();
            this.Food_Menu_DataGridView = new System.Windows.Forms.DataGridView();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Item_Name_Label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Food_ID_Label = new System.Windows.Forms.Label();
            this.Get_Item_Name_Box = new System.Windows.Forms.TextBox();
            this.Get_Price_Box = new System.Windows.Forms.TextBox();
            this.Get_Food_ID_Box = new System.Windows.Forms.TextBox();
            this.Show_Food_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Hello_Kitchen_Label = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Food_Menu_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Food_Menu_Label
            // 
            this.Food_Menu_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Food_Menu_Label.AutoSize = true;
            this.Food_Menu_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Food_Menu_Label.Location = new System.Drawing.Point(338, 9);
            this.Food_Menu_Label.Name = "Food_Menu_Label";
            this.Food_Menu_Label.Size = new System.Drawing.Size(189, 39);
            this.Food_Menu_Label.TabIndex = 0;
            this.Food_Menu_Label.Text = "Food Menu";
            // 
            // Food_Menu_DataGridView
            // 
            this.Food_Menu_DataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Food_Menu_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Food_Menu_DataGridView.Location = new System.Drawing.Point(123, 82);
            this.Food_Menu_DataGridView.Name = "Food_Menu_DataGridView";
            this.Food_Menu_DataGridView.Size = new System.Drawing.Size(265, 249);
            this.Food_Menu_DataGridView.TabIndex = 1;
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Add_Button.Location = new System.Drawing.Point(499, 269);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(104, 28);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Item_Name_Label
            // 
            this.Item_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Item_Name_Label.AutoSize = true;
            this.Item_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Item_Name_Label.Location = new System.Drawing.Point(452, 134);
            this.Item_Name_Label.Name = "Item_Name_Label";
            this.Item_Name_Label.Size = new System.Drawing.Size(75, 17);
            this.Item_Name_Label.TabIndex = 3;
            this.Item_Name_Label.Text = "Item Name";
            // 
            // Price_Label
            // 
            this.Price_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Price_Label.AutoSize = true;
            this.Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Price_Label.Location = new System.Drawing.Point(487, 169);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(40, 17);
            this.Price_Label.TabIndex = 4;
            this.Price_Label.Text = "Price";
            // 
            // Food_ID_Label
            // 
            this.Food_ID_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Food_ID_Label.AutoSize = true;
            this.Food_ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Food_ID_Label.Location = new System.Drawing.Point(470, 99);
            this.Food_ID_Label.Name = "Food_ID_Label";
            this.Food_ID_Label.Size = new System.Drawing.Size(57, 17);
            this.Food_ID_Label.TabIndex = 5;
            this.Food_ID_Label.Text = "Food ID";
            // 
            // Get_Item_Name_Box
            // 
            this.Get_Item_Name_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Get_Item_Name_Box.Location = new System.Drawing.Point(533, 134);
            this.Get_Item_Name_Box.Name = "Get_Item_Name_Box";
            this.Get_Item_Name_Box.Size = new System.Drawing.Size(193, 20);
            this.Get_Item_Name_Box.TabIndex = 6;
            // 
            // Get_Price_Box
            // 
            this.Get_Price_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Get_Price_Box.Location = new System.Drawing.Point(533, 166);
            this.Get_Price_Box.Name = "Get_Price_Box";
            this.Get_Price_Box.Size = new System.Drawing.Size(193, 20);
            this.Get_Price_Box.TabIndex = 7;
            // 
            // Get_Food_ID_Box
            // 
            this.Get_Food_ID_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Get_Food_ID_Box.Location = new System.Drawing.Point(533, 99);
            this.Get_Food_ID_Box.Name = "Get_Food_ID_Box";
            this.Get_Food_ID_Box.Size = new System.Drawing.Size(193, 20);
            this.Get_Food_ID_Box.TabIndex = 8;
            // 
            // Show_Food_Button
            // 
            this.Show_Food_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Show_Food_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Show_Food_Button.Location = new System.Drawing.Point(558, 303);
            this.Show_Food_Button.Name = "Show_Food_Button";
            this.Show_Food_Button.Size = new System.Drawing.Size(104, 28);
            this.Show_Food_Button.TabIndex = 9;
            this.Show_Food_Button.Text = "Show Food";
            this.Show_Food_Button.UseVisualStyleBackColor = true;
            this.Show_Food_Button.Click += new System.EventHandler(this.Show_Food_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Remove_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Remove_Button.Location = new System.Drawing.Point(619, 269);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(104, 28);
            this.Remove_Button.TabIndex = 10;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Hello_Kitchen_Label
            // 
            this.Hello_Kitchen_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hello_Kitchen_Label.AutoSize = true;
            this.Hello_Kitchen_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello_Kitchen_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Hello_Kitchen_Label.Location = new System.Drawing.Point(217, 9);
            this.Hello_Kitchen_Label.Name = "Hello_Kitchen_Label";
            this.Hello_Kitchen_Label.Size = new System.Drawing.Size(115, 20);
            this.Hello_Kitchen_Label.TabIndex = 78;
            this.Hello_Kitchen_Label.Text = "Hello Kitchen";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.Location = new System.Drawing.Point(2, 1);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(861, 51);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(865, 407);
            this.shapeContainer1.TabIndex = 79;
            this.shapeContainer1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(862, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // Food_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 407);
            this.Controls.Add(this.Hello_Kitchen_Label);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Show_Food_Button);
            this.Controls.Add(this.Get_Food_ID_Box);
            this.Controls.Add(this.Get_Price_Box);
            this.Controls.Add(this.Get_Item_Name_Box);
            this.Controls.Add(this.Food_ID_Label);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.Item_Name_Label);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Food_Menu_DataGridView);
            this.Controls.Add(this.Food_Menu_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Food_Menu";
            this.Load += new System.EventHandler(this.Food_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Food_Menu_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Food_Menu_Label;
        private System.Windows.Forms.DataGridView Food_Menu_DataGridView;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label Item_Name_Label;
        private System.Windows.Forms.Label Price_Label;
        private System.Windows.Forms.Label Food_ID_Label;
        private System.Windows.Forms.TextBox Get_Item_Name_Box;
        private System.Windows.Forms.TextBox Get_Price_Box;
        private System.Windows.Forms.TextBox Get_Food_ID_Box;
        private System.Windows.Forms.Button Show_Food_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Label Hello_Kitchen_Label;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}