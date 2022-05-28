using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.modele
{
    public class Cercle : Figure
    {
        private float rayon;
        private const float PI = 3.14f;

        /* La propriete LaSurface remplace la fonction Surface, elle est en lecture SEULEMENT */
        public float LaSurface
        {
            get { return PI * rayon * rayon; ; }
        }

        /* La propriete LePerimetre remplace la fonction Perimetre, elle est en lecture SEULEMENT */
        public float LePerimetre
        {
            get { return 2 * PI * rayon; }
        }

        public float Rayon
        {
            get { return this.rayon; }
            set {
                /* Il est INTERDIT que le rayon soit negatif (logique applicative) */
                if (value < 0) throw new ArgumentException("Le rayon de doit pas etre negatif.");
                this.rayon = value; }
        }

        public Cercle() { }

        public Cercle(float rayon)
        {
            this.rayon = rayon;
        }

        /*public float getRayon()
        {
            return this.rayon;
        }*/

        /*public void setRayon(float rayon)
        {
            this.rayon = rayon;
        }*/

        /* une fonction redefinie doit AVOIR le parametre OVERRIDE */
        public override float Surface()
        {
            float surf = PI * rayon * rayon;
            return surf;
        }

        /* une fonction redefinie doit AVOIR le parametre OVERRIDE */
        public override float Perimetre()
        {
            float perm = 2 * PI * rayon;
            return perm;
        }

        /* ToString genere un message personnalisee sur l'objet en cours */
        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendFormat("-----\nCercle\n Rayon={0} \t Surface={1} \t Perimetre={2}\n----- \n-----", this.rayon, this.Surface(), this.Perimetre());
            return message.ToString();
        }
    }
}
