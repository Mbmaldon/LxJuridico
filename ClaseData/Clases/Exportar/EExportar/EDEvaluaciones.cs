using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Exportar.EExportar
{
    /*Entidad para cargar la información de la evaluación*/
    public class EDEvaluaciones
    {
        public string sfolio                { get; set; }
        public string sFase                 { get; set; }
        public string sTipoSolicitud        { get; set; }
        public string sNumCliente           { get; set; }
        public string sResponsable          { get; set; }
        public string sFechaSolicitud       { get; set; }
        public string sFechaVigencia        { get; set; }
        public string sFechaEvalua          { get; set; }
        public string sSemaforo             { get; set; }
        public string SClienteContactado    { get; set; }
        public string sP1                   { get; set; }
        public string sP2                   { get; set; }
        public string sP3                   { get; set; }
        public string sP4                   { get; set; }
        public string sP5                   { get; set; }
        public string sP6                   { get; set; }
        public string sComentario           { get; set; }
        public string sFechaEvaluacion      { get; set; }

        public EDEvaluaciones()
        {

        }

        //public EDEvaluaciones(string sfolio, string sFase, string sTipoSolicitud, string sNumCliente, string sResponsable, string sFechaSolicitud, string sFechaVigencia
        //                        , string sFechaEvalua, string sSemaforo, string SClienteContactado, string sP1, string sP2, string sP3, string sP4, string sP5, string sP6
        //                        , string sComentario, string sFechaEvaluacion)
        //{
        //   this.sfolio                 = sfolio                       ;
        //   this.sFase                  = sFase                        ;
        //   this.sTipoSolicitud         = sTipoSolicitud               ;
        //   this.sNumCliente            = sNumCliente                  ;
        //   this.sResponsable           = sResponsable                 ;
        //   this.sFechaSolicitud        = sFechaSolicitud              ;
        //   this.sFechaVigencia         = sFechaVigencia               ;
        //   this.sFechaEvalua           = sFechaEvalua                 ;
        //   this.sSemaforo              = sSemaforo                    ;
        //   this.SClienteContactado     = SClienteContactado           ;
        //   this.sP1                    = sP1                          ;
        //   this.sP2                    = sP2                          ;
        //   this.sP3                    = sP3                          ;
        //   this.sP4                    = sP4                          ;
        //   this.sP5                    = sP5                          ;
        //   this.sP6                    = sP6                          ;
        //   this.sComentario            = sComentario                  ;
        //   this.sFechaEvaluacion = sFechaEvaluacion;
        //}
    }
}
