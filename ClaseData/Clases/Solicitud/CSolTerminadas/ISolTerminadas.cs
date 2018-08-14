using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.CSolTerminadas
{
    public class ISolTerminadas
    {
        /*Entidad para vaciar la información de las solicitudes terminadas o con su resolución*/
        public ISolTerminadas()
        {

        }

        public string sIdSolicitud { get; set; }
        public string sIdCaso { get; set; }
        public string sIdFase { get; set; }
        public string sFase { get; set; }
        public string sSolicitudTipo { get; set; }
        public string sNoCliente { get; set; }
        public string sConsultor { get; set; }
        public string sFSolicitud { get; set; }
        public string sFVencimiento { get; set; }
        public string sFechaResolucion { get; set; }
        public string sSemaforo { get; set; }

    }
}
