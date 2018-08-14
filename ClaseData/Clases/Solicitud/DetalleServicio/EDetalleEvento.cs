using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    /*Entidad para cargar los detalles del evento registrado*/
    public class EDetalleEvento
    {
       
        public string sExpOrigen        { get; set; }
        public string sNumExpediente    { get; set; }
        public string sJuzgado          { get; set; }
        public string sContraparte      { get; set; }
        public string sTipoJuicio       { get; set; }
        public string sEvento           { get; set; }
        public string sTarea            { get; set; }
        public string sFTerInterno      { get; set; }
        public string sFTerLegal        { get; set; }
        public string sPropuesta        { get; set; }
        public string sDecripcionActo { get; set; }

        public EDetalleEvento(string sExpOrigen, string sNumExpediente, string sJuzgado, string sContraparte,  
                              string sTipoJuicio, string sEvento, string sTarea, string sFTerInterno, 
                              string sFTerLegal, string sPropuesta, string sDecripcionActo ) 
        {
            this.sExpOrigen = sExpOrigen;
            this.sNumExpediente = sNumExpediente;
            this.sJuzgado = sJuzgado;
            this.sContraparte = sContraparte;
            this.sTipoJuicio = sTipoJuicio;
            this.sEvento = sEvento;
            this.sTarea = sTarea;
            this.sFTerInterno = sFTerInterno;
            this.sFTerLegal = sFTerLegal;
            this.sPropuesta = sPropuesta;
            this.sDecripcionActo = sDecripcionActo;
        }     
    }
}