
namespace KindergartenJoy.Forme
{
    partial class FormBiljeskaSpremljena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiljeskaSpremljena));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVrati = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bilješka uspješno napravljena!";
            // 
            // btnVrati
            // 
            this.btnVrati.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVrati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVrati.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVrati.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVrati.Location = new System.Drawing.Point(212, 100);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(171, 42);
            this.btnVrati.TabIndex = 25;
            this.btnVrati.Text = "VRATI SE NAZAD";
            this.btnVrati.UseVisualStyleBackColor = false;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormBiljeskaSpremljena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(743, 196);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.label1);
            this.Name = "FormBiljeskaSpremljena";
            this.Text = "FormBiljeskaSpremljena";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}