namespace App
{
    partial class Connexion_Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.btt_connexion = new System.Windows.Forms.Button();
            this.lbl_connexion = new System.Windows.Forms.Label();
            this.lbl_mdpOublie = new System.Windows.Forms.LinkLabel();
            this.lbl_identifiant = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_inscription = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(97, 96);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(166, 20);
            this.tb_identifiant.TabIndex = 0;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(97, 147);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(166, 20);
            this.tb_mdp.TabIndex = 1;
            this.tb_mdp.UseSystemPasswordChar = true;
            // 
            // btt_connexion
            // 
            this.btt_connexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btt_connexion.Location = new System.Drawing.Point(92, 190);
            this.btt_connexion.Name = "btt_connexion";
            this.btt_connexion.Size = new System.Drawing.Size(109, 23);
            this.btt_connexion.TabIndex = 2;
            this.btt_connexion.Text = "Se connecter";
            this.btt_connexion.UseVisualStyleBackColor = true;
            this.btt_connexion.Click += new System.EventHandler(this.btt_connexion_Click);
            // 
            // lbl_connexion
            // 
            this.lbl_connexion.AutoSize = true;
            this.lbl_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connexion.Location = new System.Drawing.Point(96, 51);
            this.lbl_connexion.Name = "lbl_connexion";
            this.lbl_connexion.Size = new System.Drawing.Size(84, 20);
            this.lbl_connexion.TabIndex = 3;
            this.lbl_connexion.Text = "Connexion";
            // 
            // lbl_mdpOublie
            // 
            this.lbl_mdpOublie.AutoSize = true;
            this.lbl_mdpOublie.Location = new System.Drawing.Point(164, 227);
            this.lbl_mdpOublie.Name = "lbl_mdpOublie";
            this.lbl_mdpOublie.Size = new System.Drawing.Size(108, 13);
            this.lbl_mdpOublie.TabIndex = 4;
            this.lbl_mdpOublie.TabStop = true;
            this.lbl_mdpOublie.Text = "Mot de passe oublié?";
            this.lbl_mdpOublie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_mdpOublie_LinkClicked);
            // 
            // lbl_identifiant
            // 
            this.lbl_identifiant.AutoSize = true;
            this.lbl_identifiant.Location = new System.Drawing.Point(23, 100);
            this.lbl_identifiant.Name = "lbl_identifiant";
            this.lbl_identifiant.Size = new System.Drawing.Size(59, 13);
            this.lbl_identifiant.TabIndex = 5;
            this.lbl_identifiant.Text = "Identifiant :";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(14, 150);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(77, 13);
            this.lbl_mdp.TabIndex = 6;
            this.lbl_mdp.Text = "Mot de passe :";
            // 
            // lbl_inscription
            // 
            this.lbl_inscription.AutoSize = true;
            this.lbl_inscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inscription.Location = new System.Drawing.Point(203, 9);
            this.lbl_inscription.Name = "lbl_inscription";
            this.lbl_inscription.Size = new System.Drawing.Size(69, 18);
            this.lbl_inscription.TabIndex = 7;
            this.lbl_inscription.TabStop = true;
            this.lbl_inscription.Text = "S\'inscrire";
            this.lbl_inscription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_inscription_LinkClicked);
            // 
            // Connexion_Form
            // 
            this.AcceptButton = this.btt_connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_inscription);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_identifiant);
            this.Controls.Add(this.lbl_mdpOublie);
            this.Controls.Add(this.lbl_connexion);
            this.Controls.Add(this.btt_connexion);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_identifiant);
            this.Name = "Connexion_Form";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Button btt_connexion;
        private System.Windows.Forms.Label lbl_connexion;
        private System.Windows.Forms.LinkLabel lbl_mdpOublie;
        private System.Windows.Forms.Label lbl_identifiant;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.LinkLabel lbl_inscription;
    }
}

