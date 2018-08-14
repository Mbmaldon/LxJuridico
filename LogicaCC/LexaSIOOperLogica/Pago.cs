using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.LexaSIOOperLogica
{
	public class Pago
	{
		public int			iIdPago					{ get; set; }
		public DateTime		dtFecha					{ get; set; }
		public string		sNoFactura				{ get; set; }
		public string		sNoSocio				{ get; set; }
		public string		sNombre					{ get; set; }
		public string		sNoOperacion			{ get; set; }
		public string		sConcepto				{ get; set; }
		public string		sBanco					{ get; set; }
		public decimal		dMonto					{ get; set; }
		public string		sReferencia				{ get; set; }
		public int			iIdCliente				{ get; set; }
		public DateTime		dtFechaDepositoSCI		{ get; set; }
		public decimal		dImporteDevolver		{ get; set; }

		public string		sCuentaBancaria			{ get; set; }
		public string		sCuentaInterbancaria	{ get; set; }
		public string		sIdBancario				{ get; set; }
		public decimal		dCostoFiscal			{ get; set; }
		[DisplayName("Conceptos")]
		public List<Concepto> lConceptos			{ get; set; }
		public decimal dGanancia { get; set; }
		public decimal dComisionNeta { get; set; }

		public Pago()
		{
			iIdPago				= 0;
			dtFecha				= DateTime.Now;
			sNoFactura			= string.Empty;
			sNoSocio			= string.Empty;
			sNombre				= string.Empty;
			sNoOperacion		= string.Empty;
			sConcepto			= string.Empty;
			sBanco				= string.Empty;
			dMonto				= 0;
			sReferencia			= string.Empty;
			iIdCliente			= 0;
			dtFechaDepositoSCI	= DateTime.Now;
			dImporteDevolver	= 0;
			dCostoFiscal		= 0;
			lConceptos			= new List<Concepto>();
			dGanancia			= 0;
			dComisionNeta		= 0;
		}

		/// <summary>
		/// Obtiene un listado de pagos registrados en la base de datos
		/// </summary>
		/// <returns></returns>
		public List<Pago> GetList()
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				List<Pago> lista = new List<Pago>();
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_PAGOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Pago item = new Pago()
							{
								iIdPago			= int.Parse(_SqlDataReader["IdPago"].ToString()),
								dtFecha			= DateTime.Parse(_SqlDataReader["FechaPago"].ToString()),
								sNoFactura		= _SqlDataReader["NoFactura"].ToString(),
								sNoSocio		= _SqlDataReader["NoSocio"].ToString(),
								sNombre			= _SqlDataReader["Nombre"].ToString(),
								sNoOperacion	= _SqlDataReader["NoOperacion"].ToString(),
								sConcepto		= _SqlDataReader["Concepto"].ToString(),
								sBanco			= _SqlDataReader["Banco"].ToString(),
								dMonto			= Decimal.Parse(_SqlDataReader["Monto"].ToString()),
								sReferencia		= _SqlDataReader["Referencia"].ToString(),
								dCostoFiscal	= decimal.Parse(_SqlDataReader["CostoFiscal"].ToString()),
								dGanancia		= decimal.Parse(_SqlDataReader["Ganancia"].ToString()),
								dComisionNeta   = decimal.Parse(_SqlDataReader["ComisionNeta"].ToString())
							};

							List<Concepto> GetConcepts = new Concepto().GetConcepto(item.iIdPago);
							for (int i = 0; i < GetConcepts.Count; i++)
							{
								Concepto itemConcepto = new Concepto(GetConcepts[i].iIdConcepto, GetConcepts[i].sConcepto, GetConcepts[i].dImporte);
								item.lConceptos.Add(itemConcepto);
							}
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

		public List<Pago> GetListDevoluciones(int iAnio, int iSemanaDesde, int iSemana)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				List<Pago> lista = new List<Pago>();
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_DEVOLUCIONES", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@Anio", iAnio);
                _SqlCommand.Parameters.AddWithValue("@SemanaDesde", iSemanaDesde);// TODO: Modificar procedimiento almacenado
                _SqlCommand.Parameters.AddWithValue("@Semana", iSemana);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Pago item = new Pago()
							{
								iIdPago					= int.Parse(_SqlDataReader["IdPago"].ToString()),
								iIdCliente				= int.Parse(_SqlDataReader["IdCliente"].ToString()),
								sNombre					= _SqlDataReader["SocioComanditario"].ToString(),
								sNoFactura				= _SqlDataReader["NoFactura"].ToString(),
								dMonto					= decimal.Parse(_SqlDataReader["Monto"].ToString()),
								sNoOperacion			= _SqlDataReader["NoOperacion"].ToString(),
								dtFecha					= DateTime.Parse(_SqlDataReader["FechaPago"].ToString()),
								dImporteDevolver		= decimal.Parse(_SqlDataReader["ImporteDevolver"].ToString()),
								sIdBancario				= _SqlDataReader["IdBancario"].ToString(),
								sCuentaBancaria			= _SqlDataReader["NumeroCuenta"].ToString(),
								sCuentaInterbancaria	= _SqlDataReader["ClabeInterbancaria"].ToString(),
								sBanco					= _SqlDataReader["Banco"].ToString(),
								dCostoFiscal			= decimal.Parse(_SqlDataReader["CostoFiscal2"].ToString())
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
		/// Actualiza los campos No de factura y Concepto de las facturas
		/// pertenecientes a un año y semana de pago
		/// </summary>
		/// <param name="iIdUsuario">Id del usuario que modifica</param>
		/// <param name="iAnio">Año</param>
		/// <param name="iSemana">Semana</param>
		/// <param name="sNoFactura">Número de factura</param>
		/// <param name="sConcepto">Concepto</param>
		/// <returns></returns>
		public int UpdatePagoFacCon(int iIdUsuario, int iAnio, int iSemana, string sNoFactura, string sConcepto)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				SqlCommand _SqlCommand = new SqlCommand("MDOSPU_ACTUALIZAR_PAGOS_FACTURA_CONCEPTO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
				_SqlCommand.Parameters.AddWithValue("@Anio", iAnio);
				_SqlCommand.Parameters.AddWithValue("@Semana", iSemana);
				_SqlCommand.Parameters.AddWithValue("@NoFactura", sNoFactura);
				_SqlCommand.Parameters.AddWithValue("@Concepto", sConcepto);

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
	}

	public class Concepto
	{
		[DisplayName("No. Concepto")]
		public int		iIdConcepto		{ get; set; }
		[DisplayName("Concepto")]
		public string	sConcepto		{ get; set; }
		[DisplayName("Importe")]
		[DisplayFormat(DataFormatString = "{0:C}")]
		public decimal	dImporte		{ get; set; }

		public Concepto ()
		{
			this.iIdConcepto	= 0 ;
			this.sConcepto		= string.Empty;
			this.dImporte		= 0;
		}

		//[DisplayFormat(DataFormatString = "{0:#.####}")]
		public Concepto(int iIdConcepto, string sConcepto, decimal dImporte)
		{
			this.iIdConcepto	= iIdConcepto;
			this.sConcepto		= sConcepto;
			this.dImporte		= dImporte;
		}

		public List<Concepto> GetConcepto(int iIdPago)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				List<Concepto> conceptos = new List<Concepto>();
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_CONCEPTOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdPago", iIdPago);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Concepto item = new Concepto()
							{
								iIdConcepto = int.Parse(_SqlDataReader["IdTipoConcepto"].ToString()),
								sConcepto	= _SqlDataReader["Descripcion"].ToString(),
								dImporte	= decimal.Parse(_SqlDataReader["Precio"].ToString())
							};
							conceptos.Add(item);
						}
					}

				}
				catch (Exception)
				{
					conceptos = null;
				}
				return conceptos;
			}
		}
	}
}
