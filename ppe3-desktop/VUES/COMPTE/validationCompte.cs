﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe3_desktop.VUES.COMPTE
{
    public partial class validationCompte : UserControl
    {
        connexionBase maConnexion;
        public validationCompte()
        {
            InitializeComponent();

            maConnexion = new connexionBase();

            clientBindingSource.DataSource = maConnexion.client.ToList();
            
        }
    }
}
