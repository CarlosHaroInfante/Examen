using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadConNota1.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public char menu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Quiere volver a hacerlo");
            Console.WriteLine("[0] - N");
            Console.WriteLine("[1] - S");
            Console.WriteLine("-------------------------------");
            char opcionElegida = Convert.ToChar(Console.ReadLine());
            return opcionElegida;
        }
    }
}
