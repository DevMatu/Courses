using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Aguila : AnimalSalvaje, Flyable
    {
        public override string comunicarse()
        {
            return "kiiaaaaah...kiiaaaah";
        }

        public string volar() ///MÉTODDO OBLIGADO A IMPLEMENTAR///
        {
            return "planeando...";
        }

    }
}
