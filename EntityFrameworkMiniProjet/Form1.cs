using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkMiniProjet
{
    
    public partial class Form1 : Form
    {
        MiniProjectEtudiant Db = new MiniProjectEtudiant();

        void clear()
        {
            txt_age.Text = txt_id.Text = txt_nom.Text = txt_nom.Text = txt_prenom.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant()
            {
                EtudiantID = int.Parse(txt_id.Text),
                Nom = txt_nom.Text,
                Prenom = txt_prenom.Text,
                Age = int.Parse(txt_age.Text)
            };

            Db.Etudiant.Add(etudiant);
            Db.SaveChanges();
            Message.Text = "L'Etudiant a été ajouté";
            clear();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant()
            {
                EtudiantID = int.Parse(txt_id.Text),
                Nom = txt_nom.Text,
                Prenom = txt_prenom.Text,
                Age = int.Parse(txt_age.Text)
            };
            Db.Etudiant.AddOrUpdate(etudiant);
            Db.SaveChanges();
            Message.Text = "Mise à jour avec Succès";
            clear();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant()
            {
                EtudiantID = int.Parse(txt_id.Text),
            };
            Db.Etudiant.Attach(etudiant);
            Db.Etudiant.Remove(etudiant);
            Db.SaveChanges();
            Message.Text = "L'Etudiant a été supprimé";
            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Afficher afficher = new Afficher();
            afficher.Show();
        }
    }
}
