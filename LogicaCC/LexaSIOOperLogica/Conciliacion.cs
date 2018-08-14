using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.LexaSIOOperLogica
{
	public class Conciliacion
	{
		public int		iIdUsuario		{ get; set; }
		public string	sReferencia1	{ get; set; }
		public decimal	dImporte		{ get; set; }

		public int		iIdMedico		{ get; set; }
		public decimal	dImporteSis		{ get; set; }
		public decimal	dImporteBan		{ get; set; }
		public string	sResultado		{ get; set; }
		public DateTime dtFechaPago		{ get; set; }
		public string	sBanco			{ get; set; }

		public Conciliacion()
		{
			iIdUsuario		= 0;
			sReferencia1	= string.Empty;
			dImporte		= 0;

			iIdMedico		= 0;
			dImporteSis		= 0;
			dImporteSis		= 0;
			sResultado		= string.Empty;
			dtFechaPago		= DateTime.Now;
			sBanco			= string.Empty;
		}

		/// <summary>
		/// Realiza el alta de pagos de bancomer
		/// </summary>
		/// <param name="Conciliacion"></param>
		/// <returns></returns>
		public Conciliacion AddPago(Conciliacion Conciliacion)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				Conciliacion item = null;
				SqlCommand _SqlCommand = new SqlCommand("MDOSPSI_REGISTRAR_PAGO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdUsuario", Conciliacion.iIdUsuario);
				_SqlCommand.Parameters.AddWithValue("@Referencia", Conciliacion.sReferencia1);
				_SqlCommand.Parameters.AddWithValue("@Importe", Conciliacion.dImporte);
				_SqlCommand.Parameters.AddWithValue("@FechaPago", Conciliacion.dtFechaPago);
				_SqlCommand.Parameters.AddWithValue("@Banco", Conciliacion.sBanco);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							item = new Conciliacion()
							{
								sReferencia1	= _SqlDataReader["Referencia1"].ToString(),
								iIdMedico		= int.Parse(_SqlDataReader["IdMedic"].ToString()),
								dImporteSis		= decimal.Parse(_SqlDataReader["TotalSistema"].ToString()),
								dImporteBan		= decimal.Parse(_SqlDataReader["TotalBanco"].ToString()),
								sResultado		= _SqlDataReader["Sta"].ToString()
							};
						}
					}
				}
				catch (Exception)
				{
					item = null;
				}
				return item;
			}
		}
	}
}
