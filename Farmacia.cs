using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEmpleados
{
    class Farmacia : IObserver
    {
        double Monto;
        double Resultado;
        double Resta;

        public void Servicios()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------");
            Console.WriteLine("Farmacia");
            Console.WriteLine("--------");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Usted Realizo algun consumo en la farmacia este mes?");
            Console.WriteLine("[1]SI [2]NO");
            int opc = int.Parse(Console.ReadLine());


            if (opc == 1)
            {
                Console.WriteLine("Ingreze el monto consumido: ");
                Monto = int.Parse(Console.ReadLine());
                Resultado = Monto / 2;
                Resta = Empleados.Salario - Resultado;
                Console.WriteLine($"Asu sueldo se le restaran: {Resultado}RD$");
                Console.WriteLine($"El restante de su salario es: {Empleados.Salario = Resta}");

            }
            if (opc == 2)
            {
                Console.WriteLine("Excelente, al parecer tuviste una buena semana sin necesidad de ningun medicamento");
            }
            Console.ReadKey();
        }
    }
}
