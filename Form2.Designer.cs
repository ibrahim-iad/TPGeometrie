namespace TP4
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddForme = new System.Windows.Forms.Button();
            this.lstFormes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddForme);
            this.groupBox1.Controls.Add(this.lstFormes);
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddForme
            // 
            this.btnAddForme.Location = new System.Drawing.Point(182, 265);
            this.btnAddForme.Name = "btnAddForme";
            this.btnAddForme.Size = new System.Drawing.Size(138, 23);
            this.btnAddForme.TabIndex = 1;
            this.btnAddForme.Text = "Ajouter";
            this.btnAddForme.UseVisualStyleBackColor = true;
            this.btnAddForme.Click += new System.EventHandler(this.btnAddForme_Click);
            // 
            // lstFormes
            // 
            this.lstFormes.FormattingEnabled = true;
            this.lstFormes.Location = new System.Drawing.Point(7, 20);
            this.lstFormes.Name = "lstFormes";
            this.lstFormes.Size = new System.Drawing.Size(478, 238);
            this.lstFormes.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 337);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstFormes;
        private System.Windows.Forms.Button btnAddForme;
    }
}