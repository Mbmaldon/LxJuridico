using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.Logica
{
    public class Supervisor
    {
        public int iIdSupervisor { get; set; }
        public int iIdVendedor { get; set; }
        public string sNombreSupervisor { get; set; }

        public List<Supervisor> lSupervisores(int iNivel, int iIdGerencia, int iIdSucursal)
        {
            //using (SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString))
            using (SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
				List<Supervisor> lista = new List<Supervisor>();
				SqlCommand _SqlCommand = new SqlCommand("OFSPS_Seleccionar_Supervisores", _sqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdNivel", iNivel);
				_SqlCommand.Parameters.AddWithValue("@IdGerencia", iIdGerencia);
				_SqlCommand.Parameters.AddWithValue("@IdSucursal", iIdSucursal);

				try
				{
				    _sqlConnection.Open();
				    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
				    if(_sqlDataReader.HasRows)
				    {
				        while(_sqlDataReader.Read())
				        {
				            Supervisor supervisor = new Supervisor()
				            {
				                iIdSupervisor     = int.Parse(_sqlDataReader["IdUsuario"].ToString()),
				                sNombreSupervisor = _sqlDataReader["Nombre"].ToString()
				            };
				            lista.Add(supervisor);
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
