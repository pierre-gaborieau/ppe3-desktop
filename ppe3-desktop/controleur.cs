﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

using ppe3_desktop.VUES.COMPTE;
using ppe3_desktop.VUES.COMPOSANT;
using System.Data.SqlClient;

#region à supprimer 
#endregion

namespace ppe3_desktop
{
    public partial class controleur : Form
    {
        #region global
        public connexionBase maConnexion = new connexionBase();
        public controleur()
        {
            InitializeComponent();
        }

        private void allFalse()
        {
            validationCompte1.Visible = false;
            verificationCompte1.Visible = false;
            ajouterFilm2.Visible = false;
            modifierFilm1.Visible = false;
            creationCompte1.Visible = false;
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static void Email(string sujet, string contenu, string email)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("ppe3videotheque@gmail.com");
                message.To.Add(new MailAddress(email));
                message.Subject = sujet;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = contenu;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("ppe3videotheque@gmail.com", "Password2019!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception e) { }
        }

        #endregion

        #region Compte
        private void VerificationCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();
            verificationCompte1.loadCombo(modele.listeClient());
            verificationCompte1.Visible = true;
        }

        private void FermetureCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();
            validationCompte1.afficherPage(modele.listeClientCheckActif(1), "");
            validationCompte1.Visible = true;
        }

        private void CréerCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();
            creationCompte1.Visible = true;
        }

        private void ValidationComtpeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();

            var listeSend = modele.listeClientCheckActif(0);

            validationCompte1.afficherPage(listeSend, "validation");

            validationCompte1.Visible = true;
        }

        public void changerStatus(client c, int val)
        {
            modele.ChangerStatus(c, val);
            allFalse();
        }

        internal void ChangementMotDePasse(string login, string mdp, string email)
        {
            modele.changerMdpClient(mdp, login);
            string contenuMail = "Votre mot de passe à été changé suite à votre demande. \nIl est maintenant : " + mdp + " .";

            Email("Changement de mot de passe", contenuMail, email);
            allFalse();
        }
        #endregion

        #region Composant
        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            allFalse();
            ajouterFilm2.SendListe(modele.getListSupport(), modele.getListGenre());
            ajouterFilm2.Visible = true;
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            allFalse();
            modifierFilm1.afficherPage(modele.getListSupport(), modele.getListGenre());
            modifierFilm1.Visible = true;
        }

        public void AjouterSupport(int idSupport, string leTitreSupport, string leRealisateur, string imageSupport, int idGenre)
        {
            modele.AjouterSupport(idSupport, leTitreSupport, leRealisateur, imageSupport, idGenre);
        }

        public void modifierSupport(support leSupport, int idSupport, string leTitreSupport, string leRealisateur, string imageSupport, int idGenre)
        {
            modele.ModifierSupport(leSupport, idSupport, leTitreSupport, leRealisateur, imageSupport, idGenre);
            MessageBox.Show("Résultat", "La modification a pris effet");
        }
        #endregion
    }
}
