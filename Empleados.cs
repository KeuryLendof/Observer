using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEmpleados
{
    class Empleados
    {
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static int Edad { get; set; }
        public static string Email { get; set; }
        public static string Direccion { get; set; }
        public static double Salario { get; set; }

        public List<IObserver> lista = new List<IObserver>();

        public void AgregarEmp(IObserver observer)
        {
            lista.Add(observer);
        }
        public void QuitarEmp(IObserver observer)
        {
            lista.Remove(observer);
        }
        public void Notificar()
        {
            foreach(var elm in lista)
            {
                elm.Servicios();
            }
        }
        public void Agregar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("----------------------");
            Console.WriteLine("Registro de Empleados");
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Indruzca el nombre del empleado: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Indruzca el apellido del empleado: ");
            Apellido = Console.ReadLine();
            Console.WriteLine("Indruzca la edad del empleado: ");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Indruzca el Email del empleado: ");
            Email = Console.ReadLine();
            Console.WriteLine("Indruzca la direccion del empleado: ");
            Direccion = Console.ReadLine();
            Console.WriteLine("Indruzca el salario del empleado: ");
            Salario = int.Parse(Console.ReadLine());

            Notificar();

        }
    }
}
