namespace SSS_2022_projekat.Windows
{
    partial class AddEditZarada
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
            label1 = new Label();
            label2 = new Label();
            txtBrojKartice = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(199, 198, 205);
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 30;
            label1.Text = "Datum";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(199, 198, 205);
            label2.Location = new Point(34, 68);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 31;
            label2.Text = "Zarada";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBrojKartice
            // 
            txtBrojKartice.Location = new Point(127, 31);
            txtBrojKartice.Name = "txtBrojKartice";
            txtBrojKartice.Size = new Size(216, 23);
            txtBrojKartice.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 33;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(94, 87, 255);
            button1.Location = new Point(32, 165);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 33);
            button1.TabIndex = 34;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(94, 87, 255);
            button2.Location = new Point(32, 202);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(144, 33);
            button2.TabIndex = 35;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(229, 99, 135);
            button6.Location = new Point(32, 239);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(144, 33);
            button6.TabIndex = 36;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(199, 198, 205);
            label5.Location = new Point(34, 107);
            label5.Name = "label5";
            label5.Size = new Size(73, 24);
            label5.TabIndex = 37;
            label5.Text = "Trener";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 23);
            comboBox1.TabIndex = 38;
            // 
            // AddEditZarada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 47, 68);
            ClientSize = new Size(404, 309);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(txtBrojKartice);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEditZarada";
            Text = "AddEditZarada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox txtBrojKartice;
        public TextBox textBox1;
        public Button button1;
        public Button button2;
        private Button button6;
        private Label label5;
        private ComboBox comboBox1;
    }
}