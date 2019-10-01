namespace ppe3_desktop.VUES.COMPTE
{
    partial class verificationCompte
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_modifmdp = new System.Windows.Forms.Panel();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_mdp2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.p_selection = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.p_modifmdp.SuspendLayout();
            this.p_selection.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_modifmdp
            // 
            this.p_modifmdp.Controls.Add(this.lbl_error);
            this.p_modifmdp.Controls.Add(this.btn_valider);
            this.p_modifmdp.Controls.Add(this.label2);
            this.p_modifmdp.Controls.Add(this.label1);
            this.p_modifmdp.Controls.Add(this.txt_mdp2);
            this.p_modifmdp.Controls.Add(this.txt_mdp);
            this.p_modifmdp.Location = new System.Drawing.Point(249, 185);
            this.p_modifmdp.Name = "p_modifmdp";
            this.p_modifmdp.Size = new System.Drawing.Size(455, 226);
            this.p_modifmdp.TabIndex = 0;
            this.p_modifmdp.Visible = false;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(89, 25);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(100, 20);
            this.txt_mdp.TabIndex = 0;
            this.txt_mdp.UseSystemPasswordChar = true;
            // 
            // txt_mdp2
            // 
            this.txt_mdp2.Location = new System.Drawing.Point(89, 51);
            this.txt_mdp2.Name = "txt_mdp2";
            this.txt_mdp2.Size = new System.Drawing.Size(100, 20);
            this.txt_mdp2.TabIndex = 1;
            this.txt_mdp2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mot de passe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirmation : ";
            // 
            // cb_client
            // 
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(146, 41);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(250, 21);
            this.cb_client.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choisir un membre : ";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(79, 77);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "Enregistrer";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(402, 39);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Sélectionner";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // p_selection
            // 
            this.p_selection.Controls.Add(this.btn_ok);
            this.p_selection.Controls.Add(this.cb_client);
            this.p_selection.Controls.Add(this.label3);
            this.p_selection.Location = new System.Drawing.Point(188, 79);
            this.p_selection.Name = "p_selection";
            this.p_selection.Size = new System.Drawing.Size(516, 100);
            this.p_selection.TabIndex = 4;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(18, 116);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(317, 13);
            this.lbl_error.TabIndex = 5;
            this.lbl_error.Text = "Vos deux champs doivent correspondre et dépasser 8 caractères.";
            this.lbl_error.Visible = false;
            // 
            // verificationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p_selection);
            this.Controls.Add(this.p_modifmdp);
            this.Name = "verificationCompte";
            this.Size = new System.Drawing.Size(909, 526);
            this.p_modifmdp.ResumeLayout(false);
            this.p_modifmdp.PerformLayout();
            this.p_selection.ResumeLayout(false);
            this.p_selection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_modifmdp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mdp2;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel p_selection;
        private System.Windows.Forms.Label lbl_error;
    }
}
