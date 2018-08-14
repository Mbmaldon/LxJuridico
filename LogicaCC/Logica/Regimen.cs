using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    public class Regimen
    {
        public int      iIdRegimen  { get; set; }
        public string   sRegimen    { get; set; }

        public Regimen()
        {
            iIdRegimen  = 0;
            sRegimen    = "";
        }

        /// <summary>
        /// Obtiene un listado de regimenes existentes en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Regimen> GetList()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Regimen> list = new List<Regimen>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_GET_REGIMEN", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Regimen item = new Regimen()
                            {
                                iIdRegimen  = int.Parse(_SqlDataReader["IdRegimen"].ToString()),
                                sRegimen    = _SqlDataReader["Regimen"].ToString()
                            };
                            list.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    list = null;
                }
                return list;
            }
        }
    }
}
