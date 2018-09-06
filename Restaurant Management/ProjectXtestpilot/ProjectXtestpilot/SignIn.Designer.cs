namespace ProjectXtestpilot
{
    partial class SignIn
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
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Get_Username_Box = new System.Windows.Forms.TextBox();
            this.Get_Password_Box = new System.Windows.Forms.TextBox();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Signin_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Account_Line_Label = new System.Windows.Forms.Label();
            this.Show_Password_label = new System.Windows.Forms.Label();
            this.Get_Combo_Box = new System.Windows.Forms.ComboBox();
            this.UserType_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Username_Label.Location = new System.Drawing.Point(68, 99);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(89, 20);
            this.Username_Label.TabIndex = 0;
            this.Username_Label.Text = "User Name";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Password_Label.Location = new System.Drawing.Point(68, 137);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(78, 20);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password";
            // 
            // Get_Username_Box
            // 
            this.Get_Username_Box.Location = new System.Drawing.Point(163, 101);
            this.Get_Username_Box.Name = "Get_Username_Box";
            this.Get_Username_Box.Size = new System.Drawing.Size(161, 20);
            this.Get_Username_Box.TabIndex = 2;
            this.Get_Username_Box.TextChanged += new System.EventHandler(this.Get_Username_Box_TextChanged);
            // 
            // Get_Password_Box
            // 
            this.Get_Password_Box.Location = new System.Drawing.Point(163, 137);
            this.Get_Password_Box.Name = "Get_Password_Box";
            this.Get_Password_Box.Size = new System.Drawing.Size(161, 20);
            this.Get_Password_Box.TabIndex = 3;
            this.Get_Password_Box.TextChanged += new System.EventHandler(this.Get_Password_Box_TextChanged);
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Login_Label.Location = new System.Drawing.Point(137, 18);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(124, 39);
            this.Login_Label.TabIndex = 4;
            this.Login_Label.Text = "Sign In";
            // 
            // Signin_Button
            // 
            this.Signin_Button.Location = new System.Drawing.Point(72, 228);
            this.Signin_Button.Name = "Signin_Button";
            this.Signin_Button.Size = new System.Drawing.Size(75, 23);
            this.Signin_Button.TabIndex = 5;
            this.Signin_Button.Text = "Sign in";
            this.Signin_Button.UseVisualStyleBackColor = true;
            this.Signin_Button.Click += new System.EventHandler(this.Signin_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(249, 228);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 6;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Account_Line_Label
            // 
            this.Account_Line_Label.AutoSize = true;
            this.Account_Line_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.Account_Line_Label.Location = new System.Drawing.Point(89, 286);
            this.Account_Line_Label.Name = "Account_Line_Label";
            this.Account_Line_Label.Size = new System.Drawing.Size(216, 13);
            this.Account_Line_Label.TabIndex = 7;
            this.Account_Line_Label.Text = "Don\'t have an account? Create an account.";
            this.Account_Line_Label.Click += new System.EventHandler(this.Account_Line_Label_Click);
            // 
            // Show_Password_label
            // 
            this.Show_Password_label.AutoSize = true;
            this.Show_Password_label.Location = new System.Drawing.Point(330, 142);
            this.Show_Password_label.Name = "Show_Password_label";
            this.Show_Password_label.Size = new System.Drawing.Size(59, 13);
            this.Show_Password_label.TabIndex = 8;
            this.Show_Password_label.Text = "Show/hide";
            this.Show_Password_label.Click += new System.EventHandler(this.Show_Password_label_Click);
            this.Show_Password_label.DoubleClick += new System.EventHandler(this.Show_Password_label_DoubleClick);
            // 
            // Get_Combo_Box
            // 
            this.Get_Combo_Box.FormattingEnabled = true;
            this.Get_Combo_Box.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier"});
            this.Get_Combo_Box.Location = new System.Drawing.Point(203, 179);
            this.Get_Combo_Box.Name = "Get_Combo_Box";
            this.Get_Combo_Box.Size = new System.Drawing.Size(121, 21);
            this.Get_Combo_Box.TabIndex = 9;
            // 
            // UserType_Label
            // 
            this.UserType_Label.AutoSize = true;
            this.UserType_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserType_Label.Location = new System.Drawing.Point(116, 180);
            this.UserType_Label.Name = "UserType_Label";
            this.UserType_Label.Size = new System.Drawing.Size(81, 20);
            this.UserType_Label.TabIndex = 10;
            this.UserType_Label.Text = "User Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 350);
            this.Controls.Add(this.UserType_Label);
            this.Controls.Add(this.Get_Combo_Box);
            this.Controls.Add(this.Show_Password_label);
            this.Controls.Add(this.Account_Line_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Signin_Button);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.Get_Password_Box);
            this.Controls.Add(this.Get_Username_Box);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Button Signin_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Account_Line_Label;
        private System.Windows.Forms.Label Show_Password_label;
        private System.Windows.Forms.ComboBox Get_Combo_Box;
        private System.Windows.Forms.Label UserType_Label;
        public System.Windows.Forms.TextBox Get_Username_Box;
        public System.Windows.Forms.TextBox Get_Password_Box;
    }
}

