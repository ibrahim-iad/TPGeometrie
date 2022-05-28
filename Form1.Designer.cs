namespace TP4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbForme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnAddForme = new System.Windows.Forms.Button();
            this.txtLargeur = new System.Windows.Forms.TextBox();
            this.txtLongueur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbForme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAfficher);
            this.groupBox1.Controls.Add(this.btnAddForme);
            this.groupBox1.Controls.Add(this.txtLargeur);
            this.groupBox1.Controls.Add(this.txtLongueur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbForme
            // 
            this.cmbForme.FormattingEnabled = true;
            this.cmbForme.Items.AddRange(new object[] {
            "Rectangle",
            "Cercle"});
            this.cmbForme.Location = new System.Drawing.Point(107, 107);
            this.cmbForme.Name = "cmbForme";
            this.cmbForme.Size = new System.Drawing.Size(171, 21);
            this.cmbForme.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forme:";
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(189, 149);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 5;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnAddForme
            // 
            this.btnAddForme.Location = new System.Drawing.Point(107, 149);
            this.btnAddForme.Name = "btnAddForme";
            this.btnAddForme.Size = new System.Drawing.Size(75, 23);
            this.btnAddForme.TabIndex = 4;
            this.btnAddForme.Text = "Ajouter";
            this.btnAddForme.UseVisualStyleBackColor = true;
            this.btnAddForme.Click += new System.EventHandler(this.btnAddForme_Click);
            // 
            // txtLargeur
            // 
            this.txtLargeur.Location = new System.Drawing.Point(107, 65);
            this.txtLargeur.Name = "txtLargeur";
            this.txtLargeur.Size = new System.Drawing.Size(171, 20);
            this.txtLargeur.TabIndex = 3;
            this.txtLargeur.Text = "0";
            // 
            // txtLongueur
            // 
            this.txtLongueur.Location = new System.Drawing.Point(107, 17);
            this.txtLongueur.Name = "txtLongueur";
            this.txtLongueur.Size = new System.Drawing.Size(171, 20);
            this.txtLongueur.TabIndex = 2;
            this.txtLongueur.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largeur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longueur / Rayon:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 227);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLargeur;
        private System.Windows.Forms.TextBox txtLongueur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbForme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnAddForme;
    }
}

