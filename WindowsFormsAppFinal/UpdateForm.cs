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
        public UpdateForm(int idJeu)//passsage de la variable id dans les parametre de la fonction pour pouvoir s'en servir 
        {
            InitializeComponent();
            _idJeu = idJeu;// dorénavant, "idJeu" est "_idJeu"
        }

        /******************************* Partie pour les conditions des valeurs renseignées à la modification d'un jeu **************/

        private void txtUpdatePrix_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // méthode qui permet d'afficher un message d'erreur si le prix indiqué est une lettre ou est <0 ou les deux, mais cette fois ci dans le formualire pour update un élément
                if (!decimal.TryParse(txtUpdatePrix.Text, out decimal prix))//verifie que le prix est bien un nombre
                {
                    lblErrorPrixLettreUpdate.Show();
                    btnUpdate.Enabled = false;
                }
                else if (prix < 0) // Vérifie si le prix est négatif
                {
                    lblErrorPrixLettreUpdate.Hide();
                    lblErrorPrix.Show();
                    btnUpdate.Enabled = false;
                }
                else // Si tout est correct rine n'est affiché
                {
                    lblErrorPrixLettreUpdate.Hide();
                    lblErrorPrix.Hide();
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la vérification du prix: " + ex.Message);
            }
        }


        /******************************* Fin de la partie pour les conditions des valeurs renseignées à la modification d'un jeu **************/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string titre = txtUpdateTitre.Text;
                string genre = genreList.Text;
                string anneeSortie = yearsPicker.Value.Year.ToString();
                string prixText = txtUpdatePrix.Text;
                string statut = statutList.Text;

                if (titre == "" || genre == "" || anneeSortie == "" || prixText == "" || statut == "")
                {
                    MessageBox.Show("Merci de remplir tout les champs");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtUpdateTitre.Text))
                    {
                        MessageBox.Show("Le titre ne peut pas être vide");
                    }
                    else
                    {
                        if (!decimal.TryParse(prixText, out decimal prix)) // verifie les lettres dans la textBox
                        {
                            MessageBox.Show("Le prix doit être un nombre ou un chiffre !");
                        }
                        else if (prix < 0) // verifie si le prix est négatif
                        {
                            MessageBox.Show("Le prix ne peux pas être négatif !");
                        }
                        else // Si tout est correct alors on affiche aucun message d'erreur 
                        {
                            //ajout d'une nouvelle personne
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                //appel de fonction open()
                                connection.Open();
                                //requete sql pour modifier un élément choisi
                                string query = "UPDATE Jeux SET titre = @titre, genre = @genre, anneeSortie = @anneeSortie, prix = @prix, statut = @statut WHERE ID=@id;";
                                SqlCommand cmd = new SqlCommand(query, connection);

                                cmd.Parameters.AddWithValue("@id", _idJeu);
                                cmd.Parameters.AddWithValue("@titre", titre);
                                cmd.Parameters.AddWithValue("@genre", genre);
                                cmd.Parameters.AddWithValue("@anneeSortie", anneeSortie);
                                cmd.Parameters.AddWithValue("@prix", prix);
                                cmd.Parameters.AddWithValue("@statut", statut);

                                cmd.ExecuteNonQuery();//execution de la requete
                                this.parentForm.dgUpdate();//fonction de rafraichissement mais récupéré depuis le formulaire parent
                                this.Close();//ferme le formulaire
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Une erreur est survenue avec la base de données: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur inattendue est survenue: " + ex.Message);
            }
        }

        private void txtUpdateTitre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUpdateTitre.Text)) // verifie si le champ est vide ou contient uniquement des espaces
                {
                    lblErrorTitreUpdate.Show();
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lblErrorTitreUpdate.Hide();
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnnulModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
