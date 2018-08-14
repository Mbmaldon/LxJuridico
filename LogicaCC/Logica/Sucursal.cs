using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.Logica
{
	public class Sucursal
	{
		public int iIdSucursal { get; set; }
		public int iIdEstado { get; set; }
		public string sSucursal { get; set; }
		
		public Sucursal()
		{
			iIdSucursal = 0;
			iIdEstado	= 0;
			sSucursal	= string.Empty;
		}

		/// <summary>
		/// Obtiene un listado de sucursales por estado
		/// </summary>
		/// <param name="iIdEstado"></param>
		/// <returns></returns>
		public List<Sucursal> GetList(int iIdEstado)
		{
            //using (SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString))
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
				List<Sucursal> lista = new List<Sucursal>();
				SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_OBTENER_SUCURSALES", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdEstado", iIdEstado);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Sucursal item = new Sucursal()
							{
								iIdSucursal = int.Parse(_SqlDataReader["IdSucursal"].ToString()),
								sSucursal	= _SqlDataReader["Sucursal"].ToString()
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
		/// Agrega una nueva sucursal
		/// </summary>
		/// <param name="iIdEstado">Id del estado al que pertenece</param>
		/// <param name="sSucursal">Nombre de la sucursal</param>
		/// <returns></returns>
		public int AddSucursal(int iIdEstado, string sSucursal)
		{
            //using (SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString))
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
				SqlCommand _SqlCommand = new SqlCommand("LXCCSPI_ALTA_SUCURSAL", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdEstado", iIdEstado);
				_SqlCommand.Parameters.AddWithValue("@Sucursal", sSucursal);

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
	}
}
