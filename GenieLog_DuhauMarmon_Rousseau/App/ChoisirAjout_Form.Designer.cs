namespace App
{
    partial class ChoisirAjout_Form
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
            this.btt_compte = new System.Windows.Forms.Button();
            this.btt_categorie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_compte
            // 
            this.btt_compte.Location = new System.Drawing.Point(81, 83);
            this.btt_compte.Name = "btt_compte";
            this.btt_compte.Size = new System.Drawing.Size(75, 23);
            this.btt_compte.TabIndex = 0;
            this.btt_compte.Text = "Compte";
            this.btt_compte.UseVisualStyleBackColor = true;
            this.btt_compte.Click += new System.EventHandler(this.btt_compte_Click);
            // 
            // btt_categorie
            // 
            this.btt_categorie.Location = new System.Drawing.Point(186, 83);
            this.btt_categorie.Name = "btt_categorie";
            this.btt_categorie.Size = new System.Drawing.Size(75, 23);
            this.btt_categorie.TabIndex = 1;
            this.btt_categorie.Text = "Catégorie";
            this.btt_categorie.UseVisualStyleBackColor = true;
            this.btt_categorie.Click += new System.EventHandler(this.btt_categorie_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajout d\'un compte ou d\'une catégorie";
            // 
            // ChoisirAjout_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 126);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_categorie);
            this.Controls.Add(this.btt_compte);
            this.Name = "ChoisirAjout_Form";
            this.Text = "Que voulez-vous ajouter?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_compte;
        private System.Windows.Forms.Button btt_categorie;
        private System.Windows.Forms.Label label1;
    }
}