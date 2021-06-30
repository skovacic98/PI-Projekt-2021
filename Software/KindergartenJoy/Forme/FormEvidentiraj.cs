using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindergartenJoy.Forme
{
    public partial class FormEvidentiraj : Form
    {
        public dijete Dijete { get; set; }
        public FormEvidentiraj(dijete dijete)
        {
            InitializeComponent();
            Dijete = dijete;
        }

        private void FormEvidentiraj_Load(object sender, EventArgs e)
        {
            lblIme.Text = Dijete.ime;
            lblPrezime.Text = Dijete.prezime;
            using (var context = new Entities())
            {
                var query = from a in context.grupa
                            select a;
                cmbGrupe.DataSource = query.ToList();
                cmbGrupe.DisplayMember = "ime_grupa";
            }

            pbZnalci.Visible = true;

            cmbGrupe.SelectedIndexChanged += CmbGrupe_SelectedIndexChanged;
        }

        private void CmbGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGrupe.SelectedIndex == 0)
            {
                pbZnalci.Visible = true;
                pbGenijalci.Visible = false;
                pbMajstori.Visible = false;
            }

            if (cmbGrupe.SelectedIndex == 1)
            {
                pbZnalci.Visible = false;
                pbGenijalci.Visible = true;
                pbMajstori.Visible = false;
            }

            if (cmbGrupe.SelectedIndex == 2)
            {
                pbZnalci.Visible = false;
                pbGenijalci.Visible = false;
                pbMajstori.Visible = true;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            grupa group = cmbGrupe.SelectedItem as grupa;
            evidencija evidencijaDjeteta = new evidencija()
            {
                dijete_id = Dijete.dijete_id,
                grupa_id = group.grupa_id,
                vrijeme_dolaska = dtpVrijemeDolaska.Value,
                vrijeme_odlaska = DateTime.Now
            };
            using (var context = new Entities())
            {
                context.evidencija.Add(evidencijaDjeteta);
                context.SaveChanges();
            }
            FormDijeteEvidentirano form = new FormDijeteEvidentirano();
            form.ShowDialog();
            this.Close();
        }

        private const string sHTMLHelpFileName = "User manual KindergartenJoy.chm";
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"\" + sHTMLHelpFileName);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
