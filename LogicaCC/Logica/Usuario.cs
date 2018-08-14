using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using LogicaCC.DB;
using System.Data.Linq;
using System.Data.SqlClient;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// Clase que se utiliza para validar al usuario y password
	/// 
	/// </summary>

    public class Usuario
    {
		// CONSTRUCTOR
        public Usuario() 
        { 
        }

		// VALIDA AL USUARIO
        //public void ValidarUsuario(string sUsuario, string sPassword)
        //{
        //    DBLXCCDataContext ADB      = new DBLXCCDataContext();
        //    UsuarioData       AUsuario = UsuarioData.Instancia;

        //    var vValidar = ADB.LXCCSPS_VALIDAR_USUARIO(sUsuario, sPassword);

        //    foreach(var X in vValidar)
        //    {
        //        AUsuario.sIdusuario     = X.IdUsuario.ToString();
        //        AUsuario.sTipoUsuario   = X.IdUsuarioTipo.ToString();
        //        AUsuario.sNombre        = X.Nombre.ToString();
        //        AUsuario.sAPaterno      = X.APaterno.ToString();
        //        AUsuario.sAMAterno      = X.AMaterno.ToString();
        //    }
        //}

        /// del usuario oara ver si existe
        /// </summary>
        /// <param name="sUsuario">Usuario de acceso</param>
        /// <param name="sContrasenia">Contraseña de acceso</param>
        public void ValidarUsuario(string sUsuario, string sContrasenia)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                UsuarioData _UsuarioData = UsuarioData.Instancia;
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_VALIDAR_USUARIO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@User", sUsuario);
                _SqlCommand.Parameters.AddWithValue("@Password", sContrasenia);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            _UsuarioData.sIdusuario     = _SqlDataReader["IdUsuario"].ToString();
                            _UsuarioData.sTipoUsuario   = _SqlDataReader["IdUsuarioTipo"].ToString();
                            _UsuarioData.sNombre        = _SqlDataReader["Nombre"].ToString();
                            _UsuarioData.sAPaterno      = _SqlDataReader["APaterno"].ToString();
                            _UsuarioData.sAMAterno      = _SqlDataReader["AMaterno"].ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    _UsuarioData = null;
                }
            }
        }
    }
}
