using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio.Abstracts;
using Ejercicio.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio.Clases
{
     class Gerente:EmpleadoBase, ISueldoBonificable
    {

        public override double SueldoBase => 10000;
        public double Bonificacion {  get; set; }

        public void CalcularBonificacion()
        {
            Bonificacion = 200;
        }
        public override  void CalcularSueldo() {
            SueldoNeto = SueldoBase + Bonificacion;
        }
        public override string ObtenerTipoEmpleado()
        {
            return "Tipo Gerente";
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Bonificacion: {Bonificacion}");
            /*Console.WriteLine($"Empleado:{Nombre}, ID Empleado:{IdEmpleado}, Pusto:{Puesto}, Sueldo: {SueldoNeto}, Bonificacion {Bonificacion}");*/
        }
       
    }
}
