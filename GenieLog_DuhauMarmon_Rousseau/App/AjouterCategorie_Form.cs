using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class AjouterCategorie_Form : Form
    {
        ICategorieRepository categorieRepository;
        Utilisateur utilisateur;

        public AjouterCategorie_Form(ICategorieRepository categorieRepository, Utilisateur utilisateur)
        {
            InitializeComponent();
            this.categorieRepository = categorieRepository;
            this.utilisateur = utilisateur;
        }

        public string GetNom()
        {
            return tb_nom.Text;
        }

        public Categorie GetCategorie()//crée une catégorie à partir d'un string
        {
            return new Categorie(tb_nom.Text);
        }

        private void btt_ajout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GetNom()))
            {
                MessageBox.Show("La catégorie doit avoir un nom !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Categorie cate = categorieRepository.GetCate(tb_nom.Text, utilisateur.Identifiant);//on regarde si la catégorie existe déjà dans la base avant de la créer
                if (cate == null)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cette catégorie existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btt_reinitialiser_Click(object sender, EventArgs e)
        {
            tb_nom.Text = string.Empty;
        }
    }
}
