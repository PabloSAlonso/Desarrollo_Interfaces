using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_8
{
    public class Cometa : Astro, ITerraformable
    {
        public bool esHabitable()
        {
            return false;
        }
    }
}
