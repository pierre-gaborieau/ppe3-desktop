using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe3_desktop.VUES.COMPOSANT.FILM
{
    public partial class AjouterFilm : UserControl
    {
        private List<support> lesFilms;
        private List<genre> lesGenres;
        public AjouterFilm()
        {
            InitializeComponent();
            lesFilms = new List<support>();
        }

        public void SendListe(List<support> lesFilms, List<genre> lesGenres)
        {
            this.lesFilms = lesFilms;
            this.lesGenres = lesGenres;

            foreach(genre g in lesGenres)
            {
                GenreBox.Items.Add(g.libelleGenre);
            }
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            if(TitleMovie.Text != null && RealMovie.Text != null && GenreBox.SelectedIndex != 0)
            {
                ((controleur)(this.Parent)).AjouterFilm(TitleMovie.Text, RealMovie.Text, GenreBox.SelectedIndex);
            }
        }
    }
}
