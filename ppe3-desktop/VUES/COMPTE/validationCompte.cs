using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ppe3_desktop;

namespace ppe3_desktop.VUES.COMPTE
{
    public partial class validationCompte : UserControl
    {
        private List<client> lesClients = new List<client>();

        public validationCompte()
        {
            InitializeComponent();
        }

        public void afficherPage(List<client> laListe)
        {
            clientBindingSource.DataSource = laListe;
            lesClients = laListe;
        }

        private void Btn_activation_Click(object sender, EventArgs e)
        {
            client send = new client();

            foreach(client c in lesClients)
            {
                if(clientBindingSource.Current == c)
                {
                    send = c;
                }
            }

            ((controleur)(this.Parent)).ActivationCompte(send);
        }
    }
}
