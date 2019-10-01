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

        #region Compte
        private void ValidationComtpeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();

            var listeSend = maConnexion.client.SqlQuery("SELECT * FROM client WHERE actif = 0").ToList();

            validationCompte1.afficherPage(listeSend);

            validationCompte1.Visible = true;
        }

        public void ActivationCompte(client c)
        {

            using (var context = new connexionBase())
            {
                int test = context.Database.ExecuteSqlCommand("Update client set actif=1 where idClient = @id", new SqlParameter("@id", c.idClient));
            }

            allFalse();
        }

        private void VérificationCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allFalse();

            var listeSend = maConnexion.client.SqlQuery("SELECT * FROM client").ToList();

            verificationCompte1.loadCombo(listeSend);

            verificationCompte1.Visible = true;

        }

        public void ChangementMotDePasse(string login, string mdp)
        {
            using (var context = new connexionBase())
            {
                int test = context.Database.ExecuteSqlCommand("Update client set pwd=@pw where login = @login", new SqlParameter("@login", login), new SqlParameter("@pw", mdp));
                
            }

            var email = maConnexion.client.SqlQuery("SELECT *  FROM dbo.client WHERE login = @login", new SqlParameter("@login", login)).FirstOrDefault();

            envoiMail(email.emailClient.ToString(), "Modification de votre mot de passe", "Votre mot de passe à été modifié suite à votre demande.\n Votre mot de passe est maintenant : " + mdp);
        }
        #endregion

        private void allFalse()
        {
            validationCompte1.Visible = false;
            //ajouterFilm1.Visible = false;
            modifierFilm1.Visible = false;
            verificationCompte1.Visible = false;
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            allFalse();
            ajouterFilm1.Visible = true;
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

        private void envoiMail(string to, string objet, string contenu)
        {
            

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("ppe3videotheque@gmail.com", "Password2019!"),
                EnableSsl = true
            };

            client.UseDefaultCredentials = true;

            try
            {
                client.Send("ppe3videotheque@gmail.com", "ppe3videotheque@gmail.com", objet, contenu);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                            ex.ToString());
            }
        }

       
    }
}
