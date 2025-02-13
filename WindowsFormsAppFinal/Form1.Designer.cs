namespace WindowsFormsAppFinal
{
    partial class Form1
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
            this.dgJeu = new System.Windows.Forms.DataGridView();
            this.gbNvJeu = new System.Windows.Forms.GroupBox();
            this.lblErrorPrixLettre = new System.Windows.Forms.Label();
            this.lblErrorPrix = new System.Windows.Forms.Label();
            this.yearsPicker = new System.Windows.Forms.DateTimePicker();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblAnneSortie = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAddJeu = new System.Windows.Forms.Button();
            this.statutList = new System.Windows.Forms.ComboBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.genreList = new System.Windows.Forms.ComboBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblErrorTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgJeu)).BeginInit();
            this.gbNvJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgJeu
            // 
            this.dgJeu.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgJeu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJeu.Location = new System.Drawing.Point(495, 67);
            this.dgJeu.Name = "dgJeu";
            this.dgJeu.RowHeadersWidth = 51;
            this.dgJeu.RowTemplate.Height = 24;
            this.dgJeu.Size = new System.Drawing.Size(1167, 536);
            this.dgJeu.TabIndex = 0;
            this.dgJeu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbNvJeu
            // 
            this.gbNvJeu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbNvJeu.Controls.Add(this.lblErrorTitre);
            this.gbNvJeu.Controls.Add(this.lblErrorPrixLettre);
            this.gbNvJeu.Controls.Add(this.lblErrorPrix);
            this.gbNvJeu.Controls.Add(this.yearsPicker);
            this.gbNvJeu.Controls.Add(this.lblStatut);
            this.gbNvJeu.Controls.Add(this.lblPrix);
            this.gbNvJeu.Controls.Add(this.lblAnneSortie);
            this.gbNvJeu.Controls.Add(this.lblGenre);
            this.gbNvJeu.Controls.Add(this.lblTitre);
            this.gbNvJeu.Controls.Add(this.btnAddJeu);
            this.gbNvJeu.Controls.Add(this.statutList);
            this.gbNvJeu.Controls.Add(this.txtPrix);
            this.gbNvJeu.Controls.Add(this.genreList);
            this.gbNvJeu.Controls.Add(this.txtTitre);
            this.gbNvJeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbNvJeu.Location = new System.Drawing.Point(45, 95);
            this.gbNvJeu.Name = "gbNvJeu";
            this.gbNvJeu.Size = new System.Drawing.Size(384, 498);
            this.gbNvJeu.TabIndex = 1;
            this.gbNvJeu.TabStop = false;
            this.gbNvJeu.Text = "Nouveau Jeu";
            // 
            // lblErrorPrixLettre
            // 
            this.lblErrorPrixLettre.AutoSize = true;
            this.lblErrorPrixLettre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrixLettre.Location = new System.Drawing.Point(58, 328);
            this.lblErrorPrixLettre.Name = "lblErrorPrixLettre";
            this.lblErrorPrixLettre.Size = new System.Drawing.Size(301, 20);
            this.lblErrorPrixLettre.TabIndex = 23;
            this.lblErrorPrixLettre.Text = "Le prix doit être une valeur numérique !";
            this.lblErrorPrixLettre.Visible = false;
            // 
            // lblErrorPrix
            // 
            this.lblErrorPrix.AutoSize = true;
            this.lblErrorPrix.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrix.Location = new System.Drawing.Point(69, 308);
            this.lblErrorPrix.Name = "lblErrorPrix";
            this.lblErrorPrix.Size = new System.Drawing.Size(290, 20);
            this.lblErrorPrix.TabIndex = 22;
            this.lblErrorPrix.Text = "Le prix ne peut pas etre inférieur à 0 !";
            this.lblErrorPrix.Visible = false;
            // 
            // yearsPicker
            // 
            this.yearsPicker.CustomFormat = "yyyy";
            this.yearsPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearsPicker.Location = new System.Drawing.Point(157, 209);
            this.yearsPicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.yearsPicker.Name = "yearsPicker";
            this.yearsPicker.ShowUpDown = true;
            this.yearsPicker.Size = new System.Drawing.Size(152, 26);
            this.yearsPicker.TabIndex = 16;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(6, 376);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(53, 20);
            this.lblStatut.TabIndex = 15;
            this.lblStatut.Text = "Statut";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(6, 282);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(38, 20);
            this.lblPrix.TabIndex = 14;
            this.lblPrix.Text = "Prix";
            // 
            // lblAnneSortie
            // 
            this.lblAnneSortie.AutoSize = true;
            this.lblAnneSortie.Location = new System.Drawing.Point(6, 215);
            this.lblAnneSortie.Name = "lblAnneSortie";
            this.lblAnneSortie.Size = new System.Drawing.Size(126, 20);
            this.lblAnneSortie.TabIndex = 13;
            this.lblAnneSortie.Text = "Année de sortie";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(6, 147);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(55, 20);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(6, 77);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(43, 20);
            this.lblTitre.TabIndex = 11;
            this.lblTitre.Text = "Titre";
            // 
            // btnAddJeu
            // 
            this.btnAddJeu.Location = new System.Drawing.Point(250, 439);
            this.btnAddJeu.Name = "btnAddJeu";
            this.btnAddJeu.Size = new System.Drawing.Size(109, 53);
            this.btnAddJeu.TabIndex = 2;
            this.btnAddJeu.Text = "Ajouter";
            this.btnAddJeu.UseVisualStyleBackColor = true;
            this.btnAddJeu.Click += new System.EventHandler(this.btnAddJeu_Click);
            // 
            // statutList
            // 
            this.statutList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statutList.FormattingEnabled = true;
            this.statutList.Items.AddRange(new object[] {
            "Disponible",
            "Rupture de stock",
            "Vendu"});
            this.statutList.Location = new System.Drawing.Point(157, 368);
            this.statutList.Name = "statutList";
            this.statutList.Size = new System.Drawing.Size(152, 28);
            this.statutList.TabIndex = 9;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(157, 279);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(152, 26);
            this.txtPrix.TabIndex = 8;
            this.txtPrix.TextChanged += new System.EventHandler(this.txtPrix_TextChanged);
            // 
            // genreList
            // 
            this.genreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreList.FormattingEnabled = true;
            this.genreList.Items.AddRange(new object[] {
            "Action",
            "RPG",
            "Sport"});
            this.genreList.Location = new System.Drawing.Point(157, 144);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(152, 28);
            this.genreList.TabIndex = 6;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(157, 74);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(152, 26);
            this.txtTitre.TabIndex = 5;
            this.txtTitre.TextChanged += new System.EventHandler(this.txtTitre_TextChanged);
            // 
            // lblErrorTitre
            // 
            this.lblErrorTitre.AutoSize = true;
            this.lblErrorTitre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitre.Location = new System.Drawing.Point(112, 103);
            this.lblErrorTitre.Name = "lblErrorTitre";
            this.lblErrorTitre.Size = new System.Drawing.Size(233, 20);
            this.lblErrorTitre.TabIndex = 24;
            this.lblErrorTitre.Text = "Le titre ne peut pas être vide !";
            this.lblErrorTitre.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1691, 803);
            this.Controls.Add(this.gbNvJeu);
            this.Controls.Add(this.dgJeu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgJeu)).EndInit();
            this.gbNvJeu.ResumeLayout(false);
            this.gbNvJeu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgJeu;
        private System.Windows.Forms.GroupBox gbNvJeu;
        private System.Windows.Forms.ComboBox statutList;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.ComboBox genreList;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAddJeu;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblAnneSortie;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.DateTimePicker yearsPicker;
        private System.Windows.Forms.Label lblErrorPrix;
        private System.Windows.Forms.Label lblErrorPrixLettre;
        private System.Windows.Forms.Label lblErrorTitre;
    }
}

