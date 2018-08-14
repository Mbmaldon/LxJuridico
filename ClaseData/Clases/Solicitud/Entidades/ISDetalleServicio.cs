using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para cargar los detalles del servicio */
    public class ISDetalleServicio
    {

        public string sIdCaso           { get; set; }
        public string sNumCliente       { get; set; }
        public string sNombreCliente    { get; set; }
        public string sRFC              { get; set; }
        public string sTelefonoMovil    { get; set; }
        public string sCorreo           { get; set; }
        public string sTipoPersona      { get; set; }
        public string sTipoServicio     { get; set; }
        public string sRegistro         { get; set; }
        public string sCoordinador      { get; set; }
        public string sConsultor        { get; set; }
        public string sIdTipoSolicitud { get; set; }
        public string sTipoEvento       { get; set; }
        public string sSolicitud        { get; set; }
        public string sFechaRegistro    { get; set; }
        public string sUrlCitas         { get; set; }
        public string sidMPYCC          { get; set; }
        public string sIdTipoServicio { get; set; }
        public string sTipificacion { get; set; }
        public ISDetalleServicio(string sIdCaso,        string sNumCliente,     string sNombreCliente,
                                 string sRFC,           string sTelefonoMovil,  string sCorreo,     string sTipoPersona,     string sTipoServicio,
                                 string sRegistro,      string sCoordinador,    string sConsultor,  string sIdTipoSolicitud, string sTipoEvento,     
                                 string sSolicitud,     string sFechaRegistro,  string sUrlCitas,   string sidMPYCC,         string sTipificacion)
        {
            this.sIdCaso            = sIdCaso;
            this.sNumCliente        = sNumCliente;
            this.sNombreCliente     = sNombreCliente;
            this.sRFC               = sRFC;
            this.sTelefonoMovil     = sTelefonoMovil;
            this.sCorreo            = sCorreo;
            this.sTipoPersona       = sTipoPersona;
            this.sTipoServicio      = sTipoServicio;
            this.sRegistro          = sRegistro;
            this.sCoordinador       = sCoordinador;
            this.sConsultor         = sConsultor;
            this.sIdTipoSolicitud   = sIdTipoSolicitud;
            this.sTipoEvento        = sTipoEvento;
            this.sSolicitud         = sSolicitud;
            this.sFechaRegistro     = sFechaRegistro;
            this.sUrlCitas          = sUrlCitas;
            this.sidMPYCC           = sidMPYCC;
            //this.sIdTipoServicio    = sIdTipoServicio;
            this.sTipificacion      = sTipificacion;
        }
    }
}
