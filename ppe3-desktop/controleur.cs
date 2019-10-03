using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ppe3_desktop.VUES.COMPTE;
using ppe3_desktop.VUES.COMPOSANT;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace ppe3_desktop
{
    public partial class controleur : Form
    {
        public connexionBase maConnexion = new connexionBase();
        public controleur()
        {
            InitializeComponent();
           
        }

        private void VeriificationCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();
            var listeSend = modele.listeClient();

            verificationCompte1.loadCombo(listeSend);
        }

        private void ValidationComtpeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();

            var listeSend = modele.listeClientNonActif();

            validationCompte1.afficherPage(listeSend, "validation");

            validationCompte1.Visible = true;
        }

        public void changerStatus(client c, int val)
        {
            modele.ChangerStatus(c, val);
            allFalse();
        }

        internal void ChangementMotDePasse(string login, string mdp)
        {
            modele.changerMdpClient(mdp, login);

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("ppe3videotheque@gmail.com", "Password2019!"),
                EnableSsl = true
            };
            client.Send("ppe3videotheque@gmail.com", "ppe3videotheque@gmail.com", "test", "testbody");
            Console.WriteLine("Sent");
            allFalse();
        }


        private void allFalse()
        {
            validationCompte1.Visible = false;
            verificationCompte1.Visible = false;
            ajouterFilm2.Visible = false;
            modifierFilm1.Visible = false;
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            allFalse();

            List<support> listeSupport = new List<support>();
            List<genre> listeGenre = new List<genre>();
            foreach (support c in maConnexion.support.ToList())
            {
                foreach (film f in maConnexion.film.ToList())
                {
                    if (c.idSupport == f.idFilm)
                    {
                        listeSupport.Add(c);
                    }
                }
            }
            foreach (genre g in maConnexion.genre.ToList())
            {
                listeGenre.Add(g);
            }
            ajouterFilm2.SendListe(listeSupport, listeGenre);
            ajouterFilm2.Visible = true;
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            allFalse();

            List<support> listeSend = new List<support>();
            foreach (support c in maConnexion.support.ToList())
            {
                foreach (film f in maConnexion.film.ToList())
                {
                    if(c.idSupport == f.idFilm)
                    {
                        listeSend.Add(c);
                    }
                }
            }
            modifierFilm1.afficherPage(listeSend);

            modifierFilm1.Visible = true;
        }

        public void AjouterSupport(int idSupport, string leTitreSupport, string leRealisateur, string imageSupport, int idGenre)
        {
            using (var context = new connexionBase())
            {
                int noOfRowUpdated = context.Database.ExecuteSqlCommand("INSERT INTO support (titreSupport, realisateur, image, idGenre) VALUES ('"+ leTitreSupport + "', '"+ leRealisateur + "', '"+ imageSupport + ".jpg', '"+ idGenre + "')");
                DialogResult Message = MessageBox.Show("Le film a été correctement enregistré", "", MessageBoxButtons.OK);
            }


            allFalse();
        }

        private void VerificationCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();
            verificationCompte1.loadCombo(modele.listeClient());
            verificationCompte1.Visible = true;
        }

        private void FermetureCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();
            validationCompte1.afficherPage(modele.listeCLientActif(), "");
            validationCompte1.Visible = true;
        }

        private void CréerCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();
        }
    }
}
