﻿namespace ppe3_desktop
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
            this.verificationCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermetureCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.verificationCompte1 = new ppe3_desktop.VUES.COMPTE.verificationCompte();
            this.ajouterFilm2 = new ppe3_desktop.VUES.COMPOSANT.FILM.AjouterFilm();
            this.validationCompte1 = new ppe3_desktop.VUES.COMPTE.validationCompte();
            this.modifierFilm1 = new ppe3_desktop.ModifierFilm();
            this.creationCompte1 = new ppe3_desktop.VUES.COMPTE.creationCompte();
            this.recherchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parRéférenceEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parDateAbonnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.recherchesToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.composantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fichierToolStripMenuItem.Text = "Fichier ";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validationComtpeToolStripMenuItem,
            this.verificationCompteToolStripMenuItem,
            this.fermetureCompteToolStripMenuItem,
            this.créerCompteToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // validationComtpeToolStripMenuItem
            // 
            this.validationComtpeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.validationComtpeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.validationComtpeToolStripMenuItem.Name = "validationComtpeToolStripMenuItem";
            this.validationComtpeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.validationComtpeToolStripMenuItem.Text = "Validation Compte";
            this.validationComtpeToolStripMenuItem.Click += new System.EventHandler(this.ValidationComtpeToolStripMenuItem_Click);
            // 
            // verificationCompteToolStripMenuItem
            // 
            this.verificationCompteToolStripMenuItem.Name = "verificationCompteToolStripMenuItem";
            this.verificationCompteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.verificationCompteToolStripMenuItem.Text = "Verification Compte";
            this.verificationCompteToolStripMenuItem.Click += new System.EventHandler(this.VerificationCompteToolStripMenuItem_Click);
            // 
            // fermetureCompteToolStripMenuItem
            // 
            this.fermetureCompteToolStripMenuItem.Name = "fermetureCompteToolStripMenuItem";
            this.fermetureCompteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.fermetureCompteToolStripMenuItem.Text = "Fermeture Compte";
            this.fermetureCompteToolStripMenuItem.Click += new System.EventHandler(this.FermetureCompteToolStripMenuItem_Click);
            // 
            // créerCompteToolStripMenuItem
            // 
            this.créerCompteToolStripMenuItem.Name = "créerCompteToolStripMenuItem";
            this.créerCompteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.créerCompteToolStripMenuItem.Text = "Créer Compte";
            this.créerCompteToolStripMenuItem.Click += new System.EventHandler(this.CréerCompteToolStripMenuItem_Click);
            // 
            // composantsToolStripMenuItem
            // 
            this.composantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.serieToolStripMenuItem,
            this.saisonToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.composantsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.composantsToolStripMenuItem.Name = "composantsToolStripMenuItem";
            this.composantsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.composantsToolStripMenuItem.Text = "Composants";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.genreToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ajouterToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.modifierToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1});
            this.filmToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.filmToolStripMenuItem.Text = "Film";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.ajouterToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.modifierToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // serieToolStripMenuItem
            // 
            this.serieToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.serieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.modifierToolStripMenuItem2});
            this.serieToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.serieToolStripMenuItem.Name = "serieToolStripMenuItem";
            this.serieToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.serieToolStripMenuItem.Text = "Serie";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.ajouterToolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem2
            // 
            this.modifierToolStripMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.modifierToolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
            this.modifierToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem2.Text = "Modifier";
            // 
            // saisonToolStripMenuItem
            // 
            this.saisonToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.saisonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem3,
            this.modifierToolStripMenuItem3});
            this.saisonToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saisonToolStripMenuItem.Name = "saisonToolStripMenuItem";
            this.saisonToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.saisonToolStripMenuItem.Text = "Saison";
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.BackColor = System.Drawing.SystemColors.Control;
            this.ajouterToolStripMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.ajouterToolStripMenuItem3.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem3
            // 
            this.modifierToolStripMenuItem3.BackColor = System.Drawing.SystemColors.Control;
            this.modifierToolStripMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.modifierToolStripMenuItem3.Name = "modifierToolStripMenuItem3";
            this.modifierToolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem3.Text = "Modifier";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem4,
            this.modifierToolStripMenuItem4});
            this.clientToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterToolStripMenuItem4
            // 
            this.ajouterToolStripMenuItem4.BackColor = System.Drawing.SystemColors.Control;
            this.ajouterToolStripMenuItem4.ForeColor = System.Drawing.Color.Black;
            this.ajouterToolStripMenuItem4.Name = "ajouterToolStripMenuItem4";
            this.ajouterToolStripMenuItem4.Size = new System.Drawing.Size(119, 22);
            this.ajouterToolStripMenuItem4.Text = "Ajouter";
            this.ajouterToolStripMenuItem4.Click += new System.EventHandler(this.CréerCompteToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem4
            // 
            this.modifierToolStripMenuItem4.BackColor = System.Drawing.SystemColors.Control;
            this.modifierToolStripMenuItem4.ForeColor = System.Drawing.Color.Black;
            this.modifierToolStripMenuItem4.Name = "modifierToolStripMenuItem4";
            this.modifierToolStripMenuItem4.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem4.Text = "Modifier";
            // 
            // verificationCompte1
            // 
            this.verificationCompte1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verificationCompte1.Location = new System.Drawing.Point(0, 26);
            this.verificationCompte1.Name = "verificationCompte1";
            this.verificationCompte1.Size = new System.Drawing.Size(800, 424);
            this.verificationCompte1.TabIndex = 7;
            this.verificationCompte1.Visible = false;
            // 
            // ajouterFilm2
            // 
            this.ajouterFilm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ajouterFilm2.Location = new System.Drawing.Point(0, 30);
            this.ajouterFilm2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajouterFilm2.Name = "ajouterFilm2";
            this.ajouterFilm2.Size = new System.Drawing.Size(800, 427);
            this.ajouterFilm2.TabIndex = 5;
            this.ajouterFilm2.Visible = false;
            // 
            // validationCompte1
            // 
            this.validationCompte1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationCompte1.Location = new System.Drawing.Point(0, 28);
            this.validationCompte1.Margin = new System.Windows.Forms.Padding(4);
            this.validationCompte1.Name = "validationCompte1";
            this.validationCompte1.Size = new System.Drawing.Size(800, 422);
            this.validationCompte1.TabIndex = 1;
            this.validationCompte1.Visible = false;
            // 
            // modifierFilm1
            // 
            this.modifierFilm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierFilm1.Location = new System.Drawing.Point(0, 26);
            this.modifierFilm1.Margin = new System.Windows.Forms.Padding(2);
            this.modifierFilm1.Name = "modifierFilm1";
            this.modifierFilm1.Size = new System.Drawing.Size(800, 424);
            this.modifierFilm1.TabIndex = 3;
            this.modifierFilm1.Visible = false;
            // 
            // creationCompte1
            // 
            this.creationCompte1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creationCompte1.Location = new System.Drawing.Point(0, 22);
            this.creationCompte1.Name = "creationCompte1";
            this.creationCompte1.Size = new System.Drawing.Size(800, 428);
            this.creationCompte1.TabIndex = 8;
            this.creationCompte1.Visible = false;
            // 
            // recherchesToolStripMenuItem
            // 
            this.recherchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parGenreToolStripMenuItem,
            this.parSupportToolStripMenuItem,
            this.parClientToolStripMenuItem,
            this.parRéférenceEmpruntToolStripMenuItem,
            this.parDateAbonnementToolStripMenuItem});
            this.recherchesToolStripMenuItem.Name = "recherchesToolStripMenuItem";
            this.recherchesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.recherchesToolStripMenuItem.Text = "Recherches";
            // 
            // parGenreToolStripMenuItem
            // 
            this.parGenreToolStripMenuItem.Name = "parGenreToolStripMenuItem";
            this.parGenreToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parGenreToolStripMenuItem.Text = "Par Genre";
            // 
            // parSupportToolStripMenuItem
            // 
            this.parSupportToolStripMenuItem.Name = "parSupportToolStripMenuItem";
            this.parSupportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parSupportToolStripMenuItem.Text = "Par Support";
            // 
            // parClientToolStripMenuItem
            // 
            this.parClientToolStripMenuItem.Name = "parClientToolStripMenuItem";
            this.parClientToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parClientToolStripMenuItem.Text = "Par Client";
            // 
            // parRéférenceEmpruntToolStripMenuItem
            // 
            this.parRéférenceEmpruntToolStripMenuItem.Name = "parRéférenceEmpruntToolStripMenuItem";
            this.parRéférenceEmpruntToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parRéférenceEmpruntToolStripMenuItem.Text = "Par Référence Emprunt";
            // 
            // parDateAbonnementToolStripMenuItem
            // 
            this.parDateAbonnementToolStripMenuItem.Name = "parDateAbonnementToolStripMenuItem";
            this.parDateAbonnementToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parDateAbonnementToolStripMenuItem.Text = "Par date Abonnement";
            // 
            // controleur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ajouterFilm2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.verificationCompte1);
            this.Controls.Add(this.validationCompte1);
            this.Controls.Add(this.modifierFilm1);
            this.Controls.Add(this.creationCompte1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "controleur";
            this.Text = "Videothèque - Accès Administrateur";
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
        private System.Windows.Forms.ToolStripMenuItem verificationCompteToolStripMenuItem;
        private VUES.COMPTE.verificationCompte verificationCompte1;
        private System.Windows.Forms.ToolStripMenuItem fermetureCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerCompteToolStripMenuItem;
        private VUES.COMPTE.creationCompte creationCompte1;
        private System.Windows.Forms.ToolStripMenuItem recherchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parRéférenceEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parDateAbonnementToolStripMenuItem;
    }
}

