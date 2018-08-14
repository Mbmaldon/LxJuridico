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
	/// Se selecciona el listado de usuarios
	/// de un tipo dado.
	/// 
	/// </summary>

	public class UsuarioLista
	{
		// CONSTRUCTOR
		public UsuarioLista()
		{
		}

		// LISTA DE USUARIOS
		public List<UsuarioInfo> ObtenerLista(string sIdTipoUsuario)
		{
			DBLXCCDataContext ADB		= new DBLXCCDataContext(ConnectionString.DbMPY);
			List<UsuarioInfo> ALista	= new List<UsuarioInfo>();
			UsuarioInfo		  AUsuario;

			var vListaUsuario = ADB.LXCCSPS_LISTA_USUARIOS(Convert.ToInt32(sIdTipoUsuario));

			foreach(var x in vListaUsuario)
			{
				AUsuario = new UsuarioInfo();
				AUsuario.sIdusuario = x.IdUsuario.ToString();
				AUsuario.sTipoUsuario = x.IdUsuarioTipo.ToString();
				AUsuario.sNombre = x.Nombre;
				AUsuario.sAPaterno = x.APaterno;
				AUsuario.sAMAterno = x.AMaterno;
				ALista.Add(AUsuario);
			}

			return ALista;
		}
	}
}
