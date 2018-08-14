using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCC.DB;

namespace LogicaCC.Logica
{
	public class DeclaracionAlta
	{
		// CONSTRUCTOR
		public DeclaracionAlta()
		{
		}

		// FUNCION QUE GUARDA LA DECLRACION
		public int Alta(string sIdCliente,	string sIdPeriodo,	string sIdDeclaracionTipo, 
						string sIdDecEstado,string sIdUsuario,	string sAñoDec, 
						string sLinCap,		string sNumOper,	string sMonto, 
						string sLlavePago,	string sFechaLimPag,string sFechaPresentacion)
		{
			DBLXCCDataContext ADB = new DBLXCCDataContext(ConnectionString.DbMPY);
			int? iResultado = null;

			ADB.LXDECSPI_ALTA_DECLARACION(Convert.ToInt64(sIdCliente), 
										  Convert.ToInt64(sIdPeriodo),
										  Convert.ToInt64(sIdDeclaracionTipo), 
										  Convert.ToInt64(sIdDecEstado), 
										  Convert.ToInt64(sIdUsuario), 
										  sAñoDec, 
										  sLinCap,
										  sNumOper,
										  Convert.ToDecimal(sMonto),
										  sLlavePago, 
										  Convert.ToDateTime(sFechaLimPag),
										  Convert.ToDateTime(sFechaPresentacion),
										  ref iResultado);

			return Convert.ToInt32(iResultado);
		}
	}
}
