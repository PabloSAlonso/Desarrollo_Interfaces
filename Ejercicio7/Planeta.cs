using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_8
{
    public class Planeta : Astro, ITerraformable
    {
        public bool Gaseoso { set; get; }

        private int satelites;
        public int Satelites
        {
            set//TODO no guarda
            {
                if (value < 0)
                {
                    satelites = 0;
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
        public Planeta() : this("", 0.00, false, 0)
        {
            
        }

        public bool esHabitable()
        {
            if (!this.Gaseoso && base.Radio >= 2000 && base.Radio <= 8000)//return esto
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
            return String.Format("Nombre:{0,10}\nSatelites:{1,4}\nRadio:{2,8:.00}", this.Nombre, this.satelites, this.Radio);
        }
        public static Planeta operator ++(Planeta p1)
        {
            p1.satelites++;
            return p1;
        }
        public static Planeta operator --(Planeta p1)
        {
            if (p1.satelites <= 0)
            {
                return p1;
            }
            else
            {
                p1.satelites--;
                return p1;
            }

        }
    }
}
