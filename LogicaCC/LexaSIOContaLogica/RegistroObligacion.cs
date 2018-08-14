using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class RegistroObligacion
    {
        public int     iIdRegistroObligacion      { get; set; }
        public int     iIdDetalleObligacion       { get; set; }
        public int     iIdCliente                 { get; set; }
        public int     iIdUsuarioRegistra         { get; set; }
        public int     iIdUsuarioModifica         { get; set; }
        public byte    btEstado                   { get; set; }
        public string  sAdjuntos                  { get; set; }
        public string  sNombre                    { get; set; }
        public string  sAPaterno                  { get; set; }
        public string  sAMaterno                  { get; set; }
        public string  sDetalleObligacion         { get; set; }
        public string  sObligacion                { get; set; }
        public string  sFormaPresentacion         { get; set; }
        public string  sFechaCumplimientoVerde    { get; set; }
        public string  sFechaCumplimientoAmarillo { get; set; }
        public string  sFechaCumplimientoRojo     { get; set; }
        public string  sFechaCumplimiento         { get; set; }
        public string  sCorreo                    { get; set; }
        public string  sExtension                 { get; set; }
        public string  sRfc                       { get; set; }
        public string  sTelMovil                  { get; set; }
        public string  sTelLocal                  { get; set; }
        public string  sCliente                   { get; set; }
		public int	   iIdEquipoContador	      { get; set; }
		public string  sEquipoContador		      { get; set; }
		public string  sEstado				      { get; set; }
		public string  sSucursal			      { get; set; }

		public RegistroObligacion()
        {
            iIdRegistroObligacion      = 0;
            iIdDetalleObligacion       = 0;
            iIdCliente                 = 0;
            iIdUsuarioRegistra         = 0;
            iIdUsuarioModifica         = 0;
            btEstado                   = 0;
            iIdEquipoContador		   = 0;
            sAdjuntos                  = string.Empty;
            sNombre                    = string.Empty;
            sAPaterno                  = string.Empty;
            sAMaterno                  = string.Empty;
            sDetalleObligacion         = string.Empty;
            sObligacion                = string.Empty;
            sFormaPresentacion         = string.Empty;
            sFechaCumplimientoVerde    = string.Empty;
            sFechaCumplimientoAmarillo = string.Empty;
            sFechaCumplimientoRojo     = string.Empty;
			sEquipoContador			   = string.Empty;
			sEstado					   = string.Empty;
			sSucursal				   = string.Empty;
		}

        /// <summary>
        /// Método Público para generar un nuevo registro de una obligación
        /// </summary>
        /// <param name="registroObligacion">Objeto de tipo RegistroObligacion que contiene sus propiedades</param>
        /// <returns></returns>
        public bool insertarRegistroObligacion(RegistroObligacion registroObligacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPI_Crear_RegistroObligacion", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, LA INFORMACIÓN QUE SE GUARDARA EN EL REGISTRO DE LA OBLIGACIÓN
                _SqlCommand.Parameters.AddWithValue("@idObligacion", registroObligacion.iIdDetalleObligacion);
                _SqlCommand.Parameters.AddWithValue("@idUsuarioRegistra", registroObligacion.iIdUsuarioRegistra);
                _SqlCommand.Parameters.AddWithValue("@idClienteR", registroObligacion.iIdCliente);

                try
                {
                    //ABRIMOS LA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                    return (_SqlCommand.ExecuteNonQuery() > 0 ? true : false);
                }
                catch
                {
                    return false;
                }
            }
        }

		/// <summary>
		/// Realiza el alta de un nuevo recordatorio para cumplimiento de este
		/// </summary>
		/// <param name="Recordatorio">Nuevo objeto de tipo Registro Obligacion</param>
		/// <returns></returns>
		public int AddRecordatorio(RegistroObligacion Recordatorio)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
				SqlCommand _SqlCommand = new SqlCommand("OFSPI_Crear_RegistroObligacion_Recordatorio", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdDetalleObligacion", Recordatorio.iIdDetalleObligacion);
				_SqlCommand.Parameters.AddWithValue("@IdCliente", Recordatorio.iIdCliente);
				_SqlCommand.Parameters.AddWithValue("@IdUsuario", Recordatorio.iIdUsuarioRegistra);
				_SqlCommand.Parameters.AddWithValue("@FechaVerde", DateTime.Parse(Recordatorio.sFechaCumplimientoVerde));
				_SqlCommand.Parameters.AddWithValue("@FechaAmarillo", DateTime.Parse(Recordatorio.sFechaCumplimientoAmarillo));
				_SqlCommand.Parameters.AddWithValue("@FechaRojo", DateTime.Parse(Recordatorio.sFechaCumplimientoRojo));

				var resultado = _SqlCommand.Parameters.Add("@Status", SqlDbType.BigInt);
				resultado.Direction = ParameterDirection.ReturnValue;

				try
				{
					_SqlConnection.Open();
					_SqlCommand.ExecuteNonQuery();
					return (int)resultado.Value;
				}
				catch (Exception)
				{
					return -1;
				}
			}
		}

        /// <summary>
        /// Método Público que regresa una lista de obligaciones de obligaciones pendientes de cumplir la semana en curso
        /// </summary>
        /// <param name="registroObligacion">Objeto de tipo RegistroObligacion que contiene sus propiedades</param>
        /// <param name="fechaDesde">Fecha de inicio para la busqueda</param>
        /// <param name="fechaHasta">Fecha de termino para la busqueda</param>
        /// <returns></returns>
        public List<RegistroObligacion> InformacionClienteSemanaObligacion(RegistroObligacion registroObligacion, string fechaDesde, string fechaHasta, string sCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                // CREAMOS UNA LISTA DE REGISTROS DE OBLIGACIONES
                List<RegistroObligacion> lista = new List<RegistroObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_ObligacionSemanaCliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL USUARIO, FECHA DE INICIO Y TERMINO PARA LA BUSQUEDA
                _SqlCommand.Parameters.AddWithValue("@idUsuario", registroObligacion.iIdUsuarioRegistra);
                _SqlCommand.Parameters.AddWithValue("@fechaDesde", DateTime.Parse(fechaDesde).ToShortDateString());
                _SqlCommand.Parameters.AddWithValue("@fechaHasta", DateTime.Parse(fechaHasta).ToShortDateString());
                _SqlCommand.Parameters.AddWithValue("@Cliente", sCliente);

                try
                {
                    //ABRIMOS LA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            //CREAMOS UN NUEVO OBJETO DE TIPO REGISTROOBLIGACION Y LO AGREGAMOS A LA LISTA
                            RegistroObligacion _registroObligacion = new RegistroObligacion()
                            {
                                iIdCliente  = int.Parse(_sqlDataReader["IdCliente"].ToString()),
                                sNombre     = string.Format("{0} {1} {2}", _sqlDataReader["Nombre"], _sqlDataReader["APaterno"], _sqlDataReader["AMaterno"]),
                                sAPaterno   = _sqlDataReader["APaterno"].ToString(),
                                sAMaterno   = _sqlDataReader["AMaterno"].ToString(),
                                sRfc        = _sqlDataReader["RFC"].ToString(),
                                sCorreo     = _sqlDataReader["CorreoElectronico"].ToString(),
                                sTelMovil   = _sqlDataReader["NumeroMovil"].ToString(),
                                sTelLocal   = _sqlDataReader["Telefono"].ToString(),
                                sCliente    = _sqlDataReader["Cliente"].ToString()
                            };
                            lista.Add(_registroObligacion);
                        }
                    }
                }
                catch
                {
                    lista = null;
                }
                return lista;
            }
        }

        /// <summary>
        /// Método Público para cambiar el estado de cumplimiento de una obligación
        /// </summary>
        /// <param name="registroObligacion">Objeto de tipo RegistroObligacion que contiene sus propiedades.</param>
        /// <returns></returns>
        public bool cumplirRegistroObligacion(RegistroObligacion registroObligacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPU_Actualizar_ObligacionCumplida", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL REGISTRO DE LA OBLIGACIÓN Y EL USUARIO QUE CAMBIO SU ESTADO
                _SqlCommand.Parameters.AddWithValue("@idRegistroObligacion", registroObligacion.iIdRegistroObligacion);
                _SqlCommand.Parameters.AddWithValue("@idUsuarioModifica", registroObligacion.iIdUsuarioModifica);

                try
                {
                    //ABRIMOS LA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                    return (_SqlCommand.ExecuteNonQuery() > 0 ? true : false);
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Método Público para descativar una obligación fiscal
        /// </summary>
        /// <param name="registroObligacion">Objeto de tipo RegistroObligacion que contiene sus propiedades</param>
        /// <returns></returns>
        public bool modificarRegistroObligacion(RegistroObligacion registroObligacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPU_Actualizar_ObligacionFiscalEstado", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL REGISTRO DE LA OBLIGACIÓN, EL ID DEL CLIENTE Y EL ESTADO
                _SqlCommand.Parameters.AddWithValue("@idDetalleObligacion", registroObligacion.iIdDetalleObligacion);
                _SqlCommand.Parameters.AddWithValue("@idCliente", registroObligacion.iIdCliente);
                _SqlCommand.Parameters.AddWithValue("@estado", registroObligacion.btEstado);

                try
                {
                    //ABRIMOS LA CONEXIÓN
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
        /// Muestra un  listado de obligaciones pendientes por contador
        /// </summary>
        /// <param name="registroObligacion"></param>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <param name="sCliente"></param>
        /// <returns></returns>
        public List<RegistroObligacion> InformacionContadorSemanaObligacion(RegistroObligacion registroObligacion, string fechaDesde, string fechaHasta, string sCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                // CREAMOS UNA LISTA DE REGISTROS DE OBLIGACIONES
                List<RegistroObligacion> lista = new List<RegistroObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_ObligacionSemanaContador", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL USUARIO, FECHA DE INICIO Y TERMINO PARA LA BUSQUEDA
                _SqlCommand.Parameters.AddWithValue("@idUsuario", registroObligacion.iIdUsuarioRegistra);
                _SqlCommand.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                _SqlCommand.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                _SqlCommand.Parameters.AddWithValue("@Contador", sCliente);

                try
                {
                    //ABRIMOS LA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            //CREAMOS UN NUEVO OBJETO DE TIPO REGISTROOBLIGACION Y LO AGREGAMOS A LA LISTA
						    RegistroObligacion _registroObligacion = new RegistroObligacion()
                            {
							    iIdEquipoContador	= int.Parse(_sqlDataReader["IdEquipoContador"].ToString()),
							    sEquipoContador		= _sqlDataReader["EquipoContador"].ToString(),
							    sEstado				= _sqlDataReader["Estado"].ToString(),
							    sSucursal			= _sqlDataReader["Sucursal"].ToString()
                            };
                            lista.Add(_registroObligacion);
                        }
                    }
                }
                catch
                {
                    lista = null;
                }
                return lista;
            }
        }
    }
}
