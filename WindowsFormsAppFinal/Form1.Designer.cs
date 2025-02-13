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
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.genreList = new System.Windows.Forms.ComboBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.statutList = new System.Windows.Forms.ComboBox();
            this.btnAddJeu = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAnneSortie = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.yearsPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgJeu)).BeginInit();
            this.gbNvJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgJeu
            // 
            this.dgJeu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJeu.Location = new System.Drawing.Point(699, 96);
            this.dgJeu.Name = "dgJeu";
            this.dgJeu.RowHeadersWidth = 51;
            this.dgJeu.RowTemplate.Height = 24;
            this.dgJeu.Size = new System.Drawing.Size(659, 501);
            this.dgJeu.TabIndex = 0;
            this.dgJeu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbNvJeu
            // 
            this.gbNvJeu.BackColor = System.Drawing.Color.FloralWhite;
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
            this.gbNvJeu.Location = new System.Drawing.Point(59, 96);
            this.gbNvJeu.Name = "gbNvJeu";
            this.gbNvJeu.Size = new System.Drawing.Size(505, 501);
            this.gbNvJeu.TabIndex = 1;
            this.gbNvJeu.TabStop = false;
            this.gbNvJeu.Text = "Nouveau Jeu";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(249, 74);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(152, 26);
            this.txtTitre.TabIndex = 5;
            this.txtTitre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // genreList
            // 
            this.genreList.FormattingEnabled = true;
            this.genreList.Items.AddRange(new object[] {
            "Action",
            "RPG",
            "Sport"});
            this.genreList.Location = new System.Drawing.Point(249, 144);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(152, 28);
            this.genreList.TabIndex = 6;
            this.genreList.SelectedIndexChanged += new System.EventHandler(this.genreList_SelectedIndexChanged);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(249, 263);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(152, 26);
            this.txtPrix.TabIndex = 8;
            // 
            // statutList
            // 
            this.statutList.FormattingEnabled = true;
            this.statutList.Items.AddRange(new object[] {
            "Disponible",
            "Rupture de stock",
            "Vendu"});
            this.statutList.Location = new System.Drawing.Point(249, 327);
            this.statutList.Name = "statutList";
            this.statutList.Size = new System.Drawing.Size(152, 28);
            this.statutList.TabIndex = 9;
            this.statutList.SelectedIndexChanged += new System.EventHandler(this.statutList_SelectedIndexChanged);
            // 
            // btnAddJeu
            // 
            this.btnAddJeu.Location = new System.Drawing.Point(304, 405);
            this.btnAddJeu.Name = "btnAddJeu";
            this.btnAddJeu.Size = new System.Drawing.Size(144, 66);
            this.btnAddJeu.TabIndex = 2;
            this.btnAddJeu.Text = "Ajouter";
            this.btnAddJeu.UseVisualStyleBackColor = true;
            this.btnAddJeu.Click += new System.EventHandler(this.btnAddJeu_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(84, 77);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(43, 20);
            this.lblTitre.TabIndex = 11;
            this.lblTitre.Text = "Titre";
            this.lblTitre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(84, 147);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(55, 20);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            // 
            // lblAnneSortie
            // 
            this.lblAnneSortie.AutoSize = true;
            this.lblAnneSortie.Location = new System.Drawing.Point(84, 209);
            this.lblAnneSortie.Name = "lblAnneSortie";
            this.lblAnneSortie.Size = new System.Drawing.Size(126, 20);
            this.lblAnneSortie.TabIndex = 13;
            this.lblAnneSortie.Text = "Année de sortie";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(84, 266);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(38, 20);
            this.lblPrix.TabIndex = 14;
            this.lblPrix.Text = "Prix";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(84, 330);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(53, 20);
            this.lblStatut.TabIndex = 15;
            this.lblStatut.Text = "Statut";
            // 
            // yearsPicker
            // 
            this.yearsPicker.CustomFormat = "yyyy";
            this.yearsPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearsPicker.Location = new System.Drawing.Point(249, 209);
            this.yearsPicker.Name = "yearsPicker";
            this.yearsPicker.ShowUpDown = true;
            this.yearsPicker.Size = new System.Drawing.Size(152, 26);
            this.yearsPicker.TabIndex = 16;
            this.yearsPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1455, 675);
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
    }
}

