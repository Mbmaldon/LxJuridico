using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class SocioComanditario
    {
        public string sNoExpediente         { get; set; }
        public string sFechaModificacion    { get; set; }
        public string sNombre               { get; set; }
        public string sDireccion            { get; set; }
        public string sCurp                 { get; set; }
        public string sComisionista         { get; set; }
        public string sActivo               { get; set; }
        public decimal dAcumulado           { get; set; }

        public int    iTotal                { get; set; }

		public string	sNoCuenta			{ get; set; }
		public string	sIdBancario			{ get; set; }
		public int		iIdCliente			{ get; set; }
		public string	sBanco				{ get; set; }
		public string	sClabeInterbancaria { get; set; }

		public SocioComanditario()
        {
            this.sNoExpediente      = string.Empty;
            this.sFechaModificacion = string.Empty;
            this.sNombre            = string.Empty;
            this.sDireccion         = string.Empty;
            this.sCurp              = string.Empty;
            this.sComisionista      = string.Empty;
            this.sActivo            = string.Empty;
            this.dAcumulado         = 0;

            this.iTotal             = 0;
        }

		/// <summary>
		/// Obtiene la información de un cliente
		/// </summary>
		/// <param name="iIdCliente"></param>
		/// <returns></returns>
		public SocioComanditario GetInfoCliente(int iIdCliente)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				SocioComanditario Cliente = null;
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_CLIENTE_BY_ID", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdCliente", iIdCliente);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Cliente = new SocioComanditario()
							{
								iIdCliente			= int.Parse(_SqlDataReader["IdCliente"].ToString()),
								sNombre				= _SqlDataReader["Nombre"].ToString(),
								sNoCuenta			= _SqlDataReader["NumeroCuenta"].ToString(),
								sIdBancario			= _SqlDataReader["IdBancario"].ToString(),
								sClabeInterbancaria = _SqlDataReader["ClabeInterbancaria"].ToString(),
								sBanco				= _SqlDataReader["Banco"].ToString()
							};
						}
					}
				}
				catch (Exception)
				{
					Cliente = null;
				}
				return Cliente;
			}
		}

		/// <summary>
		/// Actualiza el id bancario del cliente
		/// </summary>
		/// <param name="iIdUsuario"></param>
		/// <param name="iIdCliente"></param>
		/// <param name="sIdBancario"></param>
		/// <returns></returns>
		public int UpdateInfoCliente(int iIdUsuario, int iIdCliente, string sIdBancario, string sBanco)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				SqlCommand _SqlCommand = new SqlCommand("MDOSPU_ACTUALZIAR_CLIENTE_IDBANCARIO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
				_SqlCommand.Parameters.AddWithValue("@IdCliente", iIdCliente);
				_SqlCommand.Parameters.AddWithValue("@IdBancario", sIdBancario);
				_SqlCommand.Parameters.AddWithValue("@Banco", sBanco);

				var resultado = _SqlCommand.Parameters.Add("@Status", SqlDbType.Int);
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
        /// Método Público que regresa una lista de socios comanditarios
        /// </summary>
        /// <returns></returns>
        public List<SocioComanditario> listaSocioComanditario()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<SocioComanditario> lista = new List<SocioComanditario>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_SCI", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            SocioComanditario item = new SocioComanditario()
                            {
                                sNoExpediente       = _SqlDataReader["NoExpediente"].ToString(),
                                sFechaModificacion  = _SqlDataReader["FechaModificacion"].ToString(),
                                sNombre             = _SqlDataReader["Nombre"].ToString(),
                                sDireccion          = _SqlDataReader["Direccion"].ToString(),
                                sCurp               = _SqlDataReader["Curp"].ToString(),
                                sComisionista       = _SqlDataReader["Comisionista"].ToString(),
                                sActivo             = _SqlDataReader["Activo"].ToString(),
                                dAcumulado          = decimal.Parse(_SqlDataReader["Acumulado"].ToString())
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
        /// Método Público para obtener el número de socios dados de alta el mes en curso
        /// </summary>
        /// <returns></returns>
        public SocioComanditario SociosAltaMes()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                SocioComanditario socio = null;
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_TotalVendedoresAlta", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            socio = new SocioComanditario()
                            {
                                iTotal = int.Parse(_SqlDataReader["Total"].ToString())
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    socio = null;
                }
                return socio;
            }
        }

        /// <summary>
        /// Método Público que regresa un total de socios activos.
        /// </summary>
        /// <returns></returns>
        public SocioComanditario SociosActivos()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                SocioComanditario socio = null;
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_TotalSociosActivos", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            socio = new SocioComanditario()
                            {
                                iTotal = int.Parse(_SqlDataReader["Total"].ToString())
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    socio = null;
                }
                return socio;
            }
        }

        /// <summary>
        /// Método Público que regresa un número de socios dados de baja.
        /// </summary>
        /// <returns></returns>
        public SocioComanditario SociosBaja()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SocioComanditario socio = null;
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_TotalVendedoresBaja", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    //ABRIMOS NUESTRA CONEXIÓN
                    _SqlConnection.Open();
                    //EXECUTAMOS NUESTRA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            //INICIALIZAMOS NUESTRO BOJETO SOCIOCOMANDITARIO
                            socio = new SocioComanditario()
                            {
                                iTotal = int.Parse(_sqlDataReader["Total"].ToString())
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    socio = null;
                    throw;
                }
                return socio;
            }
        }

    }
}
