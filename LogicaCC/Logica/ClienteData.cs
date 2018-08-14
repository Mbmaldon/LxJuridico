using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// Clase que se usa para guardar los datos del 
	/// cliente para despues ser mostrados en los 
	/// formularios.
	/// 
	/// </summary>

    public class ClienteData
    {
		#region Variables

		public string sCliente { get; set; }
        public string sActivo { get; set; }
        public string sRfc { get; set; }
        public string sNombre { get; set; }
        public string sAPaterno { get; set; }
        public string sAMaterno { get; set; }
        public string sDireccion { get; set; }
		public string sMunicipio { get; set; }
		public string sIdEstado { get; set; }
		public string sCP { get; set; }
        public string sTelefonoLocal { get; set; }
        public string sExtension { get; set; }
        public string sTelefonoCelular { get; set; }
        public string sCorreoElectronico { get; set; }
        public string sIdServicioTipo { get; set; }
        public string sIdServicioStatus { get; set; }
        public string sFechaContratado { get; set; }
        public string sFechaVencimiento { get; set; }
		public string sIdContAsignado { get; set; }
		public string sIdCliente { get; set; }


        //NUEVAS VARIABLES
        public string   iServicioConta      { get; set; }
        public string   iServicioOD         { get; set; }
        public string   iIdComisionista     { get; set; }
        public string   iIdNivel            { get; set; }
        public string   sCurp               { get; set; }
        public string   sNoExpediente       { get; set; }

        #endregion Variables

        // CONSTRUCTOR
        public ClienteData(string sCliente, string sActivo, string sRfc, string sNombre, string sAPaterno, string sAMaterno, string sDireccion, string sMunicipio, string sIdEstado,
                           string sCP, string sTelefonoLocal, string sExtension, string sTelefonoCelular, string sCorreoElectronico, string sIdServicioTipo,
                           string sIdServicioStatus, string sFechaContratado, string sFechaVencimiento, string sIdContAsig, string sIdCliente, string iServicioConta, string iServicioOD,
                           string iIdComisionista, string iIdNivel, string sCurp, string sNoExpediente)
        {
            this.sCliente           = sCliente;
            this.sActivo            = sActivo;
            this.sRfc               = sRfc;
            this.sNombre            = sNombre;
            this.sAPaterno          = sAPaterno;
            this.sAMaterno          = sAMaterno;
            this.sDireccion         = sDireccion;
			this.sMunicipio			= sMunicipio;
			this.sIdEstado			= sIdEstado;
            this.sCP                = sCP;
            this.sTelefonoLocal     = sTelefonoLocal;
            this.sExtension         = sExtension;
            this.sTelefonoCelular   = sTelefonoCelular;
            this.sCorreoElectronico = sCorreoElectronico;
            this.sIdServicioTipo    = sIdServicioTipo;
            this.sIdServicioStatus  = sIdServicioStatus;
            this.sFechaContratado   = sFechaContratado;
            this.sFechaVencimiento  = sFechaVencimiento;
			this.sIdContAsignado	= sIdContAsig;
			this.sIdCliente			= sIdCliente;

            this.iServicioConta     = iServicioConta;
            this.iServicioOD        = iServicioOD;
            this.iIdComisionista    = iIdComisionista;
            this.iIdNivel           = iIdNivel;
            this.sCurp              = sCurp;    
            this.sNoExpediente      = sNoExpediente;

        }
    } 
}