using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para obtener el id de la propuesta que se esta registrando*/
    public class EIOSFolioPropuesta
    {
        public string sIdPropuesta { get; set; }
        public EIOSFolioPropuesta(string sIdPropuesta)
        {
            this.sIdPropuesta = sIdPropuesta;
        }
    }
}
