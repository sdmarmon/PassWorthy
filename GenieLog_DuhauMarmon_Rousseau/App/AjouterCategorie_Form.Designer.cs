namespace App
{
    partial class AjouterCategorie_Form
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
            this.btt_reinitialiser = new System.Windows.Forms.Button();
            this.btt_ajout = new System.Windows.Forms.Button();
            this.lbl_ajout = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_reinitialiser
            // 
            this.btt_reinitialiser.Location = new System.Drawing.Point(52, 122);
            this.btt_reinitialiser.Name = "btt_reinitialiser";
            this.btt_reinitialiser.Size = new System.Drawing.Size(75, 23);
            this.btt_reinitialiser.TabIndex = 32;
            this.btt_reinitialiser.Text = "Réinitialiser";
            this.btt_reinitialiser.UseVisualStyleBackColor = true;
            this.btt_reinitialiser.Click += new System.EventHandler(this.btt_reinitialiser_Click);
            // 
            // btt_ajout
            // 
            this.btt_ajout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btt_ajout.Location = new System.Drawing.Point(159, 122);
            this.btt_ajout.Name = "btt_ajout";
            this.btt_ajout.Size = new System.Drawing.Size(75, 23);
            this.btt_ajout.TabIndex = 30;
            this.btt_ajout.Text = "Ajouter";
            this.btt_ajout.UseVisualStyleBackColor = true;
            this.btt_ajout.Click += new System.EventHandler(this.btt_ajout_Click);
            // 
            // lbl_ajout
            // 
            this.lbl_ajout.AutoSize = true;
            this.lbl_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajout.Location = new System.Drawing.Point(59, 20);
            this.lbl_ajout.Name = "lbl_ajout";
            this.lbl_ajout.Size = new System.Drawing.Size(159, 20);
            this.lbl_ajout.TabIndex = 28;
            this.lbl_ajout.Text = "Ajout d\'une catégorie";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(142, 67);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(101, 20);
            this.tb_nom.TabIndex = 23;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(28, 70);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(108, 13);
            this.lbl_nom.TabIndex = 20;
            this.lbl_nom.Text = "Nom de la catégorie :";
            // 
            // AjouterCategorie_Form
            // 
            this.AcceptButton = this.btt_ajout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.btt_reinitialiser);
            this.Controls.Add(this.btt_ajout);
            this.Controls.Add(this.lbl_ajout);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.lbl_nom);
            this.Name = "AjouterCategorie_Form";
            this.Text = "Ajouter une catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_reinitialiser;
        private System.Windows.Forms.Button btt_ajout;
        private System.Windows.Forms.Label lbl_ajout;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label lbl_nom;
    }
}