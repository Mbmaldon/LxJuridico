using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    public class EDocumento
    {
        /*Entidad para vaciar la información de la solicitud de documento registrado*/
        public EDocumento()
        {

        }

        public string sIdIdSolicitudDocumento { get; set; }
        public string sRequisicion { get; set; }
        public string sTipoReq { get; set; }
        public string sRecibido { get; set; }
    }
}
