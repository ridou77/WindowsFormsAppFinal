namespace WindowsFormsAppFinal
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUpdateTitre = new System.Windows.Forms.Label();
            this.lblUpdateGenre = new System.Windows.Forms.Label();
            this.txtUpdateTitre = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.lblErrorPrixLettreUpdate = new System.Windows.Forms.Label();
            this.statutList = new System.Windows.Forms.ComboBox();
            this.yearsPicker = new System.Windows.Forms.DateTimePicker();
            this.genreList = new System.Windows.Forms.ComboBox();
            this.lblErrorPrix = new System.Windows.Forms.Label();
            this.txtUpdatePrix = new System.Windows.Forms.TextBox();
            this.lblUpdateStatut = new System.Windows.Forms.Label();
            this.lblUpdatePrix = new System.Windows.Forms.Label();
            this.lblUpdateYears = new System.Windows.Forms.Label();
            this.lblErrorTitreUpdate = new System.Windows.Forms.Label();
            this.btnAnnulModif = new System.Windows.Forms.Button();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdateTitre
            // 
            this.lblUpdateTitre.AutoSize = true;
            this.lblUpdateTitre.Location = new System.Drawing.Point(160, 104);
            this.lblUpdateTitre.Name = "lblUpdateTitre";
            this.lblUpdateTitre.Size = new System.Drawing.Size(121, 24);
            this.lblUpdateTitre.TabIndex = 0;
            this.lblUpdateTitre.Text = "Nouveau titre";
            // 
            // lblUpdateGenre
            // 
            this.lblUpdateGenre.AutoSize = true;
            this.lblUpdateGenre.Location = new System.Drawing.Point(160, 166);
            this.lblUpdateGenre.Name = "lblUpdateGenre";
            this.lblUpdateGenre.Size = new System.Drawing.Size(142, 24);
            this.lblUpdateGenre.TabIndex = 1;
            this.lblUpdateGenre.Text = "Nouveau genre";
            // 
            // txtUpdateTitre
            // 
            this.txtUpdateTitre.Location = new System.Drawing.Point(372, 100);
            this.txtUpdateTitre.Name = "txtUpdateTitre";
            this.txtUpdateTitre.Size = new System.Drawing.Size(156, 28);
            this.txtUpdateTitre.TabIndex = 2;
            this.txtUpdateTitre.TextChanged += new System.EventHandler(this.txtUpdateTitre_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(598, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 47);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbUpdate
            // 
            this.gbUpdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbUpdate.Controls.Add(this.btnAnnulModif);
            this.gbUpdate.Controls.Add(this.lblErrorTitreUpdate);
            this.gbUpdate.Controls.Add(this.lblErrorPrixLettreUpdate);
            this.gbUpdate.Controls.Add(this.statutList);
            this.gbUpdate.Controls.Add(this.yearsPicker);
            this.gbUpdate.Controls.Add(this.genreList);
            this.gbUpdate.Controls.Add(this.lblErrorPrix);
            this.gbUpdate.Controls.Add(this.txtUpdatePrix);
            this.gbUpdate.Controls.Add(this.lblUpdateStatut);
            this.gbUpdate.Controls.Add(this.lblUpdatePrix);
            this.gbUpdate.Controls.Add(this.lblUpdateYears);
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Controls.Add(this.lblUpdateGenre);
            this.gbUpdate.Controls.Add(this.txtUpdateTitre);
            this.gbUpdate.Controls.Add(this.lblUpdateTitre);
            this.gbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbUpdate.Location = new System.Drawing.Point(301, 106);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(900, 444);
            this.gbUpdate.TabIndex = 5;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Modification du Jeu";
            // 
            // lblErrorPrixLettreUpdate
            // 
            this.lblErrorPrixLettreUpdate.AutoSize = true;
            this.lblErrorPrixLettreUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrixLettreUpdate.Location = new System.Drawing.Point(534, 296);
            this.lblErrorPrixLettreUpdate.Name = "lblErrorPrixLettreUpdate";
            this.lblErrorPrixLettreUpdate.Size = new System.Drawing.Size(340, 24);
            this.lblErrorPrixLettreUpdate.TabIndex = 24;
            this.lblErrorPrixLettreUpdate.Text = "Le prix doit être une valeur numérique !";
            this.lblErrorPrixLettreUpdate.Visible = false;
            // 
            // statutList
            // 
            this.statutList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statutList.FormattingEnabled = true;
            this.statutList.Items.AddRange(new object[] {
            "Disponible",
            "Rupture de stock",
            "Vendu"});
            this.statutList.Location = new System.Drawing.Point(372, 321);
            this.statutList.Name = "statutList";
            this.statutList.Size = new System.Drawing.Size(152, 30);
            this.statutList.TabIndex = 18;
            // 
            // yearsPicker
            // 
            this.yearsPicker.CustomFormat = "yyyy";
            this.yearsPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearsPicker.Location = new System.Drawing.Point(372, 222);
            this.yearsPicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.yearsPicker.Name = "yearsPicker";
            this.yearsPicker.ShowUpDown = true;
            this.yearsPicker.Size = new System.Drawing.Size(152, 28);
            this.yearsPicker.TabIndex = 17;
            // 
            // genreList
            // 
            this.genreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreList.FormattingEnabled = true;
            this.genreList.Items.AddRange(new object[] {
            "Action",
            "RPG",
            "Sport"});
            this.genreList.Location = new System.Drawing.Point(372, 166);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(152, 30);
            this.genreList.TabIndex = 16;
            // 
            // lblErrorPrix
            // 
            this.lblErrorPrix.AutoSize = true;
            this.lblErrorPrix.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrix.Location = new System.Drawing.Point(534, 262);
            this.lblErrorPrix.Name = "lblErrorPrix";
            this.lblErrorPrix.Size = new System.Drawing.Size(321, 24);
            this.lblErrorPrix.TabIndex = 14;
            this.lblErrorPrix.Text = "Le prix ne peut pas être inferieur à 0 !";
            this.lblErrorPrix.Visible = false;
            // 
            // txtUpdatePrix
            // 
            this.txtUpdatePrix.Location = new System.Drawing.Point(372, 278);
            this.txtUpdatePrix.Name = "txtUpdatePrix";
            this.txtUpdatePrix.Size = new System.Drawing.Size(156, 28);
            this.txtUpdatePrix.TabIndex = 9;
            this.txtUpdatePrix.TextChanged += new System.EventHandler(this.txtUpdatePrix_TextChanged);
            // 
            // lblUpdateStatut
            // 
            this.lblUpdateStatut.AutoSize = true;
            this.lblUpdateStatut.Location = new System.Drawing.Point(160, 324);
            this.lblUpdateStatut.Name = "lblUpdateStatut";
            this.lblUpdateStatut.Size = new System.Drawing.Size(134, 24);
            this.lblUpdateStatut.TabIndex = 7;
            this.lblUpdateStatut.Text = "Nouveau statut";
            // 
            // lblUpdatePrix
            // 
            this.lblUpdatePrix.AutoSize = true;
            this.lblUpdatePrix.Location = new System.Drawing.Point(160, 278);
            this.lblUpdatePrix.Name = "lblUpdatePrix";
            this.lblUpdatePrix.Size = new System.Drawing.Size(123, 24);
            this.lblUpdatePrix.TabIndex = 6;
            this.lblUpdatePrix.Text = "Nouveau prix";
            // 
            // lblUpdateYears
            // 
            this.lblUpdateYears.AutoSize = true;
            this.lblUpdateYears.Location = new System.Drawing.Point(160, 222);
            this.lblUpdateYears.Name = "lblUpdateYears";
            this.lblUpdateYears.Size = new System.Drawing.Size(144, 24);
            this.lblUpdateYears.TabIndex = 5;
            this.lblUpdateYears.Text = "Année de sortie";
            // 
            // lblErrorTitreUpdate
            // 
            this.lblErrorTitreUpdate.AutoSize = true;
            this.lblErrorTitreUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitreUpdate.Location = new System.Drawing.Point(534, 104);
            this.lblErrorTitreUpdate.Name = "lblErrorTitreUpdate";
            this.lblErrorTitreUpdate.Size = new System.Drawing.Size(256, 24);
            this.lblErrorTitreUpdate.TabIndex = 25;
            this.lblErrorTitreUpdate.Text = "Le titre ne peut pas être vide !";
            this.lblErrorTitreUpdate.Visible = false;
            // 
            // btnAnnulModif
            // 
            this.btnAnnulModif.Location = new System.Drawing.Point(749, 370);
            this.btnAnnulModif.Name = "btnAnnulModif";
            this.btnAnnulModif.Size = new System.Drawing.Size(125, 47);
            this.btnAnnulModif.TabIndex = 26;
            this.btnAnnulModif.Text = "Annuler";
            this.btnAnnulModif.UseVisualStyleBackColor = true;
            this.btnAnnulModif.Click += new System.EventHandler(this.btnAnnulModif_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1451, 680);
            this.Controls.Add(this.gbUpdate);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateTitre;
        private System.Windows.Forms.Label lblUpdateGenre;
        private System.Windows.Forms.TextBox txtUpdateTitre;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.TextBox txtUpdatePrix;
        private System.Windows.Forms.Label lblUpdateStatut;
        private System.Windows.Forms.Label lblUpdatePrix;
        private System.Windows.Forms.Label lblUpdateYears;
        private System.Windows.Forms.Label lblErrorPrix;
        private System.Windows.Forms.ComboBox genreList;
        private System.Windows.Forms.DateTimePicker yearsPicker;
        private System.Windows.Forms.ComboBox statutList;
        private System.Windows.Forms.Label lblErrorPrixLettreUpdate;
        private System.Windows.Forms.Label lblErrorTitreUpdate;
        private System.Windows.Forms.Button btnAnnulModif;
    }
}