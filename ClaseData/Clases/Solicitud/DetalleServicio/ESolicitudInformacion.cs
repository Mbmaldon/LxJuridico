using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    public class ESolicitudInformacion
    {

        /*Entidad para cargar la información de la solicitud*/
        public string sSolicitud        { get; set; }
        public string sResponsable      { get; set; }
        public string sFechaVigencia    { get; set; }
        public string sRespuesta        { get; set; }
        public string sRutaArchivo      { get; set; }
        public string sFechaRespuesta   { get; set; }

        public ESolicitudInformacion(string sSolicitud, string sResponsable, string sFechaVigencia
                                     , string sRespuesta, string sRutaArchivo, string sFechaRespuesta)
        {
            this.sSolicitud = sSolicitud;
            this.sResponsable = sResponsable;
            this.sFechaVigencia = sFechaVigencia;
            this.sRespuesta = sRespuesta;
            this.sRutaArchivo = sRutaArchivo;
            this.sFechaRespuesta = sFechaRespuesta;
        }
    }
}
