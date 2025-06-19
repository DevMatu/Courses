using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_Métodos
{
    internal class Animal
    {

        public virtual string comunicarse()
        {
            return "Ruido...Ruido...";
        }

    }
}
