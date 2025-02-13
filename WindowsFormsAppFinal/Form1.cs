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

        string connectionString= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\r.russi\\Desktop\\Formation\\developpement\\WindowsFormsAppFinal\\WindowsFormsAppFinal\\fichier.mdf;Integrated Security=True";

        private UpdateForm UpdateFormInstance;

        public Form1()
        {
            InitializeComponent();

            dgUpdate();

            DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();

            btnSupprimer.Text = "Supprimer";
            btnSupprimer.HeaderText = "Action";
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();

            btnModifier.Text = "Modifier";
            btnModifier.HeaderText = "actionModifier";
            btnModifier.Name = "btnModifier";
            btnModifier.UseColumnTextForButtonValue = true;

            this.dgJeu.AllowUserToAddRows = false;

            this.dgJeu.Columns.Add(btnModifier);
            this.dgJeu.Columns.Add(btnSupprimer);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void statutList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddJeu_Click(object sender, EventArgs e)
        {
            string titre = txtTitre.Text;
            string genre = genreList.Text;
            string anneeSortie = yearsPicker.Text;
            string prix = txtPrix.Text;
            string statut = statutList.Text;

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
                    string query = "INSERT INTO Jeux (titre, genre, anneeSortie, prix, statut) VALUES(@titre, @genre, @anneeSortie, @prix, @statut);";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@titre", titre);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@anneeSortie", anneeSortie);
                    cmd.Parameters.AddWithValue("@prix", prix);
                    cmd.Parameters.AddWithValue("@statut", statut);

                    cmd.ExecuteNonQuery();
                    dgUpdate();
                }
            }

        }

        private void genreList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Cell clicked");
            // stocker dans une var de typê entier la valeur de l'ID a la row e.RowIndex

            if (e.ColumnIndex == dgJeu.Columns["btnSupprimer"].Index && e.RowIndex >= 0)
            {
                int idJeu = (int)dgJeu.Rows[e.RowIndex].Cells["ID"].Value;

                DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer ce contact", "Suppression de contact", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        //appel de fonction open()
                        connection.Open();
                        string query = "DELETE FROM Jeux WHERE ID=@id;";
                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@id", idJeu);

                        cmd.ExecuteNonQuery();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                dgUpdate();
            }
            if (e.ColumnIndex == dgJeu.Columns["btnModifier"].Index && e.RowIndex >= 0)
            {
                int id = (int)dgJeu.Rows[e.RowIndex].Cells["ID"].Value;
                string nom = (string)dgJeu.Rows[e.RowIndex].Cells["Nom"].Value;
                string email = (string)dgJeu.Rows[e.RowIndex].Cells["Email"].Value;

                UpdateFormInstance = new UpdateForm(id);
                UpdateFormInstance.ParentForm = this;
                UpdateFormInstance.Show();
            }
        }
        /************************** fonction raffraichissement de la DG *****************************/
        public void dgUpdate()
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
    }
}
