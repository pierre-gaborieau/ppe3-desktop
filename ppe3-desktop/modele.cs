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

        public static List<client> listeClientActif()
        {
            var listeSend = maConnexion.client.SqlQuery("SELECT * FROM client WHERE actif = 0").ToList();

            return (listeSend);
        }

        public static void activationClient(client c)
        {
            using (var context = new connexionBase())
            {
                int noOfRowUpdated = context.Database.ExecuteSqlCommand("Update client set actif=1 where idClient = @id", new SqlParameter("@id", c.idClient));
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
