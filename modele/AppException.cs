using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.modele
{
    /* Exception personnalisee representant la logique de l'application */
    class AppException : Exception
    {
        public AppException(string message) : base(message)
        {

        }
    }
}
