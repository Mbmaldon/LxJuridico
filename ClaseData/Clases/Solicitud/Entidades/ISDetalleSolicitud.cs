using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para cargar los detalles de la solicitud registrada*/
    public class ISDetalleSolicitud
    {
        public string sIdCaso { get; set; }
        public string sNumCliente { get; set; }
        public string sNombreCliente { get; set; }
        public string sRFC { get; set; }
        public string sTelefonoMovil { get; set; }
        public string sTipoPersona { get; set; }
        public string sTipoServicio { get; set; }
        public string sRegistro { get; set; }
        public string sCoordinador { get; set; }
        public string sIdTipoSolicitud { get; set; }
        public string sConsultor { get; set; }
        public string sGerente { get; set; }

        public string sTipoEvento { get; set; }
        public string sSolicitud { get; set; }
        public string sFechaRegistro { get; set; }
        public string sDictamen { get; set; }
        public string sUrlCitas { get; set; }
        public string sUrlArchResp { get; set; }
        public string sResolucion { get; set; }
        public string sTipificacion { get; set; }

        public string sResolucionServicio { get; set; }


        public ISDetalleSolicitud(string sIdCaso,       string sNumCliente,     string sNombreCliente,
                                  string sRFC,          string sTelefonoMovil,  string sTipoPersona,     string sTipoServicio,
                                  string sRegistro,     string sCoordinador,    string sConsultor, string sGerente,
                                  string sIdTipoSolicitud, string sTipoEvento,     string sSolicitud,       string sFechaRegistro,   
                                  string sDictamen,     string sUrlCitas,       string sUrlArchResp,     string sResolucion, 
                                  string sTipificacion, string sResolucionServicio)
        {
            this.sIdCaso                = sIdCaso;
            this.sNumCliente            = sNumCliente;
            this.sNombreCliente         = sNombreCliente;
            this.sRFC                   = sRFC;
            this.sTelefonoMovil         = sTelefonoMovil;
            this.sTipoPersona           = sTipoPersona;
            this.sTipoServicio          = sTipoServicio;
            this.sRegistro              = sRegistro;
            this.sCoordinador           = sCoordinador;
            this.sConsultor             = sConsultor;
            this.sGerente               = sGerente;
            this.sIdTipoSolicitud       = sIdTipoSolicitud;
            this.sTipoEvento            = sTipoEvento;
            this.sSolicitud             = sSolicitud;
            this.sFechaRegistro         = sFechaRegistro;
            this.sDictamen              = sDictamen;
            this.sUrlCitas              = sUrlCitas;
            this.sUrlArchResp           = sUrlArchResp;
            this.sResolucion            = sResolucion;
            this.sTipificacion          = sTipificacion;
            this.sResolucionServicio    = sResolucionServicio;


        }
    }
}
