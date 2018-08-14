using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para cargar detalles de la solicitud levantada*/
    public class ISAsignarConsultor
    {
        public string sIdCaso           { get; set; }
        public string sNumCliente       { get; set; }
        public string sNombreCliente    { get; set; }
        public string sRFC              { get; set; }
        public string sTelefonoMovil    { get; set; }
        public string sTipoPersona      { get; set; }
        public string sTipoServicio     { get; set; }
        public string sRegistro         { get; set; }
        public string sSolicitud        { get; set; }
        public string sFechaRegistro    { get; set; }
        public string sUrlLlamadas      { get; set; }
        public string sContadorAsignado { get; set; }

        public ISAsignarConsultor(string sIdCaso,   string sNumCliente,     string sNombreCliente,
                                  string sRFC,      string sTelefonoMovil,  string sTipoPersona,    string sTipoServicio,
                                  string sRegistro, string sSolicitud,      string sFechaRegistro,  string sUrlLlamadas, string sContadorAsignado)
        {
            this.sIdCaso            = sIdCaso;
            this.sNumCliente        = sNumCliente;
            this.sNombreCliente     = sNombreCliente;
            this.sRFC               = sRFC;
            this.sTelefonoMovil     = sTelefonoMovil;
            this.sTipoPersona       = sTipoPersona;
            this.sTipoServicio      = sTipoServicio;
            this.sRegistro          = sRegistro;
            this.sSolicitud         = sSolicitud;
            this.sFechaRegistro     = sFechaRegistro;
            this.sUrlLlamadas       = sUrlLlamadas;
            this.sContadorAsignado  = sContadorAsignado;

        }
    }
}
