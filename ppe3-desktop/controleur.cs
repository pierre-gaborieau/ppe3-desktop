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
            validationCompte1.Visible = true;
            validationCompte1.afficherPage(maConnexion.client.ToList());
        }

        private void allFalse()
        {
            validationCompte1.Visible = false;
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ajouterFilm1.Visible = true;
        }
    }
}
