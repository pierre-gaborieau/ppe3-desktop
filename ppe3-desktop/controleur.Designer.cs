namespace ppe3_desktop
{
    partial class controleur
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validationComtpeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.composantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterFilm2 = new ppe3_desktop.VUES.COMPOSANT.FILM.AjouterFilm();
            this.modifierFilm1 = new ppe3_desktop.ModifierFilm();
            this.validationCompte1 = new ppe3_desktop.VUES.COMPTE.validationCompte();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.composantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.fichierToolStripMenuItem.Text = "Fichier ";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validationComtpeToolStripMenuItem});
            this.compteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // validationComtpeToolStripMenuItem
            // 
            this.validationComtpeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.validationComtpeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.validationComtpeToolStripMenuItem.Name = "validationComtpeToolStripMenuItem";
            this.validationComtpeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.validationComtpeToolStripMenuItem.Text = "Validation Compte";
            this.validationComtpeToolStripMenuItem.Click += new System.EventHandler(this.ValidationComtpeToolStripMenuItem_Click);
            // 
            // composantsToolStripMenuItem
            // 
            this.composantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.serieToolStripMenuItem,
            this.saisonToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.composantsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.composantsToolStripMenuItem.Name = "composantsToolStripMenuItem";
            this.composantsToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.composantsToolStripMenuItem.Text = "Composants";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.genreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ajouterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.modifierToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1});
            this.filmToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.filmToolStripMenuItem.Text = "Film";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ajouterToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.modifierToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // serieToolStripMenuItem
            // 
            this.serieToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.serieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.modifierToolStripMenuItem2});
            this.serieToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.serieToolStripMenuItem.Name = "serieToolStripMenuItem";
            this.serieToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.serieToolStripMenuItem.Text = "Serie";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ajouterToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(149, 26);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem2
            // 
            this.modifierToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.modifierToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
            this.modifierToolStripMenuItem2.Size = new System.Drawing.Size(149, 26);
            this.modifierToolStripMenuItem2.Text = "Modifier";
            // 
            // saisonToolStripMenuItem
            // 
            this.saisonToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.saisonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem3,
            this.modifierToolStripMenuItem3});
            this.saisonToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saisonToolStripMenuItem.Name = "saisonToolStripMenuItem";
            this.saisonToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.saisonToolStripMenuItem.Text = "Saison";
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ajouterToolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(149, 26);
            this.ajouterToolStripMenuItem3.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem3
            // 
            this.modifierToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.modifierToolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.modifierToolStripMenuItem3.Name = "modifierToolStripMenuItem3";
            this.modifierToolStripMenuItem3.Size = new System.Drawing.Size(149, 26);
            this.modifierToolStripMenuItem3.Text = "Modifier";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem4,
            this.modifierToolStripMenuItem4});
            this.clientToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterToolStripMenuItem4
            // 
            this.ajouterToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ajouterToolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.ajouterToolStripMenuItem4.Name = "ajouterToolStripMenuItem4";
            this.ajouterToolStripMenuItem4.Size = new System.Drawing.Size(149, 26);
            this.ajouterToolStripMenuItem4.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem4
            // 
            this.modifierToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.modifierToolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.modifierToolStripMenuItem4.Name = "modifierToolStripMenuItem4";
            this.modifierToolStripMenuItem4.Size = new System.Drawing.Size(149, 26);
            this.modifierToolStripMenuItem4.Text = "Modifier";
            // 
            // ajouterFilm2
            // 
            this.ajouterFilm2.Location = new System.Drawing.Point(0, 42);
            this.ajouterFilm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ajouterFilm2.Name = "ajouterFilm2";
            this.ajouterFilm2.Size = new System.Drawing.Size(1423, 647);
            this.ajouterFilm2.TabIndex = 5;
            this.ajouterFilm2.Visible = false;
            // 
            // modifierFilm1
            // 
            this.modifierFilm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierFilm1.Location = new System.Drawing.Point(0, 34);
            this.modifierFilm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifierFilm1.Name = "modifierFilm1";
            this.modifierFilm1.Size = new System.Drawing.Size(1067, 522);
            this.modifierFilm1.TabIndex = 3;
            this.modifierFilm1.Visible = false;
            // 
            // validationCompte1
            // 
            this.validationCompte1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationCompte1.Location = new System.Drawing.Point(0, 34);
            this.validationCompte1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.validationCompte1.Name = "validationCompte1";
            this.validationCompte1.Size = new System.Drawing.Size(1067, 519);
            this.validationCompte1.TabIndex = 1;
            this.validationCompte1.Visible = false;
            // 
            // controleur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ajouterFilm2);
            this.Controls.Add(this.modifierFilm1);
            this.Controls.Add(this.validationCompte1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "controleur";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validationComtpeToolStripMenuItem;
        private VUES.COMPTE.validationCompte validationCompte1;
        private VUES.COMPOSANT.FILM.AjouterFilm ajouterFilm1;
        private System.Windows.Forms.ToolStripMenuItem composantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem4;
        private ModifierFilm modifierFilm1;
        private VUES.COMPOSANT.FILM.AjouterFilm ajouterFilm2;
        private System.Windows.Forms.ToolStripMenuItem veriificationCompteToolStripMenuItem;
        private VUES.COMPTE.verificationCompte verificationCompte1;
    }
}

