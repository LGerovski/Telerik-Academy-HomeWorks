namespace e_library
{
    partial class ClientForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BookRent = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Rentals = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientDetails = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordChange = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EmailChange = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.BookRent.SuspendLayout();
            this.Rentals.SuspendLayout();
            this.ClientDetails.SuspendLayout();
            this.PasswordChange.SuspendLayout();
            this.EmailChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BookRent);
            this.tabControl1.Controls.Add(this.Rentals);
            this.tabControl1.Controls.Add(this.ClientDetails);
            this.tabControl1.Controls.Add(this.PasswordChange);
            this.tabControl1.Controls.Add(this.EmailChange);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // BookRent
            // 
            this.BookRent.Controls.Add(this.button1);
            this.BookRent.Controls.Add(this.listBox1);
            this.BookRent.Controls.Add(this.label4);
            this.BookRent.Controls.Add(this.comboBox4);
            this.BookRent.Controls.Add(this.label3);
            this.BookRent.Controls.Add(this.comboBox3);
            this.BookRent.Controls.Add(this.label2);
            this.BookRent.Controls.Add(this.label1);
            this.BookRent.Controls.Add(this.comboBox2);
            this.BookRent.Location = new System.Drawing.Point(4, 30);
            this.BookRent.Name = "BookRent";
            this.BookRent.Padding = new System.Windows.Forms.Padding(3);
            this.BookRent.Size = new System.Drawing.Size(589, 290);
            this.BookRent.TabIndex = 0;
            this.BookRent.Text = "Rent a book";
            this.BookRent.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "Rent this book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(43, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 235);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filter by language";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(272, 150);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(296, 29);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter by Author";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(273, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(295, 29);
            this.comboBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter by category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(273, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(295, 29);
            this.comboBox2.TabIndex = 1;
            // 
            // Rentals
            // 
            this.Rentals.Controls.Add(this.button2);
            this.Rentals.Controls.Add(this.listBox2);
            this.Rentals.Controls.Add(this.label5);
            this.Rentals.Location = new System.Drawing.Point(4, 30);
            this.Rentals.Name = "Rentals";
            this.Rentals.Padding = new System.Windows.Forms.Padding(3);
            this.Rentals.Size = new System.Drawing.Size(589, 290);
            this.Rentals.TabIndex = 1;
            this.Rentals.Text = "My rentals";
            this.Rentals.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Return item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(36, 54);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(267, 214);
            this.listBox2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rented items";
            // 
            // ClientDetails
            // 
            this.ClientDetails.Controls.Add(this.button3);
            this.ClientDetails.Controls.Add(this.textBox4);
            this.ClientDetails.Controls.Add(this.label9);
            this.ClientDetails.Controls.Add(this.textBox3);
            this.ClientDetails.Controls.Add(this.label8);
            this.ClientDetails.Controls.Add(this.textBox2);
            this.ClientDetails.Controls.Add(this.label7);
            this.ClientDetails.Controls.Add(this.textBox1);
            this.ClientDetails.Controls.Add(this.label6);
            this.ClientDetails.Location = new System.Drawing.Point(4, 30);
            this.ClientDetails.Name = "ClientDetails";
            this.ClientDetails.Size = new System.Drawing.Size(589, 290);
            this.ClientDetails.TabIndex = 2;
            this.ClientDetails.Text = "My details";
            this.ClientDetails.UseVisualStyleBackColor = true;
            this.ClientDetails.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(419, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 67);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(23, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 27);
            this.textBox4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Telephone number";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(23, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 27);
            this.textBox3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(23, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "First name";
            // 
            // PasswordChange
            // 
            this.PasswordChange.Controls.Add(this.label14);
            this.PasswordChange.Controls.Add(this.label13);
            this.PasswordChange.Controls.Add(this.button4);
            this.PasswordChange.Controls.Add(this.textBox7);
            this.PasswordChange.Controls.Add(this.label12);
            this.PasswordChange.Controls.Add(this.textBox6);
            this.PasswordChange.Controls.Add(this.label11);
            this.PasswordChange.Controls.Add(this.textBox5);
            this.PasswordChange.Controls.Add(this.label10);
            this.PasswordChange.Location = new System.Drawing.Point(4, 30);
            this.PasswordChange.Name = "PasswordChange";
            this.PasswordChange.Size = new System.Drawing.Size(589, 290);
            this.PasswordChange.TabIndex = 3;
            this.PasswordChange.Text = "Change password";
            this.PasswordChange.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(296, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 21);
            this.label14.TabIndex = 8;
            this.label14.Text = "Invalid password";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(291, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 21);
            this.label13.TabIndex = 7;
            this.label13.Text = "Password does not match";
            this.label13.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Change password";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(40, 175);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(245, 27);
            this.textBox7.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Repeat new password";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(40, 116);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(245, 27);
            this.textBox6.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Enter new password";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(40, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(245, 27);
            this.textBox5.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Enter old password";
            // 
            // EmailChange
            // 
            this.EmailChange.Controls.Add(this.button5);
            this.EmailChange.Controls.Add(this.label19);
            this.EmailChange.Controls.Add(this.label18);
            this.EmailChange.Controls.Add(this.textBox10);
            this.EmailChange.Controls.Add(this.label17);
            this.EmailChange.Controls.Add(this.textBox9);
            this.EmailChange.Controls.Add(this.label16);
            this.EmailChange.Controls.Add(this.textBox8);
            this.EmailChange.Controls.Add(this.label15);
            this.EmailChange.Location = new System.Drawing.Point(4, 30);
            this.EmailChange.Name = "EmailChange";
            this.EmailChange.Size = new System.Drawing.Size(589, 290);
            this.EmailChange.TabIndex = 4;
            this.EmailChange.Text = "Change email";
            this.EmailChange.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(324, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 39);
            this.button5.TabIndex = 10;
            this.button5.Text = "Update email";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(291, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 21);
            this.label19.TabIndex = 9;
            this.label19.Text = "Invalid email";
            this.label19.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(291, 181);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 21);
            this.label18.TabIndex = 9;
            this.label18.Text = "Email does not match";
            this.label18.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(44, 178);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(241, 27);
            this.textBox10.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 21);
            this.label17.TabIndex = 4;
            this.label17.Text = "Repeat new email";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(44, 119);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(241, 27);
            this.textBox9.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Enter new email";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(44, 60);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(241, 27);
            this.textBox8.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Enter your email";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Edit details";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 348);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.tabControl1.ResumeLayout(false);
            this.BookRent.ResumeLayout(false);
            this.BookRent.PerformLayout();
            this.Rentals.ResumeLayout(false);
            this.Rentals.PerformLayout();
            this.ClientDetails.ResumeLayout(false);
            this.ClientDetails.PerformLayout();
            this.PasswordChange.ResumeLayout(false);
            this.PasswordChange.PerformLayout();
            this.EmailChange.ResumeLayout(false);
            this.EmailChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BookRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage Rentals;
        private System.Windows.Forms.TabPage ClientDetails;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage PasswordChange;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage EmailChange;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label15;

    }
}