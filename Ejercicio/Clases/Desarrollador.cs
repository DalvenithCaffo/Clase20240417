using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio.Abstracts;
using Ejercicio.Interfaces;

namespace Ejercicio.Clases
{
   
    class Desarrollador:EmpleadoBase
    {

        public override double SueldoBase => 2000;
      
        public override void CalcularSueldo()
        {
            SueldoNeto =  SueldoBase;
        }
        public override string ObtenerTipoEmpleado()
        {
            return "Tipo Desarrollador";
        }
        
    }
}
