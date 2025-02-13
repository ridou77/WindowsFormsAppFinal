using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            _idJeu = _idJeu;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
