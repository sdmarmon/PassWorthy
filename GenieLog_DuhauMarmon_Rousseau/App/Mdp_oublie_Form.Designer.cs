namespace App
{
    partial class Mdp_oublie_Form
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
            this.lbl_question = new System.Windows.Forms.Label();
            this.lbl_reponse = new System.Windows.Forms.Label();
            this.tb_reponse = new System.Windows.Forms.TextBox();
            this.cb_question = new System.Windows.Forms.ComboBox();
            this.btt_annuler = new System.Windows.Forms.Button();
            this.btt_valider = new System.Windows.Forms.Button();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.lbl_identifiant = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(38, 129);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(55, 13);
            this.lbl_question.TabIndex = 0;
            this.lbl_question.Text = "Question :";
            // 
            // lbl_reponse
            // 
            this.lbl_reponse.AutoSize = true;
            this.lbl_reponse.Location = new System.Drawing.Point(38, 183);
            this.lbl_reponse.Name = "lbl_reponse";
            this.lbl_reponse.Size = new System.Drawing.Size(56, 13);
            this.lbl_reponse.TabIndex = 1;
            this.lbl_reponse.Text = "Réponse :";
            // 
            // tb_reponse
            // 
            this.tb_reponse.Location = new System.Drawing.Point(99, 180);
            this.tb_reponse.Name = "tb_reponse";
            this.tb_reponse.Size = new System.Drawing.Size(121, 20);
            this.tb_reponse.TabIndex = 3;
            // 
            // cb_question
            // 
            this.cb_question.FormattingEnabled = true;
            this.cb_question.Location = new System.Drawing.Point(99, 126);
            this.cb_question.Name = "cb_question";
            this.cb_question.Size = new System.Drawing.Size(121, 21);
            this.cb_question.TabIndex = 4;
            // 
            // btt_annuler
            // 
            this.btt_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btt_annuler.Location = new System.Drawing.Point(64, 241);
            this.btt_annuler.Name = "btt_annuler";
            this.btt_annuler.Size = new System.Drawing.Size(75, 23);
            this.btt_annuler.TabIndex = 7;
            this.btt_annuler.Text = "Annuler";
            this.btt_annuler.UseVisualStyleBackColor = true;
            this.btt_annuler.Click += new System.EventHandler(this.btt_annuler_Click);
            // 
            // btt_valider
            // 
            this.btt_valider.Location = new System.Drawing.Point(166, 241);
            this.btt_valider.Name = "btt_valider";
            this.btt_valider.Size = new System.Drawing.Size(75, 23);
            this.btt_valider.TabIndex = 6;
            this.btt_valider.Text = "Valider";
            this.btt_valider.UseVisualStyleBackColor = true;
            this.btt_valider.Click += new System.EventHandler(this.btt_valider_Click);
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(99, 71);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(121, 20);
            this.tb_identifiant.TabIndex = 9;
            // 
            // lbl_identifiant
            // 
            this.lbl_identifiant.AutoSize = true;
            this.lbl_identifiant.Location = new System.Drawing.Point(38, 74);
            this.lbl_identifiant.Name = "lbl_identifiant";
            this.lbl_identifiant.Size = new System.Drawing.Size(59, 13);
            this.lbl_identifiant.TabIndex = 8;
            this.lbl_identifiant.Text = "Identifiant :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(69, 22);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(151, 20);
            this.lbl_titre.TabIndex = 10;
            this.lbl_titre.Text = "Mot de passe oublié";
            // 
            // Mdp_oublie_Form
            // 
            this.AcceptButton = this.btt_valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.tb_identifiant);
            this.Controls.Add(this.lbl_identifiant);
            this.Controls.Add(this.btt_annuler);
            this.Controls.Add(this.btt_valider);
            this.Controls.Add(this.cb_question);
            this.Controls.Add(this.tb_reponse);
            this.Controls.Add(this.lbl_reponse);
            this.Controls.Add(this.lbl_question);
            this.Name = "Mdp_oublie_Form";
            this.Text = "Mot de passe oublié";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Label lbl_reponse;
        private System.Windows.Forms.TextBox tb_reponse;
        private System.Windows.Forms.ComboBox cb_question;
        private System.Windows.Forms.Button btt_annuler;
        private System.Windows.Forms.Button btt_valider;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.Label lbl_identifiant;
        private System.Windows.Forms.Label lbl_titre;
    }
}