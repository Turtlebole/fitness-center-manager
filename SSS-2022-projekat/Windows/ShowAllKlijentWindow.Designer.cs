namespace SSS_2022_projekat
{
    partial class ShowAllKlijentWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osnovniJezikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjaIBolestiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obimKukovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obimStrukaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obimGrudiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKartice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 529);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.brojTelefonaDataGridViewTextBoxColumn,
            this.osnovniJezikDataGridViewTextBoxColumn,
            this.visinaDataGridViewTextBoxColumn,
            this.tezinaDataGridViewTextBoxColumn,
            this.stanjaIBolestiDataGridViewTextBoxColumn,
            this.obimKukovaDataGridViewTextBoxColumn,
            this.obimStrukaDataGridViewTextBoxColumn,
            this.obimGrudiDataGridViewTextBoxColumn,
            this.AdresaId,
            this.BrojKartice});
            this.dataGridView1.DataSource = this.klijentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 525);
            this.dataGridView1.TabIndex = 1;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "Pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "Pol";
            this.polDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojTelefonaDataGridViewTextBoxColumn
            // 
            this.brojTelefonaDataGridViewTextBoxColumn.DataPropertyName = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.HeaderText = "BrojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojTelefonaDataGridViewTextBoxColumn.Name = "brojTelefonaDataGridViewTextBoxColumn";
            this.brojTelefonaDataGridViewTextBoxColumn.Width = 125;
            // 
            // osnovniJezikDataGridViewTextBoxColumn
            // 
            this.osnovniJezikDataGridViewTextBoxColumn.DataPropertyName = "OsnovniJezik";
            this.osnovniJezikDataGridViewTextBoxColumn.HeaderText = "OsnovniJezik";
            this.osnovniJezikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.osnovniJezikDataGridViewTextBoxColumn.Name = "osnovniJezikDataGridViewTextBoxColumn";
            this.osnovniJezikDataGridViewTextBoxColumn.Width = 125;
            // 
            // visinaDataGridViewTextBoxColumn
            // 
            this.visinaDataGridViewTextBoxColumn.DataPropertyName = "Visina";
            this.visinaDataGridViewTextBoxColumn.HeaderText = "Visina";
            this.visinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visinaDataGridViewTextBoxColumn.Name = "visinaDataGridViewTextBoxColumn";
            this.visinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "Tezina";
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "Tezina";
            this.tezinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            this.tezinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // stanjaIBolestiDataGridViewTextBoxColumn
            // 
            this.stanjaIBolestiDataGridViewTextBoxColumn.DataPropertyName = "StanjaIBolesti";
            this.stanjaIBolestiDataGridViewTextBoxColumn.HeaderText = "StanjaIBolesti";
            this.stanjaIBolestiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjaIBolestiDataGridViewTextBoxColumn.Name = "stanjaIBolestiDataGridViewTextBoxColumn";
            this.stanjaIBolestiDataGridViewTextBoxColumn.Width = 125;
            // 
            // obimKukovaDataGridViewTextBoxColumn
            // 
            this.obimKukovaDataGridViewTextBoxColumn.DataPropertyName = "ObimKukova";
            this.obimKukovaDataGridViewTextBoxColumn.HeaderText = "ObimKukova";
            this.obimKukovaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.obimKukovaDataGridViewTextBoxColumn.Name = "obimKukovaDataGridViewTextBoxColumn";
            this.obimKukovaDataGridViewTextBoxColumn.Width = 125;
            // 
            // obimStrukaDataGridViewTextBoxColumn
            // 
            this.obimStrukaDataGridViewTextBoxColumn.DataPropertyName = "ObimStruka";
            this.obimStrukaDataGridViewTextBoxColumn.HeaderText = "ObimStruka";
            this.obimStrukaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.obimStrukaDataGridViewTextBoxColumn.Name = "obimStrukaDataGridViewTextBoxColumn";
            this.obimStrukaDataGridViewTextBoxColumn.Width = 125;
            // 
            // obimGrudiDataGridViewTextBoxColumn
            // 
            this.obimGrudiDataGridViewTextBoxColumn.DataPropertyName = "ObimGrudi";
            this.obimGrudiDataGridViewTextBoxColumn.HeaderText = "ObimGrudi";
            this.obimGrudiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.obimGrudiDataGridViewTextBoxColumn.Name = "obimGrudiDataGridViewTextBoxColumn";
            this.obimGrudiDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdresaId
            // 
            this.AdresaId.DataPropertyName = "AdresaId";
            this.AdresaId.HeaderText = "AdresaId";
            this.AdresaId.MinimumWidth = 6;
            this.AdresaId.Name = "AdresaId";
            this.AdresaId.Width = 125;
            // 
            // BrojKartice
            // 
            this.BrojKartice.DataPropertyName = "BrojKartice";
            this.BrojKartice.HeaderText = "PlatnaKartica";
            this.BrojKartice.MinimumWidth = 6;
            this.BrojKartice.Name = "BrojKartice";
            this.BrojKartice.Width = 125;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(SSS_2022_projekat.Model.Klijent);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(14, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(14, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(14, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.button6.Location = new System.Drawing.Point(14, 729);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 44);
            this.button6.TabIndex = 9;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 568);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Email";
            // 
            // ShowAllKlijentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1211, 805);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowAllKlijentWindow";
            this.Text = "Klijenti";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private DataGridView dataGridView1;
        private BindingSource klijentBindingSource;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojTelefonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn osnovniJezikDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visinaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tezinaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stanjaIBolestiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obimKukovaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obimStrukaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obimGrudiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AdresaId;
        private DataGridViewTextBoxColumn BrojKartice;
    }
}