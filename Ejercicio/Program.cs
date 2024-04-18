// See https://aka.ms/new-console-template for more information
using Ejercicio.Clases;
using Ejercicio.Interfaces;
using Ejercicio.Statics;

Desarrollador desarrollador = new Desarrollador { 
    IdEmpleado = 1,
    Nombre = "Desa001",
    Puesto = "Desarrollador PeopleSoft"
};
desarrollador.CalcularSueldo();
desarrollador.MostrarDetalles();

Gerente gerente = new Gerente { 
    IdEmpleado = 2,
    Nombre = "Gerente1", 
    Puesto="Gerente Marketing"
};
gerente.CalcularSueldo();
gerente.CalcularBonificacion();
gerente.MostrarDetalles();


Console.WriteLine("***************************************************************************");


List<IEmpleado> empleados = new List<IEmpleado>
        {
            new Gerente { Nombre = "Juan Pérez", IdEmpleado = 1, Puesto = "Gerente" },
            new Desarrollador { Nombre = "Caniche López", IdEmpleado = 2, Puesto = "Desarrollador" },
            new GerenteRRHH { Nombre = "Chester Quieroz", IdEmpleado = 3, Puesto = "GerenteRRHH" },
            new ConsultorExterno { Nombre = "Son Goku Sanchez", IdEmpleado = 4, Puesto = "Consultor Externo" }
        };

foreach (var empleado in empleados)
{


    if (empleado is ISueldoBonificable empleadoBonificable)
    {
        empleadoBonificable.CalcularBonificacion();
    }
    if (empleado is IDescuentoImpuesto empleadoDescuenta)
    {
        empleadoDescuenta.DescontarSueldo();
    }
    empleado.CalcularSueldo();
    empleado.MostrarDetalles();


    Console.WriteLine();
}