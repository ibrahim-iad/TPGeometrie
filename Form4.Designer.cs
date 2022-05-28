namespace TP4
{
    partial class Form4
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
            this.dgvFormes = new System.Windows.Forms.DataGridView();
            this.btnAddForme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFormes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvFormes
            // 
            this.dgvFormes.AllowUserToAddRows = false;
            this.dgvFormes.AllowUserToDeleteRows = false;
            this.dgvFormes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormes.Location = new System.Drawing.Point(3, 16);
            this.dgvFormes.Name = "dgvFormes";
            this.dgvFormes.ReadOnly = true;
            this.dgvFormes.Size = new System.Drawing.Size(528, 304);
            this.dgvFormes.TabIndex = 0;
            // 
            // btnAddForme
            // 
            this.btnAddForme.Location = new System.Drawing.Point(206, 342);
            this.btnAddForme.Name = "btnAddForme";
            this.btnAddForme.Size = new System.Drawing.Size(132, 23);
            this.btnAddForme.TabIndex = 1;
            this.btnAddForme.Text = "Ajouter";
            this.btnAddForme.UseVisualStyleBackColor = true;
            this.btnAddForme.Click += new System.EventHandler(this.btnAddForme_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 380);
            this.Controls.Add(this.btnAddForme);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFormes;
        private System.Windows.Forms.Button btnAddForme;
    }
}