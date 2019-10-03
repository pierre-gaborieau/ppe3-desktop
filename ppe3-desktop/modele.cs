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
            var listeSend = maConnexion.client.SqlQuery("SELECT * FROM client").ToList();

            return (listeSend);
        }

        public static List<client> listeClientNonActif()
        {
            var listeSend = maConnexion.client.SqlQuery("SELECT * FROM client WHERE actif = 0").ToList();

            return (listeSend);
        }

        public static List<client> listeCLientActif()
        {
            var listeSend = maConnexion.client.SqlQuery("SELECT * FROM client WHERE actif = 1").ToList();
            return (listeSend);
        }

        public static void ChangerStatus(client c, int value)
        {
            using (var context = new connexionBase())
            {
                int noOfRowUpdated = context.Database.ExecuteSqlCommand("Update client set actif=@status where idClient = @id", new SqlParameter("@id", c.idClient), new SqlParameter("@status", value));
            }
        }


        public static void changerMdpClient(string mdp, string login)
        {
            using (var context = new connexionBase())
            {
                int noOfRowUpdated = context.Database.ExecuteSqlCommand("Update client set pwd=@pw where login = @login", new SqlParameter("@pw", mdp), new SqlParameter("@login", login));
            }
        }
        #endregion
    }
}
