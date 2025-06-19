using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Canario : AnimalDomestico, Flyable
    {
        public override string comunicarse()
        {
            return "tuiu...tuit";
        }

        public string volar() ///MÉTODDO OBLIGADO A IMPLEMENTAR///
        {
            return "volando...";
        }
    }
}
