using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para cargar los detalles de la solicitud de información registrada*/
    public class ISDSolicitudInformacion
    {
        public string siIdSolicitudInformacion { get; set; }
        public string sIdCaso           { get; set; }
        public string sNumCliente       { get; set; }
        public string sNombreCliente    { get; set; }
        public string sRFC              { get; set; }
        public string sTelefonoMovil    { get; set; }
        public string sCorreo           { get; set; }
        public string sTipoPersona      { get; set; }
        public string sTipoServicio     { get; set; }
        public string sRegistro         { get; set; }
        public string sTipoEvento       { get; set; }
        public string sSolicitud        { get; set; }
        public string sFechaRegistro    { get; set; }
        public string sFechaVigencia    { get; set; }

        public ISDSolicitudInformacion(string siIdSolicitudInformacion, string sIdCaso,string sNumCliente, string sNombreCliente, string sRFC, string sTelefonoMovil 
                                        ,string sCorreo, string sTipoPersona, string sTipoServicio, string sRegistro, string sTipoEvento    
                                        , string sSolicitud, string sFechaRegistro, string sFechaVigencia)  
        {
              this.siIdSolicitudInformacion = siIdSolicitudInformacion;
              this.sIdCaso          = sIdCaso;
              this.sNumCliente      = sNumCliente;
              this.sNombreCliente   = sNombreCliente;
              this.sRFC             = sRFC;
              this.sTelefonoMovil   = sTelefonoMovil;
              this.sCorreo          = sCorreo;
              this.sTipoPersona     = sTipoPersona;
              this.sTipoServicio    = sTipoServicio;
              this.sRegistro        = sRegistro;
              this.sTipoEvento      = sTipoEvento;
              this.sSolicitud       = sSolicitud;
              this.sFechaRegistro   = sFechaRegistro;
              this.sFechaVigencia   = sFechaVigencia;
        }      
    }
}