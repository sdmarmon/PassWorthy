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
    public partial class Inscription_Form : Form
    {
        private IUtilisateurRepository utilisateurRepository;

        public Inscription_Form(IUtilisateurRepository utilisateurRepository)
        {
            InitializeComponent();
            this.utilisateurRepository = utilisateurRepository;
            cb_question.Items.AddRange(Fonctions.GetQuestions()); //ajout des questions dans la liste déroulante
            if (cb_question.Items.Count > 0)
            {
                cb_question.SelectedIndex = 0;//sélection du 1er élément de la liste
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
        public string GetQuestion()
        {
            return cb_question.Text;
        }

        public string GetReponse()
        {
            return tb_reponse.Text;
        }

        public Utilisateur GetUtilisateur()//crée un utilisateur en fonction des paramètres
        {
            return new Utilisateur(tb_identifiant.Text, tb_mdp.Text, cb_question.SelectedIndex, tb_reponse.Text.ToLower());
        }

        private void btt_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_inscription_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GetIdentifiant()) | string.IsNullOrEmpty(GetMdp()) | string.IsNullOrEmpty(GetQuestion()) | string.IsNullOrEmpty(GetReponse()))
            {
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IList<Utilisateur> utilisateurs = utilisateurRepository.GetUtil(tb_identifiant.Text);
                if (utilisateurs.Count == 0)//l'utilisateur ne doit pas déjà exister
                {
                    if (tb_identifiant.Text.Length > 3)//l'identifiant doit faire plus de 3 caractères
                    {
                        if (Fonctions.detForce(tb_mdp.Text)>1)//le mot de passe doit avoir une force au moins moyenne
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Votre mot de passe est trop faible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Votre identifiant doit contenir au moins 4 caractères", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Votre identifiant est déjà utilisé, veuillez en choisir un autre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btt_generer_Click(object sender, EventArgs e)//générer le mot de passe avec un form pour récupérer les paramètres
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

        private void tb_mdp_TextChanged(object sender, EventArgs e)//affiche dynamiquement la force du mot de passe
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
    }
}
