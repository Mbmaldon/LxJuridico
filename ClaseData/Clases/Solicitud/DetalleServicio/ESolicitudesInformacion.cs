using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    public class ESolicitudesInformacion
    {
        /*Entidad para vaciar la información de la solicitud de informacion solicitada por el consultor*/
        public ESolicitudesInformacion()
        {
        }
        public string sIdSolicitudInformacion { get; set; }
        public string sConsultor { get; set; }
        public string sSolicitud { get; set; }
        public string sFechaRegistro { get; set; }
        public string sFechaVigencia { get; set; }
        public string sResponsable { get; set; }
        public string sEstatus{ get; set; }

    }
}
