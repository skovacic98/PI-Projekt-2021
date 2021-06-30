using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace KindergartenJoy.Forme
{
    public partial class FormBilješke : Form
    {
        bool provjera = false;
        private korisnik potrebniKorisnik;
        List<string> djeca = new List<string>();
        string[] imena;
        string imen;

        public FormBilješke(korisnik odabraniKorisnik)
        {
            potrebniKorisnik = odabraniKorisnik;
            InitializeComponent();
            LodajDjecuUCombo();
        }

        private void KreirajBilješku()
        {
            biljeska zabilješka = new biljeska();
            zabilješka.korisnik_id = potrebniKorisnik.korisnik_id;
            zabilješka.sadrzaj = txtSadržaj.Text;
            zabilješka.datum = DateTime.Now;
            using (var context = new Entities())
            { 
                var query = from a in context.dijete
                            select a;
                List<dijete> dica = query.ToList();
                foreach (var item in dica)
                {
                    if(item.ime == imena[0] && item.prezime == imena[1])
                    {
                        zabilješka.dijete_id = item.dijete_id;
                    }
                }
                
                context.biljeska.Add(zabilješka);
                context.SaveChanges();
            }
        }

        private void LodajDjecuUCombo()
        {
            
            using (var context = new Entities())
            {
                var query = from a in context.dijete
                            select a;
                foreach (var item in query)
                {
                    djeca.Add(item.ime + " " + item.prezime);
                }
                cmbDijeca.DataSource = djeca;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            
            imen = cmbDijeca.SelectedItem as string;
            imena = imen.Split(' ');
            KreirajBilješku();
            txtSadržaj.Text = "";
            FormBiljeskaSpremljena form = new FormBiljeskaSpremljena();
            form.ShowDialog();
        }

        private void btnPosaljiBilješke_Click(object sender, EventArgs e)
        {
            PosaljiNaMail();
            FormBiljeskePoslane form = new FormBiljeskePoslane();
            form.ShowDialog();
        }

        private void PosaljiNaMail()
        {
            List<korisnik> roditelji = new List<korisnik>();
            roditelji = DohvatiListuRoditelja();
            string mail = "";

            foreach (var roditelj in roditelji)
            {
                provjera = false;
                var doc = new Document();
                MemoryStream memoryStream = new MemoryStream();
                PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
                SveZapisiUMail(doc, roditelj, writer, memoryStream);
                if(provjera == true)
                {
                    mail = roditelj.email;
                    StvoriMail(mail, memoryStream);
                }
                //MessageBox.Show($"Poslan mail na {mail}");
            }
        }

        private static void StvoriMail(string mail, MemoryStream memoryStream)
        {
            MailMessage mm = new MailMessage("pi21.tim12@gmail.com", mail)
            {
                Subject = "Bilješke",
                IsBodyHtml = true,
                Body = "Lijepi pozdrav! KindergartenJoy Vam šalje Vaše nove bilješke! \n Nalaze se u PDF obliku unutar priloga ovog mail-a.\n" +
                            " Ovo je automatski generirana e-pošta - nemojte na nju odgovarati. " +
                            "Ako imate pitanja u vezi s ovim mailom, pošaljite mail na pi21.tim12@gmail.com"
            };

            mm.Attachments.Add(new Attachment(memoryStream, $"Obavijesti.pdf"));
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("pi21.tim12", "ivanfilipsilvio")

            };

            smtp.Send(mm);
        }

        private void SveZapisiUMail(Document doc, korisnik roditelj, PdfWriter writer, MemoryStream memoryStream)
        {
            doc.Open();
            doc.Add(new Paragraph("Bilješke za Vašu djecu na današnji dan!"));
            doc.Add(new Paragraph("------------------------BILJEŠKE-----------------------"));
            List<dijete> svaDjeca = dijete.DohvatiListuDjece();
            List<upis> sviUpisi = upis.DohvatiSveUpise();
            List<upis> upisiRoditelja = new List<upis>();
            List<dijete> djecaRoditelja = new List<dijete>();

            foreach (var item in sviUpisi)
            {
                if (item.korisnik_id == roditelj.korisnik_id)
                {
                    upisiRoditelja.Add(item);
                }
            }

            foreach (var dijete in svaDjeca)
            {
                foreach (var roditelj2 in upisiRoditelja)
                {
                    if (dijete.dijete_id == roditelj2.dijete_id)
                    {
                        djecaRoditelja.Add(dijete);
                    }
                }
            }

            List<biljeska> sveBilješke = biljeska.DohvatiListuBilješki();
            List<biljeska> bilješkeDijeteta = new List<biljeska>();
            foreach (var biljeska in sveBilješke)
            {
                foreach (var dite in djecaRoditelja)
                {
                    if (biljeska.dijete_id == dite.dijete_id && biljeska.datum.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        provjera = true;
                        doc.Add(new Paragraph($"Dijete: {dite.ime} {dite.prezime}"));
                        doc.Add(new Paragraph($"Sadržaj bilješke: {biljeska.sadrzaj}"));
                        doc.Add(new Paragraph($"Datum i vrijeme kreiranja bilješke: {biljeska.datum.ToShortDateString()}"));
                        foreach (var item in korisnik.DohvatiListuKorisnika())
                        {
                            if (item.korisnik_id == biljeska.korisnik_id)
                            {
                                doc.Add(new Paragraph($"Teta koja je stvorila bilješku: {item.ime} {item.prezime}"));
                                doc.Add(new Paragraph($"-------------------------------------------------------"));
                            }
                        }

                    }
                }
            }
            writer.CloseStream = false;
            doc.Close();
            memoryStream.Position = 0;
        }


        private List<korisnik> DohvatiListuRoditelja()
        {
            List<korisnik> sviKorisnici = korisnik.DohvatiListuKorisnika();
            List<korisnik> roditelji = new List<korisnik>();
            List<upis> sviUpisi = upis.DohvatiSveUpise();

            foreach (var upis in sviUpisi)
            {
                foreach (var roditelj in sviKorisnici)
                {
                    if (!roditelji.Contains(roditelj))
                    {
                        if (upis.korisnik_id == roditelj.korisnik_id)
                        {
                            roditelji.Add(roditelj);
                        }
                    }
                }
            }
            return roditelji;
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
