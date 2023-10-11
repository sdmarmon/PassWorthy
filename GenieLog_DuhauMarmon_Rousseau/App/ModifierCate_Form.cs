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
    public partial class ModifierCate_Form : Form
    {
        private bool choix;

        public ModifierCate_Form()
        {
            InitializeComponent();
            this.ActiveControl = lbl_nom;//on active le label pour éviter la surbrillance d'un bouton
        }

        public bool GetBool()
        {
            return choix;
        }

        public string GetNom()
        {
            return tb.Text;
        }

        private void btt_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_supprimer_Click(object sender, EventArgs e)//si l'utilsateur clique sur supprimer, on renvoit true au main
        {
            choix = true;
            DialogResult = DialogResult.OK;

        }

        private void btt_modifier_Click(object sender, EventArgs e)//si l'utilsateur clique sur supprimer, on renvoit false au main
        {
            choix = false;
            DialogResult = DialogResult.OK;

        }
    }
}
