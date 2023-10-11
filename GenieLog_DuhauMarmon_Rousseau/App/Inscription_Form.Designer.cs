namespace App
{
    partial class Inscription_Form
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
            this.lbl_identifiant = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.btt_inscription = new System.Windows.Forms.Button();
            this.btt_annuler = new System.Windows.Forms.Button();
            this.cb_question = new System.Windows.Forms.ComboBox();
            this.tb_reponse = new System.Windows.Forms.TextBox();
            this.lbl_reponse = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.btt_generer = new System.Windows.Forms.Button();
            this.tb_force = new System.Windows.Forms.TextBox();
            this.lbl_inscription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_identifiant
            // 
            this.lbl_identifiant.AutoSize = true;
            this.lbl_identifiant.Location = new System.Drawing.Point(34, 65);
            this.lbl_identifiant.Name = "lbl_identifiant";
            this.lbl_identifiant.Size = new System.Drawing.Size(59, 13);
            this.lbl_identifiant.TabIndex = 0;
            this.lbl_identifiant.Text = "Identifiant :";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(33, 105);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(77, 13);
            this.lbl_mdp.TabIndex = 1;
            this.lbl_mdp.Text = "Mot de passe :";
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(118, 62);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(136, 20);
            this.tb_identifiant.TabIndex = 2;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(117, 102);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(136, 20);
            this.tb_mdp.TabIndex = 3;
            this.tb_mdp.TextChanged += new System.EventHandler(this.tb_mdp_TextChanged);
            // 
            // btt_inscription
            // 
            this.btt_inscription.Location = new System.Drawing.Point(241, 300);
            this.btt_inscription.Name = "btt_inscription";
            this.btt_inscription.Size = new System.Drawing.Size(75, 23);
            this.btt_inscription.TabIndex = 4;
            this.btt_inscription.Text = "S\'inscrire";
            this.btt_inscription.UseVisualStyleBackColor = true;
            this.btt_inscription.Click += new System.EventHandler(this.btt_inscription_Click);
            // 
            // btt_annuler
            // 
            this.btt_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btt_annuler.Location = new System.Drawing.Point(117, 300);
            this.btt_annuler.Name = "btt_annuler";
            this.btt_annuler.Size = new System.Drawing.Size(75, 23);
            this.btt_annuler.TabIndex = 5;
            this.btt_annuler.Text = "Annuler";
            this.btt_annuler.UseVisualStyleBackColor = true;
            this.btt_annuler.Click += new System.EventHandler(this.btt_annuler_Click);
            // 
            // cb_question
            // 
            this.cb_question.FormattingEnabled = true;
            this.cb_question.Location = new System.Drawing.Point(118, 199);
            this.cb_question.Name = "cb_question";
            this.cb_question.Size = new System.Drawing.Size(294, 21);
            this.cb_question.TabIndex = 9;
            // 
            // tb_reponse
            // 
            this.tb_reponse.Location = new System.Drawing.Point(118, 244);
            this.tb_reponse.Name = "tb_reponse";
            this.tb_reponse.Size = new System.Drawing.Size(294, 20);
            this.tb_reponse.TabIndex = 8;
            // 
            // lbl_reponse
            // 
            this.lbl_reponse.AutoSize = true;
            this.lbl_reponse.Location = new System.Drawing.Point(35, 246);
            this.lbl_reponse.Name = "lbl_reponse";
            this.lbl_reponse.Size = new System.Drawing.Size(56, 13);
            this.lbl_reponse.TabIndex = 7;
            this.lbl_reponse.Text = "Réponse :";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(35, 205);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(55, 13);
            this.lbl_question.TabIndex = 6;
            this.lbl_question.Text = "Question :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(35, 171);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(216, 13);
            this.lbl_titre.TabIndex = 10;
            this.lbl_titre.Text = "Pour prévoir la perte de votre mot de passe :";
            // 
            // btt_generer
            // 
            this.btt_generer.Location = new System.Drawing.Point(271, 102);
            this.btt_generer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btt_generer.Name = "btt_generer";
            this.btt_generer.Size = new System.Drawing.Size(56, 19);
            this.btt_generer.TabIndex = 11;
            this.btt_generer.Text = "Générer";
            this.btt_generer.UseVisualStyleBackColor = true;
            this.btt_generer.Click += new System.EventHandler(this.btt_generer_Click);
            // 
            // tb_force
            // 
            this.tb_force.BackColor = System.Drawing.Color.DimGray;
            this.tb_force.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_force.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_force.Location = new System.Drawing.Point(336, 101);
            this.tb_force.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_force.Name = "tb_force";
            this.tb_force.ReadOnly = true;
            this.tb_force.Size = new System.Drawing.Size(76, 23);
            this.tb_force.TabIndex = 12;
            this.tb_force.Text = "Force";
            this.tb_force.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_inscription
            // 
            this.lbl_inscription.AutoSize = true;
            this.lbl_inscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inscription.Location = new System.Drawing.Point(169, 18);
            this.lbl_inscription.Name = "lbl_inscription";
            this.lbl_inscription.Size = new System.Drawing.Size(82, 20);
            this.lbl_inscription.TabIndex = 13;
            this.lbl_inscription.Text = "Inscription";
            // 
            // Inscription_Form
            // 
            this.AcceptButton = this.btt_inscription;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 351);
            this.Controls.Add(this.lbl_inscription);
            this.Controls.Add(this.tb_force);
            this.Controls.Add(this.btt_generer);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.cb_question);
            this.Controls.Add(this.tb_reponse);
            this.Controls.Add(this.lbl_reponse);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.btt_annuler);
            this.Controls.Add(this.btt_inscription);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_identifiant);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_identifiant);
            this.Name = "Inscription_Form";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_identifiant;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Button btt_inscription;
        private System.Windows.Forms.Button btt_annuler;
        private System.Windows.Forms.ComboBox cb_question;
        private System.Windows.Forms.TextBox tb_reponse;
        private System.Windows.Forms.Label lbl_reponse;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Button btt_generer;
        private System.Windows.Forms.TextBox tb_force;
        private System.Windows.Forms.Label lbl_inscription;
    }
}