using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio.Interfaces;

namespace Ejercicio.Abstracts
{
    abstract class EmpleadoBase:IEmpleado
    {
        //Propiedades 
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }
        public string Puesto { get; set; }
        public double SueldoNeto { get; set; }
        public abstract double SueldoBase { get; }

        // Método abstracto, te obliga que se tiene que implementar
        public abstract void CalcularSueldo();
        public abstract string ObtenerTipoEmpleado();
        //virtual te da la opcion para poder sobre escribir el metodo
        public virtual void MostrarDetalles() {
            Console.WriteLine($"Empleado:{Nombre}, ID Empleado:{IdEmpleado}, Pusto:{Puesto}, Sueldo: {SueldoNeto}");
        }

    }
}
