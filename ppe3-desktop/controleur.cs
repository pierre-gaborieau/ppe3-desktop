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

namespace ppe3_desktop
{
    public partial class controleur : Form
    {
        public connexionBase maConnexion = new connexionBase();
        public controleur()
        {
            InitializeComponent();
           
        }

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
                int noOfRowUpdated = context.Database.ExecuteSqlCommand("Update client set actif=1 where idClient = @id", new SqlParameter("@id", c.idClient));
            }

            allFalse();

        }

        private void allFalse()
        {
            validationCompte1.Visible = false;
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

        public void AjouterFilm(List<support> lesSupport, string leTitre, string leReal, int idGenre, string imageName, string duree)
        {
            using (var context = new connexionBase())
            {
                int noOfRowUpdated = context.Database.ExecuteSqlCommand("INSERT INTO support (titreSupport, realisateur, image, idGenre) VALUES ('"+leTitre+"', '"+leReal+"', '"+imageName+".jpg', '"+idGenre+"')");
            }

            int max = 0;

            foreach(support s in lesSupport)
            {
                if(s.idSupport > max)
                {
                    max = s.idSupport;
                }
            }


            allFalse();
        }
    }
}
