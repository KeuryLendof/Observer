using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEmpleados
{
    class Cooperativa : IObserver
    {
        double Resultado;
        double Resta;
        public void Servicios()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------");
            Console.WriteLine("Cooperativa");
            Console.WriteLine("-----------");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("El descuento de la cooperativa es del 5% de su salario");

            Console.WriteLine("Quieres participar en la cooperativa? [1]Si [2]No");
            int opc = int.Parse(Console.ReadLine());


            if (opc == 1)
            {
                Resultado = Empleados.Salario * 5 / 100;
                Resta = Empleados.Salario - Resultado;

                Console.WriteLine($"Su descuento de la cooperativa se realizo, Su salario es de {Resta}");
                Console.WriteLine($"Su descuento fue de: {Resultado}");

                Console.WriteLine($"El restante de su salario es: {Empleados.Salario = Resta}");
            }
            if (opc == 2)
            {
                Console.WriteLine("Aviso: La cooperativa es muy importante ya que puede servir como una manera de ahorro para sus prestamos!!!");
            }

            Console.ReadKey();
        }
    }
}
