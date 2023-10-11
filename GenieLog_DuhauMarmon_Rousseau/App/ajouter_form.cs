using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;

namespace App
{
    public partial class Ajouter_form : Form
    {
        Utilisateur utilisateur;
       
        public Ajouter_form(IList<Categorie> categories, Utilisateur utilisateur)
        {
            InitializeComponent();

            // Ajout des catégories dans la liste déroulante
            cb_cate.Items.AddRange(categories.ToArray<Categorie>());
            cb_cate.Items.Add("Sans catégorie");
            cb_cate.SelectedIndex = 0;
            this.utilisateur = utilisateur;
        }

        public Compte GetCompte()//crée un compte à partir du form rempli
        {
            if (cb_cate.SelectedIndex == cb_cate.Items.Count-1)//si aucune catégorie n'est choisie
            {
                return new Compte(tb_identifiant.Text, tb_mdp.Text, tb_titre.Text, tb_url.Text, null, utilisateur);
            }
            else
            {
                return new Compte(tb_identifiant.Text, tb_mdp.Text, tb_titre.Text, tb_url.Text, (Categorie)cb_cate.SelectedItem, utilisateur);
            }
        }

        public string GetIdentifiant()
        {
            return tb_identifiant.Text;
        }

        public string GetMdp()
        {
            return tb_mdp.Text;
        }
        public string GetTitre()
        {
            return tb_titre.Text;
        }

        private void btt_reinitialiser_Click(object sender, EventArgs e)//réinitialisation du form
        {
            tb_titre.Text = string.Empty;
            tb_identifiant.Text = string.Empty;
            tb_mdp.Text = string.Empty;
            tb_url.Text = string.Empty;
            cb_cate.SelectedIndex = 0;
        }

        private void btt_ajout_Click(object sender, EventArgs e)//validation de l'ajout
        {
            if (cb_cate.SelectedItem.ToString() == "Wifi")//si le compte est un compte wifi
            {
                if (string.IsNullOrEmpty(GetTitre()) || string.IsNullOrEmpty(GetMdp()))
                {
                    MessageBox.Show("Les champs SSID et mot de passe sont obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else if (string.IsNullOrEmpty(GetTitre()) || string.IsNullOrEmpty(GetIdentifiant()) || string.IsNullOrEmpty(GetMdp()))
            {
                MessageBox.Show("Les champs titre, identifiant et mot de passe sont obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btt_generer_Click(object sender, EventArgs e)//génère un mot de passe après ouverture d'un form pour obtenir les paramètres
        {
            GenererMdp_Form dlgGenererMdp = new GenererMdp_Form();
            if (dlgGenererMdp.ShowDialog() == DialogResult.OK)
            {
                int nbCarac = dlgGenererMdp.GetNbCarac();
                int nbChiffres = dlgGenererMdp.GetNbChiffres();
                int nbSymb = dlgGenererMdp.GetNbSymb();
                tb_mdp.Text = Fonctions.genMdp(nbCarac, nbChiffres, nbSymb);
            }
        }

        private void tb_mdp_TextChanged(object sender, EventArgs e)//affichage de la force du mot de passe en couleurs
        {
            if (!(string.IsNullOrEmpty(tb_mdp.Text)))
            {
                int force = Fonctions.detForce(tb_mdp.Text);
                switch (force)
                {
                    case 3:
                        {
                            tb_force.Text = "Fort";
                            tb_force.BackColor = Color.Green;
                            break;
                        }
                    case 2:
                        {
                            tb_force.Text = "Moyen";
                            tb_force.BackColor = Color.DarkOrange;
                            break;
                        }
                    case 1:
                        {
                            tb_force.Text = "Faible";
                            tb_force.BackColor = Color.Red;
                            break;
                        }
                }


            }
            else
            {
                tb_force.Text = "Force";
                tb_force.BackColor = Color.DimGray;
            }
        }

        private void cb_cate_SelectedIndexChanged(object sender, EventArgs e)//quand la catégorie devient "wifi", les paramètres sont légèrement différents
        {
            if (cb_cate.SelectedItem.ToString() == "Wifi")
            {
                lbl_identifiant.Text = "Identifiant (optionnel) :";
                lbl_titre.Text = "SSID :";
                tb_url.Enabled = false;
            }
            else
            {
                lbl_identifiant.Text = "Identifiant pour ce compte :";
                lbl_titre.Text = "Titre :";
                tb_url.Enabled = true;
            }
        }
    }
}
