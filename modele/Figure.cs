using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.modele
{
    public class Figure
    {
        /* ajouter virtual pour permettre la redefinition */
        public virtual float Surface()
        {
            return 0.0f;
        }

        /* ajouter virtual pour permettre la redefinition */
        public virtual float Perimetre()
        {
            return 0.0f;
        }
    }
}
