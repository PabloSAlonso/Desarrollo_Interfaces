using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema4WindowsForms;

namespace Tema4WindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioBotones());

        }
    }
}
//Ejercicio 1
//En un formulario con título “Mouse Tester” coloca dos botones. Debe actuar
//de la siguiente forma:
//• Cada vez que el ratón esté dentro del formulario se debe indicar la
//coordenada en el título (p. ej: x: 100, y: 212). También debe hacerlo
//aunque se esté encima de algún componente. Se debe hacer en una
//única función asociada al evento MouseMove.
//• Cuando el puntero está fuera del formulario, se restablece el valor del
//título que había en tiempo de diseño.
//• Los botones “emularán” los botones del ratón (izquierdo y derecho)
//cambiando de color si dicho botón del ratón está pulsado sobre el
//formulario imagen. En caso de un ratón con otros botones dicha
//pulsación coloreará los dos Button al mismo tiempo. Este efecto será
//solo sobre el formulario, no es necesario sobre los componentes del
//mismo.
//• Además si se pulsa alguna tecla, dicha tecla debe aparecer como título
//del formulario. Si se pulsa ESC, entonces se restaura el título del
//formulario.
//• Debajo de los botones, o a un lado, se crearán en tiempo de ejecución
//20 botones en 4 filas y 5 columnas. Dichos botones tendrán en su
//campo text los números del 1 al 20. Cuando algún botón es pulsado su
//número cambia de color y al soltarlo vuelve a negro. Recuerda que las
//coordenadas también deben funcionar en estos botones.
//Al salir debe preguntar al usuario si está seguro y cancelar en caso negativo.
