namespace ProjectXtestpilot
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            this.Exit_Buttom = new System.Windows.Forms.Button();
            this.Profile_Information_Label = new System.Windows.Forms.Label();
            this.Profile_DataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hello_Kitchen_Label = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Buttom
            // 
            this.Exit_Buttom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit_Buttom.Location = new System.Drawing.Point(734, 355);
            this.Exit_Buttom.Name = "Exit_Buttom";
            this.Exit_Buttom.Size = new System.Drawing.Size(115, 31);
            this.Exit_Buttom.TabIndex = 60;
            this.Exit_Buttom.Text = "Exit";
            this.Exit_Buttom.UseVisualStyleBackColor = true;
            this.Exit_Buttom.Click += new System.EventHandler(this.Exit_Buttom_Click);
            // 
            // Profile_Information_Label
            // 
            this.Profile_Information_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Profile_Information_Label.AutoSize = true;
            this.Profile_Information_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Profile_Information_Label.Location = new System.Drawing.Point(293, 9);
            this.Profile_Information_Label.Name = "Profile_Information_Label";
            this.Profile_Information_Label.Size = new System.Drawing.Size(293, 39);
            this.Profile_Information_Label.TabIndex = 41;
            this.Profile_Information_Label.Text = "Profile Information";
            // 
            // Profile_DataGridView
            // 
            this.Profile_DataGridView.AllowUserToOrderColumns = true;
            this.Profile_DataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Profile_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Profile_DataGridView.Location = new System.Drawing.Point(12, 90);
            this.Profile_DataGridView.Name = "Profile_DataGridView";
            this.Profile_DataGridView.Size = new System.Drawing.Size(837, 235);
            this.Profile_DataGridView.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(855, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // Hello_Kitchen_Label
            // 
            this.Hello_Kitchen_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hello_Kitchen_Label.AutoSize = true;
            this.Hello_Kitchen_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello_Kitchen_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Hello_Kitchen_Label.Location = new System.Drawing.Point(172, 9);
            this.Hello_Kitchen_Label.Name = "Hello_Kitchen_Label";
            this.Hello_Kitchen_Label.Size = new System.Drawing.Size(115, 20);
            this.Hello_Kitchen_Label.TabIndex = 65;
            this.Hello_Kitchen_Label.Text = "Hello Kitchen";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(861, 412);
            this.shapeContainer1.TabIndex = 66;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.Location = new System.Drawing.Point(5, 3);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(852, 52);
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 412);
            this.Controls.Add(this.Hello_Kitchen_Label);
            this.Controls.Add(this.Profile_DataGridView);
            this.Controls.Add(this.Exit_Buttom);
            this.Controls.Add(this.Profile_Information_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Profile_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_Buttom;
        private System.Windows.Forms.Label Profile_Information_Label;
        private System.Windows.Forms.DataGridView Profile_DataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Hello_Kitchen_Label;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}