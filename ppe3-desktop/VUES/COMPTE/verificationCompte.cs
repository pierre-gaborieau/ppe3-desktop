    using System;
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
    public partial class verificationCompte : UserControl
    {
        public verificationCompte()
        {
            InitializeComponent();
        }

        public void loadCombo(List<client> lesClients)
        {
            lbl_error.Visible = false;
            List<string> cbList = new List<string>();
            foreach(client c in lesClients)
            {

                string s = c.login;
                cbList.Add(s);
            }

            cb_client.DataSource = cbList;
        }


        private void Btn_ok_Click(object sender, EventArgs e)
        {
            p_selection.Visible = false;
            p_modifmdp.Visible = true;

        }

        private void Btn_valider_Click(object sender, EventArgs e)
        {
            if(txt_mdp.Text == txt_mdp2.Text && txt_mdp.Text.Length > 8)
            {
                ((controleur)(this.Parent)).ChangementMotDePasse(cb_client.Text, txt_mdp.Text);
                
                this.Visible = false;
                lbl_error.Visible = false;
            }
            else
            {
                lbl_error.Visible = true;
            }
        }
    }
}
