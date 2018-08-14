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
	/// FUNCION QUE ACTUALIZA LA INFORMACION DEL CLIENTE, ASI COMO 
	/// DE SUS CONTACTOS AUTORIZADOS.
	/// 
	/// </summary>
	
	public class ClienteActInfo
	{
		// CONSTRUCTOR
		public ClienteActInfo()
		{
		}

		// ENVIO DE INFORMACIÓN
		public int ActualizarInfo(string sCliente,		string sIdEstado,	string sIdUsuario,		string sNombre, 
								  string sPaterno,		string sMaterno,	string sRFC,			string sDireccion, 
								  string sMunicipio,	string sCP,			string sLocal,			string sExtension, 
								  string sMovil,		string sCorreo,		string sIdServEstatus,	string sidServicioTipo,
								  string sFechaContr,	string sFechaVenci, string sIdContador,		string sNombreC1,		
								  string sPaternoC1,	string sMaternoC1,	string sLocalC1,		string sExtensionC1, 
								  string sMovilC1,		string sCorreoC1,	string sNombreC2,		string sPaternoC2, 
								  string sMaternoC2,	string sLocalC2,	string sExtensionC2,	string sMovilC2, 
								  string sCorreoC2,     bool bServicioConta, bool bServicioOD,      string sIdComisionista,
                                  string sIdNivel,      string sCurp,       string sNoExpediente)
		{
			DBLXCCDataContext ADB = new DBLXCCDataContext(ConnectionString.DbMPY);
			int? iResultado = 0;

			ADB.LXCCSPU_ALTA_ACT_CLIENTE(sCliente,
										 Convert.ToInt64(sIdEstado),
										 Convert.ToInt64(sIdUsuario),
										 sNombre, sPaterno, sMaterno,
										 sRFC, sDireccion, sMunicipio,
										 sCP, sLocal, sExtension, sMovil,
										 sCorreo,
										 Convert.ToInt64(sIdServEstatus),
										 Convert.ToInt64(sidServicioTipo),
										 Convert.ToDateTime(sFechaContr),
										 Convert.ToDateTime(sFechaVenci),
										 Convert.ToInt64(sIdContador),
										 sNombreC1, 
										 sPaternoC1, 
										 sMaternoC1,
										 sLocalC1, 
										 sExtensionC1, 
										 sMovilC1, 
										 sCorreoC1,
										 sNombreC2, 
										 sPaternoC2, 
										 sMaternoC2,
										 sLocalC2,
										 sExtensionC2,
										 sMovilC2,
										 sCorreoC2,
                                         bServicioConta,
                                         bServicioOD,
                                         Convert.ToInt64(sIdComisionista),
                                         Convert.ToInt64(sIdNivel),
                                         sCurp,
                                         sNoExpediente,

                                         ref iResultado);

			return Convert.ToInt32(iResultado);
		}        
	}
}
