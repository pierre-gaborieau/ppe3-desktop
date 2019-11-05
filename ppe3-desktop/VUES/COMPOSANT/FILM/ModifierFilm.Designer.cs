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
            this.supportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GABORIEAU_LAUGEREDataSet = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.filmTableAdapter();
            this.supportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supportTableAdapter = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.supportTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.Label();
            this.idSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListeFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GABORIEAU_LAUGEREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeFilm
            // 
            this.ListeFilm.AllowUserToAddRows = false;
            this.ListeFilm.AllowUserToDeleteRows = false;
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
            this.ListeFilm.Location = new System.Drawing.Point(2, 2);
            this.ListeFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListeFilm.MultiSelect = false;
            this.ListeFilm.Name = "ListeFilm";
            this.ListeFilm.ReadOnly = true;
            this.ListeFilm.RowHeadersWidth = 51;
            this.ListeFilm.RowTemplate.Height = 24;
            this.ListeFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListeFilm.Size = new System.Drawing.Size(543, 190);
            this.ListeFilm.TabIndex = 0;
            this.ListeFilm.SelectionChanged += new System.EventHandler(this.ListeFilm_SelectionChanged);
            // 
            // supportBindingSource1
            // 
            this.supportBindingSource1.DataMember = "support";
            this.supportBindingSource1.DataSource = this.pPE3_GABORIEAU_LAUGEREDataSet;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Location = new System.Drawing.Point(3, 342);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(10, 13);
            this.movieTitle.TabIndex = 3;
            this.movieTitle.Text = "-";
            // 
            // idSupportDataGridViewTextBoxColumn
            // 
            this.idSupportDataGridViewTextBoxColumn.DataPropertyName = "idSupport";
            this.idSupportDataGridViewTextBoxColumn.HeaderText = "idSupport";
            this.idSupportDataGridViewTextBoxColumn.Name = "idSupportDataGridViewTextBoxColumn";
            this.idSupportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titreSupportDataGridViewTextBoxColumn
            // 
            this.titreSupportDataGridViewTextBoxColumn.DataPropertyName = "titreSupport";
            this.titreSupportDataGridViewTextBoxColumn.HeaderText = "titreSupport";
            this.titreSupportDataGridViewTextBoxColumn.Name = "titreSupportDataGridViewTextBoxColumn";
            this.titreSupportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realisateurDataGridViewTextBoxColumn
            // 
            this.realisateurDataGridViewTextBoxColumn.DataPropertyName = "realisateur";
            this.realisateurDataGridViewTextBoxColumn.HeaderText = "realisateur";
            this.realisateurDataGridViewTextBoxColumn.Name = "realisateurDataGridViewTextBoxColumn";
            this.realisateurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idGenreDataGridViewTextBoxColumn
            // 
            this.idGenreDataGridViewTextBoxColumn.DataPropertyName = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.HeaderText = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.Name = "idGenreDataGridViewTextBoxColumn";
            this.idGenreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ModifierFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListeFilm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifierFilm";
            this.Size = new System.Drawing.Size(548, 384);
            ((System.ComponentModel.ISupportInitialize)(this.ListeFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GABORIEAU_LAUGEREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListeFilm;
        private System.Windows.Forms.BindingSource supportBindingSource1;
        private PPE3_GABORIEAU_LAUGEREDataSet pPE3_GABORIEAU_LAUGEREDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.filmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource supportBindingSource;
        private PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.supportTableAdapter supportTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenreDataGridViewTextBoxColumn;
    }
}
