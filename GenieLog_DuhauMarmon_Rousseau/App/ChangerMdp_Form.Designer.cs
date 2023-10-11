namespace App
{
    partial class ChangerMdp_Form
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
            this.btt_annuler = new System.Windows.Forms.Button();
            this.btt_ok = new System.Windows.Forms.Button();
            this.tb_actuel = new System.Windows.Forms.TextBox();
            this.tb_nouveau = new System.Windows.Forms.TextBox();
            this.lbl_actuel = new System.Windows.Forms.Label();
            this.lbl_nouveau = new System.Windows.Forms.Label();
            this.btt_generer = new System.Windows.Forms.Button();
            this.tb_force = new System.Windows.Forms.TextBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_annuler
            // 
            this.btt_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btt_annuler.Location = new System.Drawing.Point(121, 171);
            this.btt_annuler.Name = "btt_annuler";
            this.btt_annuler.Size = new System.Drawing.Size(75, 23);
            this.btt_annuler.TabIndex = 0;
            this.btt_annuler.Text = "Annuler";
            this.btt_annuler.UseVisualStyleBackColor = true;
            this.btt_annuler.Click += new System.EventHandler(this.btt_annuler_Click);
            // 
            // btt_ok
            // 
            this.btt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btt_ok.Location = new System.Drawing.Point(233, 171);
            this.btt_ok.Name = "btt_ok";
            this.btt_ok.Size = new System.Drawing.Size(75, 23);
            this.btt_ok.TabIndex = 1;
            this.btt_ok.Text = "OK";
            this.btt_ok.UseVisualStyleBackColor = true;
            // 
            // tb_actuel
            // 
            this.tb_actuel.Location = new System.Drawing.Point(145, 64);
            this.tb_actuel.Name = "tb_actuel";
            this.tb_actuel.Size = new System.Drawing.Size(127, 20);
            this.tb_actuel.TabIndex = 2;
            // 
            // tb_nouveau
            // 
            this.tb_nouveau.Location = new System.Drawing.Point(145, 120);
            this.tb_nouveau.Name = "tb_nouveau";
            this.tb_nouveau.Size = new System.Drawing.Size(127, 20);
            this.tb_nouveau.TabIndex = 3;
            this.tb_nouveau.TextChanged += new System.EventHandler(this.tb_nouveau_TextChanged);
            // 
            // lbl_actuel
            // 
            this.lbl_actuel.AutoSize = true;
            this.lbl_actuel.Location = new System.Drawing.Point(19, 67);
            this.lbl_actuel.Name = "lbl_actuel";
            this.lbl_actuel.Size = new System.Drawing.Size(109, 13);
            this.lbl_actuel.TabIndex = 4;
            this.lbl_actuel.Text = "Mot de passe actuel :";
            // 
            // lbl_nouveau
            // 
            this.lbl_nouveau.AutoSize = true;
            this.lbl_nouveau.Location = new System.Drawing.Point(19, 123);
            this.lbl_nouveau.Name = "lbl_nouveau";
            this.lbl_nouveau.Size = new System.Drawing.Size(123, 13);
            this.lbl_nouveau.TabIndex = 5;
            this.lbl_nouveau.Text = "Nouveau mot de passe :";
            // 
            // btt_generer
            // 
            this.btt_generer.Location = new System.Drawing.Point(276, 120);
            this.btt_generer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btt_generer.Name = "btt_generer";
            this.btt_generer.Size = new System.Drawing.Size(63, 19);
            this.btt_generer.TabIndex = 6;
            this.btt_generer.Text = "Générer";
            this.btt_generer.UseVisualStyleBackColor = true;
            this.btt_generer.Click += new System.EventHandler(this.btt_generer_Click);
            // 
            // tb_force
            // 
            this.tb_force.BackColor = System.Drawing.Color.DimGray;
            this.tb_force.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_force.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_force.Location = new System.Drawing.Point(344, 118);
            this.tb_force.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_force.Name = "tb_force";
            this.tb_force.ReadOnly = true;
            this.tb_force.Size = new System.Drawing.Size(76, 23);
            this.tb_force.TabIndex = 22;
            this.tb_force.Text = "Force";
            this.tb_force.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(106, 18);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(223, 20);
            this.lbl_titre.TabIndex = 23;
            this.lbl_titre.Text = "Changement de mot de passe";
            // 
            // ChangerMdp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 218);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.tb_force);
            this.Controls.Add(this.btt_generer);
            this.Controls.Add(this.lbl_nouveau);
            this.Controls.Add(this.lbl_actuel);
            this.Controls.Add(this.tb_nouveau);
            this.Controls.Add(this.tb_actuel);
            this.Controls.Add(this.btt_ok);
            this.Controls.Add(this.btt_annuler);
            this.Name = "ChangerMdp_Form";
            this.Text = "Changer de mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_annuler;
        private System.Windows.Forms.Button btt_ok;
        private System.Windows.Forms.TextBox tb_actuel;
        private System.Windows.Forms.TextBox tb_nouveau;
        private System.Windows.Forms.Label lbl_actuel;
        private System.Windows.Forms.Label lbl_nouveau;
        private System.Windows.Forms.Button btt_generer;
        private System.Windows.Forms.TextBox tb_force;
        private System.Windows.Forms.Label lbl_titre;
    }
}