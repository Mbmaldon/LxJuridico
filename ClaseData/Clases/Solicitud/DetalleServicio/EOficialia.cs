using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    public class EOficialia
    {
        /*Entidad para vaciar la información de la solicitud de oficialia de partes*/
        public EOficialia()
        { }

        public string sIdOficialia { get; set; }
        public string sConsultor{ get; set; }
        public string sExpOrigen { get; set; }
        public string sNumExpediente { get; set; }
        public string sJuzgado { get; set; }
        public string sContraparte { get; set; }
        public string sTipoJuicio { get; set; }
        public string sOficialia { get; set; }

    }
}
