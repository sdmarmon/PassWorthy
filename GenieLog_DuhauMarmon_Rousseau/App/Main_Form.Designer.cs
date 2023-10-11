namespace App
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_comptes = new System.Windows.Forms.GroupBox();
            this.btt_modifCate = new System.Windows.Forms.Button();
            this.btt_ajout = new System.Windows.Forms.Button();
            this.tv_comptes = new System.Windows.Forms.TreeView();
            this.btt_recherche = new System.Windows.Forms.Button();
            this.tb_recherche = new System.Windows.Forms.RichTextBox();
            this.gb_compte = new System.Windows.Forms.GroupBox();
            this.tb_force = new System.Windows.Forms.TextBox();
            this.btt_supprimer = new System.Windows.Forms.Button();
            this.btt_generation = new System.Windows.Forms.Button();
            this.cb_cate = new System.Windows.Forms.ComboBox();
            this.lbl_cate = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.lbl_url = new System.Windows.Forms.Label();
            this.btt_modifier = new System.Windows.Forms.Button();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.tb_titre = new System.Windows.Forms.TextBox();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_identifiant = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.lbl_estVieux = new System.Windows.Forms.Label();
            this.cb_memeComptes = new System.Windows.Forms.ComboBox();
            this.lbl_nbreComptes = new System.Windows.Forms.Label();
            this.lbl_estFaible = new System.Windows.Forms.Label();
            this.btt_deconnexion = new System.Windows.Forms.Button();
            this.btt_changeMdp = new System.Windows.Forms.Button();
            this.gb_comptes.SuspendLayout();
            this.gb_compte.SuspendLayout();
            this.gb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_comptes
            // 
            this.gb_comptes.Controls.Add(this.btt_modifCate);
            this.gb_comptes.Controls.Add(this.btt_ajout);
            this.gb_comptes.Controls.Add(this.tv_comptes);
            this.gb_comptes.Controls.Add(this.btt_recherche);
            this.gb_comptes.Controls.Add(this.tb_recherche);
            this.gb_comptes.Location = new System.Drawing.Point(36, 14);
            this.gb_comptes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_comptes.Name = "gb_comptes";
            this.gb_comptes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_comptes.Size = new System.Drawing.Size(267, 489);
            this.gb_comptes.TabIndex = 0;
            this.gb_comptes.TabStop = false;
            this.gb_comptes.Text = "Comptes";
            // 
            // btt_modifCate
            // 
            this.btt_modifCate.Enabled = false;
            this.btt_modifCate.Location = new System.Drawing.Point(45, 459);
            this.btt_modifCate.Name = "btt_modifCate";
            this.btt_modifCate.Size = new System.Drawing.Size(174, 23);
            this.btt_modifCate.TabIndex = 9;
            this.btt_modifCate.Text = "Modifier ou supprimer la catégorie";
            this.btt_modifCate.UseVisualStyleBackColor = true;
            this.btt_modifCate.Click += new System.EventHandler(this.btt_modifCate_Click);
            // 
            // btt_ajout
            // 
            this.btt_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ajout.ForeColor = System.Drawing.Color.Green;
            this.btt_ajout.Location = new System.Drawing.Point(212, 407);
            this.btt_ajout.Name = "btt_ajout";
            this.btt_ajout.Size = new System.Drawing.Size(40, 37);
            this.btt_ajout.TabIndex = 8;
            this.btt_ajout.Text = "+";
            this.btt_ajout.UseVisualStyleBackColor = true;
            this.btt_ajout.Click += new System.EventHandler(this.btt_ajout_Click);
            // 
            // tv_comptes
            // 
            this.tv_comptes.Location = new System.Drawing.Point(8, 70);
            this.tv_comptes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tv_comptes.Name = "tv_comptes";
            this.tv_comptes.Size = new System.Drawing.Size(253, 383);
            this.tv_comptes.TabIndex = 7;
            this.tv_comptes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvComptes_NodeMouseDoubleClick);
            // 
            // btt_recherche
            // 
            this.btt_recherche.Location = new System.Drawing.Point(188, 29);
            this.btt_recherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_recherche.Name = "btt_recherche";
            this.btt_recherche.Size = new System.Drawing.Size(71, 23);
            this.btt_recherche.TabIndex = 6;
            this.btt_recherche.Text = "Rechercher";
            this.btt_recherche.UseVisualStyleBackColor = true;
            this.btt_recherche.Click += new System.EventHandler(this.btt_recherche_Click);
            // 
            // tb_recherche
            // 
            this.tb_recherche.Location = new System.Drawing.Point(8, 32);
            this.tb_recherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(174, 21);
            this.tb_recherche.TabIndex = 0;
            this.tb_recherche.Text = "";
            // 
            // gb_compte
            // 
            this.gb_compte.Controls.Add(this.tb_force);
            this.gb_compte.Controls.Add(this.btt_supprimer);
            this.gb_compte.Controls.Add(this.btt_generation);
            this.gb_compte.Controls.Add(this.cb_cate);
            this.gb_compte.Controls.Add(this.lbl_cate);
            this.gb_compte.Controls.Add(this.tb_url);
            this.gb_compte.Controls.Add(this.lbl_url);
            this.gb_compte.Controls.Add(this.btt_modifier);
            this.gb_compte.Controls.Add(this.tb_mdp);
            this.gb_compte.Controls.Add(this.tb_identifiant);
            this.gb_compte.Controls.Add(this.tb_titre);
            this.gb_compte.Controls.Add(this.lbl_mdp);
            this.gb_compte.Controls.Add(this.lbl_identifiant);
            this.gb_compte.Controls.Add(this.lbl_titre);
            this.gb_compte.Location = new System.Drawing.Point(371, 73);
            this.gb_compte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_compte.Name = "gb_compte";
            this.gb_compte.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_compte.Size = new System.Drawing.Size(635, 225);
            this.gb_compte.TabIndex = 1;
            this.gb_compte.TabStop = false;
            this.gb_compte.Text = "Compte";
            // 
            // tb_force
            // 
            this.tb_force.BackColor = System.Drawing.Color.DimGray;
            this.tb_force.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_force.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_force.Location = new System.Drawing.Point(480, 89);
            this.tb_force.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_force.Name = "tb_force";
            this.tb_force.ReadOnly = true;
            this.tb_force.Size = new System.Drawing.Size(86, 23);
            this.tb_force.TabIndex = 13;
            this.tb_force.Text = "Force";
            this.tb_force.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btt_supprimer
            // 
            this.btt_supprimer.Enabled = false;
            this.btt_supprimer.Location = new System.Drawing.Point(526, 183);
            this.btt_supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_supprimer.Name = "btt_supprimer";
            this.btt_supprimer.Size = new System.Drawing.Size(100, 32);
            this.btt_supprimer.TabIndex = 12;
            this.btt_supprimer.Text = "Supprimer";
            this.btt_supprimer.UseVisualStyleBackColor = true;
            this.btt_supprimer.Click += new System.EventHandler(this.btt_supprimer_Click_1);
            // 
            // btt_generation
            // 
            this.btt_generation.Location = new System.Drawing.Point(382, 90);
            this.btt_generation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_generation.Name = "btt_generation";
            this.btt_generation.Size = new System.Drawing.Size(82, 21);
            this.btt_generation.TabIndex = 11;
            this.btt_generation.Text = "Générer";
            this.btt_generation.UseVisualStyleBackColor = true;
            this.btt_generation.Click += new System.EventHandler(this.btt_generation_Click);
            // 
            // cb_cate
            // 
            this.cb_cate.FormattingEnabled = true;
            this.cb_cate.Location = new System.Drawing.Point(179, 152);
            this.cb_cate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_cate.Name = "cb_cate";
            this.cb_cate.Size = new System.Drawing.Size(186, 21);
            this.cb_cate.TabIndex = 10;
            this.cb_cate.SelectedIndexChanged += new System.EventHandler(this.cb_cate_SelectedIndexChanged);
            // 
            // lbl_cate
            // 
            this.lbl_cate.AutoSize = true;
            this.lbl_cate.Location = new System.Drawing.Point(6, 154);
            this.lbl_cate.Name = "lbl_cate";
            this.lbl_cate.Size = new System.Drawing.Size(58, 13);
            this.lbl_cate.TabIndex = 9;
            this.lbl_cate.Text = "Catégorie :";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(179, 122);
            this.tb_url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(186, 20);
            this.tb_url.TabIndex = 8;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(6, 124);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(85, 13);
            this.lbl_url.TabIndex = 7;
            this.lbl_url.Text = "Url (lien du site) :";
            // 
            // btt_modifier
            // 
            this.btt_modifier.Enabled = false;
            this.btt_modifier.Location = new System.Drawing.Point(382, 183);
            this.btt_modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_modifier.Name = "btt_modifier";
            this.btt_modifier.Size = new System.Drawing.Size(122, 32);
            this.btt_modifier.TabIndex = 6;
            this.btt_modifier.Text = "Modifier";
            this.btt_modifier.UseVisualStyleBackColor = true;
            this.btt_modifier.Click += new System.EventHandler(this.btt_modifier_Click);
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(179, 92);
            this.tb_mdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(186, 20);
            this.tb_mdp.TabIndex = 5;
            this.tb_mdp.TextChanged += new System.EventHandler(this.tb_mdp_TextChanged);
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(179, 62);
            this.tb_identifiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(186, 20);
            this.tb_identifiant.TabIndex = 4;
            // 
            // tb_titre
            // 
            this.tb_titre.Location = new System.Drawing.Point(179, 30);
            this.tb_titre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_titre.Name = "tb_titre";
            this.tb_titre.Size = new System.Drawing.Size(186, 20);
            this.tb_titre.TabIndex = 3;
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(6, 96);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(77, 13);
            this.lbl_mdp.TabIndex = 2;
            this.lbl_mdp.Text = "Mot de passe :";
            // 
            // lbl_identifiant
            // 
            this.lbl_identifiant.AutoSize = true;
            this.lbl_identifiant.Location = new System.Drawing.Point(7, 64);
            this.lbl_identifiant.Name = "lbl_identifiant";
            this.lbl_identifiant.Size = new System.Drawing.Size(59, 13);
            this.lbl_identifiant.TabIndex = 1;
            this.lbl_identifiant.Text = "Identifiant :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(7, 32);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(34, 13);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Titre :";
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.lbl_estVieux);
            this.gb_info.Controls.Add(this.cb_memeComptes);
            this.gb_info.Controls.Add(this.lbl_nbreComptes);
            this.gb_info.Controls.Add(this.lbl_estFaible);
            this.gb_info.Location = new System.Drawing.Point(371, 306);
            this.gb_info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_info.Name = "gb_info";
            this.gb_info.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_info.Size = new System.Drawing.Size(635, 160);
            this.gb_info.TabIndex = 2;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Informations";
            // 
            // lbl_estVieux
            // 
            this.lbl_estVieux.AutoSize = true;
            this.lbl_estVieux.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estVieux.ForeColor = System.Drawing.Color.Red;
            this.lbl_estVieux.Location = new System.Drawing.Point(9, 124);
            this.lbl_estVieux.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estVieux.Name = "lbl_estVieux";
            this.lbl_estVieux.Size = new System.Drawing.Size(426, 13);
            this.lbl_estVieux.TabIndex = 3;
            this.lbl_estVieux.Text = "Attention ! Votre mot de passe n\'a pas été changé depuis plus de 6 mois !";
            this.lbl_estVieux.Visible = false;
            // 
            // cb_memeComptes
            // 
            this.cb_memeComptes.FormattingEnabled = true;
            this.cb_memeComptes.Location = new System.Drawing.Point(401, 35);
            this.cb_memeComptes.Name = "cb_memeComptes";
            this.cb_memeComptes.Size = new System.Drawing.Size(226, 21);
            this.cb_memeComptes.TabIndex = 2;
            // 
            // lbl_nbreComptes
            // 
            this.lbl_nbreComptes.AutoSize = true;
            this.lbl_nbreComptes.Location = new System.Drawing.Point(7, 37);
            this.lbl_nbreComptes.Name = "lbl_nbreComptes";
            this.lbl_nbreComptes.Size = new System.Drawing.Size(288, 13);
            this.lbl_nbreComptes.TabIndex = 1;
            this.lbl_nbreComptes.Text = "Ce mot de passe est déjà utilisé dans les comptes suivants :";
            // 
            // lbl_estFaible
            // 
            this.lbl_estFaible.AutoSize = true;
            this.lbl_estFaible.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estFaible.ForeColor = System.Drawing.Color.Red;
            this.lbl_estFaible.Location = new System.Drawing.Point(9, 85);
            this.lbl_estFaible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estFaible.Name = "lbl_estFaible";
            this.lbl_estFaible.Size = new System.Drawing.Size(243, 13);
            this.lbl_estFaible.TabIndex = 0;
            this.lbl_estFaible.Text = "Attention ! Votre mot de passe est faible !";
            this.lbl_estFaible.Visible = false;
            // 
            // btt_deconnexion
            // 
            this.btt_deconnexion.Location = new System.Drawing.Point(898, 474);
            this.btt_deconnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_deconnexion.Name = "btt_deconnexion";
            this.btt_deconnexion.Size = new System.Drawing.Size(109, 28);
            this.btt_deconnexion.TabIndex = 3;
            this.btt_deconnexion.Text = "Déconnexion";
            this.btt_deconnexion.UseVisualStyleBackColor = true;
            this.btt_deconnexion.Click += new System.EventHandler(this.btt_deconnexion_Click);
            // 
            // btt_changeMdp
            // 
            this.btt_changeMdp.Location = new System.Drawing.Point(802, 14);
            this.btt_changeMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_changeMdp.Name = "btt_changeMdp";
            this.btt_changeMdp.Size = new System.Drawing.Size(205, 23);
            this.btt_changeMdp.TabIndex = 10;
            this.btt_changeMdp.Text = "Modifier mon mot de passe PassWorthy";
            this.btt_changeMdp.UseVisualStyleBackColor = true;
            this.btt_changeMdp.Click += new System.EventHandler(this.btt_changeMdp_Click);
            // 
            // Main_Form
            // 
            this.AcceptButton = this.btt_recherche;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 514);
            this.Controls.Add(this.btt_changeMdp);
            this.Controls.Add(this.btt_deconnexion);
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.gb_compte);
            this.Controls.Add(this.gb_comptes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Form";
            this.Text = "Utilisateur : ";
            this.gb_comptes.ResumeLayout(false);
            this.gb_compte.ResumeLayout(false);
            this.gb_compte.PerformLayout();
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_comptes;
        private System.Windows.Forms.RichTextBox tb_recherche;
        private System.Windows.Forms.GroupBox gb_compte;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.TextBox tb_titre;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label lbl_identifiant;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Button btt_modifier;
        private System.Windows.Forms.Button btt_recherche;
        private System.Windows.Forms.ComboBox cb_cate;
        private System.Windows.Forms.Label lbl_cate;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.TreeView tv_comptes;
        private System.Windows.Forms.Button btt_deconnexion;
        private System.Windows.Forms.Button btt_generation;
        private System.Windows.Forms.Button btt_supprimer;
        private System.Windows.Forms.Button btt_ajout;
        private System.Windows.Forms.Button btt_changeMdp;
        private System.Windows.Forms.TextBox tb_force;
        private System.Windows.Forms.Label lbl_nbreComptes;
        private System.Windows.Forms.Label lbl_estFaible;
        private System.Windows.Forms.ComboBox cb_memeComptes;
        private System.Windows.Forms.Button btt_modifCate;
        private System.Windows.Forms.Label lbl_estVieux;
    }
}