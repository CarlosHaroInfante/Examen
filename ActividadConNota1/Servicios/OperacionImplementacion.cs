using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadConNota1.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public bool bisiesto(int any)
        {
            bool bisiesto = true;
            Console.WriteLine(any);



            if (any % 4 == 0)
            {
                Console.WriteLine("Es divisible entre 4");

                if (any % 100 == 0)
                {
                    Console.WriteLine("Tambien es Divisible entre 100");

                    if (any % 400 == 0)
                    {
                        Console.WriteLine("Tambien es Divisible entre 400");

                    }
                }

            }



            else
            {
                Console.WriteLine("No es Año Bisiesto");
                bisiesto = false;

            }

            return bisiesto;

        }

        public int dias(bool bisiesto)
        {
            bool dia = bisiesto;
            
            return dia;
        }
    }
}

    

