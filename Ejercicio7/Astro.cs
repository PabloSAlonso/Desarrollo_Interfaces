using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_8
{
    public abstract class Astro
    {
        private String nombre;
        private double radio;
        public String Nombre
        {
            set
            {
                nombre = value.ToUpper();
            }
            get
            {
                return "\"" + nombre + "\"";
            }
        }
        public double Radio
        {
            set
            {
                radio = value > 0 ? value : throw new ArgumentException();
            }
            get
            {
                return radio;
            }
        }

        public override bool Equals(object? obj) 
        {
            if (obj is Astro)
            {
                return this.Nombre == ((Astro)obj).Nombre;
            }
            else if (obj is String)
            {
                return this.Nombre == (String)obj;
            }
            else
            {
                return false;
            }
        }



        public Astro(String nombre, double radio)
        {
            this.nombre = nombre;
            this.radio = radio;
        }
        public Astro() : this ("Tierra", 6378)
        {
    
        }
    }
}

