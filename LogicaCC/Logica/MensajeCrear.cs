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
	/// Clase que guarda la informacion del mensaje a ser enviado.
	/// 
	/// </summary>

	public class MensajeCrear
	{
		// CONSTRUCTOR
		public MensajeCrear()
		{

		}

		// ENVIO DE INFORMACIÓN DEL MENSAJE
		public int Mensaje(string sIdUsuario, string sIdCliente, string sIdMensajeTipo, string sMensaje)
		{
			int iResultado = 0;
			int? iIResultado = null;

			DBLXCCDataContext ADB = new DBLXCCDataContext(ConnectionString.DbMPY);

			ADB.LXCCSPI_CREAR_MENSAJE(Convert.ToInt64(sIdUsuario), 
									  Convert.ToInt64(sIdCliente), 
									  Convert.ToInt64(sIdMensajeTipo), 
									  sMensaje, 
									  ref iIResultado);


			return iResultado;
		}
	}
}
