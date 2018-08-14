using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    public class EEventos
    {
        /*Entidad para vaciar la información del evento registrado*/
        public EEventos()
        {
        }
        public string sIdSolicitudEvento { get; set; }
        public string sConsultor { get; set; }
        public string sExpOrigen { get; set; }
        public string sNumExpediente { get; set; }
        public string sJuzgado { get; set; }
        public string sContraparte { get; set; }
        public string sTipoJuicio { get; set; }
        public string sEvento { get; set; }
        public string sTarea { get; set; }
        public string sFTerInterno { get; set; }
        public string sFTerLegal { get; set; }
        public string sPropuesta { get; set; }
        public string sArchivo { get; set; }
    }
}
