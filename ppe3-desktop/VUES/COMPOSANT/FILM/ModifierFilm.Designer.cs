namespace ppe3_desktop
{
    partial class ModifierFilm
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
            this.ListeFilm = new System.Windows.Forms.DataGridView();
            this.pPE3_GABORIEAU_LAUGEREDataSet = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.filmTableAdapter();
            this.supportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supportTableAdapter = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.supportTableAdapter();
            this.supportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListeFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GABORIEAU_LAUGEREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeFilm
            // 
            this.ListeFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeFilm.AutoGenerateColumns = false;
            this.ListeFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSupportDataGridViewTextBoxColumn,
            this.titreSupportDataGridViewTextBoxColumn,
            this.realisateurDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.idGenreDataGridViewTextBoxColumn});
            this.ListeFilm.DataSource = this.supportBindingSource1;
            this.ListeFilm.Location = new System.Drawing.Point(3, 3);
            this.ListeFilm.Name = "ListeFilm";
            this.ListeFilm.RowHeadersWidth = 51;
            this.ListeFilm.RowTemplate.Height = 24;
            this.ListeFilm.Size = new System.Drawing.Size(724, 234);
            this.ListeFilm.TabIndex = 0;
            // 
            // pPE3_GABORIEAU_LAUGEREDataSet
            // 
            this.pPE3_GABORIEAU_LAUGEREDataSet.DataSetName = "PPE3_GABORIEAU_LAUGEREDataSet";
            this.pPE3_GABORIEAU_LAUGEREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "film";
            this.filmBindingSource.DataSource = this.pPE3_GABORIEAU_LAUGEREDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
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
            // supportBindingSource1
            // 
            this.supportBindingSource1.DataMember = "support";
            this.supportBindingSource1.DataSource = this.pPE3_GABORIEAU_LAUGEREDataSet;
            // 
            // idSupportDataGridViewTextBoxColumn
            // 
            this.idSupportDataGridViewTextBoxColumn.DataPropertyName = "idSupport";
            this.idSupportDataGridViewTextBoxColumn.HeaderText = "idSupport";
            this.idSupportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSupportDataGridViewTextBoxColumn.Name = "idSupportDataGridViewTextBoxColumn";
            this.idSupportDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSupportDataGridViewTextBoxColumn.Width = 125;
            // 
            // titreSupportDataGridViewTextBoxColumn
            // 
            this.titreSupportDataGridViewTextBoxColumn.DataPropertyName = "titreSupport";
            this.titreSupportDataGridViewTextBoxColumn.HeaderText = "titreSupport";
            this.titreSupportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titreSupportDataGridViewTextBoxColumn.Name = "titreSupportDataGridViewTextBoxColumn";
            this.titreSupportDataGridViewTextBoxColumn.Width = 125;
            // 
            // realisateurDataGridViewTextBoxColumn
            // 
            this.realisateurDataGridViewTextBoxColumn.DataPropertyName = "realisateur";
            this.realisateurDataGridViewTextBoxColumn.HeaderText = "realisateur";
            this.realisateurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.realisateurDataGridViewTextBoxColumn.Name = "realisateurDataGridViewTextBoxColumn";
            this.realisateurDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.Width = 125;
            // 
            // idGenreDataGridViewTextBoxColumn
            // 
            this.idGenreDataGridViewTextBoxColumn.DataPropertyName = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.HeaderText = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGenreDataGridViewTextBoxColumn.Name = "idGenreDataGridViewTextBoxColumn";
            this.idGenreDataGridViewTextBoxColumn.Width = 125;
            // 
            // ModifierFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListeFilm);
            this.Name = "ModifierFilm";
            this.Size = new System.Drawing.Size(730, 473);
            ((System.ComponentModel.ISupportInitialize)(this.ListeFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GABORIEAU_LAUGEREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListeFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supportBindingSource1;
        private PPE3_GABORIEAU_LAUGEREDataSet pPE3_GABORIEAU_LAUGEREDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.filmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource supportBindingSource;
        private PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.supportTableAdapter supportTableAdapter;
    }
}
