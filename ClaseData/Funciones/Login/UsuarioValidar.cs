using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseData.Data;
using ClaseData.Clases;

namespace ClaseData.Funciones
{
	public class UsuarioValidar
	{
		public UsuarioValidar()
		{
		}

        /*Función para validar que el usuario exista en la tabla usuario*/
		public void Validar(string sUsuario, string sPassword)
		{
			DBCAJDataContext ADB		 = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
			DatosUsuario	AUsuario = DatosUsuario.Instancia;

			var vUsuario = ADB.ADMSPS_VALIDAR_USUARIO(sUsuario, sPassword);

			foreach(var vRow in vUsuario)
			{
				AUsuario.sIdusuario	  = vRow.IdUsuario.ToString();
				AUsuario.sTipoUsuario = vRow.IdUsuarioTipo.ToString();
                AUsuario.sIdMateria   = vRow.IdMateria.ToString();
				AUsuario.sNombre	  = vRow.Nombre.ToString();
				AUsuario.sAPaterno	  = vRow.APaterno.ToString();
				AUsuario.sAMAterno	  = vRow.AMaterno.ToString();
			}
		}
	}
}
