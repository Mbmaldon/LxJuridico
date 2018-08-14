using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
	public class Dispersion
	{
		public int		iIdConcepto		{ get; set; }
		public string	sConcepto		{ get; set; }
		public int		iIdRfcOrdenante { get; set; }
		public string	sRfcOrdenante	{ get; set; }

		public Dispersion()
		{
			iIdConcepto		= 0;
			iIdRfcOrdenante = 0;
			sConcepto		= string.Empty;
			sRfcOrdenante	= string.Empty;
		}

		/// <summary>
		/// Obtiene información para generar el Layout bancario
		/// </summary>
		/// <param name="iModo">1 para PREV SOC HR y 2 para ALIMENTOS</param>
		/// <returns></returns>
		public Dispersion GetInfoForLayaut(int iModo)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				Dispersion info = null;
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_INFO_LAYOUT", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@Modo", iModo);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							info = new Dispersion()
							{
								sConcepto		= _SqlDataReader["ConceptoDispersion"].ToString(),
								sRfcOrdenante	= _SqlDataReader["RfcOrdenante"].ToString()
							};
						}
					}
				}
				catch (Exception)
				{

					info = null;
				}
				return info;
			}
		}
	}
}
