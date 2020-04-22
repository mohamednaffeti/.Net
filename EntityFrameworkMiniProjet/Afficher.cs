using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkMiniProjet
{
    public partial class Afficher : Form
    {
        MiniProjectEtudiant Db = new MiniProjectEtudiant();
        public Afficher()
        {
            InitializeComponent();
        }

        private void Afficher_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Etudiant.Select(x => new {
                CIN = x.EtudiantID,
                NOM = x.Nom,
                PRENOM = x.Prenom,
                AGE = x.Age
            }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
