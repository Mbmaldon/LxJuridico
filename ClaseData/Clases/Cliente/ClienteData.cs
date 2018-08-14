using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Cliente
{
    public class ClienteData
    {
        /*Entidades para vaciar la información del cliente*/
        public string sIdCliente { get; set; }
        public string sIdServicioTipo { get; set; }
        public string sIdTipoPersona { get; set; }
        public string sNoCliente { get; set; }
        public string sRFC { get; set; }
        public string sNombreCliente { get; set; }
        public string sNumeroMovil { get; set; }
        public string sServicioTipo { get; set; }
        public string sTipoPersona { get; set; }

        public ClienteData(string sIdCliente, string sIdServicioTipo, string sIdTipoPersona,
                            string sNoCliente, string sRFC, string sNombreCliente, string sNumeroMovil,
                            string sServicioTipo, string sTipoPersona)
        {
            this.sIdCliente = sIdCliente;
            this.sIdServicioTipo = sIdServicioTipo;
            this.sIdTipoPersona = sIdTipoPersona;
            this.sNoCliente = sNoCliente;
            this.sRFC = sRFC;
            this.sNombreCliente = sNombreCliente;
            this.sNumeroMovil = sNumeroMovil;
            this.sServicioTipo = sServicioTipo;
            this.sTipoPersona = sTipoPersona;
        }
    }
}
