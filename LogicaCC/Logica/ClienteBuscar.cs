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
	/// Se hace la busqueda de una cliente por numero de cliente
	/// o RFC y se evnia el id del usuario (contador) que esta realizando
	/// la busqueda para que se filtre solo los que tiene asignados.
	/// 
	/// </summary>

	public class ClienteBuscar
	{
		// CONSTRUCTOR
		public ClienteBuscar()
		{
		}

		// SE HACE LA BUSQUEDA
		public ClienteData Buscar(string sCliente,string sRfc,string sIdUsuario)
		{
			DBLXCCDataContext	ADB		 = new DBLXCCDataContext(ConnectionString.DbMPY);
			ClienteData			ACliente = null;

			var vCliente = ADB.LXCCSPS_BUSCAR_CLIENTE(sCliente, 
													  sRfc, 
													  Convert.ToInt64(sIdUsuario));

			foreach(var x in vCliente)
			{
				ACliente = new ClienteData(x.IdCliente.ToString(),x.Activo.ToString(), "", x.Nombre.ToString(), x.APaterno.ToString(),
											x.AMaterno.ToString(), "", "", "", "", "", "",
											x.NumeroMovil.ToString(),
											x.CorreoElectronico.ToString(),
											"", "", "", "", "",
											x.IdCliente.ToString(),
                                            x.ServicioConta.ToString(), x.ServicioOD.ToString(),
                                            x.IdComisionista.ToString(), x.IdNivel.ToString(),
                                            x.Curp, x.NoExpediente);
			}

			return ACliente;
		}
	}
}
