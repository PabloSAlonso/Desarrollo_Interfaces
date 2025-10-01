using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Ordenador
    {
        private string nombre;
        private int memoriaRAM;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int MemoriaRAM
        {
            set
            {
                if (MemoriaRAM < 0)
                {
                    MemoriaRAM = 16;
                }
                memoriaRAM = value;
            }
            get
            {
                return memoriaRAM;
            }

        }
        public static bool compruebaIps(String bytes)
        {
            string[] separados = bytes.Split(".");
            if (separados.Length == 4)
            {
                foreach (var num in separados) 
                {
                    if (!byte.TryParse(num, out _))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, MemoriaRAM: {MemoriaRAM}";
        }
    }
}