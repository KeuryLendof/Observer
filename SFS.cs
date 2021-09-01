using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEmpleados
{
    class SFS : IObserver
    {
        double Resultado;
        double Resta;

        public void Servicios()
        {
            Console.Clear();
            Resultado = Empleados.Salario * 3.04 / 100;
            Resta = Empleados.Salario - Resultado;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("-----------");
            Console.WriteLine("<<< SFS >>>");
            Console.WriteLine("-----------");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Su descuento de SFS se realizo, Su salario es de {Resta}");
            Console.WriteLine($"Su descuento fue de: {Resultado}");
            Console.WriteLine($"El restante de su salario es: {Empleados.Salario = Resta}");

            Console.ReadKey();
        }
    
    }
}
