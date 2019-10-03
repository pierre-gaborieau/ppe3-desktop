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
    public partial class creationCompte : UserControl
    {
        public creationCompte()
        {
            InitializeComponent();
        }

        private void Btn_creer_Click(object sender, EventArgs e)
        {
            if(txt_pw.Text == txt_pw2.Text)
            {
                string email = txt_mail_a.Text + "@" + txt_mail_b.Text + "." + txt_mail_c.Text;
                lbl_error.Visible = false;
                modele.creerClient(email, txt_nom.Text, txt_prenom.Text, txt_login.Text, txt_pw.Text, chk_Cheque.Checked);
            }
            else
            {
                lbl_error.Visible = true;
                txt_pw.Text = "";
                txt_pw2.Text = "";
            }
        }
    }
}
