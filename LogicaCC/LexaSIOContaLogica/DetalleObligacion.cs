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
    public class DetalleObligacion
    {
        //CREAMOS PROPIEDADES
        public int    iIdDetalleObligacion  { get; set; }
        public int    iIdObligacion         { get; set; }
        public string sDetalleObligacion    { get; set; }
        public string sFormaPresentacion    { get; set; }

        public int    iIdRegistroObligacion { get; set; }
        public string sfechaVerde           { get; set; }
        public string sfechaAmarillo        { get; set; }
        public string sfechaRojo            { get; set; }
        public string sFechaEntrega         { get; set; }
        public int    iDefault              { get; set; }

		public string sRegimen { get; set; }
		public int? iR01 { get; set; }
		public int? iR02 { get; set; }
		public int? iR03 { get; set; }
		public int? iR04 { get; set; }
		public int? iR05 { get; set; }
		public int? iR06 { get; set; }
		public int? iR07 { get; set; }
		public int? iR08 { get; set; }
		public int? iR09 { get; set; }
		public int? iR10 { get; set; }

		public string sObligacion { get; set; }


		// CREAMOS CONSTRUCTOR
		public DetalleObligacion()
        {
            iIdDetalleObligacion   = 0;
            iIdObligacion          = 0;
            sDetalleObligacion     = string.Empty;
            sFormaPresentacion     = string.Empty;
            iIdRegistroObligacion  = 0;
            sfechaVerde            = string.Empty;
            sfechaAmarillo         = string.Empty;
            sfechaRojo             = string.Empty;

			iDefault			   = 0;
			iR01				   = null;
			iR02				   = null;
			iR03				   = null;
			iR04				   = null;
			iR05				   = null;
			iR06				   = null;
			iR07				   = null;
			iR08				   = null;
			iR09				   = null;
			iR10				   = null;

			sObligacion			   = string.Empty;
        }

		/// <summary>
		/// Obtiene un listado de obligaciones de modo recordatorio
		/// </summary>
		/// <returns></returns>
		public List<DetalleObligacion> GetListRecordatorios()
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
				List<DetalleObligacion> lista = new List<DetalleObligacion>();
				SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_Recordatorios", _SqlConnection) { CommandType = CommandType.StoredProcedure };

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							DetalleObligacion item = new DetalleObligacion()
							{
								iIdObligacion			= int.Parse(_SqlDataReader["IdObligacion"].ToString()),
								sObligacion				= _SqlDataReader["Obligacion"].ToString(),
								iIdDetalleObligacion	= int.Parse(_SqlDataReader["IdDetalleObligacion"].ToString()),
								sDetalleObligacion		= _SqlDataReader["DetalleObligacion"].ToString()
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
        /// Obtiene un listado de obligaciones fiscales para los regimenes de personas fisicas y morales
        /// </summary>
        /// <param name="iR1">Id del regimen de persona física para dar de alta</param>
        /// <param name="iR2">Id del regimen de persona física dada de alta</param>
        /// <param name="iR3">Id del regimen de persona moral  empresa dada de alta</param>
        /// <param name="iR4">Id del regimen de persona moral empresa de nueva creación</param>
        /// <returns></returns>
        public List<DetalleObligacion> GetListObligaciones(int iR1, int iR2, int iR3, int iR4)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
                List<DetalleObligacion> list = new List<DetalleObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFMPYSPS_Seleccionar_ObligacionesInicio_RGM", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdRegimen1", iR1);
                _SqlCommand.Parameters.AddWithValue("@IdRegimen2", iR2);
                _SqlCommand.Parameters.AddWithValue("@IdRegimen3", iR3);
                _SqlCommand.Parameters.AddWithValue("@IdRegimen4", iR4);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        int? iNull = null;
                        while (_SqlDataReader.Read())
                        {
                            DetalleObligacion item = new DetalleObligacion()
                            {
                                sDetalleObligacion	= _SqlDataReader["DetalleObligacion"].ToString(),
								iDefault			= int.Parse(_SqlDataReader["iDefault"].ToString()),
								iR01				= _SqlDataReader["R1"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R1"].ToString()),
								iR02				= _SqlDataReader["R2"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R2"].ToString()),
								iR03				= _SqlDataReader["R3"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R3"].ToString()),
								iR04				= _SqlDataReader["R4"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R4"].ToString()),
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

		public List<DetalleObligacion> GetListObligaciones(int iR1, int iR2, int iR3, int iR4, int iR5, int iR6, int iR7, int iR8, int iR9, int iR10)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
			{
				List<DetalleObligacion> lista = new List<DetalleObligacion>();
				SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_ObligacionesInicio_RGM", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdRegimen1", iR1);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen2", iR2);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen3", iR3);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen4", iR4);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen5", iR5);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen6", iR6);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen7", iR7);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen8", iR8);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen9", iR9);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen10", iR10);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							int? iNull = null;
							DetalleObligacion item = new DetalleObligacion()
							{
								sDetalleObligacion	= _SqlDataReader["DetalleObligacion"].ToString(),
								iDefault			= int.Parse(_SqlDataReader["iDefault"].ToString()),
								iR01				= _SqlDataReader["R1"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R1"].ToString()),
								iR02				= _SqlDataReader["R2"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R2"].ToString()),
								iR03				= _SqlDataReader["R3"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R3"].ToString()),
								iR04				= _SqlDataReader["R4"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R4"].ToString()),
								iR05				= _SqlDataReader["R5"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R5"].ToString()),
								iR06				= _SqlDataReader["R6"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R6"].ToString()),
								iR07				= _SqlDataReader["R7"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R7"].ToString()),
								iR08				= _SqlDataReader["R8"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R8"].ToString()),
								iR09				= _SqlDataReader["R9"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R9"].ToString()),
								iR10				= _SqlDataReader["R10"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R10"].ToString())
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
        /// Obtiene  un listado de Dictamenes por regimen
        /// </summary>
        /// <param name="iRegimen">Id del regimen que desea obtener</param>
        /// <returns></returns>
        public List<DetalleObligacion> GetListDictamenes(int iRegimen)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
                List<DetalleObligacion> lista = new List<DetalleObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_ObligacionesDictamenes", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdRegimen", iRegimen);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            DetalleObligacion item = new DetalleObligacion()
                            {
                                sDetalleObligacion	= _SqlDataReader["DetalleObligacion"].ToString(),
								iDefault			= int.Parse(_SqlDataReader["iDefault"].ToString()),
								iR01				= int.Parse(_SqlDataReader["R1"].ToString())
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
        /// Obtiene un listado de obligaciones ISN
        /// </summary>
        /// <param name="iRegimen">Id del regimen que desea obtener</param>
        /// <returns></returns>
        public List<DetalleObligacion> GetListISN(int iRegimen)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
                List<DetalleObligacion> lista = new List<DetalleObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_ObligacionesISN", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdRegimen", iRegimen);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            DetalleObligacion item = new DetalleObligacion()
                            {
                                sDetalleObligacion	= _SqlDataReader["DetalleObligacion"].ToString(),
								iDefault			= int.Parse(_SqlDataReader["iDefault"].ToString()),
								iR01				= int.Parse(_SqlDataReader["R1"].ToString())
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
        /// Método Público que regresa una lista de obligaciones correspondientes a un regimen.
        /// </summary>
        /// <param name="detalleOlbigacion">DetalleObligacion que tiene sus propiedades</param>
        /// <returns></returns>
        public List<DetalleObligacion> listaObligacionesInicio(DetalleObligacion detalleOlbigacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                // CREAMOS UNA LISTA DE OBLIGACIONES CON DETALLES
                List<DetalleObligacion> lista = new List<DetalleObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_ObligacionesInicio", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DE LA OBLIGACIÓN
                _SqlCommand.Parameters.AddWithValue("@idObligacion", detalleOlbigacion.iIdObligacion);

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
                            //CREAMOS UN NUEBO OBJETO DETALLEOBLIGACION Y LO AGREGAMOS A LA LISTA
                            DetalleObligacion obligacion = new DetalleObligacion()
                            {
							    iIdObligacion			= int.Parse(_sqlDataReader["IdObligacion"].ToString()),
                                iIdDetalleObligacion    = int.Parse(_sqlDataReader["IdDetalleObligacion"].ToString()),
                                sDetalleObligacion      = _sqlDataReader["DetalleObligacion"].ToString(),
                                iDefault                = int.Parse(_sqlDataReader["iDefault"].ToString())
                            };
                            lista.Add(obligacion);
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
        /// Método Público que regresa una lista de obligaciones perternecientes a un cliente y
        /// que se encuentran en cierto rango de fechas
        /// </summary>
        /// <param name="idCliente">ID del cliente</param>
        /// <param name="fechaInicio">Fecha de inicio de busqueda</param>
        /// <param name="fechaTermino">Fecha de termino de busqueda</param>
        /// <param name="estado">Estado de las obligaciones</param>
        /// <returns></returns>
        public List<DetalleObligacion> listaObligacionesCliente(int idCliente, string fechaInicio, string fechaTermino, int estado)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                // CREAMOS UNA LISTA DE OBLIGACIONES
                List<DetalleObligacion> lista = new List<DetalleObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_ObligacionesCliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL CLIENTE, FECHA DE INICIO Y FIN DE BUSQUEDA Y ESTADO DE CUMPLIMIENTO
                _SqlCommand.Parameters.AddWithValue("@idCliente", idCliente);
                _SqlCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                _SqlCommand.Parameters.AddWithValue("@fechaFin", fechaTermino);
                _SqlCommand.Parameters.AddWithValue("@estado", estado);

                try
                {
                    // ABRIMOS LA CONEXIÓN
                    _SqlConnection.Open();
                    // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            int? iNull = null;
						    DetalleObligacion item = new DetalleObligacion()
						    {
                                iIdRegistroObligacion = int.Parse(_sqlDataReader["IdRegistroObligacion"].ToString()),
							    sDetalleObligacion	  = _sqlDataReader["DetalleObligacion"].ToString(),
							    sFormaPresentacion	  = _sqlDataReader["FormaPresentacion"].ToString(),
							    sfechaVerde			  = _sqlDataReader["FechaCumplimientoVerde"].ToString(),
							    sfechaAmarillo		  = _sqlDataReader["FechaCumplimientoAmarillo"].ToString(),
							    sfechaRojo			  = _sqlDataReader["FechaCumplimientoRojo"].ToString(),
							    sFechaEntrega		  = _sqlDataReader["FechaEntrega"].ToString(),
                                sObligacion           = _sqlDataReader["Obligacion"].ToString()
						    };
						    lista.Add(item);
						    // CREAMOS UN NUEVO OBJETO OBLIGACIÓN Y LO AGREGAMOS A LA LISTA
						    //int? iNull = null;
						    //DetalleObligacion item = new DetalleObligacion()
						    //{
							   // sDetalleObligacion	= _sqlDataReader["DetalleObligacion"].ToString(),
							   // sFormaPresentacion	= _sqlDataReader["FormaPresentacion"].ToString(),
							   // sfechaVerde			= _sqlDataReader["FechaCumplimientoVerde"].ToString(),
							   // sfechaAmarillo		= _sqlDataReader["FechaCumplimientoAmarillo"].ToString(),
							   // sfechaRojo			= _sqlDataReader["FechaCumplimientoRojo"].ToString(),
							   // sFechaEntrega		= _sqlDataReader["FechaEntrega"].ToString(),
							   // iR01				= _sqlDataReader["R1"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R1"].ToString()),
							   // iR02				= _sqlDataReader["R2"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R2"].ToString()),
							   // iR03				= _sqlDataReader["R3"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R3"].ToString()),
							   // iR04				= _sqlDataReader["R4"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R4"].ToString()),
							   // iR05				= _sqlDataReader["R5"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R5"].ToString()),
							   // iR06				= _sqlDataReader["R6"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R6"].ToString()),
							   // iR07				= _sqlDataReader["R7"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R7"].ToString()),
							   // iR08				= _sqlDataReader["R8"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R8"].ToString()),
							   // iR09				= _sqlDataReader["R9"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R9"].ToString()),
							   // iR10				= _sqlDataReader["R10"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R10"].ToString())
						    //};
						    //lista.Add(item);
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
        /// Método Público que regresa una lista de obligaciones correspondientes a un cliente
        /// </summary>
        /// <param name="idCliente">ID del cliente</param>
        /// <returns></returns>
        public List<DetalleObligacion> listaObligaciones(string sCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                // CREAMOS UNA LISTA DE OBLIGACIONES
                List<DetalleObligacion> lista = new List<DetalleObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_Obligaciones", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL CLIENTE
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
                            //CREAMOS UN NUEVO OBJETO DE TIPO OBLIGACIÓN Y LO AGREGAMOS A LA LISTA
                            DetalleObligacion obligacion = new DetalleObligacion()
                            {
							    iIdObligacion			= int.Parse(_sqlDataReader["IdObligacion"].ToString()),
                                iIdDetalleObligacion    = int.Parse(_sqlDataReader["IdDetalleObligacion"].ToString()),
                                sDetalleObligacion      = _sqlDataReader["DetalleObligacion"].ToString()
                            };
                            lista.Add(obligacion);
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
		/// Obtiene un listado de obligaciones de tipo recordatorio
		/// </summary>
		/// <param name="sCliente">Clave del cliente que desea obtener el listado de obligaciones</param>
		/// <returns></returns>
		public List<DetalleObligacion> GetListObligacionesRecordatorios(string sCliente)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
				List<DetalleObligacion> lista = new List<DetalleObligacion>();
				SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_Obligaciones_Recordatorios", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@Cliente", sCliente);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							DetalleObligacion item = new DetalleObligacion()
							{
                                iIdObligacion        = int.Parse(_SqlDataReader["IdObligacion"].ToString()),
                                iIdDetalleObligacion = int.Parse(_SqlDataReader["IdDetalleObligacion"].ToString()),
                                sDetalleObligacion	 = _SqlDataReader["DetalleObligacion"].ToString(),
                                sObligacion          = _SqlDataReader["Obligacion"].ToString()
							};
							lista.Add(item);
							//int? iNull = null;
							//DetalleObligacion item = new DetalleObligacion()
							//{
							//	sDetalleObligacion	= _SqlDataReader["DetalleObligacion"].ToString(),
							//	iR01				= _SqlDataReader["R1"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R1"].ToString()),
							//	iR02				= _SqlDataReader["R2"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R2"].ToString()),
							//	iR03				= _SqlDataReader["R3"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R3"].ToString()),
							//	iR04				= _SqlDataReader["R4"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R4"].ToString()),
							//	iR05				= _SqlDataReader["R5"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R5"].ToString()),
							//	iR06				= _SqlDataReader["R6"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R6"].ToString()),
							//	iR07				= _SqlDataReader["R7"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R7"].ToString()),
							//	iR08				= _SqlDataReader["R8"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R8"].ToString()),
							//	iR09				= _SqlDataReader["R9"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R9"].ToString()),
							//	iR10				= _SqlDataReader["R10"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R10"].ToString())
							//};
							//lista.Add(item);
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
		/// Obtiene un listado de obligaciones unicas
		/// </summary>
		/// <param name="sCliente">Clave del cliente que desea obtener el listado de obligaciones</param>
		/// <returns></returns>
		public List<DetalleObligacion> GetListObligacionesUnicas(string sCliente)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
				List<DetalleObligacion> lista = new List<DetalleObligacion>();
				SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_Obligaciones_Unicas", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@Cliente", sCliente);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
                            DetalleObligacion item = new DetalleObligacion()
                            {
                                iIdObligacion        = int.Parse(_SqlDataReader["IdObligacion"].ToString()),
                                iIdDetalleObligacion = int.Parse(_SqlDataReader["IdDetalleObligacion"].ToString()),
                                sDetalleObligacion   = _SqlDataReader["DetalleObligacion"].ToString(),
                                sObligacion          = _SqlDataReader["Obligacion"].ToString()
                            };
                            lista.Add(item);
							//int? iNull = null;
							//DetalleObligacion item = new DetalleObligacion()
							//{
							//	sDetalleObligacion	= _SqlDataReader["DetalleObligacion"].ToString(),
							//	iR01				= _SqlDataReader["R1"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R1"].ToString()),
							//	iR02				= _SqlDataReader["R2"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R2"].ToString()),
							//	iR03				= _SqlDataReader["R3"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R3"].ToString()),
							//	iR04				= _SqlDataReader["R4"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R4"].ToString()),
							//	iR05				= _SqlDataReader["R5"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R5"].ToString()),
							//	iR06				= _SqlDataReader["R6"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R6"].ToString()),
							//	iR07				= _SqlDataReader["R7"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R7"].ToString()),
							//	iR08				= _SqlDataReader["R8"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R8"].ToString()),
							//	iR09				= _SqlDataReader["R9"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R9"].ToString()),
							//	iR10				= _SqlDataReader["R10"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R10"].ToString())
							//};
							//lista.Add(item);
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
		/// Método Público para validar si un cliente ya tiene una obligación asignada y en
		/// estado aun no cumplida para realizar una reasignación.
		/// </summary>
		/// <param name="idObligacion">ID de la obligación</param>
		/// <param name="idCliente">ID del cliente</param>
		/// <returns></returns>
		public bool validarObligacion(int idObligacion, int idCliente)
        {
            using (SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // Declaramos una nueva conexión y asignamos la cadena de conexion
            {
                try
                {
                    //Abrimos conexión
                    _sqlConnection.Open();
                    //Creamos un Command y asignamos la consulta y pasamos la conexión
                    SqlCommand _sqlCommand  = new SqlCommand("OFSPS_Validar_ValidarObligacion", _sqlConnection);
                    //Asignamos el tipo de Command
                    _sqlCommand.CommandType = CommandType.StoredProcedure;

                    //Agregamos los parametros de la consulta.
                    _sqlCommand.Parameters.AddWithValue("@idDetalleObligacion", idObligacion);
                    _sqlCommand.Parameters.AddWithValue("@idCliente", idCliente);

                    //Devuelve la fila afectada
                    int count = Convert.ToInt32(_sqlCommand.ExecuteScalar());

                    if (count == 0)
                        return false;
                    else
                        return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<DetalleObligacion> ObligacionesFiscalesCumplidas(string sCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
                List<DetalleObligacion> lista = new List<DetalleObligacion>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_ObligacionesCumplidasCliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@Cliente", sCliente);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if(_sqlDataReader.HasRows)
                    {
                        while(_sqlDataReader.Read())
                        {
						    //CREAMOS UN NUEVO OBJETO OBLIGACIÓN Y LO AGREGAMOS A LA LISTA
						    int? iNull = null;
						    DetalleObligacion item = new DetalleObligacion()
						    {
							    sDetalleObligacion	= _sqlDataReader["DetalleObligacion"].ToString(),
							    sFormaPresentacion	= _sqlDataReader["FormaPresentacion"].ToString(),
							    sfechaVerde			= _sqlDataReader["FechaCumplimientoVerde"].ToString(),
							    sfechaAmarillo		= _sqlDataReader["FechaCumplimientoAmarillo"].ToString(),
							    sfechaRojo			= _sqlDataReader["FechaCumplimientoRojo"].ToString(),
							    sFechaEntrega		= _sqlDataReader["FechaEntrega"].ToString(),
							    iR01				= _sqlDataReader["R1"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R1"].ToString()),
							    iR02				= _sqlDataReader["R2"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R2"].ToString()),
							    iR03				= _sqlDataReader["R3"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R3"].ToString()),
							    iR04 = _sqlDataReader["R4"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R4"].ToString()),
							    iR05 = _sqlDataReader["R5"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R5"].ToString()),
							    iR06 = _sqlDataReader["R6"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R6"].ToString()),
							    iR07 = _sqlDataReader["R7"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R7"].ToString()),
							    iR08 = _sqlDataReader["R8"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R8"].ToString()),
							    iR09 = _sqlDataReader["R9"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R9"].ToString()),
							    iR10 = _sqlDataReader["R10"] == DBNull.Value ? iNull : int.Parse(_sqlDataReader["R10"].ToString()),
                                sObligacion = _sqlDataReader["Obligacion"].ToString()
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

		public DetalleObligacion GetDetalleObligacion(int iIdObligacion)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
				DetalleObligacion Obligacion = null;
				SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_DetalleObligacion", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdDetalleObligacion", iIdObligacion);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Obligacion = new DetalleObligacion()
							{
								iIdDetalleObligacion	= int.Parse(_SqlDataReader["IdDetalleObligacion"].ToString()),
								sDetalleObligacion		= _SqlDataReader["DetalleObligacion"].ToString(),
								sObligacion				= _SqlDataReader["Obligacion"].ToString(),
								sFormaPresentacion		= _SqlDataReader["FormaPresentacion"].ToString(),
								sfechaVerde				= _SqlDataReader["FechaVerde"].ToString(),
								sfechaAmarillo			= _SqlDataReader["FechaAmarilla"].ToString(),
								sfechaRojo				= _SqlDataReader["FechaRoja"].ToString()
							};
						}
					}
				}
				catch (Exception)
				{
					Obligacion = null;
				}
				return Obligacion;
			}
		}

		public List<DetalleObligacion> GetListObligacionesISR(int iR1, int iR2)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
			{
				List<DetalleObligacion> lista = new List<DetalleObligacion>();
				SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_ObligacionesInicio_RGM_ISR", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdRegimen1", iR1);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen2", iR2);
				_SqlCommand.Parameters.AddWithValue("@IdRegimen3", 0);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							int? iNull = null;
							DetalleObligacion item = new DetalleObligacion()
							{
								sDetalleObligacion	= _SqlDataReader["DetalleObligacion"].ToString(),
								iDefault			= int.Parse(_SqlDataReader["iDefault"].ToString()),
								iR01				= _SqlDataReader["R1"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R1"].ToString()),
								iR02				= _SqlDataReader["R2"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R2"].ToString()),
								iR03				= _SqlDataReader["R3"] == DBNull.Value ? iNull : int.Parse(_SqlDataReader["R3"].ToString())
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