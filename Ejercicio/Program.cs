// See https://aka.ms/new-console-template for more information
using Ejercicio.Clases;
using Ejercicio.Interfaces;
using Ejercicio.Statics;

#region primerEjemplo
//Desarrollador desarrollador = new Desarrollador { 
//    IdEmpleado = 1,
//    Nombre = "Desa001",
//    Puesto = "Desarrollador PeopleSoft"
//};
//desarrollador.CalcularSueldo();
//desarrollador.MostrarDetalles();

//Gerente gerente = new Gerente { 
//    IdEmpleado = 2,
//    Nombre = "Gerente1", 
//    Puesto="Gerente Marketing"
//};
//gerente.CalcularSueldo();
//gerente.CalcularBonificacion();
//gerente.MostrarDetalles();
#endregion

#region Ejercicio 
int opcion, idEmpleado;
string tipoEmpleado, nombreEmpleado, puestoEmpleado ;

List<IEmpleado> empleados = new List<IEmpleado>();

do {
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("1) Ingresar Empleado");
    Console.WriteLine("2) Mostrar Listado de Empleado");
    Console.WriteLine("3) Salir");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("Seleccione una opcion:");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {   case 1:

            Console.WriteLine(" **** REGISTRO EMPLEADO **** ");
            Console.WriteLine();
            Console.WriteLine("**** tipos de empleado ****");
            Console.WriteLine("(A) Consultor Externo");
            Console.WriteLine("(B) Desarrollador");
            Console.WriteLine("(C) Gerente");
            Console.WriteLine("(D) Gerente RRHH");
            Console.WriteLine("**** tipos de empleado ****");
            Console.WriteLine("Seleccione Tipo: ");
            tipoEmpleado = Console.ReadLine();
            Console.WriteLine("Nombre Empleado: ");
            nombreEmpleado = Console.ReadLine();
            Console.WriteLine("ID Empleado: ");
            idEmpleado = Convert.ToInt32(Console.ReadLine());

            
            switch (tipoEmpleado.ToUpper())
            {
                case "A":
                    puestoEmpleado = "Consultor Externo";
                    empleados.Add(new ConsultorExterno { Nombre = nombreEmpleado, IdEmpleado = idEmpleado, Puesto = puestoEmpleado });
                    break;
                case "B":
                    puestoEmpleado = "Desarrollador";
                    empleados.Add(new Desarrollador { Nombre = nombreEmpleado, IdEmpleado = idEmpleado, Puesto = puestoEmpleado });
                    break;
                case "C":
                    puestoEmpleado = "Gerente";
                    empleados.Add(new Gerente { Nombre = nombreEmpleado, IdEmpleado = idEmpleado, Puesto = puestoEmpleado });
                    break;
                case "D":
                    puestoEmpleado = "GerenteRRHH";
                    empleados.Add(new Desarrollador { Nombre = nombreEmpleado, IdEmpleado = idEmpleado, Puesto = puestoEmpleado });
                    break;
                default:
                    break;
            }
           
            break;
        case 2:

            Console.WriteLine(" **** MOSTRANDO EMPLEADOS **** ");
            Console.WriteLine();

            foreach (var empleado in empleados)
            {
                if (empleado is ISueldoBonificable empleadoBonificable)
                {
                    empleadoBonificable.CalcularBonificacion();
                }
                if (empleado is IDescuentoImpuesto empleadoDescuenta)
                {
                    empleadoDescuenta.CalcularDescuento();
                }
                empleado.CalcularSueldo();
                empleado.MostrarDetalles();
                Console.WriteLine();
            }

            break;
        default:
            Console.WriteLine("Opcion Invalida!..");
            break;
    }

}while(opcion != 3);

#endregion

#region EjemploClase
//List< IEmpleado > empleados2 = new List<IEmpleado>
//        {
//            new Gerente { Nombre = "Juan Pérez", IdEmpleado = 1, Puesto = "Gerente" },
//            new Desarrollador { Nombre = "Caniche López", IdEmpleado = 2, Puesto = "Desarrollador" },
//            new GerenteRRHH { Nombre = "Chester Quieroz", IdEmpleado = 3, Puesto = "GerenteRRHH" },
//            new ConsultorExterno { Nombre = "Son Goku Sanchez", IdEmpleado = 4, Puesto = "Consultor Externo" }
//        };

//foreach (var empleado in empleados2)
//{


//    if (empleado is ISueldoBonificable empleadoBonificable)
//    {
//        empleadoBonificable.CalcularBonificacion();
//    }
//    if (empleado is IDescuentoImpuesto empleadoDescuenta)
//    {
//        empleadoDescuenta.CalcularDescuento();
//    }
//    empleado.CalcularSueldo();
//    empleado.MostrarDetalles();


//    Console.WriteLine();
//}

#endregion