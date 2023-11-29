using ActividadConNota1.Servicios;

class Program
{
    static void Main(string[] args)
    {
        NumeroInterfaz num = new NumeroImplementacion();
        int a = num.Mes();
        int b = num.año();


        OperacionInterfaz calculo = new OperacionImplementacion();
        bool bisiesto = calculo.bisiesto(b);
        Console.WriteLine(bisiesto);

        int dias = calculo.dias(a);
        switch (a) {
            case 0:

                a = 1;
                a = 3;
                a = 5;
                a = 7;
                a = 8;
                a = 10;
                a = 12;
                Console.WriteLine("Tienen 31 Dias");
                Console.WriteLine("Enero, Marzo, Mayo, Julio, Agosto, Octubre, Diciembre tienen 31 dias");
                break;

            case 1:
                a = 4;
                a = 6;
                a = 9;
                a = 11;
                Console.WriteLine("Tienen 30 Dias");
                Console.WriteLine("Abril, Junio, Septiembre, Noviembre");
                break; 
        }
        Console.WriteLine(dias);

        MenuInterfaz menu = new MenuImplementacion();
        a = menu.menu();
        b = menu.menu();
        //int opcionElegida;


    }

}
