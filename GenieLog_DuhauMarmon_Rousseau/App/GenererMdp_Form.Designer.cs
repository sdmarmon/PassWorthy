namespace App
{
    partial class GenererMdp_Form
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
            this.num_carac = new System.Windows.Forms.NumericUpDown();
            this.num_symb = new System.Windows.Forms.NumericUpDown();
            this.num_chiffres = new System.Windows.Forms.NumericUpDown();
            this.lbl_carac = new System.Windows.Forms.Label();
            this.lbl_chiffres = new System.Windows.Forms.Label();
            this.lbl_symb = new System.Windows.Forms.Label();
            this.btt_generer = new System.Windows.Forms.Button();
            this.lbl_titre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_carac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_symb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_chiffres)).BeginInit();
            this.SuspendLayout();
            // 
            // num_carac
            // 
            this.num_carac.Location = new System.Drawing.Point(152, 63);
            this.num_carac.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_carac.Name = "num_carac";
            this.num_carac.Size = new System.Drawing.Size(44, 20);
            this.num_carac.TabIndex = 0;
            this.num_carac.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_carac.ValueChanged += new System.EventHandler(this.num_carac_ValueChanged);
            // 
            // num_symb
            // 
            this.num_symb.Location = new System.Drawing.Point(152, 155);
            this.num_symb.Name = "num_symb";
            this.num_symb.Size = new System.Drawing.Size(44, 20);
            this.num_symb.TabIndex = 1;
            this.num_symb.ValueChanged += new System.EventHandler(this.num_symb_ValueChanged);
            // 
            // num_chiffres
            // 
            this.num_chiffres.Location = new System.Drawing.Point(152, 110);
            this.num_chiffres.Name = "num_chiffres";
            this.num_chiffres.Size = new System.Drawing.Size(44, 20);
            this.num_chiffres.TabIndex = 2;
            this.num_chiffres.ValueChanged += new System.EventHandler(this.num_chiffres_ValueChanged);
            // 
            // lbl_carac
            // 
            this.lbl_carac.AutoSize = true;
            this.lbl_carac.Location = new System.Drawing.Point(12, 65);
            this.lbl_carac.Name = "lbl_carac";
            this.lbl_carac.Size = new System.Drawing.Size(112, 13);
            this.lbl_carac.TabIndex = 3;
            this.lbl_carac.Text = "Nombre de caractères";
            // 
            // lbl_chiffres
            // 
            this.lbl_chiffres.AutoSize = true;
            this.lbl_chiffres.Location = new System.Drawing.Point(12, 112);
            this.lbl_chiffres.Name = "lbl_chiffres";
            this.lbl_chiffres.Size = new System.Drawing.Size(96, 13);
            this.lbl_chiffres.TabIndex = 4;
            this.lbl_chiffres.Text = "Nombre de chiffres";
            // 
            // lbl_symb
            // 
            this.lbl_symb.AutoSize = true;
            this.lbl_symb.Location = new System.Drawing.Point(12, 156);
            this.lbl_symb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_symb.Name = "lbl_symb";
            this.lbl_symb.Size = new System.Drawing.Size(105, 13);
            this.lbl_symb.TabIndex = 5;
            this.lbl_symb.Text = "Nombre de symboles";
            // 
            // btt_generer
            // 
            this.btt_generer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btt_generer.Location = new System.Drawing.Point(75, 199);
            this.btt_generer.Margin = new System.Windows.Forms.Padding(2);
            this.btt_generer.Name = "btt_generer";
            this.btt_generer.Size = new System.Drawing.Size(56, 19);
            this.btt_generer.TabIndex = 6;
            this.btt_generer.Text = "Générer";
            this.btt_generer.UseVisualStyleBackColor = true;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(11, 18);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(190, 20);
            this.lbl_titre.TabIndex = 7;
            this.lbl_titre.Text = "Générer un mot de passe";
            // 
            // GenererMdp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 235);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.btt_generer);
            this.Controls.Add(this.lbl_symb);
            this.Controls.Add(this.lbl_chiffres);
            this.Controls.Add(this.lbl_carac);
            this.Controls.Add(this.num_chiffres);
            this.Controls.Add(this.num_symb);
            this.Controls.Add(this.num_carac);
            this.Name = "GenererMdp_Form";
            this.Text = "Générer le mot de passe";
            ((System.ComponentModel.ISupportInitialize)(this.num_carac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_symb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_chiffres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_carac;
        private System.Windows.Forms.NumericUpDown num_symb;
        private System.Windows.Forms.NumericUpDown num_chiffres;
        private System.Windows.Forms.Label lbl_carac;
        private System.Windows.Forms.Label lbl_chiffres;
        private System.Windows.Forms.Label lbl_symb;
        private System.Windows.Forms.Button btt_generer;
        private System.Windows.Forms.Label lbl_titre;
    }
}