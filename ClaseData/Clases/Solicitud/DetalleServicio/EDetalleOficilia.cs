using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    /*Entidad para cargar los detalles de la solicitud al usuario de oficialia de partes*/
    public class EDetalleOficilia
    {
        public string sExpOrigen        { get; set; }
        public string sNumExpediente    { get; set; }
        public string sJuzgado          { get; set; }
        public string sContraparte      { get; set; }
        public string sTipoJuicio       { get; set; }
        public string sOficialia        { get; set; }

        public EDetalleOficilia(string sExpOrigen, string sNumExpediente 
                                ,string sJuzgado, string sContraparte   
                                ,string sTipoJuicio, string sOficialia)
        {
            this.sExpOrigen = sExpOrigen;
            this.sNumExpediente = sNumExpediente;
            this.sJuzgado = sJuzgado;
            this.sContraparte = sContraparte;
            this.sTipoJuicio = sTipoJuicio;
            this.sOficialia = sOficialia;
        }
    }
}
