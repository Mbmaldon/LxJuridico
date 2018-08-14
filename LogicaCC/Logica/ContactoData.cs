using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// Clase que da estructura a la informacion de los contactos
	/// autorizados de un cliente.
	/// 
	/// </summary>

	public class ContactoData
	{
		public string sIdContacto { get; set; }
		public string sNombre { get; set; }
		public string sAPaterno { get; set; }
		public string sMaterno { get; set; }
		public string sCorreoEletronico { get; set; }
		public string sTelefonolocal { get; set; }
		public string sExtension { get; set; }
		public string sTelefonoMovil { get; set; }

		// CONSTRUCTOR
		public ContactoData(string sIdContacto,			string sNombre,			
							string sAPaterno, 			string sMaterno,
							string sCorreoEletronico,	string sTelefonolocal, 
							string sExtension,			string sTelefonoMovil)
		{
			this.sIdContacto		= sIdContacto;
			this.sNombre			= sNombre;
			this.sAPaterno			= sAPaterno;
			this.sMaterno			= sMaterno;
			this.sCorreoEletronico	= sCorreoEletronico;
			this.sTelefonolocal		= sTelefonolocal;
			this.sExtension			= sExtension;
			this.sTelefonoMovil		= sTelefonoMovil;
		}

	}
}
