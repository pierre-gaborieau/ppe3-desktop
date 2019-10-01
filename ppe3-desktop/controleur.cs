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
            //ajouterFilm1.Visible = false;
            modifierFilm1.Visible = false;
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
    }
}
