using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace WindowsFormsAppFinal
{
    public partial class UpdateForm: Form
    {
        private int _idJeu;
        public Form1 parentForm { get; set; }

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\r.russi\\Desktop\\Formation\\developpement\\WindowsFormsAppFinal\\WindowsFormsAppFinal\\Fichier.mdf;Integrated Security=True";
        public UpdateForm(int idJeu)
        {
            InitializeComponent();
            _idJeu = idJeu;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /******************************* Partie pour les conditions des valeurs renseignées à la modification d'un jeu **************/
        private void txtUpdateTitre_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateTitre.Text.Length < 3)
            {
                this.lblerrorTitre.Show();
                this.btnUpdate.Enabled = false;
            }
            else
            {
                this.lblerrorTitre.Hide(); // Masquer l'erreur si le nom est valide
                this.btnUpdate.Enabled = true;
            }
        }

        private void txtUpdateGenre_TextChanged(object sender, EventArgs e)
        {
            if (lblErrorGenre.Text.Length < 2)
            {
                this.lblErrorGenre.Show();
                this.btnUpdate.Enabled = false;
            }
            else
            {
                this.lblErrorGenre.Hide(); // Masquer l'erreur si le nom est valide
                this.btnUpdate.Enabled = true;
            }
        }

        private void txtUpdateYears_TextChanged(object sender, EventArgs e)
        {
            if (lblErrorYears.Text.Length < 3)
            {
                this.lblErrorYears.Show();
                this.btnUpdate.Enabled = false;
            }
            else
            {
                this.lblErrorYears.Hide(); // Masquer l'erreur si le nom est valide
                this.btnUpdate.Enabled = true;
            }
        }

        private void txtUpdatePrix_TextChanged(object sender, EventArgs e)
        {
            if (lblErrorPrix.Text.Length < 3)
            {
                this.lblErrorPrix.Show();
                this.btnUpdate.Enabled = false;
            }
            else
            {
                this.lblErrorPrix.Hide(); // Masquer l'erreur si le nom est valide
                this.btnUpdate.Enabled = true;
            }
        }

        private void txtUpdateStatut_TextChanged(object sender, EventArgs e)
        {
            if (lblErrorStatut.Text.Length < 3)
            {
                this.lblErrorStatut.Show();
                this.btnUpdate.Enabled = false;
            }
            else
            {
                this.lblErrorStatut.Hide(); // Masquer l'erreur si le nom est valide
                this.btnUpdate.Enabled = true;
            }
        }
        /******************************* Fin de la partie pour les conditions des valeurs renseignées à la modification d'un jeu **************/


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblerrorTitre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string titre = txtUpdateTitre.Text;
            string genre = lblErrorGenre.Text;
            string anneeSortie = yearsPicker.Value.Year.ToString();
            string prix = lblErrorPrix.Text;
            string statut = lblErrorStatut.Text;

            if (titre == "" || genre == "" || anneeSortie == "" || prix == "" || statut == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
            }
            else
            {
                //ajout d'une nouvelle personne
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //appel de fonction open()
                    connection.Open();
                    string query = "UPDATE Jeux SET titre = @titre, genre = @genre, anneeSortie = @anneeSortie, prix = @prix, statut = @statut WHERE ID=@id;";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@id", _idJeu);
                    cmd.Parameters.AddWithValue("@titre", titre);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@anneeSortie", anneeSortie);
                    cmd.Parameters.AddWithValue("@prix", prix);
                    cmd.Parameters.AddWithValue("@statut", statut);

                    cmd.ExecuteNonQuery();
                    this.parentForm.dgUpdate();
                    this.Close();
                }
            }
        }
    }
}
