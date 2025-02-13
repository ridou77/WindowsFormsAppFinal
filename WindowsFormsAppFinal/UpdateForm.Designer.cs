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
            this.txtUpdateGenre = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.lblUpdateYears = new System.Windows.Forms.Label();
            this.lblUpdatePrix = new System.Windows.Forms.Label();
            this.lblUpdateStatut = new System.Windows.Forms.Label();
            this.txtUpdateYears = new System.Windows.Forms.TextBox();
            this.txtUpdatePrix = new System.Windows.Forms.TextBox();
            this.txtUpdateStatut = new System.Windows.Forms.TextBox();
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
            // 
            // txtUpdateGenre
            // 
            this.txtUpdateGenre.Location = new System.Drawing.Point(372, 163);
            this.txtUpdateGenre.Name = "txtUpdateGenre";
            this.txtUpdateGenre.Size = new System.Drawing.Size(156, 28);
            this.txtUpdateGenre.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(643, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 53);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.txtUpdateStatut);
            this.gbUpdate.Controls.Add(this.txtUpdatePrix);
            this.gbUpdate.Controls.Add(this.txtUpdateYears);
            this.gbUpdate.Controls.Add(this.lblUpdateStatut);
            this.gbUpdate.Controls.Add(this.lblUpdatePrix);
            this.gbUpdate.Controls.Add(this.lblUpdateYears);
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Controls.Add(this.lblUpdateGenre);
            this.gbUpdate.Controls.Add(this.txtUpdateTitre);
            this.gbUpdate.Controls.Add(this.lblUpdateTitre);
            this.gbUpdate.Controls.Add(this.txtUpdateGenre);
            this.gbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbUpdate.Location = new System.Drawing.Point(280, 69);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(872, 444);
            this.gbUpdate.TabIndex = 5;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Modification du Jeu";
            // 
            // lblUpdateYears
            // 
            this.lblUpdateYears.AutoSize = true;
            this.lblUpdateYears.Location = new System.Drawing.Point(160, 222);
            this.lblUpdateYears.Name = "lblUpdateYears";
            this.lblUpdateYears.Size = new System.Drawing.Size(144, 24);
            this.lblUpdateYears.TabIndex = 5;
            this.lblUpdateYears.Text = "Année de sortie";
            this.lblUpdateYears.Click += new System.EventHandler(this.label1_Click);
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
            // lblUpdateStatut
            // 
            this.lblUpdateStatut.AutoSize = true;
            this.lblUpdateStatut.Location = new System.Drawing.Point(160, 324);
            this.lblUpdateStatut.Name = "lblUpdateStatut";
            this.lblUpdateStatut.Size = new System.Drawing.Size(134, 24);
            this.lblUpdateStatut.TabIndex = 7;
            this.lblUpdateStatut.Text = "Nouveau statut";
            // 
            // txtUpdateYears
            // 
            this.txtUpdateYears.Location = new System.Drawing.Point(372, 218);
            this.txtUpdateYears.Name = "txtUpdateYears";
            this.txtUpdateYears.Size = new System.Drawing.Size(156, 28);
            this.txtUpdateYears.TabIndex = 8;
            // 
            // txtUpdatePrix
            // 
            this.txtUpdatePrix.Location = new System.Drawing.Point(372, 278);
            this.txtUpdatePrix.Name = "txtUpdatePrix";
            this.txtUpdatePrix.Size = new System.Drawing.Size(156, 28);
            this.txtUpdatePrix.TabIndex = 9;
            // 
            // txtUpdateStatut
            // 
            this.txtUpdateStatut.Location = new System.Drawing.Point(372, 324);
            this.txtUpdateStatut.Name = "txtUpdateStatut";
            this.txtUpdateStatut.Size = new System.Drawing.Size(156, 28);
            this.txtUpdateStatut.TabIndex = 10;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 680);
            this.Controls.Add(this.gbUpdate);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateTitre;
        private System.Windows.Forms.Label lblUpdateGenre;
        private System.Windows.Forms.TextBox txtUpdateTitre;
        private System.Windows.Forms.TextBox txtUpdateGenre;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.TextBox txtUpdateStatut;
        private System.Windows.Forms.TextBox txtUpdatePrix;
        private System.Windows.Forms.TextBox txtUpdateYears;
        private System.Windows.Forms.Label lblUpdateStatut;
        private System.Windows.Forms.Label lblUpdatePrix;
        private System.Windows.Forms.Label lblUpdateYears;
    }
}