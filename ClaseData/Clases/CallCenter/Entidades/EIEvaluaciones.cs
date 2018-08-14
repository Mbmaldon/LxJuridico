using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.CallCenter.Entidades
{
    public class EIEvaluaciones
    {
        /*Entidad para vaciar la información de las evaluaciones registradas*/
        public EIEvaluaciones()
        {

        }

        public string sIdEvaluacion { get; set; }
        public string sUsuario { get; set; }
        public string sFechaRegistro { get; set; }
        public string sClienteContactado { get; set; }
    }
}
