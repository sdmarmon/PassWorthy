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
    public partial class Connexion_Form : Form
    {
        private IUtilisateurRepository utilisateurRepository;
        private ICategorieRepository categorieRepository;
        private ICompteRepository compteRepository;
        private IAppartenanceRepository appartenanceRepository;
        private Utilisateur utilisateur;

        public Connexion_Form(IUtilisateurRepository utilisateurRepository, ICategorieRepository categorieRepository, ICompteRepository compteRepository, IAppartenanceRepository appartenanceRepository)
        {
            InitializeComponent();
            this.utilisateurRepository = utilisateurRepository;
            this.categorieRepository = categorieRepository;
            this.compteRepository = compteRepository;
            this.appartenanceRepository = appartenanceRepository;
        }

        private void btt_connexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_identifiant.Text) | string.IsNullOrEmpty(tb_mdp.Text))
            {
                MessageBox.Show("Certains champs obligatoires ne sont pas remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IList<Utilisateur> utilisateurs = new List<Utilisateur>();
                try
                {
                    utilisateurs = utilisateurRepository.Authentification(tb_identifiant.Text, tb_mdp.Text); //si l'utilisateur est dans la base de donnée
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur d'accès à la BDD : "+ ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (utilisateurs.Count == 1)
                {
                    utilisateur = utilisateurs[0];
                    OuvrirMain(utilisateur); //alors on ouvre le form principal avec ses paramamètres
                }
                else
                {
                    MessageBox.Show("Identifiant et/ou mot de passe erroné·s", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_inscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//pour s'inscrire, on utilise un form pour recueillir les paramètres
        {
            Inscription_Form dlgInscription = new Inscription_Form(utilisateurRepository);
            if (dlgInscription.ShowDialog() == DialogResult.OK)
            {
                utilisateur = dlgInscription.GetUtilisateur();
                string message = utilisateur.ToString();
                MessageBox.Show(message, "Récapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                utilisateurRepository.Save(utilisateur);//sauvegarde de l'utilisateur dans la bdd
                appartenanceRepository.SaveCateBase(categorieRepository, utilisateur);// ajout des catégories de base : Scolarité, Administratif, Réseaux Sociaux et Wifi
                OuvrirMain(utilisateur);
            }
        }

        private void lbl_mdpOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//pour le mot de passe oublié, redirection vers un autre form
        {
            Mdp_oublie_Form dlgMdp = new Mdp_oublie_Form(utilisateurRepository);
            if (dlgMdp.ShowDialog() == DialogResult.OK) { }
        }

        private void Reinitialiser()//réinitialisation du form
        {
            tb_identifiant.Text = string.Empty;
            tb_mdp.Text = string.Empty;
            this.Show();
            this.Focus();
            tb_identifiant.Focus();
        }

        private void OuvrirMain(Utilisateur utilisateur)//ouverture du main
        {
            this.Hide();
            var form2 = new Main_Form(utilisateur, this.categorieRepository, this.compteRepository, this.utilisateurRepository, this.appartenanceRepository);
            form2.FormClosed += (s, args) => Application.Exit();
            form2.Disposed += (s, args) => Reinitialiser();
            form2.Show();
        }
    }
}
