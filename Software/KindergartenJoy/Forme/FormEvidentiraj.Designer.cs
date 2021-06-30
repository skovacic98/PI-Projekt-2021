
namespace KindergartenJoy.Forme
{
    partial class FormEvidentiraj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvidentiraj));
            this.cmbGrupe = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.dtpVrijemeDolaska = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.pbZnalci = new System.Windows.Forms.PictureBox();
            this.pbGenijalci = new System.Windows.Forms.PictureBox();
            this.pbMajstori = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZnalci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenijalci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMajstori)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGrupe
            // 
            this.cmbGrupe.FormattingEnabled = true;
            this.cmbGrupe.Location = new System.Drawing.Point(157, 11);
            this.cmbGrupe.Name = "cmbGrupe";
            this.cmbGrupe.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupe.TabIndex = 2;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpremi.Location = new System.Drawing.Point(27, 37);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(183, 42);
            this.btnSpremi.TabIndex = 25;
            this.btnSpremi.Text = "EVIDENTIRAJ";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(118, 40);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(0, 13);
            this.labelIme.TabIndex = 26;
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(138, 74);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(0, 13);
            this.labelPrezime.TabIndex = 27;
            // 
            // dtpVrijemeDolaska
            // 
            this.dtpVrijemeDolaska.Location = new System.Drawing.Point(172, 119);
            this.dtpVrijemeDolaska.Name = "dtpVrijemeDolaska";
            this.dtpVrijemeDolaska.Size = new System.Drawing.Size(200, 20);
            this.dtpVrijemeDolaska.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.lblPrezime);
            this.panel1.Controls.Add(this.lblIme);
            this.panel1.Controls.Add(this.dtpVrijemeDolaska);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 165);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "IME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "PREZIME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "DATUM:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.pbMajstori);
            this.panel2.Controls.Add(this.pbGenijalci);
            this.panel2.Controls.Add(this.pbZnalci);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbGrupe);
            this.panel2.Location = new System.Drawing.Point(489, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 295);
            this.panel2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "GRUPA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnSpremi);
            this.panel3.Location = new System.Drawing.Point(27, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 114);
            this.panel3.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblIme.Location = new System.Drawing.Point(171, 20);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(41, 16);
            this.lblIme.TabIndex = 29;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPrezime.Location = new System.Drawing.Point(169, 70);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(85, 16);
            this.lblPrezime.TabIndex = 30;
            this.lblPrezime.Text = "Prezime";
            // 
            // pbZnalci
            // 
            this.pbZnalci.Image = ((System.Drawing.Image)(resources.GetObject("pbZnalci.Image")));
            this.pbZnalci.Location = new System.Drawing.Point(21, 46);
            this.pbZnalci.Name = "pbZnalci";
            this.pbZnalci.Size = new System.Drawing.Size(279, 225);
            this.pbZnalci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZnalci.TabIndex = 19;
            this.pbZnalci.TabStop = false;
            this.pbZnalci.Visible = false;
            // 
            // pbGenijalci
            // 
            this.pbGenijalci.Image = ((System.Drawing.Image)(resources.GetObject("pbGenijalci.Image")));
            this.pbGenijalci.Location = new System.Drawing.Point(21, 46);
            this.pbGenijalci.Name = "pbGenijalci";
            this.pbGenijalci.Size = new System.Drawing.Size(279, 225);
            this.pbGenijalci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGenijalci.TabIndex = 33;
            this.pbGenijalci.TabStop = false;
            this.pbGenijalci.Visible = false;
            // 
            // pbMajstori
            // 
            this.pbMajstori.Image = ((System.Drawing.Image)(resources.GetObject("pbMajstori.Image")));
            this.pbMajstori.Location = new System.Drawing.Point(21, 46);
            this.pbMajstori.Name = "pbMajstori";
            this.pbMajstori.Size = new System.Drawing.Size(279, 225);
            this.pbMajstori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMajstori.TabIndex = 34;
            this.pbMajstori.TabStop = false;
            this.pbMajstori.Visible = false;
            // 
            // FormEvidentiraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(833, 344);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormEvidentiraj";
            this.Text = "Evidentiraj";
            this.Load += new System.EventHandler(this.FormEvidentiraj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZnalci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenijalci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMajstori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGrupe;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.DateTimePicker dtpVrijemeDolaska;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.PictureBox pbZnalci;
        private System.Windows.Forms.PictureBox pbGenijalci;
        private System.Windows.Forms.PictureBox pbMajstori;
    }
}