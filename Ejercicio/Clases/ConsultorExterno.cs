using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio.Abstracts;

namespace Ejercicio.Clases
{
     class ConsultorExterno: EmpleadoBase
    {
        public override double SueldoBase => 5000;

        public override void CalcularSueldo()
        {
            SueldoNeto = SueldoBase;
        }
        public override string ObtenerTipoEmpleado()
        {
            return "Tipo Consultor Externo";
        }

    }
}
