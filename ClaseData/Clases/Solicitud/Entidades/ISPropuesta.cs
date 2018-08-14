using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para cargar la validación de la propuesta registrada*/
    public class ISPropuesta
    {
        public string sPropuesta { get; set; }
        public string sRechazo { get; set; }

        public ISPropuesta(string sPropuesta, string sRechazo)
        {
            this.sPropuesta = sPropuesta;
            this.sRechazo = sRechazo;

        }
    }
}
