using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe3_desktop
{
    public partial class controleur : Form
    {
        connexionBase maConnexion;
        public controleur()
        {
            InitializeComponent();
            maConnexion = new connexionBase();
        }
    }
}
