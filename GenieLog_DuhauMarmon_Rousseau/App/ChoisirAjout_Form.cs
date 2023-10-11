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
    public partial class ChoisirAjout_Form : Form
    {
        private bool choix;

        public ChoisirAjout_Form()
        {
            InitializeComponent();
            this.ActiveControl = label1;//pour ne pas avoir l'un des boutons en surbrillance, on active un label
        }

        private void btt_compte_Click(object sender, EventArgs e)//si on choisit d'ajouter un compte, la valeur du booléan est true
        {
            choix = true;
            DialogResult = DialogResult.OK;
        }

        private void btt_categorie_Click(object sender, EventArgs e)//si on choisit d'ajouter une catégorie, la valeur du booléan est false
        {
            choix = false;
            DialogResult = DialogResult.OK;
        }

        public bool GetBool()
        {
            return choix;
        }
    }
}
