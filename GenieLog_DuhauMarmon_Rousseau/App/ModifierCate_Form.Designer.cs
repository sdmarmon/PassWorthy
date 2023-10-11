namespace App
{
    partial class ModifierCate_Form
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
            this.btt_supprimer = new System.Windows.Forms.Button();
            this.btt_modifier = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_annuler
            // 
            this.btt_annuler.Location = new System.Drawing.Point(28, 123);
            this.btt_annuler.Name = "btt_annuler";
            this.btt_annuler.Size = new System.Drawing.Size(75, 23);
            this.btt_annuler.TabIndex = 0;
            this.btt_annuler.Text = "Annuler";
            this.btt_annuler.UseVisualStyleBackColor = true;
            this.btt_annuler.Click += new System.EventHandler(this.btt_annuler_Click);
            // 
            // btt_supprimer
            // 
            this.btt_supprimer.Location = new System.Drawing.Point(109, 123);
            this.btt_supprimer.Name = "btt_supprimer";
            this.btt_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btt_supprimer.TabIndex = 1;
            this.btt_supprimer.Text = "Supprimer";
            this.btt_supprimer.UseVisualStyleBackColor = true;
            this.btt_supprimer.Click += new System.EventHandler(this.btt_supprimer_Click);
            // 
            // btt_modifier
            // 
            this.btt_modifier.Location = new System.Drawing.Point(190, 123);
            this.btt_modifier.Name = "btt_modifier";
            this.btt_modifier.Size = new System.Drawing.Size(75, 23);
            this.btt_modifier.TabIndex = 2;
            this.btt_modifier.Text = "Modifier";
            this.btt_modifier.UseVisualStyleBackColor = true;
            this.btt_modifier.Click += new System.EventHandler(this.btt_modifier_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(31, 77);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(108, 13);
            this.lbl_nom.TabIndex = 3;
            this.lbl_nom.Text = "Nom de la catégorie :";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(145, 70);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 20);
            this.tb.TabIndex = 4;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(38, 21);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(207, 20);
            this.lbl_titre.TabIndex = 5;
            this.lbl_titre.Text = "Modification d\'une catégorie";
            // 
            // ModifierCate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.btt_modifier);
            this.Controls.Add(this.btt_supprimer);
            this.Controls.Add(this.btt_annuler);
            this.Name = "ModifierCate_Form";
            this.Text = "Modifier une catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_annuler;
        private System.Windows.Forms.Button btt_supprimer;
        private System.Windows.Forms.Button btt_modifier;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lbl_titre;
    }
}