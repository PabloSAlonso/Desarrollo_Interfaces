using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Examen
{
    public class Record
    {
        private string Nombre { get; set; }
        private int Edad
        {
            get => Edad;
            set
            {
                Edad = value < 0 ? throw new ArgumentException("La edad debe ser positiva") : value;
            }
        }
        private int Puntuacion { get; set; }

        public Record(String nombre, int edad, int puntuacion)
        {
            Nombre = nombre;
            Edad = edad;
            Puntuacion = puntuacion;
        }

        public override String ToString()
        {
            return String.Format($"Nombre:{Nombre}, Edad:{Edad}, Puntuación:{Puntuacion}");
        }
    }
}
