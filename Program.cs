using System;

namespace ObserverEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados Emp = new Empleados();

            AFP afp = new AFP();
            SFS sfs = new SFS();
            Cooperativa coo = new Cooperativa();
            Farmacia far = new Farmacia();
            PlanFunerario plan = new PlanFunerario();

            Emp.AgregarEmp(afp);
            Emp.AgregarEmp(sfs);
            Emp.AgregarEmp(coo);
            Emp.AgregarEmp(far);
            Emp.AgregarEmp(plan);

            Emp.Agregar();

            Console.ReadKey();
        }
    }
}
