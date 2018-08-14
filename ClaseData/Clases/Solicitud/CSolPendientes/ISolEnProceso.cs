using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.CSolPendientes
{
    public class ISolEnProceso
    {
        /*Entidad para vaciar la informacion de las solciitudes en proceso de una resolución*/
        public string sIdSolicitud { get; set; }
        public string sIdCaso { get; set; }
        public string sIdFase { get; set; }
        public string sFase { get; set; }
        public string sSolicitudTipo { get; set; }
        public string sNoCliente { get; set; }
        public string sResponsable { get; set; }
        public string sFSolicitud { get; set; }
        public string sFVencimiento { get; set; }
        public string sSemaforo { get; set; }

        public ISolEnProceso()
        {

        }
    }
}
