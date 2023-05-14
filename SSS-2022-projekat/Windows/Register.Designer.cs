using System.Data.SqlClient;

namespace SSS_2022_projekat.Windows
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        static String CONNECTION_STRING = @"Data Source=";

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlatnaKartica = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxPrimaryLanguage = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxForNumber = new System.Windows.Forms.TextBox();
            this.checkedListBoxJezici = new System.Windows.Forms.CheckedListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxProfession = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonCertificate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 724);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 243);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wellcome!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SSS_2022_projekat.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(135, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Space Pancakes Fitness";
            // 
            // textBoxPlatnaKartica
            // 
            this.textBoxPlatnaKartica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxPlatnaKartica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlatnaKartica.ForeColor = System.Drawing.Color.White;
            this.textBoxPlatnaKartica.Location = new System.Drawing.Point(363, 474);
            this.textBoxPlatnaKartica.Name = "textBoxPlatnaKartica";
            this.textBoxPlatnaKartica.Size = new System.Drawing.Size(245, 16);
            this.textBoxPlatnaKartica.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(365, 442);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(95, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Card number";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(363, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(245, 16);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(363, 107);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(245, 16);
            this.textBoxEmail.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel2.Location = new System.Drawing.Point(363, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 5);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel3.Location = new System.Drawing.Point(364, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 5);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(365, 15);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(364, 80);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.buttonRegister.Location = new System.Drawing.Point(361, 658);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(120, 33);
            this.buttonRegister.TabIndex = 17;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.register_click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.buttonLogIn.Location = new System.Drawing.Point(487, 658);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(120, 33);
            this.buttonLogIn.TabIndex = 18;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.login_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(676, 15);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.ForeColor = System.Drawing.Color.White;
            this.textBoxLastName.Location = new System.Drawing.Point(671, 40);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(245, 16);
            this.textBoxLastName.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel4.Location = new System.Drawing.Point(671, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 5);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(671, 80);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(671, 107);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(245, 16);
            this.textBoxPassword.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel5.Location = new System.Drawing.Point(671, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 5);
            this.panel5.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(365, 149);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Country";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCountry.ForeColor = System.Drawing.Color.White;
            this.textBoxCountry.Location = new System.Drawing.Point(363, 171);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(245, 16);
            this.textBoxCountry.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel6.Location = new System.Drawing.Point(364, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 5);
            this.panel6.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(671, 149);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "City";
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCity.ForeColor = System.Drawing.Color.White;
            this.textBoxCity.Location = new System.Drawing.Point(671, 171);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(245, 16);
            this.textBoxCity.TabIndex = 6;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel7.Location = new System.Drawing.Point(671, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 5);
            this.panel7.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(363, 272);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(668, 272);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Primary language";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.comboBoxGender.ForeColor = System.Drawing.Color.White;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "MUSKI",
            "ZENSKI"});
            this.comboBoxGender.Location = new System.Drawing.Point(363, 303);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(245, 23);
            this.comboBoxGender.TabIndex = 9;
            // 
            // comboBoxPrimaryLanguage
            // 
            this.comboBoxPrimaryLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.comboBoxPrimaryLanguage.ForeColor = System.Drawing.Color.White;
            this.comboBoxPrimaryLanguage.FormattingEnabled = true;
            this.comboBoxPrimaryLanguage.Items.AddRange(new object[] {
            "srpski",
            "engleski",
            "ruski",
            "nemacki"});
            this.comboBoxPrimaryLanguage.Location = new System.Drawing.Point(668, 303);
            this.comboBoxPrimaryLanguage.Name = "comboBoxPrimaryLanguage";
            this.comboBoxPrimaryLanguage.Size = new System.Drawing.Size(245, 23);
            this.comboBoxPrimaryLanguage.TabIndex = 10;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel10.Location = new System.Drawing.Point(363, 256);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(245, 5);
            this.panel10.TabIndex = 25;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStreet.ForeColor = System.Drawing.Color.White;
            this.textBoxStreet.Location = new System.Drawing.Point(363, 236);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(245, 16);
            this.textBoxStreet.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(365, 214);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Street";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel11.Location = new System.Drawing.Point(671, 256);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(245, 5);
            this.panel11.TabIndex = 28;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber.ForeColor = System.Drawing.Color.White;
            this.textBoxNumber.Location = new System.Drawing.Point(671, 236);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(245, 16);
            this.textBoxNumber.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(671, 214);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Number";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel12.Location = new System.Drawing.Point(671, 493);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(245, 5);
            this.panel12.TabIndex = 31;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(671, 471);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(245, 16);
            this.textBoxPhoneNumber.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(668, 442);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Phone number";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.comboBoxRole.ForeColor = System.Drawing.Color.White;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "TRENER",
            "KLIJENT"});
            this.comboBoxRole.Location = new System.Drawing.Point(363, 383);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(245, 23);
            this.comboBoxRole.TabIndex = 11;
            this.comboBoxRole.SelectionChangeCommitted += new System.EventHandler(this.role_change);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(363, 340);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Role";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(668, 340);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(118, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Other languages";
            // 
            // textBoxForNumber
            // 
            this.textBoxForNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxForNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForNumber.Location = new System.Drawing.Point(678, 541);
            this.textBoxForNumber.Name = "textBoxForNumber";
            this.textBoxForNumber.Size = new System.Drawing.Size(245, 16);
            this.textBoxForNumber.TabIndex = 38;
            // 
            // checkedListBoxJezici
            // 
            this.checkedListBoxJezici.FormattingEnabled = true;
            this.checkedListBoxJezici.Items.AddRange(new object[] {
            "srpski",
            "engleski",
            "ruski",
            "nemacki",
            "italijanski",
            "spanski",
            "kineski"});
            this.checkedListBoxJezici.Location = new System.Drawing.Point(668, 383);
            this.checkedListBoxJezici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxJezici.Name = "checkedListBoxJezici";
            this.checkedListBoxJezici.Size = new System.Drawing.Size(248, 40);
            this.checkedListBoxJezici.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel8.Location = new System.Drawing.Point(362, 496);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(245, 5);
            this.panel8.TabIndex = 41;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel9.Location = new System.Drawing.Point(362, 581);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(245, 5);
            this.panel9.TabIndex = 44;
            // 
            // textBoxProfession
            // 
            this.textBoxProfession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxProfession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfession.ForeColor = System.Drawing.Color.White;
            this.textBoxProfession.Location = new System.Drawing.Point(363, 559);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.Size = new System.Drawing.Size(245, 16);
            this.textBoxProfession.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(365, 527);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(77, 20);
            this.label17.TabIndex = 43;
            this.label17.Text = "Profession";
            // 
            // buttonCertificate
            // 
            this.buttonCertificate.Location = new System.Drawing.Point(668, 558);
            this.buttonCertificate.Name = "buttonCertificate";
            this.buttonCertificate.Size = new System.Drawing.Size(248, 28);
            this.buttonCertificate.TabIndex = 16;
            this.buttonCertificate.Text = "Upload certificate";
            this.buttonCertificate.UseVisualStyleBackColor = true;
            this.buttonCertificate.Click += new System.EventHandler(this.click_upload);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(970, 717);
            this.Controls.Add(this.buttonCertificate);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.textBoxProfession);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.checkedListBoxJezici);
            this.Controls.Add(this.textBoxPlatnaKartica);
            this.Controls.Add(this.textBoxForNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxPrimaryLanguage);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeMyControl()
        {
            textBoxEmail.Text = "";
            textBoxEmail.PasswordChar = '*';
            textBoxEmail.MaxLength = 12;
        }
        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Button buttonRegister;
        private Button buttonLogIn;
        private Label label5;
        private TextBox textBoxLastName;
        private Panel panel4;
        private Label label6;
        private TextBox textBoxPassword;
        private Panel panel5;
        private Label label7;
        private TextBox textBoxCountry;
        private Panel panel6;
        private Label label8;
        private TextBox textBoxCity;
        private Panel panel7;
        private Label label9;
        private Label label10;
        private ComboBox comboBoxGender;
        private ComboBox comboBoxPrimaryLanguage;
        private Panel panel10;
        private TextBox textBoxStreet;
        private Label label11;
        private Panel panel11;
        private TextBox textBoxNumber;
        private Label label12;
        private Panel panel12;
        private TextBox textBoxPhoneNumber;
        private Label label13;
        private ComboBox comboBoxRole;
        private Label label14;
        private Label label15;
        private TextBox textBoxForNumber;
        private TextBox textBoxPlatnaKartica;
        private Label label16;
        private CheckedListBox checkedListBoxJezici;
        private Panel panel8;
        private Panel panel9;
        public TextBox textBoxProfession;
        private Label label17;
        public Button buttonCertificate;
    }
}