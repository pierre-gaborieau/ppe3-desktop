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

        public void afficherPage(List<support> lesSupports, List<genre> lesGenres)
        {
            supportBindingSource1.DataSource = lesSupports;
            lesFilms = lesSupports;

            foreach (genre s in lesGenres)
            {
                lesGenresCombo.Items.Add(s.idGenre + " " + s.libelleGenre);
            }
        }

        private void ListeFilm_SelectionChanged(object sender, EventArgs e)
        {
            foreach (support c in lesFilms)
            {
                if (supportBindingSource1.Current == c)
                {
                    idSupport.Value = c.idSupport;
                    titreSupport.Text = c.titreSupport;
                    realisateur.Text = c.realisateur;
                    image.Text = c.image;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            support send = new support();
            foreach (support c in lesFilms)
            {
                if (supportBindingSource1.Current == c)
                {
                    send = c;
                }
            }

            ((controleur)(this.Parent)).modifierSupport(send, Convert.ToInt32(idSupport.Value), titreSupport.Text, realisateur.Text, image.Text, lesGenresCombo.SelectedIndex+1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
