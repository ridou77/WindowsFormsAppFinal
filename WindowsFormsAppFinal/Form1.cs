using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsAppFinal
{
    public partial class Form1: Form
    {
        //chaine de connection pour la base de donnée
        string connectionString= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\r.russi\\Desktop\\Formation\\developpement\\WindowsFormsAppFinal\\WindowsFormsAppFinal\\fichier.mdf;Integrated Security=True";

        //instance pour relier mes deux formulaire
        private UpdateForm UpdateFormInstance;

        public Form1()
        {
            InitializeComponent();

            dgUpdate();//fonction pour raffraichir la page 

            DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
            //boutton suppreimer
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.HeaderText = "Suppression";
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
            //boutton modifier
            btnModifier.Text = "Modifier";
            btnModifier.HeaderText = "Modification";
            btnModifier.Name = "btnModifier";
            btnModifier.UseColumnTextForButtonValue = true;

            this.dgJeu.AllowUserToAddRows = false;

            this.dgJeu.Columns.Add(btnModifier);//ajout colonne pour boutton modifier
            this.dgJeu.Columns.Add(btnSupprimer);//ajout colonne pour bouton supprimer
        }

        private void btnAddJeu_Click(object sender, EventArgs e)
        {
            //variable pour stocker les valeur de mon formualaire
            string titre = txtTitre.Text;
            string genre = genreList.Text;
            string anneeSortie = yearsPicker.Text;
            string prix = txtPrix.Text + " €";
            string statut = statutList.Text;

            if (titre == "" || genre == "" || anneeSortie == "" || prix == "" || statut == "")//verifier que les champs ne sont pas vide
            {
                MessageBox.Show("Merci de remplir tout les champs");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        //appel de fonction open()
                        connection.Open();
                        //requete sql pour ajouter dans la base de donnée
                        string query = "INSERT INTO Jeux (titre, genre, anneeSortie, prix, statut) VALUES(@titre, @genre, @anneeSortie, @prix, @statut);";
                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@titre", titre);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@anneeSortie", anneeSortie);
                        cmd.Parameters.AddWithValue("@prix", prix);
                        cmd.Parameters.AddWithValue("@statut", statut);

                        cmd.ExecuteNonQuery();
                        dgUpdate();//raffraichissement de la page

                        txtTitre.Clear();//videer le contenu de la textbox pour le titre
                        genreList.SelectedIndex = -1;//remettre la liste à l'index -1, donc rien
                        yearsPicker.Value = DateTime.Now;//remettre la date à la date d'ajoutrd'hui
                        txtPrix.Clear();
                        statutList.SelectedIndex = -1;
                    }
                    catch (SqlException ex)//bloc try/catch pouir gerer une eventuelle erreur sql, au cas ou l'insertion de donnée dans la base se passerait mal
                    {
                        MessageBox.Show("erreur" + ex.Message);
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Cell clicked");
            // stocker dans une var de typê entier la valeur de l'ID a la row e.RowIndex

            if (e.ColumnIndex == dgJeu.Columns["btnSupprimer"].Index && e.RowIndex >= 0)
            {
                int idJeu = (int)dgJeu.Rows[e.RowIndex].Cells["ID"].Value; //valeur de idJeu
                try { 
                DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer ce contact", "Suppression de contact", MessageBoxButtons.YesNo); //popu^p de confirmation de suppréssion
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        //appel de fonction open()
                        connection.Open();
                        string query = "DELETE FROM Jeux WHERE ID=@id;";//requete sql pour supprimer un élément de la table 
                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@id", idJeu);

                        cmd.ExecuteNonQuery();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //si "non" est cliqué alors on se contente de fermer la boite de dialogue 
                }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du jeu: " + ex.Message);
                }
                dgUpdate();
            }
            if (e.ColumnIndex == dgJeu.Columns["btnModifier"].Index && e.RowIndex >= 0)
            {
                int id = (int)dgJeu.Rows[e.RowIndex].Cells["ID"].Value;
                string nom = (string)dgJeu.Rows[e.RowIndex].Cells["Titre"].Value;
                string email = (string)dgJeu.Rows[e.RowIndex].Cells["Genre"].Value;

                UpdateFormInstance = new UpdateForm(id);//en lien avec le deuxieme fourmaire de mofiication
                UpdateFormInstance.parentForm = this;
                UpdateFormInstance.Show();
            }
        }
        /************************** fonction raffraichissement de la DG *****************************/
        public void dgUpdate()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Jeux";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgJeu.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour de la liste des jeux: " + ex.Message);
            }

        }

        private void txtPrix_TextChanged(object sender, EventArgs e)// méthode qui permet d'afficher un message d'erreur si le prix indiqué est une lettre ou est <0 ou les deux 
        {
            try
            {
                if (!decimal.TryParse(txtPrix.Text, out decimal prix)) // verifie les lettres dans la textBox
                {
                    lblErrorPrixLettre.Show();
                    btnAddJeu.Enabled = false;
                }
                else if (prix < 0) // verifie si le prix est négatif
                {
                    lblErrorPrixLettre.Hide();
                    lblErrorPrix.Show();
                    btnAddJeu.Enabled = false;
                }
                else // Si tout est correct alors on affiche aucun message d'erreur 
                {
                    lblErrorPrixLettre.Hide();
                    lblErrorPrix.Hide();
                    btnAddJeu.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtTitre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitre.Text)) // verifie si le champ est vide ou contient uniquement des espaces
                {
                    lblErrorTitre.Show();
                    btnAddJeu.Enabled = false;
                }
                else
                {
                    lblErrorTitre.Hide();
                    btnAddJeu.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
