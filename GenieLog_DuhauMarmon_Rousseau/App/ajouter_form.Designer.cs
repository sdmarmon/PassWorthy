namespace App
{
    partial class Ajouter_form
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
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.tb_titre = new System.Windows.Forms.TextBox();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.lbl_identifiant = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.lbl_url = new System.Windows.Forms.Label();
            this.lbl_ajout = new System.Windows.Forms.Label();
            this.lbl_cate = new System.Windows.Forms.Label();
            this.btt_ajout = new System.Windows.Forms.Button();
            this.cb_cate = new System.Windows.Forms.ComboBox();
            this.btt_reinitialiser = new System.Windows.Forms.Button();
            this.btt_generer = new System.Windows.Forms.Button();
            this.tb_force = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(188, 152);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(101, 20);
            this.tb_mdp.TabIndex = 11;
            this.tb_mdp.TextChanged += new System.EventHandler(this.tb_mdp_TextChanged);
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(188, 108);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(101, 20);
            this.tb_identifiant.TabIndex = 10;
            // 
            // tb_titre
            // 
            this.tb_titre.Location = new System.Drawing.Point(188, 69);
            this.tb_titre.Name = "tb_titre";
            this.tb_titre.Size = new System.Drawing.Size(101, 20);
            this.tb_titre.TabIndex = 9;
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(25, 155);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(154, 13);
            this.lbl_mdp.TabIndex = 8;
            this.lbl_mdp.Text = "Mot de passe pour ce compte :";
            // 
            // lbl_identifiant
            // 
            this.lbl_identifiant.AutoSize = true;
            this.lbl_identifiant.Location = new System.Drawing.Point(25, 114);
            this.lbl_identifiant.Name = "lbl_identifiant";
            this.lbl_identifiant.Size = new System.Drawing.Size(136, 13);
            this.lbl_identifiant.TabIndex = 7;
            this.lbl_identifiant.Text = "Identifiant pour ce compte :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(25, 75);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(87, 13);
            this.lbl_titre.TabIndex = 6;
            this.lbl_titre.Text = "Titre du compte :";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(188, 191);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(101, 20);
            this.tb_url.TabIndex = 13;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(25, 194);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(87, 13);
            this.lbl_url.TabIndex = 12;
            this.lbl_url.Text = "Lien du site (url) :";
            // 
            // lbl_ajout
            // 
            this.lbl_ajout.AutoSize = true;
            this.lbl_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajout.Location = new System.Drawing.Point(152, 21);
            this.lbl_ajout.Name = "lbl_ajout";
            this.lbl_ajout.Size = new System.Drawing.Size(137, 20);
            this.lbl_ajout.TabIndex = 14;
            this.lbl_ajout.Text = "Ajout d\'un compte";
            // 
            // lbl_cate
            // 
            this.lbl_cate.AutoSize = true;
            this.lbl_cate.Location = new System.Drawing.Point(25, 233);
            this.lbl_cate.Name = "lbl_cate";
            this.lbl_cate.Size = new System.Drawing.Size(58, 13);
            this.lbl_cate.TabIndex = 15;
            this.lbl_cate.Text = "Catégorie :";
            // 
            // btt_ajout
            // 
            this.btt_ajout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btt_ajout.Location = new System.Drawing.Point(240, 293);
            this.btt_ajout.Name = "btt_ajout";
            this.btt_ajout.Size = new System.Drawing.Size(75, 23);
            this.btt_ajout.TabIndex = 17;
            this.btt_ajout.Text = "Ajouter";
            this.btt_ajout.UseVisualStyleBackColor = true;
            this.btt_ajout.Click += new System.EventHandler(this.btt_ajout_Click);
            // 
            // cb_cate
            // 
            this.cb_cate.FormattingEnabled = true;
            this.cb_cate.Location = new System.Drawing.Point(188, 230);
            this.cb_cate.Name = "cb_cate";
            this.cb_cate.Size = new System.Drawing.Size(101, 21);
            this.cb_cate.TabIndex = 18;
            this.cb_cate.SelectedIndexChanged += new System.EventHandler(this.cb_cate_SelectedIndexChanged);
            // 
            // btt_reinitialiser
            // 
            this.btt_reinitialiser.Location = new System.Drawing.Point(134, 293);
            this.btt_reinitialiser.Name = "btt_reinitialiser";
            this.btt_reinitialiser.Size = new System.Drawing.Size(75, 23);
            this.btt_reinitialiser.TabIndex = 19;
            this.btt_reinitialiser.Text = "Réinitialiser";
            this.btt_reinitialiser.UseVisualStyleBackColor = true;
            this.btt_reinitialiser.Click += new System.EventHandler(this.btt_reinitialiser_Click);
            // 
            // btt_generer
            // 
            this.btt_generer.Location = new System.Drawing.Point(300, 153);
            this.btt_generer.Margin = new System.Windows.Forms.Padding(2);
            this.btt_generer.Name = "btt_generer";
            this.btt_generer.Size = new System.Drawing.Size(56, 19);
            this.btt_generer.TabIndex = 20;
            this.btt_generer.Text = "Générer";
            this.btt_generer.UseVisualStyleBackColor = true;
            this.btt_generer.Click += new System.EventHandler(this.btt_generer_Click);
            // 
            // tb_force
            // 
            this.tb_force.BackColor = System.Drawing.Color.DimGray;
            this.tb_force.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_force.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_force.Location = new System.Drawing.Point(364, 152);
            this.tb_force.Margin = new System.Windows.Forms.Padding(2);
            this.tb_force.Name = "tb_force";
            this.tb_force.ReadOnly = true;
            this.tb_force.Size = new System.Drawing.Size(76, 23);
            this.tb_force.TabIndex = 21;
            this.tb_force.Text = "Force";
            this.tb_force.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ajouter_form
            // 
            this.AcceptButton = this.btt_ajout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 350);
            this.Controls.Add(this.tb_force);
            this.Controls.Add(this.btt_generer);
            this.Controls.Add(this.btt_reinitialiser);
            this.Controls.Add(this.cb_cate);
            this.Controls.Add(this.btt_ajout);
            this.Controls.Add(this.lbl_cate);
            this.Controls.Add(this.lbl_ajout);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_identifiant);
            this.Controls.Add(this.tb_titre);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_identifiant);
            this.Controls.Add(this.lbl_titre);
            this.Name = "Ajouter_form";
            this.Text = "Ajouter un compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.TextBox tb_titre;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label lbl_identifiant;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label lbl_ajout;
        private System.Windows.Forms.Label lbl_cate;
        private System.Windows.Forms.Button btt_ajout;
        private System.Windows.Forms.ComboBox cb_cate;
        private System.Windows.Forms.Button btt_reinitialiser;
        private System.Windows.Forms.Button btt_generer;
        private System.Windows.Forms.TextBox tb_force;
    }
}