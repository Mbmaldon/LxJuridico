using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCC.DB;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// Se obtienen los contactos autorizados
	/// de un cliente dado.
	/// 
	/// </summary>

	public class ContactoAut
	{
		// CONSTRUCTOR
		public ContactoAut()
		{
		}

		// LISTA CONTACTOS AUTORIZADOS
		public List<ContactoData> ListaContactos(string sIdCliente)
		{
			DBLXCCDataContext	ADB			= new DBLXCCDataContext(ConnectionString.DbMPY);
			List<ContactoData>	AContactos	= new List<ContactoData>();
			ContactoData		AContacto	= null;

			var vContactos = ADB.LXCCSPS_CONTACTOS_AUT(Convert.ToInt32(sIdCliente));

			foreach(var x in vContactos)
			{
				AContacto = new ContactoData(x.IdClienteContactoAut.ToString(),
											 x.Nombre,
											 x.APaterno,
											 x.AMaterno,
											 x.CorreoElectronico,
											 x.TelefonoLocal,
											 x.Extension,
											 x.TelefonoMovil);

				AContactos.Add(AContacto);
			}

			return AContactos;
		}
	}
}
