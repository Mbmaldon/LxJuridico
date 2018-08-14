using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para cargar la información del documento registrado*/
    public class ISDocumento
    {
        public string sRequisicion { get; set; }
        public string sTipoReq { get; set; }

        public ISDocumento (string sRequisicion, string sTipoReq)
        {
            this.sRequisicion = sRequisicion;
            this.sTipoReq = sTipoReq;
        }
    }
}
