using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe3_desktop
{
    public partial class ModifierFilm : UserControl
    {
        private List<support> lesFilms = new List<support>();

        public ModifierFilm()
        {
            InitializeComponent();
        }

        public void afficherPage(List<support> laListe)
        {
            ListeFilm.DataSource = laListe;
            lesFilms = laListe;
        }

        private void ListeFilm_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            support send = new support();

            foreach (support c in lesFilms)
            {
                if ( == c)
                {
                    movieTitle.Text = c.titreSupport;
                    send = c;
                }
            }

            //((controleur)(this.Parent)).modifierFilm(send, 1);
        }
    }
}
