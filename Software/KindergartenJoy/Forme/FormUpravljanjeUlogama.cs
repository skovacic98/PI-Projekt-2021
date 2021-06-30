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
    public partial class FormUpravljanjeUlogama : Form
    {
        string[] uloge = { "Teta", "Roditelj", "Admin" };
        private korisnik odabraniKorisnik;
        public FormUpravljanjeUlogama()
        {
            InitializeComponent();
        }

        private void FormUpravljanjeUlogama_Load(object sender, EventArgs e)
        {
            dgvKorisnici.DataSource = korisnik.DohvatiListuKorisnika();
            dgvKorisnici.Columns["aktivnost"].Visible = false;
            dgvKorisnici.Columns["aktivnost1"].Visible = false;
            dgvKorisnici.Columns["biljeska"].Visible = false;
            dgvKorisnici.Columns["dnevnik"].Visible = false;
            dgvKorisnici.Columns["tip_korisnik"].Visible = false;
            dgvKorisnici.Columns["obavijest"].Visible = false;
            dgvKorisnici.Columns["upis"].Visible = false;
            dgvKorisnici.Columns["korisnik_id"].Visible = false;
            dgvKorisnici.Columns["aktivnost_id"].Visible = false;
            dgvKorisnici.Columns["lozinka"].Visible = false;
            dgvKorisnici.Columns["lozinka_sha256"].Visible = false;
            dgvKorisnici.Columns["status"].Visible = false;
            dgvKorisnici.Columns["pretplata"].Visible = false;
            dgvKorisnici.Columns["grupa"].Visible = false;
            dgvKorisnici.Columns["grupa_id"].Visible = false;
            cmbUloge.DataSource = uloge;

            pbTeta.Visible = true;

            cmbUloge.SelectedIndexChanged += CmbUloge_SelectedIndexChanged;
        }

        private void CmbUloge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUloge.SelectedIndex == 0)
            {
                pbTeta.Visible = true;
                pbRoditelj.Visible = false;
                pbAdmin.Visible = false;
            }

            if (cmbUloge.SelectedIndex == 1)
            {
                pbTeta.Visible = false;
                pbRoditelj.Visible = true;
                pbAdmin.Visible = false;
            }

            if (cmbUloge.SelectedIndex == 2)
            {
                pbTeta.Visible = false;
                pbRoditelj.Visible = false;
                pbAdmin.Visible = true;
            }

        }

        private korisnik DohvatiOdabranogKorisnika()
        {
            return dgvKorisnici.CurrentRow.DataBoundItem as korisnik;
        }

        private void btnIzmjeniUlogu_Click(object sender, EventArgs e)
        {
            odabraniKorisnik = DohvatiOdabranogKorisnika();
            using (var context = new Entities())
            {
                context.korisnik.Attach(odabraniKorisnik);
                if(cmbUloge.SelectedItem.ToString() == "Teta")
                {
                    odabraniKorisnik.tip_korisnik_id = 2;
                    context.SaveChanges();
                }
                if(cmbUloge.SelectedItem.ToString() == "Roditelj")
                {
                    odabraniKorisnik.tip_korisnik_id = 3;
                    context.SaveChanges();
                }
                if(cmbUloge.SelectedItem.ToString() == "Admin")
                {
                    odabraniKorisnik.tip_korisnik_id = 1;
                    context.SaveChanges();
                }
            }
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            dgvKorisnici.DataSource = korisnik.DohvatiListuKorisnika();
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

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
