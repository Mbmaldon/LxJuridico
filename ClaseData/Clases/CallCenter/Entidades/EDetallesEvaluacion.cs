using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.CallCenter.Entidades
{
    public class EDetallesEvaluacion
    {
        /*Entidades para vaciar la información del cliente y la solicitud realizada*/

        public string sNumCliente                   { get; set; }
        public string sCliente                      { get; set; }
        public string sRFC                          { get; set; }
        public string sNumMovil                     { get; set; }
        public string sNumLocal                     { get; set; }
        public string sFolio                        { get; set; }
        public string sFechaSolicitud               { get; set; }
        public string sFechaResolución              { get; set; }
        public string sConsultor                    { get; set; }
        public string sTipoSolicitud                { get; set; }
        public string sFechaSolicitudevaluacion     { get; set; }


        public EDetallesEvaluacion(string sNumCliente, string sCliente, string sRFC, string sNumMovil, string sNumLocal, string sFolio                   
                                    ,string sFechaSolicitud, string sFechaResolución, string sConsultor, string sTipoSolicitud           
                                    , string sFechaSolicitudevaluacion)
        {
            this.sNumCliente               = sNumCliente;
            this.sCliente                  = sCliente;
            this.sRFC                      = sRFC;
            this.sNumMovil                 = sNumMovil;
            this.sNumLocal                 = sNumLocal;
            this.sFolio                    = sFolio;
            this.sFechaSolicitud           = sFechaSolicitud;
            this.sFechaResolución          = sFechaResolución;
            this.sConsultor                = sConsultor;
            this.sTipoSolicitud            = sTipoSolicitud;
            this.sFechaSolicitudevaluacion = sFechaSolicitudevaluacion;

        }
    }
}
