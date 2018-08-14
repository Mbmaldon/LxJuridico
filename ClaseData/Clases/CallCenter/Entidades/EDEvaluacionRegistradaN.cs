using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.CallCenter.Entidades
{
    public class EDEvaluacionRegistradaN
    {
        /*Entidad para vaciar la información de la evaluación rechazada registrada por el coordinador */
        public string sObservaciones { get; set; }
        public string sFechaRegistro { get; set; }

        public EDEvaluacionRegistradaN(string sObservaciones,string sFechaRegistro)
        {
           this.sObservaciones = sObservaciones;
           this.sFechaRegistro = sFechaRegistro;
        }
    }
}
