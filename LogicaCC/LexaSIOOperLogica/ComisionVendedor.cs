using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.LexaSIOOperLogica
{
    public class ComisionVendedor
    {
        public int      iIdOperacionComisionista    { get; set; }
        public int      iIdOperacion                { get; set; }
        public int      iIdVendedor                 { get; set; }
        public string   sNombreVendedor             { get; set; }
        public string   sNoOperacionBancaria        { get; set; }
        public decimal  dImporte                    { get; set; }        
        public int      iSemana                     { get; set; }
        public string   sPagado                     { get; set; }
        public int      iVentas                     { get; set; }
        public string   sFacturaPagada              { get; set; }
        public string   sFechaPago                  { get; set; }
        public string   sFechaCreacion              { get; set; }
        public string   sFechaModificacion          { get; set; }
        public string   sNoFactura                  { get; set; }
        public decimal  dComisionF                  { get; set; } //BONO
        public decimal  dBolsa                      { get; set; } //BONO
        public decimal  dBono                       { get; set; } //BONO
        public int      iTrimestre                  { get; set; } //BONO
        public string   sTipoComision               { get; set; }
        public int      iIdTipoUsuario              { get; set; }
        public string   sUTipo                      { get; set; }
        public int      iAnio                       { get; set; }
        public string   sFechaFactura               { get; set; }
        public string   sCuentaBancaria             { get; set; }
		public string	sCuentaInterbancaria		{ get; set; }




		public int iIdComisionista { get; set; }
		public int iIdComision { get; set; }
		public string sNombre { get; set; }
		public string sIdBancario { get; set; }
		public decimal dPorcentaje { get; set; }
		public string sBanco { get; set; }


		/// <summary>
		/// Obtiene un listado de comisiones
		/// </summary>
		/// <returns></returns>
		public List<ComisionVendedor> GetListComisiones(int iAnio, int iSemanaDesde, int iSemanaHasta)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				List<ComisionVendedor> lista = new List<ComisionVendedor>();
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_COMISIONES", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@Anio", iAnio);
				_SqlCommand.Parameters.AddWithValue("@SemanaDesde", iSemanaDesde);
				_SqlCommand.Parameters.AddWithValue("@SemanaHasta", iSemanaHasta);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							ComisionVendedor item = new ComisionVendedor()
							{
								iIdComision				= int.Parse(_SqlDataReader["IdComision"].ToString()),
								sNombre					= _SqlDataReader["Comisionista"].ToString(),
								sUTipo					= _SqlDataReader["UsuarioTipo"].ToString(),
								sIdBancario				= _SqlDataReader["IdBancario"].ToString(),
								sCuentaBancaria			= _SqlDataReader["Cuenta"].ToString(),
								sCuentaInterbancaria	= _SqlDataReader["ClabeInterbancaria"].ToString(),
								sNoFactura				= _SqlDataReader["NoFactura"].ToString(),
								sFechaFactura			= _SqlDataReader["FechaFactura"].ToString(),
								dComisionF				= decimal.Parse(_SqlDataReader["Comision"].ToString()),
								sNoOperacionBancaria	= _SqlDataReader["NoOperacion"].ToString(),
								sFechaPago				= _SqlDataReader["FechaPago"].ToString(),
								dPorcentaje				= decimal.Parse(_SqlDataReader["Porcentaje"].ToString()),
								dImporte				= decimal.Parse(_SqlDataReader["Monto"].ToString()),
								iIdComisionista			= int.Parse(_SqlDataReader["IdUsuario"].ToString()),
								sBanco					= _SqlDataReader["Banco"].ToString()
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


		public List<ComisionVendedor> lComisionesVendedores(int iNoSemana, int iAnio)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                List<ComisionVendedor> lista = new List<ComisionVendedor>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_ComisionesVendedores", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@NoSemana", iNoSemana);
                _SqlCommand.Parameters.AddWithValue("@Anio", iAnio);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            ComisionVendedor item = new ComisionVendedor()
                            {
                                iIdOperacionComisionista = int.Parse(_SqlDataReader["IdOperacionComisionista"].ToString()),
                                iIdOperacion             = int.Parse(_SqlDataReader["IdOperacion"].ToString()),
                                iIdVendedor              = int.Parse(_SqlDataReader["IdVendedor"].ToString()),
                                sNombreVendedor          = _SqlDataReader["NombreVendedor"].ToString(),
                                sNoOperacionBancaria     = _SqlDataReader["NoOperacionBancaria"].ToString(),
                                dImporte                 = decimal.Parse(_SqlDataReader["Importe"].ToString()) + (decimal.Parse(_SqlDataReader["Importe"].ToString()) * decimal.Parse("0.16")),
                                iSemana                  = int.Parse(_SqlDataReader["Semana"].ToString()),
                                sPagado                  = _SqlDataReader["Pagado"].ToString(),
                                iVentas                  = int.Parse(_SqlDataReader["Anio"].ToString()),
                                sFacturaPagada           = _SqlDataReader["FacturaPagada"].ToString(),
                                sFechaPago               = _SqlDataReader["FechaPago"].ToString(),
                                sFechaCreacion           = _SqlDataReader["FechaCreacion"].ToString(),
                                sFechaModificacion       = _SqlDataReader["FechaModificacion"].ToString(),
                                sNoFactura               = _SqlDataReader["NoFactura"].ToString(),
                                sTipoComision            = _SqlDataReader["TipoComision"].ToString(),
                                iIdTipoUsuario           = int.Parse(_SqlDataReader["IdUsuarioTipo"].ToString()),
                                sUTipo                   = _SqlDataReader["UTipo"].ToString(),           
                                sFechaFactura            = _SqlDataReader["FechaFactura"].ToString(),
                                sCuentaBancaria          = _SqlDataReader["Cuenta"].ToString()
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

        //public List<ComisionVendedor> lBonosVendedores()
        //{
        //    List<ComisionVendedor> lista = new List<ComisionVendedor>();
        //    SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
        //    SqlCommand _sqlCommand       = new SqlCommand("LSOSPS_Seleccionar_BonosVendedores", _sqlConnection) { CommandType = CommandType.StoredProcedure };

        //    try
        //    {
        //        _sqlConnection.Open();
        //        SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
        //        if(_sqlDataReader.HasRows)
        //        {
        //            while(_sqlDataReader.Read())
        //            {
        //                ComisionVendedor comision = new ComisionVendedor()
        //                {
        //                    iIdVendedor       = int.Parse(_sqlDataReader["IdVendedor"].ToString()),
        //                    sNombreVendedor   = _sqlDataReader["Vendedor"].ToString(),
        //                    dImporte          = decimal.Parse(_sqlDataReader["TotalImportesFacturas"].ToString()),
        //                    dComisionF        = decimal.Parse(_sqlDataReader["TotalComisiones"].ToString()),
        //                    dBolsa            = decimal.Parse(_sqlDataReader["Bolsa"].ToString()),
        //                    dBono             = decimal.Parse(_sqlDataReader["Bono"].ToString()),
        //                    iTrimestre        = int.Parse(_sqlDataReader["Trimestre"].ToString())
        //                };
        //                lista.Add(comision);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        lista = null;
        //    }
        //    finally
        //    {
        //        _sqlConnection.Close();
        //    }
        //    return lista;
        //}

        public bool bPagarComision(ComisionVendedor comision)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                SqlCommand _SqlCommand = new SqlCommand("LSOSPU_Pagar_ComisionVendedor", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdOperacionComisionista", comision.iIdOperacionComisionista);
                _SqlCommand.Parameters.AddWithValue("@NoOperacionBancaria", comision.sNoOperacionBancaria);
                _SqlCommand.Parameters.AddWithValue("@Comision", comision.dComisionF);
                _SqlCommand.Parameters.AddWithValue("@FechaPago", comision.sFechaPago);

                var parameterReturn = _SqlCommand.Parameters.Add("@Status", SqlDbType.Int);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    var result = parameterReturn.Value;
                    if (int.Parse(result.ToString()) == 1)
                        return true;
                    else
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<ComisionVendedor> lAnios()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                List<ComisionVendedor> lista = new List<ComisionVendedor>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_Anios_Comisiones", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            ComisionVendedor Anio = new ComisionVendedor()
                            {
                                iAnio = int.Parse(_SqlDataReader["Anio"].ToString())
                            };
                            lista.Add(Anio);
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
