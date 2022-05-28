using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.modele;

namespace TP4
{
    public partial class Form1 : Form
    {
        private List<Figure> figures;

        public Form1()
        {
            InitializeComponent();
            this.figures = new List<Figure>();
        }


        private void btnAddForme_Click(object sender, EventArgs e)
        {
            float longueur = Convert.ToSingle(txtLongueur.Text);
            float largeur = Convert.ToSingle(txtLargeur.Text);
            Figure forme = null;

            switch(cmbForme.Text)
            {
                case "Rectangle":
                    forme = new Rectangle(longueur, largeur);
                    break;
                case "Cercle":
                    forme = new Cercle(longueur);
                    break;
                default:
                    return;
            }

            this.figures.Add(forme);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            foreach(Figure f in this.figures)
            {
                MessageBox.Show(f.ToString(), "Mes figures");
            }
        }
    }
}
