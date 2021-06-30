
namespace KindergartenJoy.Forme
{
    partial class FormUpravljanjeUlogama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpravljanjeUlogama));
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.cmbUloge = new System.Windows.Forms.ComboBox();
            this.btnIzmjeniUlogu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNazad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbTeta = new System.Windows.Forms.PictureBox();
            this.pbRoditelj = new System.Windows.Forms.PictureBox();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoditelj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(23, 92);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(635, 295);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // cmbUloge
            // 
            this.cmbUloge.FormattingEnabled = true;
            this.cmbUloge.Location = new System.Drawing.Point(24, 44);
            this.cmbUloge.Name = "cmbUloge";
            this.cmbUloge.Size = new System.Drawing.Size(215, 21);
            this.cmbUloge.TabIndex = 1;
            // 
            // btnIzmjeniUlogu
            // 
            this.btnIzmjeniUlogu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzmjeniUlogu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmjeniUlogu.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmjeniUlogu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzmjeniUlogu.Location = new System.Drawing.Point(271, 33);
            this.btnIzmjeniUlogu.Name = "btnIzmjeniUlogu";
            this.btnIzmjeniUlogu.Size = new System.Drawing.Size(184, 40);
            this.btnIzmjeniUlogu.TabIndex = 2;
            this.btnIzmjeniUlogu.Text = "IZMJENI ULOGU";
            this.btnIzmjeniUlogu.UseVisualStyleBackColor = false;
            this.btnIzmjeniUlogu.Click += new System.EventHandler(this.btnIzmjeniUlogu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnIzmjeniUlogu);
            this.panel1.Controls.Add(this.cmbUloge);
            this.panel1.Location = new System.Drawing.Point(23, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 107);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnNazad);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 79);
            this.panel2.TabIndex = 7;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNazad.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.Color.Black;
            this.btnNazad.Location = new System.Drawing.Point(674, 27);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(251, 31);
            this.btnNazad.TabIndex = 28;
            this.btnNazad.Text = "Nazad na naslovnicu";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "UPRAVLJANJE ULOGAMA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(525, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pbTeta
            // 
            this.pbTeta.Image = ((System.Drawing.Image)(resources.GetObject("pbTeta.Image")));
            this.pbTeta.Location = new System.Drawing.Point(676, 92);
            this.pbTeta.Name = "pbTeta";
            this.pbTeta.Size = new System.Drawing.Size(251, 295);
            this.pbTeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeta.TabIndex = 8;
            this.pbTeta.TabStop = false;
            this.pbTeta.Visible = false;
            // 
            // pbRoditelj
            // 
            this.pbRoditelj.Image = ((System.Drawing.Image)(resources.GetObject("pbRoditelj.Image")));
            this.pbRoditelj.Location = new System.Drawing.Point(676, 92);
            this.pbRoditelj.Name = "pbRoditelj";
            this.pbRoditelj.Size = new System.Drawing.Size(251, 295);
            this.pbRoditelj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRoditelj.TabIndex = 9;
            this.pbRoditelj.TabStop = false;
            this.pbRoditelj.Visible = false;
            // 
            // pbAdmin
            // 
            this.pbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(676, 92);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(251, 295);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdmin.TabIndex = 10;
            this.pbAdmin.TabStop = false;
            this.pbAdmin.Visible = false;
            // 
            // FormUpravljanjeUlogama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(948, 546);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.pbRoditelj);
            this.Controls.Add(this.pbTeta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpravljanjeUlogama";
            this.Text = "FormUpravljanjeUlogama";
            this.Load += new System.EventHandler(this.FormUpravljanjeUlogama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoditelj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.ComboBox cmbUloge;
        private System.Windows.Forms.Button btnIzmjeniUlogu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbTeta;
        private System.Windows.Forms.PictureBox pbRoditelj;
        private System.Windows.Forms.PictureBox pbAdmin;
    }
}