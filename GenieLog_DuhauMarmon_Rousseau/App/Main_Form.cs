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
    public partial class Main_Form : Form
    {
        private Utilisateur utilisateur;
        private ICategorieRepository categorieRepository;
        private ICompteRepository compteRepository;
        private IUtilisateurRepository utilisateurRepository;
        private IAppartenanceRepository appartenanceRepository;
        private Compte compteCourant; //compte sur lequel l'utilisateur vient de double cliquer
        private Categorie categorieCourante; //catégorie sur laquelle l'utilisateur vient de double cliquer

        public Main_Form(Utilisateur utilisateur, ICategorieRepository categorieRepository, ICompteRepository compteRepository, IUtilisateurRepository utilisateurRepository, IAppartenanceRepository appartenanceRepository)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.categorieRepository = categorieRepository;
            this.compteRepository = compteRepository;
            this.utilisateurRepository = utilisateurRepository;
            this.appartenanceRepository = appartenanceRepository;
            AfficherContenu();
        }

        private void AfficherContenu()
        {
            tv_comptes.BeginUpdate();
            tv_comptes.Nodes.Clear();
            IList<Categorie> categories;
            IList<Compte> comptes;
            TreeNode node;
            int i = 0;
            comptes = compteRepository.GetFaible(utilisateur.Identifiant);//récupération des comptes à mots de passe faibles
            if (comptes.Count != 0)
            {
                tv_comptes.Nodes.Add("Comptes à mot de passe faible");
                foreach (Compte compte in comptes)
                {
                    node = tv_comptes.Nodes[0].Nodes.Add(compte.Titre);
                    node.Tag = compte;
                }
                i++;
            }
            comptes = compteRepository.GetVieux(utilisateur.Identifiant);//récupération des comptes à mots de passe anciens
            if (comptes.Count != 0)
            {
                tv_comptes.Nodes.Add("Comptes à mot de passe ancien");
                foreach (Compte compte in comptes)
                {
                    node = tv_comptes.Nodes[0+i].Nodes.Add(compte.Titre);
                    node.Tag = compte;
                }
                i++;
            }
            categories = categorieRepository.GetAll(utilisateur.Identifiant);//récupération des catégories d'un utilisateur
            foreach (Categorie categorie in (categories))
            {
                tv_comptes.Nodes.Add(categorie.Nom);
                comptes = compteRepository.GetCate(utilisateur.Identifiant, categorie.Nom);//récupération des comptes dans chaque catégories
                foreach (Compte compte in (comptes))
                {
                    node = tv_comptes.Nodes[categories.IndexOf(categorie)+i].Nodes.Add(compte.Titre);
                    node.Tag = compte;
                }
            }
            comptes = compteRepository.GetSansCate(utilisateur.Identifiant);//récupération des comptes sans catégories
            if (comptes.Count != 0)
            {
                tv_comptes.Nodes.Add("Sans catégorie");
                foreach (Compte compte in comptes)
                {
                    node = tv_comptes.Nodes[categories.Count+i].Nodes.Add(compte.Titre);
                    node.Tag = compte;
                }
            }
            tv_comptes.EndUpdate();
        }

        private void AfficherRecherche(string recherche)//permet la recherche d'un compte (n'affiche que ceux là)
        {
            if (recherche.Length !=0)
            {
                tv_comptes.BeginUpdate();
                tv_comptes.Nodes.Clear();
                IList<Compte> comptes;
                TreeNode node;
                comptes = compteRepository.Recherche(utilisateur.Identifiant, recherche);
                foreach (Compte compte in (comptes))
                {
                    node = tv_comptes.Nodes.Add(compte.Titre);
                    node.Tag = compte;
                }
                tv_comptes.EndUpdate();
            }
            else
            {
                AfficherContenu(); // Peut-être rajouter un bouton réinitialiser
            }

        }

        private void AjoutCompte()//création d'un nouveau compte en passant par un form pour recueillir les paramètres
        {
            IList<Categorie> categories = categorieRepository.GetAll(utilisateur.Identifiant);
            Ajouter_form dlgAjout = new Ajouter_form(categories, utilisateur);
            if (dlgAjout.ShowDialog() == DialogResult.OK)
            {
                Compte compte = dlgAjout.GetCompte();//crée le nouveau compte
                compteRepository.Save(compte, true);//l'enregistre dans la bdd
                string message = "Voici les informations que vous avez entrées :\n" + compte.ToString();
                MessageBox.Show(message, "Récapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AfficherCompte(compte);
                AfficherContenu();
            }
        }

        private void btt_recherche_Click(object sender, EventArgs e)//déclenche la recherche
        {
            string recherche = tb_recherche.Text;
            AfficherRecherche(recherche);
        }

        private void btt_modifier_Click(object sender, EventArgs e)//permet la modification d'un compte directement en vue du main
        {
            if (cb_cate.SelectedItem.ToString() == "Wifi")//si le compte est un compte wifi les paramètres ne sont pas les mêmes
            {
                if (string.IsNullOrEmpty(tb_mdp.Text) || string.IsNullOrEmpty(tb_titre.Text))
                {
                    MessageBox.Show("Les champs titre et mot de passe sont obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Modifier(compteCourant);//modification du compte (double cliqué) en fonction des paramètres entrés dans le main
                }
            }
            else if (string.IsNullOrEmpty(tb_identifiant.Text) || string.IsNullOrEmpty(tb_mdp.Text) || string.IsNullOrEmpty(tb_titre.Text))
            {
                MessageBox.Show("Les champs titre, identifiant et mot de passe sont obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Modifier(compteCourant);//modification du compte (double cliqué) en fonction des paramètres entrés dans le main
            }
        }

        private void Modifier(Compte compte)//modification du compte (double cliqué) en fonction des paramètres entrés dans le main
        {
            bool changerDate = false;
            compte.Identifiant = tb_identifiant.Text;
            if (compte.Mdp != tb_mdp.Text)
            {
                changerDate = true;//on ne modifiera la date que si le mot de passe est modifié
                compte.Force = Fonctions.detForce(tb_mdp.Text);//on recalcule la force du mot de passe puisqu'il change
            }
            compte.Mdp = tb_mdp.Text;
            compte.Titre = tb_titre.Text;
            compte.Site = tb_url.Text;
            compte.Cate = categorieRepository.GetCate(cb_cate.Text);
            compteRepository.Save(compte, changerDate);//on sauvegarde les modifications dans la bdd
            MessageBox.Show("Modifications effectuées !", "Récapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AfficherInfosCompte(compte);//on réinitialise les infos
            AfficherContenu();//et le contenu
        }

        private void tvComptes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)//lorsque l'on double clique dans la partie affichant les comptes et catégories
        {
            btt_modifCate.Enabled = false;
            TreeNode node = tv_comptes.SelectedNode;
            if (node!=null)//si on sélectionne quelque chose
            {
                if (node.Tag != null)//et que ce n'est pas une catégorie
                {
                    Compte compte = (Compte)node.Tag;
                    AfficherCompte(compte);//on affiche les données du compte à droite
                }
                else//sinon
                {
                    Categorie categorie = categorieRepository.GetCate(node.Text, utilisateur.Identifiant);//on vérifie que la catégorie n'est pas nulle
                    if (categorie != null)
                    {
                        btt_modifCate.Enabled = true;//on peut décider de modifier cette catégorie
                        categorieCourante = categorie;
                    }
                }
            }
        }

        private void AfficherCompte(Compte compte)
        {
            btt_modifier.Enabled = true;
            btt_supprimer.Enabled = true;
            this.compteCourant = compte; // La modification se fait sur le dernier compte double clické et non pas le compte sélectionné
            tb_identifiant.Text = compte.Identifiant;
            tb_mdp.Text = compte.Mdp;
            tb_titre.Text = compte.Titre;
            tb_url.Text = compte.Site;
            IList<Categorie> categories = categorieRepository.GetAll(utilisateur.Identifiant);
            cb_cate.Items.Clear();
            cb_cate.Text = string.Empty;
            cb_cate.Items.AddRange(categories.ToArray<Categorie>());//met les catégories dans la box
            cb_cate.Items.Add("Sans catégorie");
            if (compte.Cate != null)
            {
                cb_cate.SelectedItem = compte.Cate;
            }
            else
            {
                cb_cate.SelectedIndex = cb_cate.Items.Count - 1;
            }
            AfficherInfosCompte(compte);//lorsque le compte est affiché (paramètres) on affiche les informations liées (voir dessous)
        }

        public void AfficherInfosCompte(Compte compte)//affichage des informations importantes liées au compte
        {
            lbl_estFaible.Visible = false;
            lbl_estVieux.Visible = false;
            if (compte.Date < DateTime.Now.AddDays(-180))
            {
                lbl_estVieux.Visible = true;//on indique que le mot de passe est vieux s'il a plus de 6mois
            }
            if (compte.Force == 1)
            {
                lbl_estFaible.Visible = true;//on indique que le mot de passe est faible quand c'est le cas
            }
            IList<Compte> comptes = compteRepository.GetMemeMdp(utilisateur.Identifiant, compte);//on recherche les comptes aillant le même mot de passe que le compte, pour permettre à l'utilisateur de changer certains mots de passe
            cb_memeComptes.Items.Clear();
            cb_memeComptes.Text = string.Empty;
            if (comptes.Count > 0)
            {
                cb_memeComptes.Enabled = true;
                foreach (Compte c in comptes)
                {
                    cb_memeComptes.Items.Add(c.Titre);
                }
                cb_memeComptes.SelectedIndex = 0;
            }
            else
            {
                cb_memeComptes.Enabled = false;
            }
        }

        private void btt_deconnexion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AjoutCategorie()//on ajoute une catégorie grâce à un form pour récuperer les paramètres
        {
            AjouterCategorie_Form dlgAjoutCate = new AjouterCategorie_Form(categorieRepository, utilisateur);
            if (dlgAjoutCate.ShowDialog() == DialogResult.OK)
            {
                Categorie cate = dlgAjoutCate.GetCategorie();//on crée la catégorie
                string message = "Voici les informations que vous avez entrées :\n" + cate.ToString();
                MessageBox.Show(message, "Récapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Categorie categorie = categorieRepository.GetCate(cate.Nom);//on regarde si elle existe déjà dans la bdd
                if (categorie == null)
                {
                    categorieRepository.Save(cate);//sinon, on la sauvegarde
                    Appartenance appart = new Appartenance(utilisateur, cate);//et on la lie à l'utilisateur
                    appartenanceRepository.Save(appart);
                }
                else
                {
                    Appartenance appart = new Appartenance(utilisateur, categorie);//si elle existe déjà, on la lie simplement à l'utilisateur
                    appartenanceRepository.Save(appart);
                }
            }
            AfficherContenu();
        }

        private void btt_generation_Click(object sender, EventArgs e)//générer un mot de passe
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Voulez-vous quitter l'application ?",
                                    "Confirmation",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);
        }

        private void btt_supprimer_Click_1(object sender, EventArgs e)//une fois le compte double cliqué, on peut le supprimer grâce au bouton dans le main
        {
            if (compteCourant != null)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer le compte : "+compteCourant.Titre+"?",
                                "Confirmation",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    compteRepository.Supprimer(compteCourant);
                    MessageBox.Show("Suppresion effectuée !", "Récapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            tb_titre.Text = string.Empty;
            tb_identifiant.Text = string.Empty;
            tb_mdp.Text = string.Empty;
            tb_url.Text = string.Empty;
            cb_cate.Items.Clear();
            cb_cate.Text = string.Empty;
            btt_modifier.Enabled = false;
            btt_supprimer.Enabled = false;
            AfficherContenu();
        }

        private void btt_ajout_Click(object sender, EventArgs e)//si il veut ajouter une catégorie ou un compte, l'utilisateur est redirigé vers une pop up pour choisir l'un ou l'autre
        {
            ChoisirAjout_Form dlgChoix = new ChoisirAjout_Form();
            if (dlgChoix.ShowDialog() == DialogResult.OK)
            {
                if (dlgChoix.GetBool())
                {
                    AjoutCompte();
                }
                else
                {
                    AjoutCategorie();
                }
            }
        }

        private void btt_changeMdp_Click(object sender, EventArgs e)//pour changer le mot de passe général, on utilise un form pour récupérer les paramètres
        {
            ChangerMdp_Form dlgmdp = new ChangerMdp_Form(utilisateur);
            if (dlgmdp.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dlgmdp.GetActuel()) || string.IsNullOrEmpty(dlgmdp.GetNouveau()))
                {
                    MessageBox.Show("Les champs sont tous obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IList<Utilisateur> utilisateurs = utilisateurRepository.Authentification(utilisateur.Identifiant, dlgmdp.GetActuel());//si l'utilsateur entre correctement son ancien mot de passe
                    if (utilisateurs.Count == 1)
                    {
                        utilisateur.Mdp = dlgmdp.GetNouveau();//on change son mot de passe
                        utilisateurRepository.Save(utilisateur);//on sauvegarde le nouveau mot de passe si tout va bien
                        string message = "Votre nouveau mot de passe est :\n" + dlgmdp.GetNouveau();
                        MessageBox.Show(message, "Récapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vous n'avez pas entré le bon mot de passe actuel", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tb_mdp_TextChanged(object sender, EventArgs e)//affichage dynamique de la force du mot de passe
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

        private void cb_cate_SelectedIndexChanged(object sender, EventArgs e)//selon si le compte est un compte wifi ou non, les paramètres ne sont pas tous à fait les mêmes
        {
            if (cb_cate.SelectedItem.ToString() == "Wifi")
            {
                lbl_identifiant.Text = "Identifiant (optionnel) :";
                lbl_titre.Text = "SSID :";
                tb_url.Enabled = false;
            }
            else
            {
                lbl_identifiant.Text = "Identifiant :";
                lbl_titre.Text = "Titre :";
                tb_url.Enabled = true;
            }
        }

        private void btt_modifCate_Click(object sender, EventArgs e)//modification d'une catégorie à travers une pop up
        {
            if (categorieCourante.Nom == "Wifi")///cas particulier de la catégorie wifi
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer les comportements associés à la catégorie Wifi ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ModifierOuSupprimer();
                }
            }
            else
            {
                ModifierOuSupprimer();
            }
        }

        private void ModifierOuSupprimer()
        {
            ModifierCate_Form dlgModif = new ModifierCate_Form();
            if (dlgModif.ShowDialog() == DialogResult.OK)
            {
                if (dlgModif.GetBool())//si on veut supprimer une catégorie
                {
                    btt_modifCate.Enabled = false;
                    IList<Compte> comptes = compteRepository.GetCate(utilisateur.Identifiant, categorieCourante.Nom);
                    foreach (Compte compte in comptes) // tous les comptes appartenant à l'utilisateur & à la catégorie perdent leur référence à cette catégorie
                    {
                        compte.Cate = null;
                        compteRepository.Save(compte, false);
                    }
                    appartenanceRepository.Supprimer(appartenanceRepository.GetApp(utilisateur, categorieCourante));//on supprime l'appartenance avec l'utilisateur
                    if (appartenanceRepository.GetAll(categorieCourante).Count == 0)//et si plus aucun utilisateur n'a cette catégorie, on la supprime
                    {
                        categorieRepository.Supprimer(categorieCourante);
                    }
                }
                else//si on veut modifier une catégorie
                {
                    categorieCourante.Nom = dlgModif.GetNom();
                    categorieRepository.Save(categorieCourante);//on la met à jour dans la bdd
                }
            }
            AfficherContenu();
        }
    }
}
