using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    public class ISRutaDocumento
    {
        /*Entidad para vaciar la información de la ruta e id del archivo registrado*/
        public string sIdRuta { get; set; }
        public string sRutaArchivo { get; set; }

        public ISRutaDocumento(string sIdRuta, string sRutaArchivo)
        {
            this.sIdRuta = sIdRuta;
            this.sRutaArchivo = sRutaArchivo;
        }
    }
}
