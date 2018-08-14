using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// Informacion basica de los usuarios del sistema  
	/// 
	/// </summary>

	public class UsuarioInfo
	{
		public string sNombre { get; set; }
		public string sAPaterno { get; set; }
		public string sAMAterno { get; set; }
		public string sTipoUsuario { get; set; }
		public string sIdusuario { get; set; }

		// CONSTRUCTOR
		public UsuarioInfo()
		{
		}
	}
}
