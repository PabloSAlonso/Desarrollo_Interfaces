using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioo9
{
    public class Ordenador
    {
        public string Nombre { set; get; }

        private int memoriaRAM;
        public int MemoriaRam
        {
            set
            {
                memoriaRAM = value < 0 ? value : 16;
            }
            get
            {
                return memoriaRAM;
            }
        }
        public Ordenador(string nombre, int MemoriaRam)
        {
            Nombre = nombre;
            memoriaRAM = MemoriaRam;
        }

        public Ordenador()
        {
            Nombre = "";
            memoriaRAM = 0;
        }

        public static bool comprobarIp(string ip)
        {
            bool flag = true;
            string[] ipSplited = ip.Split(".");
            if (ipSplited.Length == 4)
            {
                foreach (var ipElement in ipSplited)
                {
                    return (byte.TryParse(ipElement, out _));
                }
            }
            return false;
        }

        public String pedirIp()
        {
            string ip = Console.ReadLine();
            while (!comprobarIp(ip))
            {
                Console.WriteLine("La ip no es valida, introducela de nuevo");
                ip = Console.ReadLine();
            }
            return ip;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, MemoriaRAM: {MemoriaRam}";
        }
    }
}
