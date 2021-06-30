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
    public partial class FormEvidencija : Form
    {
        public FormEvidencija()
        {
            InitializeComponent();
        }

        private void FormEvidencija_Load(object sender, EventArgs e)
        {
            dgvDjeca.DataSource = dijete.DohvatiListuDjece();
            dgvDjeca.Columns["biljeska"].Visible = false;
            dgvDjeca.Columns["upis"].Visible = false;
            dgvDjeca.Columns["evidencija"].Visible = false;
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            FormEvidentiraj form = new FormEvidentiraj(dgvDjeca.CurrentRow.DataBoundItem as dijete);
            form.ShowDialog();
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

        private void btnNazad_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
