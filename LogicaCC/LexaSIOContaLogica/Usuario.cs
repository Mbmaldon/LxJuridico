using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AGREGAMOS LIBRERIAS ADICIONALES
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class Usuario
    {
        public int      iIdUsuario          { get; set; }
        public int      iIdUsuarioTipo      { get; set; }
        public int      iIdUsuarioNivel     { get; set; }
        public string   sNombre             { get; set; }
        public string   sAPaterno           { get; set; }
        public string   sAMaterno           { get; set; }
        public string   sUsuario            { get; set; }
        public string   sContrasena         { get; set; }
        public byte     bActivo             { get; set; }
        public string   sActivo             { get; set; }
        public string   sCorreoElectronico  { get; set; }
        public string   sTelefonoLocal      { get; set; }
        public string   sExtension          { get; set; }
        public string   sTelefonoMovil      { get; set; }
        public string   sUsuarioTipo        { get; set; }
        public string   sCedula             { get; set; }
        public string   sFechaCreacion      { get; set; }
        public string   sUsuarioNivel       { get; set; }
        public int      iIdEstado           { get; set; }

        // Propiedades para el alta del usuario en el PMS
        public int     iIdGerencia       { get; set; }
        public int     iIdPuesto         { get; set; }
        public int     iIdTipo           { get; set; }
        public string  sGerencia         { get; set; }
        public string  sPuesto           { get; set; }
        public string  sTipo             { get; set; }
        public string  sNoCuentaBancaria { get; set; }
		public int iIdSucursal			 { get; set; }
		public int? iIdEquipoContable { get; set; }
		public int? iIdGerente { get; set; }
		public int? iIdSupervisor { get; set; }


		public Usuario()
        {
            iIdUsuario          = 0;
            iIdUsuarioTipo      = 0;
            iIdUsuarioNivel     = 0;
            sNombre             = string.Empty;
            sAPaterno           = string.Empty;
            sAMaterno           = string.Empty;
            sUsuario            = string.Empty;
            sContrasena         = string.Empty;
            bActivo             = 0;
            sActivo             = string.Empty;
            sCorreoElectronico  = string.Empty;
            sTelefonoLocal      = string.Empty;
            sExtension          = string.Empty;
            sTelefonoMovil      = string.Empty;
            sUsuarioTipo        = string.Empty;
            sCedula             = string.Empty;
            sFechaCreacion      = string.Empty;
            sNoCuentaBancaria   = string.Empty;
			iIdSucursal			= 0;
			iIdEquipoContable	= null;
			iIdGerente			= null;
			iIdSupervisor		= null;
        }

        /// <summary>
        /// Método Público que regresa una lista de niveles de usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> listaNivelUsuario()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Usuario> lista = new List<Usuario>();
                SqlCommand _SqlCommand = new SqlCommand("LXSIOCS_Seleccionar_UsuarioNivel", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Usuario item = new Usuario()
                            {
                                iIdUsuarioNivel = int.Parse(_SqlDataReader["IdUsuarioNivel"].ToString()),
                                sUsuarioNivel   = _SqlDataReader["UsuarioNivel"].ToString()
                            };
                            lista.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    lista = null;
                }
                return lista;
            }
        }

        /// <summary>
        /// Método Público que regresa una lista de Tipos de usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> listaTipoUsuario(int iIdGerencia, int iIdNivel)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<Usuario> lista = new List<Usuario>();
                SqlCommand _SqlCommand = new SqlCommand("LXSIOCS_Seleccionar_UsuarioTipo", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdGerencia", iIdGerencia);
                _SqlCommand.Parameters.AddWithValue("@IdNivel", iIdNivel);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Usuario item = new Usuario()
                            {
                                iIdUsuarioTipo = int.Parse(_SqlDataReader["IdUsuarioTipo"].ToString()),
                                sUsuarioTipo   = _SqlDataReader["UsuarioTipo"].ToString()
                            };
                            lista.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    lista = null;
                }
                return lista;
            }
        }

        /// <summary>
        /// Método Público para insertar un nuevo usuario
        /// </summary>
        /// <param name="usuario">Objeto de tipo usuario que contiene sus propiedades</param>
        /// <returns></returns>
        public int InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
				//CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
				SqlCommand _sqlCommand         = new SqlCommand("LXSIOCI_Crear_Usuario", _sqlConnection) { CommandType = CommandType.StoredProcedure };

				//PASAMOS COMO PARAMETRO A LA CONSULTA, LA INFORMACIÓN QUE SE GUARDARA EN EL REGISTRO DEL USUARIO
				_sqlCommand.Parameters.AddWithValue("@idUsuarioTipo", usuario.iIdUsuarioTipo);
				_sqlCommand.Parameters.AddWithValue("@nombre", usuario.sNombre);
				_sqlCommand.Parameters.AddWithValue("@aPaterno", usuario.sAPaterno);
				_sqlCommand.Parameters.AddWithValue("@aMaterno", usuario.sAMaterno);
				_sqlCommand.Parameters.AddWithValue("@usuario", usuario.sUsuario);
				_sqlCommand.Parameters.AddWithValue("@contrasena", usuario.sContrasena);
				_sqlCommand.Parameters.AddWithValue("@activo", usuario.bActivo);
				_sqlCommand.Parameters.AddWithValue("@correoElectronico", usuario.sCorreoElectronico) ;
				_sqlCommand.Parameters.AddWithValue("@telefonoLocal", usuario.sTelefonoLocal);
				_sqlCommand.Parameters.AddWithValue("@extension", usuario.sExtension);
				_sqlCommand.Parameters.AddWithValue("@telefonoMovil", usuario.sTelefonoMovil);
				_sqlCommand.Parameters.AddWithValue("@cedula", usuario.sCedula);
				_sqlCommand.Parameters.AddWithValue("@IdEstado", usuario.iIdEstado);
				_sqlCommand.Parameters.AddWithValue("@NoCuenta", usuario.sNoCuentaBancaria);
				_sqlCommand.Parameters.AddWithValue("@IdSucursal", usuario.iIdSucursal);
				_sqlCommand.Parameters.AddWithValue("@IdEquipoContador", usuario.iIdEquipoContable);
				_sqlCommand.Parameters.AddWithValue("@IdGerente", usuario.iIdGerente);
				_sqlCommand.Parameters.AddWithValue("@IdSupervisor", usuario.iIdSupervisor);

				var resultado = _sqlCommand.Parameters.Add("@Status", SqlDbType.BigInt);
				resultado.Direction = ParameterDirection.ReturnValue;

				try
				{
					//ABRIMOS LA CONEXIÓN
					_sqlConnection.Open();
					//EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
					_sqlCommand.ExecuteNonQuery();
					return (int)resultado.Value;
				}
				catch (Exception)
				{
					return 0;
				}
			}
		}

        public int iActualizaCuentaBancaria(int iIdUsuarioCreacion, int iIdUsuario, string sCuenta)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPI_USUARIO_CUENTA", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuarioCreacion", iIdUsuarioCreacion);
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@Cuenta", sCuenta);

                var parameterReturn = _SqlCommand.Parameters.Add("@Status", SqlDbType.BigInt);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return int.Parse(parameterReturn.Value.ToString());                    
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Método Público que regresa una lista de usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> listaUsuarios()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<Usuario> lista = new List<Usuario>();
                SqlCommand _SqlCommand = new SqlCommand("LXSIOCS_Seleccionar_Usuarios", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Usuario item = new Usuario()
                            {
                                iIdUsuario          = int.Parse(_SqlDataReader["IdUsuario"].ToString()),
                                iIdUsuarioTipo      = int.Parse(_SqlDataReader["IdUsuarioTipo"].ToString()),
                                sNombre             = _SqlDataReader["Nombre"].ToString(),
                                sAPaterno           = _SqlDataReader["APaterno"].ToString(),
                                sAMaterno           = _SqlDataReader["AMaterno"].ToString(),
                                sUsuario            = _SqlDataReader["Usuario"].ToString(),
                                sContrasena         = _SqlDataReader["Contrasena"].ToString(),
                                sActivo             = _SqlDataReader["Activo"].ToString(),
                                sCorreoElectronico  = _SqlDataReader["CorreoElectronico"].ToString(),
                                sTelefonoLocal      = _SqlDataReader["TelefonoLocal"].ToString(),
                                sExtension          = _SqlDataReader["Extension"].ToString(),
                                sTelefonoMovil      = _SqlDataReader["TelefonoMovil"].ToString(),
                                sUsuarioTipo        = _SqlDataReader["UsuarioTipo"].ToString(),
                                sFechaCreacion      = _SqlDataReader["FechaCreacion"].ToString()
                            };
                            lista.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    lista = null;
                }
                return lista;
            }
        }

        public Usuario InformacionUsuario(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                Usuario usuario = null;
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_USUARIO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            usuario = new Usuario()
                            {
                                iIdUsuario          = int.Parse(_SqlDataReader["IdUsuario"].ToString()),
                                iIdUsuarioTipo      = int.Parse(_SqlDataReader["IdUsuarioTipo"].ToString()),
                                sNombre             = _SqlDataReader["Nombre"].ToString(),
                                sAPaterno           = _SqlDataReader["APaterno"].ToString(),
                                sAMaterno           = _SqlDataReader["AMaterno"].ToString(),
                                sUsuario            = _SqlDataReader["Usuario"].ToString(),
                                sContrasena         = _SqlDataReader["Contrasena"].ToString(),
                                sActivo             = _SqlDataReader["Activo"].ToString(),
                                sCorreoElectronico  = _SqlDataReader["CorreoElectronico"].ToString(),
                                sTelefonoLocal      = _SqlDataReader["TelefonoLocal"].ToString(),
                                sExtension          = _SqlDataReader["Extension"].ToString(),
                                sTelefonoMovil      = _SqlDataReader["TelefonoMovil"].ToString(),
                                sCedula             = _SqlDataReader["Cedula"].ToString(),
                                sUsuarioTipo        = _SqlDataReader["UsuarioTipo"].ToString(),
                                sFechaCreacion      = _SqlDataReader["FechaCreacion"].ToString(),
                                sNoCuentaBancaria   = _SqlDataReader["Cuenta"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    usuario = null;
                }
                return usuario;
            }
        }

        /// <summary>
        /// Obtiene una lista de gerencias disponibles para el
        /// alta de usuarios en el sistema PMS
        /// </summary>
        /// <returns></returns>
        public List<Usuario> lListaGerencia()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Usuario> lista = new List<Usuario>();
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_GERENCIA", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Usuario item = new Usuario()
                            {
                                iIdGerencia = int.Parse(_SqlDataReader["IdGerencia"].ToString()),
                                sGerencia   = _SqlDataReader["Gerencia"].ToString()
                            };
                            lista.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    lista = null;
                }
                return lista;
            }
        }

        /// <summary>
        /// Obtiene una lista de puestos para el alta de usuarios
        /// en el sistema PMS
        /// </summary>
        /// <param name="iIdGerencia">Id de la genrecia requerida para obtener los puestos</param>
        /// <returns></returns>
        public List<Usuario> lListaPuesto(int iIdGerencia)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Usuario> lista = new List<Usuario>();
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_PUESTO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdGerencia", iIdGerencia);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Usuario item = new Usuario()
                            {
                                iIdPuesto = int.Parse(_SqlDataReader["IdPuesto"].ToString()),
                                sPuesto   = _SqlDataReader["Puesto"].ToString()
                            };
                            lista.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    lista = null;
                }
                return lista;
            }
        }

        /// <summary>
        /// Obtiene una lista de los tipos de usuarios existentes
        /// para el alta de usuarios en el PMS
        /// </summary>
        /// <returns></returns>
        public List<Usuario> lListaTipo()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Usuario> lista = new List<Usuario>();
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_TIPOUUSUARIO", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Usuario item = new Usuario()
                            {
                                iIdTipo = int.Parse(_SqlDataReader["IdTipoUsuario"].ToString()),
                                sTipo   = _SqlDataReader["TipoUsuario"].ToString()
                            };
                            lista.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    lista = null;
                }
                return lista;
            }
        }

        public int iAltaUsuarioPMS(Usuario usuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_COLABORADOR_AGREGAR", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", usuario.iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@nombre", usuario.sNombre);
                _SqlCommand.Parameters.AddWithValue("@ap", usuario.sAPaterno);
                _SqlCommand.Parameters.AddWithValue("@am", usuario.sAMaterno);
                _SqlCommand.Parameters.AddWithValue("@IdPuesto", usuario.iIdPuesto);
                _SqlCommand.Parameters.AddWithValue("@TipoUsuario", usuario.iIdTipo);
                _SqlCommand.Parameters.AddWithValue("@Usuario", usuario.sUsuario);
                _SqlCommand.Parameters.AddWithValue("@Pass", usuario.sContrasena);
                _SqlCommand.Parameters.AddWithValue("@Email", usuario.sCorreoElectronico);

                var parameterReturn = _SqlCommand.Parameters.Add("@Status", SqlDbType.BigInt);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return int.Parse(parameterReturn.Value.ToString());
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

		/// <summary>
		/// Obtiene un listado de gerencias desde la base de datos
		/// </summary>
		/// <returns></returns>
		public List<Usuario> GetListGerencias()
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
				List<Usuario> lista = new List<Usuario>();
				SqlCommand _SqlCommand = new SqlCommand("MDSPS_OBTENER_GERENCIAS", _SqlConnection) { CommandType = CommandType.StoredProcedure };

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Usuario item = new Usuario()
							{
								iIdGerencia = int.Parse(_SqlDataReader["IdGerencia"].ToString()),
								sGerencia	= _SqlDataReader["Gerencia"].ToString()
							};
							lista.Add(item);
						}
					}
				}
				catch (Exception)
				{
					lista = null;
					//throw;
				}
				return lista;
			}
		}

        /// <summary>
        /// Obtiene un listado de agentes de call center filtrados por grupo
        /// </summary>
        /// <param name="iIdGrupo">Id del grupo a filtrar</param>
        /// <returns></returns>
        public List<Usuario> GetListCallCenter(int iIdGrupo)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Usuario> list = new List<Usuario>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_OBTENER_AGENTES_CC", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdGrupo", iIdGrupo);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Usuario item = new Usuario()
                            {
                                iIdUsuario  = int.Parse(_SqlDataReader["IdUsuario"].ToString()),
                                sNombre     = string.Format("{0} {1} {2}", _SqlDataReader["Nombre"].ToString(), _SqlDataReader["APaterno"].ToString(), _SqlDataReader["AMaterno"].ToString())
                            };
                            list.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    list = null;
                }
                return list;
            }
        }
    }
}