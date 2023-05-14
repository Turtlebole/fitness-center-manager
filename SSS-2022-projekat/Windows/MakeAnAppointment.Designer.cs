namespace SSS_2022_projekat.Windows
{
    partial class MakeAnAppointment
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
            this.comboBoxTrener = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTermin = new System.Windows.Forms.ComboBox();
            this.buttonMakeAnAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTrener
            // 
            this.comboBoxTrener.FormattingEnabled = true;
            this.comboBoxTrener.Location = new System.Drawing.Point(51, 76);
            this.comboBoxTrener.Name = "comboBoxTrener";
            this.comboBoxTrener.Size = new System.Drawing.Size(550, 23);
            this.comboBoxTrener.TabIndex = 0;
            this.comboBoxTrener.SelectionChangeCommitted += new System.EventHandler(this.trener_change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointment";
            // 
            // comboBoxTermin
            // 
            this.comboBoxTermin.FormattingEnabled = true;
            this.comboBoxTermin.Location = new System.Drawing.Point(51, 188);
            this.comboBoxTermin.Name = "comboBoxTermin";
            this.comboBoxTermin.Size = new System.Drawing.Size(550, 23);
            this.comboBoxTermin.TabIndex = 2;
            // 
            // buttonMakeAnAppointment
            // 
            this.buttonMakeAnAppointment.Location = new System.Drawing.Point(496, 299);
            this.buttonMakeAnAppointment.Name = "buttonMakeAnAppointment";
            this.buttonMakeAnAppointment.Size = new System.Drawing.Size(105, 57);
            this.buttonMakeAnAppointment.TabIndex = 4;
            this.buttonMakeAnAppointment.Text = "Make an appointment";
            this.buttonMakeAnAppointment.UseVisualStyleBackColor = true;
            this.buttonMakeAnAppointment.Click += new System.EventHandler(this.btnMakeAppointment);
            // 
            // MakeAnAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 396);
            this.Controls.Add(this.buttonMakeAnAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTrener);
            this.Name = "MakeAnAppointment";
            this.Text = "MakeAnAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        public ComboBox comboBoxTrener;
        public ComboBox comboBoxTermin;
        public Button buttonMakeAnAppointment;
    }
}