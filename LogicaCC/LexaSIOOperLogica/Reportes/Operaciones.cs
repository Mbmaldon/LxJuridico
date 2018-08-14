using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica.Reportes
{
	public class Operaciones
	{
		public string	sCliente			{ get; set; }
		public string	sNombre				{ get; set; }
		public string	sEjecutivo			{ get; set; }
		public string	sNoFactura			{ get; set; }
		public string	sReferencia			{ get; set; }
		public DateTime dtFechaPago			{ get; set; }
		public decimal	dMonto				{ get; set; }
		public decimal	dImporteDevolver	{ get; set; }
		public decimal	dImporteRepartir	{ get; set; }
		public decimal	dComisiones			{ get; set; }
		public decimal	dBeneficio			{ get; set; }

		public Operaciones()
		{
			sCliente			= string.Empty;
			sNombre				= string.Empty;
			sEjecutivo			= string.Empty;
			sNoFactura			= string.Empty;
			sReferencia			= string.Empty;
			dtFechaPago			= DateTime.Now;
			dMonto				= 0;
			dImporteDevolver	= 0;
			dImporteRepartir	= 0;
			dComisiones			= 0;
			dBeneficio			= 0;
		}

		/// <summary>
		/// Obtiene un listado de pagos con desgloses de importes para reportes
		/// para el area deoperaciones
		/// </summary>
		/// <returns></returns>
		public List<Operaciones> GetList()
		{
            //using (SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString))
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				List<Operaciones> lista = new List<Operaciones>();
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_REPORTES_OPERACIONES", _SqlConnection) { CommandType = CommandType.StoredProcedure };

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Operaciones item = new Operaciones()
							{
								sCliente			= _SqlDataReader["Cliente"].ToString(),
								sNombre				= _SqlDataReader["Nombre"].ToString(),
								sEjecutivo			= _SqlDataReader["Ejecutivo"].ToString(),
								sNoFactura			= _SqlDataReader["NoFactura"].ToString(),
								sReferencia			= _SqlDataReader["Referencia"].ToString(),
								dtFechaPago			= DateTime.Parse(_SqlDataReader["FechaPago"].ToString()),
								dMonto				= decimal.Parse(_SqlDataReader["Monto"].ToString()),
								dImporteDevolver	= decimal.Parse(_SqlDataReader["ImporteDevolver"].ToString()),
								dImporteRepartir	= decimal.Parse(_SqlDataReader["ImporteRepartir"].ToString()),
								dComisiones			= decimal.Parse(_SqlDataReader["Comisiones"].ToString()),
								dBeneficio			= decimal.Parse(_SqlDataReader["Beneficio"].ToString())
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
