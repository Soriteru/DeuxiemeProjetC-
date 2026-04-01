namespace DeuxiemeProjet
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxImmat = new System.Windows.Forms.TextBox();
            this.radioEssence = new System.Windows.Forms.RadioButton();
            this.radioDiesel = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxAnnee = new System.Windows.Forms.TextBox();
            this.TextBoxCheveaux = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEnreg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAffich = new System.Windows.Forms.Button();
            this.listPrime = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxVoit = new System.Windows.Forms.TextBox();
            this.buttonCalcul = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCouleur = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro d\'Immatriculation :";
            // 
            // TextBoxImmat
            // 
            this.TextBoxImmat.Location = new System.Drawing.Point(183, 21);
            this.TextBoxImmat.Name = "TextBoxImmat";
            this.TextBoxImmat.Size = new System.Drawing.Size(100, 22);
            this.TextBoxImmat.TabIndex = 1;
            this.TextBoxImmat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioEssence
            // 
            this.radioEssence.AutoSize = true;
            this.radioEssence.Location = new System.Drawing.Point(57, 57);
            this.radioEssence.Name = "radioEssence";
            this.radioEssence.Size = new System.Drawing.Size(81, 20);
            this.radioEssence.TabIndex = 2;
            this.radioEssence.TabStop = true;
            this.radioEssence.Text = "Essence";
            this.radioEssence.UseVisualStyleBackColor = true;
            // 
            // radioDiesel
            // 
            this.radioDiesel.AutoSize = true;
            this.radioDiesel.Location = new System.Drawing.Point(197, 57);
            this.radioDiesel.Name = "radioDiesel";
            this.radioDiesel.Size = new System.Drawing.Size(67, 20);
            this.radioDiesel.TabIndex = 3;
            this.radioDiesel.TabStop = true;
            this.radioDiesel.Text = "Diesel";
            this.radioDiesel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Année :";
            // 
            // TextBoxAnnee
            // 
            this.TextBoxAnnee.Location = new System.Drawing.Point(71, 99);
            this.TextBoxAnnee.Name = "TextBoxAnnee";
            this.TextBoxAnnee.Size = new System.Drawing.Size(126, 22);
            this.TextBoxAnnee.TabIndex = 5;
            // 
            // TextBoxCheveaux
            // 
            this.TextBoxCheveaux.Location = new System.Drawing.Point(136, 134);
            this.TextBoxCheveaux.Name = "TextBoxCheveaux";
            this.TextBoxCheveaux.Size = new System.Drawing.Size(61, 22);
            this.TextBoxCheveaux.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Chevaux :";
            // 
            // buttonEnreg
            // 
            this.buttonEnreg.Location = new System.Drawing.Point(90, 183);
            this.buttonEnreg.Name = "buttonEnreg";
            this.buttonEnreg.Size = new System.Drawing.Size(87, 28);
            this.buttonEnreg.TabIndex = 8;
            this.buttonEnreg.Text = "Enregistrer";
            this.buttonEnreg.UseVisualStyleBackColor = true;
            this.buttonEnreg.Click += new System.EventHandler(this.buttonEnreg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bénéficiaire Prime :";
            // 
            // buttonAffich
            // 
            this.buttonAffich.Location = new System.Drawing.Point(324, 53);
            this.buttonAffich.Name = "buttonAffich";
            this.buttonAffich.Size = new System.Drawing.Size(75, 23);
            this.buttonAffich.TabIndex = 10;
            this.buttonAffich.Text = "Afficher";
            this.buttonAffich.UseVisualStyleBackColor = true;
            this.buttonAffich.Click += new System.EventHandler(this.buttonAffich_Click);
            // 
            // listPrime
            // 
            this.listPrime.FormattingEnabled = true;
            this.listPrime.ItemHeight = 16;
            this.listPrime.Location = new System.Drawing.Point(406, 53);
            this.listPrime.Name = "listPrime";
            this.listPrime.Size = new System.Drawing.Size(120, 84);
            this.listPrime.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Calcul Vignette :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Immatriculation :";
            // 
            // TextBoxVoit
            // 
            this.TextBoxVoit.Location = new System.Drawing.Point(483, 204);
            this.TextBoxVoit.Name = "TextBoxVoit";
            this.TextBoxVoit.Size = new System.Drawing.Size(65, 22);
            this.TextBoxVoit.TabIndex = 14;
            // 
            // buttonCalcul
            // 
            this.buttonCalcul.Location = new System.Drawing.Point(382, 233);
            this.buttonCalcul.Name = "buttonCalcul";
            this.buttonCalcul.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcul.TabIndex = 15;
            this.buttonCalcul.Text = "Calculer";
            this.buttonCalcul.UseVisualStyleBackColor = true;
            this.buttonCalcul.Click += new System.EventHandler(this.buttonCalcul_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Couleur :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numéro :";
            // 
            // labelCouleur
            // 
            this.labelCouleur.AutoSize = true;
            this.labelCouleur.Location = new System.Drawing.Point(545, 236);
            this.labelCouleur.Name = "labelCouleur";
            this.labelCouleur.Size = new System.Drawing.Size(26, 16);
            this.labelCouleur.TabIndex = 18;
            this.labelCouleur.Text = "NA";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(545, 260);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(26, 16);
            this.labelNumero.TabIndex = 19;
            this.labelNumero.Text = "NA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 599);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelCouleur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCalcul);
            this.Controls.Add(this.TextBoxVoit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listPrime);
            this.Controls.Add(this.buttonAffich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEnreg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxCheveaux);
            this.Controls.Add(this.TextBoxAnnee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioDiesel);
            this.Controls.Add(this.radioEssence);
            this.Controls.Add(this.TextBoxImmat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxImmat;
        private System.Windows.Forms.RadioButton radioEssence;
        private System.Windows.Forms.RadioButton radioDiesel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxAnnee;
        private System.Windows.Forms.TextBox TextBoxCheveaux;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEnreg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAffich;
        private System.Windows.Forms.ListBox listPrime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxVoit;
        private System.Windows.Forms.Button buttonCalcul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCouleur;
        private System.Windows.Forms.Label labelNumero;
    }
}

