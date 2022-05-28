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
    public partial class Form3 : Form
    {
        private List<Figure> figures = null;

        public Form3(List<Figure> liste)
        {
            InitializeComponent();
            this.figures = liste;
        }

        private void btnAddForme_Click(object sender, EventArgs e)
        {
            float longueur = Convert.ToSingle(txtLongueur.Text);
            float largeur = Convert.ToSingle(txtLargeur.Text);
            Figure forme = null;

            switch (cmbForme.Text)
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
            this.Close();
        }
    }
}
