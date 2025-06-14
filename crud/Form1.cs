using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crud.Data;
using crud.Models;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadVoitures()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = VoitureDb.GetAll();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadVoitures();
        }

        private void ajout_Click(object sender, EventArgs e)
        {
            string numero = numVoiture.Text.Trim();
            string marque = marqueVoiture.Text.Trim();
            string modele = modelVoiture.Text.Trim();

            if (string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(marque) || string.IsNullOrEmpty(modele))
            {
                MessageBox.Show("Tous les champs sont obligatoires.");
                return;
            }

            // Vérification : minimum 7 caractères et contient un espace (ex: "1234 TAB")
            if (numero.Length < 7 || !numero.Contains(" "))
            {
                MessageBox.Show("Le numéro doit contenir au moins 7 caractères et inclure un espace (ex: 1236 TAB).");
                return;
            }

            var voiture = new Voiture(numero, marque, modele);
            VoitureDb.Add(voiture);

            LoadVoitures();
            ClearForm();
        }

        private void ClearForm()
        {
            numVoiture.Text = "";
            marqueVoiture.Text = "";
            modelVoiture.Text = "";
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Voiture v)
            {
                v.Numero = numVoiture.Text.Trim();
                v.Marque = marqueVoiture.Text.Trim();
                v.Modele = modelVoiture.Text.Trim();

                VoitureDb.Update(v);
                LoadVoitures();
                ClearForm();
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Voiture v)
            {
                var confirm = MessageBox.Show("Supprimer cette voiture ?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    VoitureDb.Delete(v.Id);
                    LoadVoitures();
                    ClearForm();
                }
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Voiture v)
            {
                numVoiture.Text = v.Numero;
                marqueVoiture.Text = v.Marque;
                modelVoiture.Text = v.Modele;
            }
        }
    }
}
