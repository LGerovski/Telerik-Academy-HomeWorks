namespace e_library
{
    partial class LoginMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.NewClient = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ForgottenPassword = new System.Windows.Forms.LinkLabel();
            this.HelpMenu = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(124, 34);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(257, 27);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Enter user name";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(124, 75);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(257, 27);
            this.Password.TabIndex = 3;
            this.Password.Text = "Enter password";
            this.Password.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(10, 133);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(175, 42);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NewClient
            // 
            this.NewClient.AutoSize = true;
            this.NewClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewClient.Location = new System.Drawing.Point(190, 209);
            this.NewClient.Name = "NewClient";
            this.NewClient.Size = new System.Drawing.Size(191, 21);
            this.NewClient.TabIndex = 5;
            this.NewClient.TabStop = true;
            this.NewClient.Text = "New clients registration";
            this.NewClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelButton1);
            this.groupBox1.Controls.Add(this.ForgottenPassword);
            this.groupBox1.Controls.Add(this.NewClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LoginButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ForgottenPassword
            // 
            this.ForgottenPassword.AutoSize = true;
            this.ForgottenPassword.Location = new System.Drawing.Point(6, 209);
            this.ForgottenPassword.Name = "ForgottenPassword";
            this.ForgottenPassword.Size = new System.Drawing.Size(166, 21);
            this.ForgottenPassword.TabIndex = 6;
            this.ForgottenPassword.TabStop = true;
            this.ForgottenPassword.Text = "Forgotten password";
            this.ForgottenPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // HelpMenu
            // 
            this.HelpMenu.Location = new System.Drawing.Point(361, 12);
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(75, 23);
            this.HelpMenu.TabIndex = 7;
            this.HelpMenu.Text = "Help - F1";
            this.HelpMenu.UseVisualStyleBackColor = true;
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(236, 133);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(145, 42);
            this.CancelButton1.TabIndex = 7;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 348);
            this.Controls.Add(this.HelpMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginMenu";
            this.Text = "Login menu";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel NewClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button HelpMenu;
        private System.Windows.Forms.LinkLabel ForgottenPassword;
        private System.Windows.Forms.Button CancelButton1;
    }
}