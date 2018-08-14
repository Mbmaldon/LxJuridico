using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    public class EPropuestaRespuesta
    {
        /*Entidad para vaciar la información de la propuesta de respuesta registrada*/
        public EPropuestaRespuesta()
        {

        }

        public string sIdPropuestaRespuesta { get; set; }
        public string sAprobada { get; set; }
        public string sConsultor { get; set; }
        public string sCoordinador { get; set; }
        public string sPropuesta { get; set; }
        public string sArchivo { get; set; }
        public string sAprobacion { get; set; }
        public string sDescripcionRechazo { get; set; }
    }
}
