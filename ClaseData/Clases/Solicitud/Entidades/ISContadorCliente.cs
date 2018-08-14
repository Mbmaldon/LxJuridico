using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para cargar el id y nombre del contador*/
    public class ISContadorCliente
    {
        public string sIdContador   { get; set; }
        public string sNomContador  { get; set; }

        public ISContadorCliente(string sIdContador, string sNomContador)
        {
            this.sIdContador = sIdContador;
            this.sNomContador = sNomContador;
        }
    }
}
