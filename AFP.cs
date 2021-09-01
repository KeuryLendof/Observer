using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEmpleados
{
    class AFP : IObserver
    {
        double Resultado;
        double Resta;
        

        public void Servicios()
        {
          
            Resultado = Empleados.Salario * 2.87 / 100;
            Resta = Empleados.Salario - Resultado;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------");
            Console.WriteLine("<<< AFP >>>");
            Console.WriteLine("-----------");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Su descuento de AFP se realizo, Su salario es de {Resta}");
            Console.WriteLine($"Su descuento fue de: {Resultado}");
            Console.WriteLine($"El restante de su salario es: {Empleados.Salario = Resta}");

            Console.ReadKey();
        }
    }
}
