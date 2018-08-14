using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    public class Genero
    {
        public int      iIdGenero   { get; set; }
        public string   sGenero     { get; set; }

        public Genero()
        {
            iIdGenero   = 0;
            sGenero     = "";
        }

        /// <summary>
        /// Obtiene un listado de generos, masculino y femenino.
        /// </summary>
        /// <returns></returns>
        public List<Genero> GetList()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Genero> list = new List<Genero>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_GET_GENEROS", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Genero item = new Genero()
                            {
                                iIdGenero   = int.Parse(_SqlDataReader["IdGenero"].ToString()),
                                sGenero     = _SqlDataReader["Genero"].ToString()
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
