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
    public class Cliente
    {
        //CREAMOS PROPIEADES
        public int       iIdCliente             { get; set; }
        public int       iIdUsuarioCreacion     { get; set; }
        public int       iIdUsuarioModificacion { get; set; }
        public int       iIdTipoPersona         { get; set; }
        public string    sCliente               { get; set; }
        public string    sNombre                { get; set; }
        public string    sAPaterno              { get; set; }
        public string    sAMaterno              { get; set; }
        public string    sRfc                   { get; set; }
        public string    sCorreoElectronico     { get; set; }
        public string    sTelefono              { get; set; }
        public string    sDireccion             { get; set; }
        public string    sMunicipio             { get; set; }
        public string    sCodigoPostal          { get; set; }
        public string    sExtension             { get; set; }
        public string    sNumeroMovil           { get; set; }

        public int      iIdEstado         { get; set; }
        public int      iIdServicioTipo   { get; set; }
        public string   sCurp             { get; set; }
        public string   sStatus           { get; set; }
        public DateTime dtFechaBaja       { get; set; }
        public string   sActivo           { get; set; }
        public int      iIdContador       { get; set; }
        public string   sContador         { get; set; }
        public int      iIdRegimen        { get; set; }
        public string   sRegimen            { get; set; }

        //CREAMOS CONSTRUCTOR
        public Cliente()
        {
            iIdCliente             = 0;
            iIdUsuarioCreacion     = 0;
            iIdUsuarioModificacion = 0;
            iIdTipoPersona         = 0;
            iIdRegimen             = 0;
            sCliente               = string.Empty;
            sNombre                = string.Empty;
            sAPaterno              = string.Empty;
            sAMaterno              = string.Empty;
            sRfc                   = string.Empty;
            sCorreoElectronico     = string.Empty;
            sTelefono              = string.Empty;
            sDireccion             = string.Empty;
            sMunicipio             = string.Empty;
            sCodigoPostal          = string.Empty;
            sExtension             = string.Empty;
            sNumeroMovil           = string.Empty;
            sStatus                = string.Empty;
            sContador              = string.Empty;
            sRegimen               = string.Empty;
        }

		/// <summary>
		/// Obtiene  un listado de clientes por contador
		/// </summary>
		/// <param name="iIdContador">Id del contador</param>
		/// <returns></returns>
		public List<Cliente> GetListClientesByContador(int iIdContador)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
				List<Cliente> list = new List<Cliente>();
				SqlCommand _SqlCommand = new SqlCommand("MDSPS_OBTENER_CLIENTES_BY_CONTADOR", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdContador);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Cliente item = new Cliente()
							{
								iIdCliente			= int.Parse(_SqlDataReader["IdCliente"].ToString()),
								sCliente			= _SqlDataReader["Cliente"].ToString(),
								sNombre				= _SqlDataReader["Nombre"].ToString(),
								sAPaterno			= _SqlDataReader["APaterno"].ToString(),
								sAMaterno			= _SqlDataReader["AMaterno"].ToString(),
								sCorreoElectronico	=_SqlDataReader["CorreoElectronico"].ToString(),
								sNumeroMovil		= _SqlDataReader["NumeroMovil"].ToString()
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

        /// <summary>
        /// Método público para agregar nuevos clientes a los
        /// registros de la base de datos DBLEXACONTA
        /// </summary>
        /// <param name="_cliente">Objeto de tipo Cliente con propieades</param>
        /// <returns></returns>
        public bool bInsertarCliente(Cliente _cliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPC_Crear_Cliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                //PASAMOS COMO PARAMETRO A LA CONSULTA, LA INFORMACIÓN QUE SE GUARDARA DEL CLIENTE
                _SqlCommand.Parameters.AddWithValue("@idCliente", _cliente.iIdCliente);
                _SqlCommand.Parameters.AddWithValue("@idUsuarioCreacion", _cliente.iIdUsuarioCreacion);
                _SqlCommand.Parameters.AddWithValue("@cliente", _cliente.sCliente);
                _SqlCommand.Parameters.AddWithValue("@nombre", _cliente.sNombre);
                _SqlCommand.Parameters.AddWithValue("@aPaterno", _cliente.sAPaterno);
                _SqlCommand.Parameters.AddWithValue("@aMaterno", _cliente.sAMaterno);
                _SqlCommand.Parameters.AddWithValue("@rfc", _cliente.sRfc);
                _SqlCommand.Parameters.AddWithValue("@correoElectronico", _cliente.sCorreoElectronico);
                _SqlCommand.Parameters.AddWithValue("@telefono", _cliente.sTelefono);
                _SqlCommand.Parameters.AddWithValue("@direccion", _cliente.sDireccion);
                _SqlCommand.Parameters.AddWithValue("@municipio", _cliente.sMunicipio);
                _SqlCommand.Parameters.AddWithValue("@codigoPostal", _cliente.sCodigoPostal);
                _SqlCommand.Parameters.AddWithValue("@extension", _cliente.sExtension);
                _SqlCommand.Parameters.AddWithValue("@numeroMovil", _cliente.sNumeroMovil);

                try
                {
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                    return (_SqlCommand.ExecuteNonQuery() > 0 ? true : false);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Método público que devuelve información detallada
        /// de un cliente pasando como parametro su ID
        /// </summary>
        /// <param name="idCliente">Clave de cliente(idCliente)</param>
        /// <returns></returns>
        public Cliente InformacionCliente(int idCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
                Cliente cliente = null;
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_Cliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@idCliente", idCliente);

                try
                {
                    //ABRIMOS NUESTRA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            //INICIALIZAMOS EL OBJETO CLIENTE Y ASIGNAMOS INFORMACIÓN A SUS PROPIEDADES
                            cliente = new Cliente()
                            {
                                iIdCliente          = int.Parse(_sqlDataReader["IdCliente"].ToString()),
                                sNombre             = _sqlDataReader["Nombre"].ToString(),
                                sAPaterno           = _sqlDataReader["APaterno"].ToString(),
                                sAMaterno           = _sqlDataReader["AMaterno"].ToString(),
                                sRfc                = _sqlDataReader["RFC"].ToString(),
                                sCorreoElectronico  = _sqlDataReader["CorreoElectronico"].ToString(),
                                sTelefono           = _sqlDataReader["Telefono"].ToString(),
                                sDireccion          = _sqlDataReader["Direccion"].ToString(),
                                sMunicipio          = _sqlDataReader["Municipio"].ToString(),
                                sCodigoPostal       = _sqlDataReader["CodigoPostal"].ToString(),
                                sExtension          = _sqlDataReader["Extension"].ToString(),
                                sNumeroMovil        = _sqlDataReader["NumeroMovil"].ToString(),
                                sCliente            = _sqlDataReader["Cliente"].ToString(),
                                iIdContador         = int.Parse(_sqlDataReader["IdContadorAsignado"].ToString()),
                                sContador           = _sqlDataReader["Contador"].ToString(),
							    sActivo				= _sqlDataReader["Activo"].ToString(),
                                iIdRegimen          = int.Parse(_sqlDataReader["IdRegimen"].ToString()),
                                sRegimen            = _sqlDataReader["Regimen"].ToString()
                            };
                        }
                    }
                }
                catch
                {
                    cliente = null;
                }
                return cliente;
            }
        }


        /// <summary>
        /// Método público que devuelve información detallada
        /// de un cliente pasando como parametro su ID
        /// </summary>
        /// <param name="Cliente">Clave de cliente(idCliente)</param>
        /// <returns></returns>
        public Cliente InformacionCliente(string sCliente, int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                Cliente client = null;
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_ClienteOC", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL CLIENTE
                _SqlCommand.Parameters.AddWithValue("Cliente", sCliente);
                _SqlCommand.Parameters.AddWithValue("IdUsuario", iIdUsuario);

                try
                {
                    //ABRIMOS NUESTRA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            //INICIALIZAMOS EL OBJETO CLIENTE Y ASIGNAMOS INFORMACIÓN A SUS PROPIEDADES
                            client = new Cliente()
                            {
                                iIdCliente          = int.Parse(_sqlDataReader["IdCliente"].ToString()),
                                sNombre             = _sqlDataReader["Nombre"].ToString(),
                                sAPaterno           = _sqlDataReader["APaterno"].ToString(),
                                sAMaterno           = _sqlDataReader["AMaterno"].ToString(),
                                sRfc                = _sqlDataReader["RFC"].ToString(),
                                sCorreoElectronico  = _sqlDataReader["CorreoElectronico"].ToString(),
                                sTelefono           = _sqlDataReader["Telefono"].ToString(),
                                sDireccion          = _sqlDataReader["Direccion"].ToString(),
                                sMunicipio          = _sqlDataReader["Municipio"].ToString(),
                                sCodigoPostal       = _sqlDataReader["CodigoPostal"].ToString(),
                                sExtension          = _sqlDataReader["Extension"].ToString(),
                                sNumeroMovil        = _sqlDataReader["NumeroMovil"].ToString(),
                                sCliente            = _sqlDataReader["Cliente"].ToString(),
                                iIdRegimen          = int.Parse(_sqlDataReader["IdRegimen"].ToString()),
                                sRegimen            = _sqlDataReader["Regimen"].ToString()
                            };
                        }
                    }
                }
                catch
                {
                    client = null;
                }
                return client;
            }
        }

        public Cliente informacionClienteExLN(int iIdContador, string sCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
                Cliente cliente = null;
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_Cliente_EXLN", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdContador", iIdContador);
                _SqlCommand.Parameters.AddWithValue("@Cliente", sCliente);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            cliente = new Cliente()
                            {
                                iIdCliente          = int.Parse(_SqlDataReader["IdCliente"].ToString()),
                                sNombre             = _SqlDataReader["Nombre"].ToString(),
                                sAPaterno           = _SqlDataReader["APaterno"].ToString(),
                                sAMaterno           = _SqlDataReader["AMaterno"].ToString(),
                                sRfc                = _SqlDataReader["RFC"].ToString(),
                                sCorreoElectronico  = _SqlDataReader["CorreoElectronico"].ToString(),
                                sTelefono           = _SqlDataReader["Telefono"].ToString(),
                                sDireccion          = _SqlDataReader["Direccion"].ToString(),
                                sMunicipio          = _SqlDataReader["Municipio"].ToString(),
                                sCodigoPostal       = _SqlDataReader["CodigoPostal"].ToString(),
                                sExtension          = _SqlDataReader["Extension"].ToString(),
                                sNumeroMovil        = _SqlDataReader["NumeroMovil"].ToString(),
                                sCliente            = _SqlDataReader["Cliente"].ToString(),
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    cliente = null;
                }
                return cliente;
            }
        }

        public List<Cliente> lDirectorio(int iIdContador)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Cliente> lista = new List<Cliente>();
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_DIRECTORIO_CLIENTES", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdContadorAsignado", iIdContador);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while(_SqlDataReader.Read())
                        {
                            Cliente cliente = new Cliente()
                            {
                                iIdCliente          = int.Parse(_SqlDataReader["IdCliente"].ToString()),
                                sCliente            = _SqlDataReader["Cliente"].ToString(),
                                sNombre             = _SqlDataReader["Nombre"].ToString(),
                                sRfc                = _SqlDataReader["RFC"].ToString(),
                                sNumeroMovil        = _SqlDataReader["NumeroMovil"].ToString(),
                                sCorreoElectronico  = _SqlDataReader["CorreoElectronico"].ToString()
                            };
                            lista.Add(cliente);
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

        public Cliente InfoClienteContador(string sCliente, int iIdContadorAsignado)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                Cliente cliente = null;
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_CLIENTE_BUSCAR", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@Cliente", sCliente);
                _SqlCommand.Parameters.AddWithValue("@IdContadorAsignado", iIdContadorAsignado);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            cliente = new Cliente()
                            {
                                sCliente           = _SqlDataReader["Cliente"].ToString(),
                                sActivo            = _SqlDataReader["Activo"].ToString(),
                                sRfc               = _SqlDataReader["RFC"].ToString(),
                                sNombre            = _SqlDataReader["Nombre"].ToString(),
                                sAPaterno          = _SqlDataReader["APaterno"].ToString(),
                                sAMaterno          = _SqlDataReader["AMaterno"].ToString(),
                                sDireccion         = _SqlDataReader["Direccion"].ToString(),
                                sMunicipio         = _SqlDataReader["Municipio"].ToString(),
                                iIdEstado          = int.Parse(_SqlDataReader["IdEstado"].ToString()),
                                sCodigoPostal      = _SqlDataReader["CodigoPostal"].ToString(),
                                sTelefono          = _SqlDataReader["NumeroLocal"].ToString(),
                                sExtension         = _SqlDataReader["Extension"].ToString(),
                                sNumeroMovil       = _SqlDataReader["NumeroMovil"].ToString(),
                                sCorreoElectronico = _SqlDataReader["CorreoElectronico"].ToString(),
                                iIdServicioTipo    = int.Parse(_SqlDataReader["IdServicioTipo"].ToString()),
                                iIdContador        = int.Parse(_SqlDataReader["IdContadorAsignado"].ToString()),
                                iIdCliente         = int.Parse(_SqlDataReader["IdCliente"].ToString()),
                                sCurp              = _SqlDataReader["CURP"].ToString(),
                                iIdRegimen         = int.Parse(_SqlDataReader["IdRegimen"].ToString())
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    cliente = null;
                }
                return cliente;
            }
        }
    }
}
