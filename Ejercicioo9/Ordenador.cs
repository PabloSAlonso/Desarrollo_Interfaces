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

        public Ordenador() : this("", 0)
        {

        }

        public static bool comprobarIp(string ip)
        {
            bool flag = true;
            string[] ipSplited = ip.Split(".");
            if (ipSplited.Length == 4)
            {
                for (int i = 0; i < ipSplited.Length; i++)
                {
                    if (!byte.TryParse(ipSplited[i], out _))
                    {
                        return false;
                    }

                }
            }
            else
            {
                return false;
            }
            return true;
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
