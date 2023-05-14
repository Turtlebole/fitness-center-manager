namespace SSS_2022_projekat.Windows
{
    partial class StartTrening
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.TimingBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Timelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TimingBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimingBar
            // 
            this.TimingBar.Controls.Add(this.Timelbl);
            this.TimingBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TimingBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimingBar.ForeColor = System.Drawing.Color.White;
            this.TimingBar.Location = new System.Drawing.Point(129, 191);
            this.TimingBar.Minimum = 0;
            this.TimingBar.Name = "TimingBar";
            this.TimingBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.TimingBar.ProgressColor2 = System.Drawing.Color.Crimson;
            this.TimingBar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            this.TimingBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TimingBar.Size = new System.Drawing.Size(171, 171);
            this.TimingBar.TabIndex = 0;
            this.TimingBar.Text = "guna2CircleProgressBar1";
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Timelbl.Location = new System.Drawing.Point(34, 62);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(100, 45);
            this.Timelbl.TabIndex = 1;
            this.Timelbl.Text = "Timig";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Training is in progress";
            // 
            // StartTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimingBar);
            this.Name = "StartTrening";
            this.Text = "StartTrening";
            this.Load += new System.EventHandler(this.StartTrening_Load);
            this.TimingBar.ResumeLayout(false);
            this.TimingBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar TimingBar;
        private Label Timelbl;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}