using System;
using System.Collections.Generic;
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

        #endregion
    }
}
