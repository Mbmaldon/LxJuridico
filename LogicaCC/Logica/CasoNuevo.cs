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
	/// Clase que genera un caso o llamada por el 
	/// usuario esta solo se genera y devuelve el id
	/// del caso.
	/// 
	/// </summary>
	
	public class CasoNuevo
	{
		// CONSTRUCTOR
		public CasoNuevo()
		{
		}

		// FUNCION QUE DEVUELVE EL ID DEL CASO GENERADO
		public int CrearCaso(string sIdUsuario)
		{
			DBLXCCDataContext ADB = new DBLXCCDataContext(ConnectionString.DbMPY);
			int iIdCaso = 0;
			long? IdCaso = null;

			ADB.LXCCSPI_CASO_NUEVO(Convert.ToInt64(sIdUsuario), ref IdCaso);

			if(IdCaso != 0)
			{
				iIdCaso = Convert.ToInt32(IdCaso);
			}

			return iIdCaso;
		}
	}
}
