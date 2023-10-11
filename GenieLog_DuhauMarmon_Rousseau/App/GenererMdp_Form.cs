using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class GenererMdp_Form : Form
    {
        public GenererMdp_Form()
        {
            InitializeComponent();
            num_carac.Value = 10;
            num_chiffres.Value = 2;
            num_symb.Value = 4;
        }

        public int GetNbCarac()
        {
            return (int)num_carac.Value;
        }
        public int GetNbChiffres()
        {
            return (int)num_chiffres.Value;
        }
        public int GetNbSymb()
        {
            return (int)num_symb.Value;
        }

        private void num_carac_ValueChanged(object sender, EventArgs e)
        {
            if (num_carac.Value < num_chiffres.Value + num_symb.Value)
            {
                if(num_chiffres.Value == 1)
                {
                    num_symb.Maximum = num_carac.Value - 1;
                }
                else
                num_symb.Maximum = num_carac.Value;
                num_chiffres.Maximum = num_carac.Value - num_symb.Value;
            }
            else
            {
                num_symb.Maximum = num_carac.Value - num_chiffres.Value;
                num_chiffres.Maximum = num_carac.Value - num_symb.Value;
            }
        }

        private void num_chiffres_ValueChanged(object sender, EventArgs e)
        {
            num_symb.Maximum = num_carac.Value - num_chiffres.Value;
        }

        private void num_symb_ValueChanged(object sender, EventArgs e)
        {
            num_chiffres.Maximum = num_carac.Value - num_symb.Value;
        }
    }
}
