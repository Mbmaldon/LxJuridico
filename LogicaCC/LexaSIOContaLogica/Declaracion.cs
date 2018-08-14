using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class Declaracion
    {
        //CREAMOS PROPIEDADES
        public int       iIdDetalleObligacion { get; set; }
        public int       iIdCliente           { get; set; }
        public int       iIdPeriodo           { get; set; }
        public string    sDetalleObligacion   { get; set; }
        public string    sPeriodo             { get; set; }
        public int       iAnio                { get; set; }
        public string    sIdCliente           { get; set; }
        public string    sIdPeriodo           { get; set; }
        public string    sIdDeclaracionTipo   { get; set; }             
        public string    sIdDecEstado         { get; set; }
        public string    sIdUsuario           { get; set; }
        public string    sAñoDec              { get; set; }
        public string    sLinCap              { get; set; }
        public string    sNumOper             { get; set; }
        public string    sMonto               { get; set; }
        public string    sLlavePago           { get; set; }
        public string    sFechaLimPag         { get; set; }
        public string    sFechaPresentacion   { get; set; }
        public int       iIdDeclaracionModo   { get; set; }
        public string    sDeclaracionModo     { get; set; }
		public int       iIdDeclaracion       { get; set; }
		public string    sDeclaracion         { get; set; }
		public DateTime  dtFechaLimitePago    { get; set; }
		public DateTime  dtFechaPresentacion  { get; set; }
		public string    sDeclaracionEstado   { get; set; }
		public decimal   dMonto               { get; set; }
        public DateTime? dtFechaPago          { get; set; }

        public List<Declaracion> listaDeclaracionesModo()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Declaracion> lista = new List<Declaracion>();
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_DECLARACIONES_MODOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Declaracion DeclaracionModo = new Declaracion()
                            {
                                iIdDeclaracionModo = int.Parse(_SqlDataReader["IdDeclaracionModo"].ToString()),
                                sDeclaracionModo   = _SqlDataReader["DeclaracionModo"].ToString()
                            };
                            lista.Add(DeclaracionModo);
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
        /// Método Público que regresa una lista de declaraciones pasando
        /// como parametro el ID de cliente que se desea obtener.
        /// </summary>
        /// <param name="declaracion">Objeto de tipo Declaración que contiene el ID de Cliente</param>
        /// <returns></returns>
        public List<Declaracion> listaDeclaraciones(Declaracion declaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<Declaracion> lista = new List<Declaracion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_DeclaracionesObligaciones", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL USUARIO
                _SqlCommand.Parameters.AddWithValue("@idCliente", declaracion.iIdCliente);

                try
                {
                    //ABRIMOS NUESTRA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if(_sqlDataReader.HasRows)
                    {
                        while(_sqlDataReader.Read())
                        {
                            //CREAMOS UN NUEVO OBJETO DECLARACION Y LO AGREGAMOS A LA LISTA
                            Declaracion declaraciones = new Declaracion()
                            {
                                iIdDetalleObligacion  = int.Parse(_sqlDataReader["IdDetalleObligacion"].ToString()),
                                sDetalleObligacion    = _sqlDataReader["DetalleObligacion"].ToString()
                            };
                            lista.Add(declaraciones);
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
        /// Método Público que regresa una lista de periodos que no
        /// han sido seleccionados para cumplir una declaración pasando
        /// como parametro un Cliente, Año y Tipo de Declaración
        /// </summary>
        /// <param name="declaracion">Objeto de Tipo Declaracio que contiene el IdCliente, Año e IdTipoDeclaracion</param>
        /// <returns></returns>
        public List<Declaracion> listaPeriodo(Declaracion declaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<Declaracion> lista = new List<Declaracion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_DeclaracionesObligaciones", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL CLIENTE, AÑO DE DECLARACIÓN Y TIPO DE DECLARACIÓN
                _SqlCommand.Parameters.AddWithValue("@idCliente", declaracion.iIdCliente);
                _SqlCommand.Parameters.AddWithValue("@anio", declaracion.iAnio);
                _SqlCommand.Parameters.AddWithValue("@idDeclaracionTipo", declaracion.iIdDetalleObligacion);

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
                            //CREAMOS UN NUEVO OBJETO DECLARACIÓN Y LO AGREGAMOS A LA LISTA
                            Declaracion declaraciones = new Declaracion()
                            {
                                iIdPeriodo   = int.Parse(_sqlDataReader["IdPeriodoDeclaracion"].ToString()),
                                sPeriodo     = _sqlDataReader["PeriodoDeclaracion"].ToString()
                            };
                            lista.Add(declaraciones);
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
        /// Método Público que regresa una lista de Declaraciones Complementarias
        /// pasando como parametro el ID de Cliente.
        /// </summary>
        /// <param name="declaracion">Objeto de tipo Declaracion que contiene el IdCliente</param>
        /// <returns></returns>
        public List<Declaracion> listaDComplementarias(Declaracion declaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<Declaracion> lista = new List<Declaracion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_ObligacionCliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL CLIENTE
                _SqlCommand.Parameters.AddWithValue("@idCliente", declaracion.iIdCliente);

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
                            //CREAMOS UN NUEVO OBJETO DECLARACIÓN Y LO AGREGAMOS A LA LISTA
                            Declaracion declaraciones = new Declaracion()
                            {
                                iIdDetalleObligacion    = int.Parse(_sqlDataReader["IdDetalleObligacion"].ToString()),
                                sDetalleObligacion      = _sqlDataReader["DetalleObligacion"].ToString()
                            };
                            lista.Add(declaraciones);
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
        /// Método Público que regresa una lista de periodos de
        /// Declaraciones Complementarias tomando en cuenta sólo
        /// los que no se han cumplido
        /// </summary>
        /// <param name="declaracion">Objeto de tipo Declaracion que contiene el IdCliente, Año e IdDeclaracionTipo</param>
        /// <returns></returns>
        public List<Declaracion> listaPeriodoDC(Declaracion declaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                // CREAMOS UNA LISTA DE DECLARACIONES
                List<Declaracion> lista = new List<Declaracion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_PeriodosDComplementarias", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL CLIENTE, AÑO DE DECLARACIÓN Y TIPO DE DECLARACIÓN
                _SqlCommand.Parameters.AddWithValue("@idCliente", declaracion.iIdCliente);
                _SqlCommand.Parameters.AddWithValue("@anio", declaracion.iAnio);
                _SqlCommand.Parameters.AddWithValue("@idDeclaracionTipo", declaracion.iIdDetalleObligacion);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Declaracion item = new Declaracion()
                            {
                                iIdPeriodo = int.Parse(_SqlDataReader["IdPeriodoDeclaracion"].ToString()),
                                sPeriodo   = _SqlDataReader["PeriodoDeclaracion"].ToString()
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
        /// Método Público que crea nuevos registros de Declaraciones
        /// Complementarias en la BD DBLEXACONTA
        /// </summary>
        /// <param name="declaracion">Objeto de tipo Declaracion con sus propiedades</param>
        /// <returns></returns>
        public bool crearDeclaracionComplementaria(Declaracion declaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPI_Crear_DeclaracionComplementaria", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, LA INFORMACIÓN QUE SE GUARDARA DE LA DECLARACIÓN COMPLEMENTARIA
                _SqlCommand.Parameters.AddWithValue("@IdCliente", declaracion.sIdCliente);
                _SqlCommand.Parameters.AddWithValue("@IdPeriodo", declaracion.sIdPeriodo);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracionTipo", declaracion.sIdDeclaracionTipo);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracionEstado", declaracion.sIdDecEstado);
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", declaracion.sIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@AñoDeclaracion", declaracion.sAñoDec);
                _SqlCommand.Parameters.AddWithValue("@LineaCaptura", declaracion.sLinCap);
                _SqlCommand.Parameters.AddWithValue("@NumOperacion", declaracion.sNumOper);
                _SqlCommand.Parameters.AddWithValue("@Monto", declaracion.sMonto);
                _SqlCommand.Parameters.AddWithValue("@LlavePago", declaracion.sLlavePago);
                _SqlCommand.Parameters.AddWithValue("@FechaLimitePago", declaracion.sFechaLimPag);
                _SqlCommand.Parameters.AddWithValue("@FechaPresentacion", declaracion.sFechaPresentacion);

                try
                {
                    _SqlConnection.Open();
                    return (_SqlCommand.ExecuteNonQuery() > 0 ? true : false);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public int AddStatement(Declaracion _Statement)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("LXDECSPI_ALTA_DECLARACION_V2", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdCliente", _Statement.iIdCliente);
                _SqlCommand.Parameters.AddWithValue("@IdPeriodo", _Statement.iIdPeriodo);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracionTipo", _Statement.sIdDeclaracionTipo);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracionEstado", _Statement.sIdDecEstado);
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", _Statement.sIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@AñoDeclaracion", _Statement.sAñoDec);
                _SqlCommand.Parameters.AddWithValue("@LineaCaptura", _Statement.sLinCap);
                _SqlCommand.Parameters.AddWithValue("@NumOperacion", _Statement.sNumOper);
                _SqlCommand.Parameters.AddWithValue("@Monto", _Statement.sMonto);
                _SqlCommand.Parameters.AddWithValue("@LlavePago", _Statement.sLlavePago);
                _SqlCommand.Parameters.AddWithValue("@FechaLimitePago", _Statement.sFechaLimPag);
                _SqlCommand.Parameters.AddWithValue("@FechaPresentacion", _Statement.sFechaPresentacion);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracionModo", _Statement.iIdDeclaracionModo);

                var Resultado       = _SqlCommand.Parameters.Add("@Status", SqlDbType.BigInt);
                Resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return (int)Resultado.Value;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int UpdateStatement(Declaracion _Statement)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MDSPU_DECLARACION_ACTUALIZAR", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracion", _Statement.iIdDeclaracion);
                _SqlCommand.Parameters.AddWithValue("@IdPerioro", _Statement.iIdPeriodo);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracionTipo", _Statement.sIdDeclaracionTipo);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracionEstado", _Statement.sIdDecEstado);
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", _Statement.sIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@Anio", _Statement.iAnio);
                _SqlCommand.Parameters.AddWithValue("@LineaCaptura", _Statement.sLinCap);
                _SqlCommand.Parameters.AddWithValue("@NumeroOperacion", _Statement.sNumOper);
                _SqlCommand.Parameters.AddWithValue("@Monto", _Statement.dMonto);
                _SqlCommand.Parameters.AddWithValue("@LlavePago", _Statement.sLlavePago);
                _SqlCommand.Parameters.AddWithValue("@FechaLimitePago", _Statement.dtFechaLimitePago);
                _SqlCommand.Parameters.AddWithValue("@FechaPresentacion", _Statement.dtFechaPresentacion);
                _SqlCommand.Parameters.AddWithValue("@FechaPago", _Statement.dtFechaPago);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracionModo", _Statement.iIdDeclaracionModo);

                var Resultado       = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.Int);
                Resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return (int)Resultado.Value;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Método Público que regresa una lista de declaraciones para realizar calculos de sus importes
        /// </summary>
        /// <param name="idUsuario">ID del usuario</param>
        /// <returns></returns>
        public List<Declaracion> listaDeclaracionesCalculadora(int idUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                //CREAMOS UNA LISTA DE DECLARACIONES
                List<Declaracion> lista = new List<Declaracion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_DeclaracionesCalculadora", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL CLIENTE
                _SqlCommand.Parameters.AddWithValue("@idCliente", idUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Declaracion item = new Declaracion()
                            {
                                sIdDeclaracionTipo = _SqlDataReader["IdDeclaracion"].ToString(),
                                sDetalleObligacion = _SqlDataReader["DeclaracionTipo"].ToString()
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
        /// Método Público que regresa una fecha de limite de pago de una declaración
        /// </summary>
        /// <param name="idDeclaracion">ID de la declaración</param>
        /// <returns></returns>
        public Declaracion fechaDeclaracion(int idDeclaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                Declaracion concepto = null;
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_DeclaracionFecha", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DE LA DECLARACIÓN
                _SqlCommand.Parameters.AddWithValue("@idDeclaracion", idDeclaracion);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            concepto = new Declaracion()
                            {
                                sFechaLimPag        = _SqlDataReader["FechaLimitePago"].ToString(),
                                sDeclaracionEstado  = _SqlDataReader["DeclaracionEstado"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    concepto = null;
                }
                return concepto;
            }
        }

		/// <summary>
		/// Obtiene un listado de declaraciones por cliente
		/// </summary>
		/// <param name="iIdCliente">Id del cliente</param>
		/// <returns></returns>
		public List<Declaracion> GetListDeclaracionesByCliente(int iIdCliente)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
			{
				List<Declaracion> lista = new List<Declaracion>();
				SqlCommand _SqlCommand = new SqlCommand("MDCTSPS_OBTENER_DECLARACIONES_CLIENTE", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdCliente", iIdCliente);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Declaracion item = new Declaracion()
							{
								iIdDeclaracion			= int.Parse(_SqlDataReader["IdDeclaracion"].ToString()),
								sDeclaracion			= _SqlDataReader["DeclaracionTipo"].ToString(),
								iAnio					= int.Parse(_SqlDataReader["AñoDeclaracion"].ToString()),
								sPeriodo				= _SqlDataReader["PeriodoDeclaracion"].ToString(),
								sDeclaracionModo		= _SqlDataReader["DeclaracionModo"].ToString(),
								sDeclaracionEstado		= _SqlDataReader["DeclaracionEstado"].ToString(),
								sLinCap					= _SqlDataReader["LineaCaptura"].ToString(),
								sNumOper				= _SqlDataReader["NumOperacion"].ToString(),
								dMonto					= decimal.Parse(_SqlDataReader["Monto"].ToString()),
								sLlavePago				= _SqlDataReader["LlavePago"].ToString(),
								dtFechaLimitePago		= DateTime.Parse(_SqlDataReader["FechaLimitePago"].ToString()),
								dtFechaPresentacion		= DateTime.Parse(_SqlDataReader["FechaPresentacion"].ToString())
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
    }
}