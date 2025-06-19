using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_Métodos
{
    internal class Gato : AnimalDomestico
    {

       public override string comunicarse()
        {
            return "Miau...Miau...";
        }

    }
}
