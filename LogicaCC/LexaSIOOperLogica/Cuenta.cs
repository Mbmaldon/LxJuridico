using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
	public class Cuenta
	{
		public int		iIdCuenta	{ get; set; }
		public string	sCuenta		{ get; set; }

		public Cuenta()
		{
			iIdCuenta	= 0;
			sCuenta		= string.Empty;
		}

		/// <summary>
		/// Obtiene un listado de cuentas de origen para la creación de layouts bancarios para comisiones
		/// </summary>
		/// <returns></returns>
		public List<Cuenta> GetListCuentaOrigenComisiones()
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				List<Cuenta> lista = new List<Cuenta>();
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_CUENTAS_ORIGEN", _SqlConnection) { CommandType = CommandType.StoredProcedure };

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Cuenta item = new Cuenta()
							{
								iIdCuenta	= int.Parse(_SqlDataReader["IdCuentaOrigen"].ToString()),
								sCuenta		= _SqlDataReader["CuentaOrigen"].ToString()
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
		/// Obtiene un listao de cuentas de origen para la creación de layouts bancarios para devoluciones
		/// </summary>
		/// <returns></returns>
		public List<Cuenta> GetListCuentaOrigenDevoluciones()
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				List<Cuenta> lista = new List<Cuenta>();
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_CUENTAS_ORIGEN_DEVOLUCIONES", _SqlConnection) { CommandType = CommandType.StoredProcedure };

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Cuenta item = new Cuenta()
							{
								iIdCuenta	= int.Parse(_SqlDataReader["IdCuentaOrigen"].ToString()),
								sCuenta		= _SqlDataReader["CuentaOrigen"].ToString()
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
