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

        public validationCompte()
        {
            InitializeComponent();

            
            
        }

        public void afficherPage(List<client> laListe)
        {
            clientBindingSource.DataSource = laListe;
        }
    }
}
