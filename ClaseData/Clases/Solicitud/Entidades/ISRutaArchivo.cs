using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    public class ISRutaArchivo
    {
        /*Entidad para vaciar la información de la ruta del archivo registrado */
        public string sRutaArchivo { get; set; }

        public ISRutaArchivo(string sRutaArchivo)
        {
            this.sRutaArchivo = sRutaArchivo;
        }
    }
}
