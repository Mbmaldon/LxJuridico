using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
	public class EquipoContable
	{
		public int		iIdEquipoContable	{ get; set; }
		public string	sEquipoContable		{ get; set; }

		public EquipoContable()
		{
			iIdEquipoContable	= 0;
			sEquipoContable		= "";
		}

		/// <summary>
		/// Obtiene un listado de equipos contables en base a una sucursal
		/// </summary>
		/// <param name="iIdSucursal">Id de la sucursal</param>
		/// <returns></returns>
		public List<EquipoContable> GetListEquipoContable(int iIdSucursal)
		{
            //using (SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString))
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
				List<EquipoContable> lista = new List<EquipoContable>();
				SqlCommand _SqlCommand = new SqlCommand("LXMDCSPS_EQUIPOCONTABLE_GET", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdSucursal", iIdSucursal);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							EquipoContable item = new EquipoContable()
							{
								iIdEquipoContable	= int.Parse(_SqlDataReader["IdEquipoContador"].ToString()),
								sEquipoContable		= _SqlDataReader["EquipoContador"].ToString()
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
