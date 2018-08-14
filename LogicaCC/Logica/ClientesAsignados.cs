using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCC.DB;

namespace LogicaCC.Logica
{
	public class ClientesAsignados
	{
		string sIdUsuario;

		// CONSTRUCTOR
		public ClientesAsignados(string sIdUsuario)
		{
			this.sIdUsuario = sIdUsuario;
		}

		// DEVUELVE LISTA DE CLIENTES ASIGNADOS
		public ArrayList ListaClientes()
		{
			DBLXCCDataContext	ADB		= new DBLXCCDataContext(ConnectionString.DbMPY);
			ArrayList			ALista	= new ArrayList();
			
			var vLista = ADB.LXCCSPS_LISTA_CLIENTE_ASIGNADOS(Convert.ToInt64(sIdUsuario));

			foreach(var cliente in vLista)
			{
				ClienteInfoSMS ACliente = new ClienteInfoSMS();

				ACliente.TelMovil = cliente.NumeroMovil.ToString();
				ACliente.EMail = cliente.CorreoElectronico.ToString();
				ALista.Add(ACliente);
			}

			return ALista;
		}
	}
}
