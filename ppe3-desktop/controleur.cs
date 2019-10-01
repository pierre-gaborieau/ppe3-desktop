using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

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
            List<client> listeSend = new List<client>();
            foreach(client c in maConnexion.client.ToList())
            {
                if(c.actif == 0)
                {
                    listeSend.Add(c);
                }
            }
            validationCompte1.afficherPage(listeSend);

            validationCompte1.Visible = true;
        }

        public void ActivationCompte(client c)
        {

            using (var context = new connexionBase())
            {
                /*int query = context.client
                    .ExecuteSqlCommand("UPDATE actif in CLIENT SET 1 where login=@login", new SqlParameter("@login", c.login));
                Console.WriteLine(query.nomClient);*/
            }

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
