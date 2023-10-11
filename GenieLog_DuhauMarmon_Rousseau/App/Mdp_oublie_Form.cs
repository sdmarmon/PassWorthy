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
    public partial class Mdp_oublie_Form : Form
    {
        private IUtilisateurRepository utilisateurRepository;

        public Mdp_oublie_Form(IUtilisateurRepository utilisateurRepository)
        {
            InitializeComponent();
            this.utilisateurRepository = utilisateurRepository;
            cb_question.Items.AddRange(Fonctions.GetQuestions());//ajout des questions dans la liste déroulante
            if (cb_question.Items.Count > 0)
            {
                cb_question.SelectedIndex = 0;//sélection du 1er élément de la liste
            }
        }

        private void btt_valider_Click(object sender, EventArgs e)//validation des données pour retrouver le mot de passe
        {
            if (string.IsNullOrEmpty(tb_identifiant.Text) | string.IsNullOrEmpty(cb_question.Text) | string.IsNullOrEmpty(tb_reponse.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IList<Utilisateur> utilisateurs = utilisateurRepository.MdpPerdu(tb_identifiant.Text, cb_question.SelectedIndex, tb_reponse.Text.ToLower());//on cherche l'utilisateur dans la bdd avec sa question et sa réponse (en minuscule, pour que les majuscules n'influencent pas)
                if (utilisateurs.Count == 1)
                {
                    string message = "Votre mot de passe est : " + utilisateurs[0].Mdp;
                    MessageBox.Show(message, "Mot de passe retrouvé!", MessageBoxButtons.OK, MessageBoxIcon.Information);//on montre dans une pop à l'utilsateur son mot de passe
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Identifiant et/ou question/réponse erroné·e·s", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btt_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
