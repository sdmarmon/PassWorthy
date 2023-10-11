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
    public partial class ChangerMdp_Form : Form
    {
        public ChangerMdp_Form(Utilisateur utilisateur)
        {
            InitializeComponent();
        }

        public string GetActuel()
        {
            return (tb_actuel.Text);
        }

        public string GetNouveau()
        {
            return (tb_nouveau.Text);
        }

        private void btt_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_generer_Click(object sender, EventArgs e)//générer un mot de passe avec un autre form pour récupérer les paramètres
        {
            GenererMdp_Form dlgGenererMdp = new GenererMdp_Form();
            if (dlgGenererMdp.ShowDialog() == DialogResult.OK)
            {
                int nbCarac = dlgGenererMdp.GetNbCarac();
                int nbChiffres = dlgGenererMdp.GetNbChiffres();
                int nbSymb = dlgGenererMdp.GetNbSymb();
                tb_nouveau.Text = Fonctions.genMdp(nbCarac, nbChiffres, nbSymb);
            }
        }

        private void tb_nouveau_TextChanged(object sender, EventArgs e)//indication de la force du nouveau mot de passe entré
        {
            if (!(string.IsNullOrEmpty(tb_nouveau.Text)))
            {
                int force = Fonctions.detForce(tb_nouveau.Text);
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
