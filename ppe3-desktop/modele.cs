using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe3_desktop
{
    public static class modele
    {
        private static connexionBase maConnexion = new connexionBase();


        #region Client
        public static List<client> listeClient()
        {
            var listeSend = maConnexion.client.ToList();

            return (listeSend);
        }

        public static List<client> listeClientCheckActif(int val)
        {
            var listeSend = maConnexion.client.ToList().Where(x => x.actif == val).ToList();

            return (listeSend);
        }

        public static void ChangerStatus(client c, int value)
        {
            int noOfRowUpdated = maConnexion.Database.ExecuteSqlCommand("Update client set actif=@status where idClient = @id", new SqlParameter("@id", c.idClient), new SqlParameter("@status", value));


        }


        public static void changerMdpClient(string mdp, string login)
        {
            int noOfRowUpdated = maConnexion.Database.ExecuteSqlCommand("Update client set pwd=@pw where login = @login", new SqlParameter("@pw", mdp), new SqlParameter("@login", login));
        }

        public static void creerClient(string email, string nom, string prenom, string login, string pw, bool cheque)
        {
            DateTime date = DateTime.Now;


            int id = maConnexion.client.ToList().Count();

            int actif = 0;
            if (cheque)
            {
                actif = 1;
            }

            int no = maConnexion.Database.ExecuteSqlCommand("Insert into client values(@nom, @prenom, @email, @dateActif, @login, @pw, @actif)", new SqlParameter("@nom", nom), new SqlParameter("@prenom", prenom), new SqlParameter("@email", email), 
                new SqlParameter("dateActif", date), new SqlParameter("@login", login), new SqlParameter("@pw", pw), new SqlParameter("@actif", actif));
        }

        #endregion

        #region Composant
        public static void AjouterSupport(int idSupport, string leTitreSupport, string leRealisateur, string imageSupport, int idGenre)
        {
            using (var context = new connexionBase())
            {
                int noOfRowUpdated = context.Database.ExecuteSqlCommand("INSERT INTO support (titreSupport, realisateur, image, idGenre) VALUES ('" + leTitreSupport + "', '" + leRealisateur + "', '" + imageSupport + ".jpg', '" + idGenre + "')");
            }
        }
        public static List<support> getListSupport()
        {
            List<support> listeSupport = new List<support>();
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

            return listeSupport;
        }
        public static List<genre> getListGenre()
        {
            List<genre> listeGenre = new List<genre>();
            foreach (genre g in maConnexion.genre.ToList())
            {
                listeGenre.Add(g);
            }

            return listeGenre;
        }
        public static void ModifierSupport(support leSupport, int idSupport, string leTitreSupport, string leRealisateur, string imageSupport, int idGenre)
        {
            using (var context = new connexionBase())
            {
                int noOfRowUpdated = context.Database.ExecuteSqlCommand("UPDATE support set titreSupport=@leTitreSupport, realisateur=@leRealisateur, image=@imageSupport, idGenre=@idGenre WHERE idSupport=@idSupport", new SqlParameter("@idSupport", idSupport), new SqlParameter("@leTitreSupport", leTitreSupport), new SqlParameter("@leRealisateur", leRealisateur), new SqlParameter("@imageSupport", imageSupport), new SqlParameter("@idGenre", idGenre));
            }
        }
        #endregion

    }
}
