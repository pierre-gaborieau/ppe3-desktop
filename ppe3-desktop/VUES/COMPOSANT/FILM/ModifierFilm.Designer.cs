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
            this.idSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreSupportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pPE3_GABORIEAU_LAUGEREDataSet = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.filmTableAdapter();
            this.supportTableAdapter = new ppe3_desktop.PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.supportTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.realisateur = new System.Windows.Forms.TextBox();
            this.titreSupport = new System.Windows.Forms.TextBox();
            this.idSupport = new System.Windows.Forms.NumericUpDown();
            this.image = new System.Windows.Forms.TextBox();
            this.lesGenresCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListeFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GABORIEAU_LAUGEREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeFilm
            // 
            this.ListeFilm.AllowUserToAddRows = false;
            this.ListeFilm.AllowUserToDeleteRows = false;
            this.ListeFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.ListeFilm.Margin = new System.Windows.Forms.Padding(2);
            this.ListeFilm.MultiSelect = false;
            this.ListeFilm.Name = "ListeFilm";
            this.ListeFilm.ReadOnly = true;
            this.ListeFilm.RowHeadersWidth = 51;
            this.ListeFilm.RowTemplate.Height = 24;
            this.ListeFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListeFilm.Size = new System.Drawing.Size(543, 177);
            this.ListeFilm.TabIndex = 0;
            this.ListeFilm.SelectionChanged += new System.EventHandler(this.ListeFilm_SelectionChanged);
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
            // realisateur
            // 
            this.realisateur.Location = new System.Drawing.Point(6, 249);
            this.realisateur.Name = "realisateur";
            this.realisateur.Size = new System.Drawing.Size(100, 20);
            this.realisateur.TabIndex = 4;
            // 
            // titreSupport
            // 
            this.titreSupport.Location = new System.Drawing.Point(6, 223);
            this.titreSupport.Name = "titreSupport";
            this.titreSupport.Size = new System.Drawing.Size(100, 20);
            this.titreSupport.TabIndex = 5;
            // 
            // idSupport
            // 
            this.idSupport.Location = new System.Drawing.Point(6, 197);
            this.idSupport.Name = "idSupport";
            this.idSupport.ReadOnly = true;
            this.idSupport.Size = new System.Drawing.Size(120, 20);
            this.idSupport.TabIndex = 6;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(6, 275);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(100, 20);
            this.image.TabIndex = 7;
            // 
            // lesGenresCombo
            // 
            this.lesGenresCombo.FormattingEnabled = true;
            this.lesGenresCombo.Location = new System.Drawing.Point(6, 301);
            this.lesGenresCombo.Name = "lesGenresCombo";
            this.lesGenresCombo.Size = new System.Drawing.Size(121, 21);
            this.lesGenresCombo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "id Support";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Titre du film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Réalisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Genre";
            // 
            // ModifierFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lesGenresCombo);
            this.Controls.Add(this.image);
            this.Controls.Add(this.idSupport);
            this.Controls.Add(this.titreSupport);
            this.Controls.Add(this.realisateur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListeFilm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifierFilm";
            this.Size = new System.Drawing.Size(548, 395);
            ((System.ComponentModel.ISupportInitialize)(this.ListeFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPE3_GABORIEAU_LAUGEREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSupport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListeFilm;
        private System.Windows.Forms.BindingSource supportBindingSource1;
        private PPE3_GABORIEAU_LAUGEREDataSet pPE3_GABORIEAU_LAUGEREDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.filmTableAdapter filmTableAdapter;
        private PPE3_GABORIEAU_LAUGEREDataSetTableAdapters.supportTableAdapter supportTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreSupportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox realisateur;
        private System.Windows.Forms.TextBox titreSupport;
        private System.Windows.Forms.NumericUpDown idSupport;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.ComboBox lesGenresCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
