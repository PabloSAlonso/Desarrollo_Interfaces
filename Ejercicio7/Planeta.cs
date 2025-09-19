using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Planeta : Astro, ITerraformable
    {
        public bool Gaseoso
        {
            set; get;
        }
        public int satelites
        {
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
            }
            get
            {
                return satelites;
            }
        }
        public Planeta(String nombre, double radio, bool gaseoso, int satelites) : base(nombre, radio)
        {
            this.Gaseoso = gaseoso;
            this.satelites = satelites;
        }
        public Planeta() : base("", 1)
        {
            this.Gaseoso = false;
            this.satelites = 0;
        }

        public bool esHabitable()
        {
            if (!this.Gaseoso && base.Radio >= 2000 && base.Radio <= 8000)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }
        public override string ToString()
        {
            return String.Format("%10s %4d %.2f",this.Nombre,this.satelites, this.Radio);
        }
    }
}
