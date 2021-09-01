using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEmpleados
{
    class PlanFunerario : IObserver
    {
        double SalarioMinimo = 10000;
        double Descuento = 500;
        double Resultado;
        //double Resta;


        public void Servicios()
        {
            if(Empleados.Salario > SalarioMinimo)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------------");
                Console.WriteLine("Plan Funerario");
                Console.WriteLine("--------------");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Asu salario se le descontaran {Descuento}RD$ por el plan funerario!");

                Resultado = Empleados.Salario - Descuento;
                Console.WriteLine($"El restante de su salario es: {Empleados.Salario = Resultado}");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Su salario esta por debajo de 10000 pesos no puede aplicar al plan funerario!");
            }
        }
    }
}
