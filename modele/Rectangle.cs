using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.modele
{
    public class Rectangle : Figure
    {
        private float longueur;
        private float largeur;

        public float Longueur
        {
            get { return this.longueur; }
            set
            {
                /* utilisation d'une Exception personnalisee */
                /* Il est INTERDIT que la longueur soit negative (logique applicative) */
                if (value < 0) throw new AppException("La longueur ne doit pas etre negative.");
                this.longueur = value;
            }
        }

        public float Largeur
        {
            get { return this.largeur; }
            set
            {
                /* utilisation d'une Exception generale */
                /* Il est INTERDIT que la largeur soit negative (logique applicative) */
                if (value < 0) throw new ArgumentException("La largeur de doit pas etre negative.");
                this.largeur = value;
            }
        }

        /* La propriete LaSurface remplace la fonction Surface, elle est en lecture SEULEMENT */
        public float LaSurface
        {
            get { return this.largeur * this.longueur; }
        }

        /* La propriete LePerimetre remplace la fonction Perimetre, elle est en lecture SEULEMENT */
        public float LePerimetre
        {
            get { return 2 * (this.largeur * this.longueur); }
        }

        public Rectangle() { }

        public Rectangle(float longueur, float largeur)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        /*public float getLongueur()
        {
            return this.longueur;
        }*/

        /*public void setLongueur(float longueur)
        {
            this.longueur = longueur;
        }*/

        /*public float getLargeur()
        {
            return this.largeur;
        }*/

        /*public void setLargeur(float largeur)
        {
            this.largeur = largeur;
        }*/

        /* une fonction redefinie doit AVOIR le paramtre OVERRIDE */
        public override float Perimetre()
        {
            float per = 2 * (this.longueur + this.largeur);
            return per;
        }

        /* une fonction redefinie doit AVOIR le paramtre OVERRIDE */
        public override float Surface()
        {
            float surf = this.longueur * this.largeur;
            return surf;
        }

        /* ToString genere un message personnalisee sur l'objet en cours */
        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendFormat("-----\nRectangle\n Longueur={0} \t Largeur={1} \t", this.longueur, this.largeur);
            message.AppendFormat("Surface={0} \t Perimetre={1}\n-----", this.Surface(), this.Perimetre());
            return message.ToString();
        }
    }
}
