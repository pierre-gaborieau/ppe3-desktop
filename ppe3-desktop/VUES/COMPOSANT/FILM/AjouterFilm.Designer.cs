namespace ppe3_desktop.VUES.COMPOSANT.FILM
{
    partial class AjouterFilm
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
            this.components = new System.ComponentModel.Container();
            this.TitleMovie = new System.Windows.Forms.TextBox();
            this.RealMovie = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddMovie = new System.Windows.Forms.Button();
            this.pPE3_GABORIEAU_LAUGEREDataSet = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSet();
            this.supportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supportTableAdapter = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.supportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GABORIEAU_LAUGEREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleMovie
            // 
            this.TitleMovie.Location = new System.Drawing.Point(3, 3);
            this.TitleMovie.Name = "TitleMovie";
            this.TitleMovie.Size = new System.Drawing.Size(271, 22);
            this.TitleMovie.TabIndex = 0;
            // 
            // RealMovie
            // 
            this.RealMovie.Location = new System.Drawing.Point(3, 31);
            this.RealMovie.Name = "RealMovie";
            this.RealMovie.Size = new System.Drawing.Size(271, 22);
            this.RealMovie.TabIndex = 1;
            // 
            // GenreBox
            // 
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Location = new System.Drawing.Point(3, 59);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(121, 24);
            this.GenreBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titre du film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Réalisateur du film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre";
            // 
            // AddMovie
            // 
            this.AddMovie.Location = new System.Drawing.Point(3, 89);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(75, 23);
            this.AddMovie.TabIndex = 6;
            this.AddMovie.Text = "Ajouter";
            this.AddMovie.UseVisualStyleBackColor = true;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // pPE3_GABORIEAU_LAUGEREDataSet
            // 
            this.pPE3_GABORIEAU_LAUGEREDataSet.DataSetName = "PPE3_GABORIEAU_LAUGEREDataSet";
            this.pPE3_GABORIEAU_LAUGEREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supportBindingSource
            // 
            this.supportBindingSource.DataMember = "support";
            this.supportBindingSource.DataSource = this.pPE3_GABORIEAU_LAUGEREDataSet;
            // 
            // supportTableAdapter
            // 
            this.supportTableAdapter.ClearBeforeFill = true;
            // 
            // AjouterFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddMovie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.RealMovie);
            this.Controls.Add(this.TitleMovie);
            this.Name = "AjouterFilm";
            this.Size = new System.Drawing.Size(972, 526);
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GABORIEAU_LAUGEREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleMovie;
        private System.Windows.Forms.TextBox RealMovie;
        private System.Windows.Forms.ComboBox GenreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.BindingSource supportBindingSource;
        private PPE3_GABORIEAU_LAUGEREDataSet pPE3_GABORIEAU_LAUGEREDataSet;
        private PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.supportTableAdapter supportTableAdapter;
    }
}
