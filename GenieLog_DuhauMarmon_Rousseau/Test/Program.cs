using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IUtilisateurRepository utilRepo = new UtilisateurRepository();
            ICompteRepository compteRepo = new CompteRepository();
            ICategorieRepository categorieRepo = new CategorieRepository();
            IAppartenanceRepository appartenanceRepo = new AppartenanceRepository();


            //Tests de utilisateurRepository :

            //récupération de tous les utilisateurs
            Console.WriteLine("Liste des utilisateurs :");
            IList<Utilisateur> utils = utilRepo.GetAll();
            foreach (Utilisateur util in utils)
            {
                Console.WriteLine(util);
            }

            //ajout d'un utilisateur
            Utilisateur util1 = new Utilisateur("Delphine", "Rousseau", 1, "grave");
            utilRepo.Save(util1);
            Console.WriteLine("Liste des utilisateurs après ajout :");
            utils = utilRepo.GetAll();//récupération de tous les utilisateurs après ajout
            foreach (Utilisateur util in utils)
            {
                Console.WriteLine(util);
            }

            //vérification qu'un utilisateur présent dans la bdd est reconnu lors de la connexion
            if (utilRepo.Authentification("Delphine", "Rousseau").Count == 1)
            {
                Console.WriteLine("C'est bon, l'authentification marche!");
            }
            else
            {
                Console.WriteLine("C'est nul, l'authentification ne marche pas!");
            }
            //vérification qu'un utilisateur non présent dans la bdd n'est pas reconnu lors de la connexion
            if (utilRepo.Authentification("Paul", "Rousseau").Count == 1)
            {
                Console.WriteLine("C'est nul, l'authentification ne marche pas!");
            }
            else
            {
                Console.WriteLine("C'est bon, l'authentification marche!");
            }

            //vérification qu'un utilisateur présent dans la bdd est reconnu lors de la recherche d'un mdp oublie
            if (utilRepo.MdpPerdu("Delphine", 1, "grave").Count == 1)
            {
                Console.WriteLine("C'est bon, l'authentification marche!");
            }
            else
            {
                Console.WriteLine("C'est nul, l'authentification ne marche pas!");
            }
            //vérification qu'un utilisateur non présent dans la bdd n'est pas reconnu lors de la recherche d'un mdp oublie
            if (utilRepo.MdpPerdu("Delphine", 1, "bof").Count == 1)
            {
                Console.WriteLine("C'est nul, l'authentification ne marche pas!");
            }
            else
            {
                Console.WriteLine("C'est bon, l'authentification marche!");
            }

            //vérification de la recherche d'un utilisateur par son nom
            IList<Utilisateur> Del = utilRepo.GetUtil("Delphine");
            if (Del.Count == 1)
            {
                Console.WriteLine(Del[0]);
            }
            else
            {
                Console.WriteLine("Problème ! On ne trouve pas Delphine!");
            }




            //Tests de categorieRepository

            //vérification de l'ajout d'une catégorie
            Categorie film = new Categorie("streaming");
            categorieRepo.Save(film);

            //vérification de la récupération d'une catégorie
            Categorie catBase = categorieRepo.GetCate("Administratif");
            Console.WriteLine("Catégorie associée au nom Administratif : ");
            Console.WriteLine(catBase);

            //vérification qu'une catégorie est bien liée à un utilisateur
            if (categorieRepo.GetCate("Administratif", "master") != null)
            {
                Console.WriteLine("Oui, administratif est bien une catégorie de master!");
            }
            else
            {
                Console.WriteLine("Problème ! Administratif devrait pourtant être une catégorie de master");
            }

            //vérification de la récupération des catégories d'un utilisateur
            IList<Categorie> cats = categorieRepo.GetAll("master");
            Console.WriteLine("Voici toutes les catégories de master : ");
            foreach (Categorie c in cats)
            {
                Console.WriteLine(c);
            }

            //vérification de la suppression d'une catégorie (administratif) (en regardant toutes les catégories de master) -> correspond à ModifierOuSupprimer du main
            IList<Compte> comptesAdmin = compteRepo.GetCate("master", "Administratif");
            foreach (Compte compte in comptesAdmin) // tous les comptes appartenant à l'utilisateur & à la catégorie perdent leur référence à cette catégorie
            {
                compte.Cate = null;
                compteRepo.Save(compte, false);
            }
            appartenanceRepo.Supprimer(appartenanceRepo.GetApp(utils[0], catBase));//on supprime l'appartenance avec l'utilisateur
            if (appartenanceRepo.GetAll(catBase).Count == 0)//et si plus aucun utilisateur n'a cette catégorie, on la supprime
            {
                categorieRepo.Supprimer(catBase);
            }
            cats = categorieRepo.GetAll("master"); //et on réaffiche les catégories de Delphine pour vérifier la suppression
            Console.WriteLine("Voici toutes les catégories de master après suppression d'administratif : ");
            foreach (Categorie c in cats)
            {
                Console.WriteLine(c);
            }




            //Tests du compteRepository

            //vérification de la recherche des tous les utilisateurs, ainsi que la force de leur mot de passe respectif
            Console.WriteLine("Liste des comptes d'un utilisateur et leur force de mot de passe :");
            IList<Compte> comptes = compteRepo.GetAll("master");
            foreach (Compte compte in comptes)
            {
                Console.WriteLine(compte);
                Console.WriteLine(Fonctions.detForce(compte.Mdp));
                Console.WriteLine(Fonctions.genMdp(10, 3, 3));
            }

            //vérification de la recherche des comptes aux mots de passe faibles
            Console.WriteLine("Recherche des faibles");
            IList<Compte> comptes5 = compteRepo.GetFaible("master");
            foreach (Compte compte in comptes5)
            {
                Console.WriteLine(compte);
            }

            //vérification de la recherche des comptes aux mots de passe vieux
            Console.WriteLine("Recherche des plus vieux");
            IList<Compte> comptes4 = compteRepo.GetVieux("master");
            foreach (Compte compte in comptes4)
            {
                Console.WriteLine(compte);
            }

            //vérification de l'ajout d'un nouveau compte en regardant tous les comptes de Delphine
            Compte compte1 = new Compte("Belle", "Bete", "Film", "bellebete.com", film, Del[0]);
            Compte compte2 = new Compte("Sale", "Bete", "Serie", "salebete.com", film, Del[0]);
            compteRepo.Save(compte1, true);
            compteRepo.Save(compte2, true);
            IList<Compte> comptesDel = compteRepo.GetAll("Delphine");
            Console.WriteLine("Affichage des comptes de Delphine après ajout");
            foreach (Compte compte in comptesDel)
            {
                Console.WriteLine(compte);
            }

            //vérification de la recherche des comptes avec le même mot de passe (que le compte "Belle" cad compte1)
            IList<Compte> memes = compteRepo.GetMemeMdp("Delphine", compte1);
            Console.WriteLine("Affichage des comptes de Delphine ayant le même mot de passe que le compte1");
            foreach (Compte compte in memes)
            {
                Console.WriteLine(compte);
            }

            //vérification de la suppression d'un compte en affichant les comptes de Delphine
            compteRepo.Supprimer(compte2);
            comptesDel = compteRepo.GetAll("Delphine");
            Console.WriteLine("Affichage des comptes de Delphine après suppression");
            foreach (Compte compte in comptesDel)
            {
                Console.WriteLine(compte);
            }

            //vérification de la récupération des comptes dans une catégorie donnée
            Console.WriteLine("Liste des comptes de master dans la catégorie ENSC :");
            IList<Compte> comptes2 = compteRepo.GetCate("master","ENSC");
            Console.WriteLine("Affichage des comptes de master dans la catégorie ENSC");
            foreach (Compte compte in comptes2)
            {
                Console.WriteLine(compte);
            }

            //vérification de la récupération des comptes sans catégorie
            Console.WriteLine("Liste des comptes de master sans catégorie :");
            IList<Compte> comptes3 = compteRepo.GetSansCate("master");
            Console.WriteLine("Affichage des comptes de master sans catégorie");
            foreach (Compte compte in comptes3)
            {
                Console.WriteLine(compte);
            }

            //vérification de la récupération des comptes avec le terme .com
            Console.WriteLine("Recherche du terme .com dans les comptes de master :");
            IList<Compte> comptes6 = compteRepo.Recherche("master", ".com");
            Console.WriteLine("Affichage des comptes de master contenant .com");
            foreach (Compte compte in comptes6)
            {
                Console.WriteLine(compte);
            }





            //Tests de appartenanceRepository


            //vérification de l'ajout d'une appartenance
            Utilisateur utili = new Utilisateur("Charlotte", "Rousseau", 1, "C'est mon dernier mot");
            utilRepo.Save(utili);
            Appartenance apparte = new Appartenance(utili, film);
            appartenanceRepo.Save(apparte);
            IList<Categorie> cates = categorieRepo.GetAll("Charlotte");//on vérifie en regardant si film est bien dans la liste des catégories de Charlotte
            Console.WriteLine("Voici toutes les catégories de Charlotte : ");
            foreach (Categorie c in cates)
            {
                Console.WriteLine(c);
            }

            //vérification de l'ajout des catégories de base à un utilisateur (nouveau)
            appartenanceRepo.SaveCateBase(categorieRepo, utili);
            IList<Categorie> catsCha = categorieRepo.GetAll("Charlotte");//on vérifie en regardant si les catégories ont bien été ajoutée chez Charlotte
            Console.WriteLine("Voici toutes les catégories de Charlotte : ");
            foreach (Categorie c in catsCha)
            {
                Console.WriteLine(c);
            }

            //vérification qu'une catégorie appartient ou non à un utilisateur
            if (appartenanceRepo.GetApp(utili, film) != null)
            {
                Console.WriteLine("En effet, la catégorie film est bien associée à Charlotte");
            }
            else
            {
                Console.WriteLine("Problème : la catégorie film n'est pas associée à Charlotte!");
            }

            //vérification des appartenances liées à une catégorie
            IList<Appartenance> appartenances = appartenanceRepo.GetAll(film);
            Console.WriteLine("Voici toutes les appartenances de la catégorie film");
            foreach (Appartenance a in appartenances)
            {
                Console.WriteLine(a);
            }


            Console.ReadLine();
        }
    }
}
