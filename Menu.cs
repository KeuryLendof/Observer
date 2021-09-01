using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEmpleados
{
    class Menu
    {
        int opc;

        Empleados Emp = new Empleados();

        AFP afp = new AFP();
        SFS sfs = new SFS();
        Cooperativa coo = new Cooperativa();
        Farmacia far = new Farmacia();
        PlanFunerario plan = new PlanFunerario();

        public void MenuPrincipal()
        {
            do
            {
                Console.WriteLine("Seleccione la opcion deseada: ");
                Console.WriteLine("[1] Crear Empleado");
                Console.WriteLine("[2] Inscripcion de planes");
                Console.WriteLine("[3] Cancelacion de planes");
                Console.WriteLine("[4] Registro del consumo de farmacia");
                Console.WriteLine("[5] Calculo de la nomina");
                Console.WriteLine("[6] Salir");

                opc = int.Parse(Console.ReadLine());

                switch(opc)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }

            } while (opc != 6);
        }
        public void MenuInscribirPlanes()
        {

        }
        public void MenuCancelarPlanes()
        {

        }
    }
}
