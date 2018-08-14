using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.LexaSIOOperLogica
{
    public class TipoFactura
    {
        public int iIdTipoFactura { get; set; }
        public string sTipoFactura { get; set; }

        public List<TipoFactura> lTipoFacturas()
        {
            List<TipoFactura> lista      = new List<TipoFactura>();
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand       = new SqlCommand("LSOSPS_Seleccionar_TipoFactura", _sqlConnection) { CommandType = CommandType.StoredProcedure };
            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        TipoFactura tipoFactura = new TipoFactura()
                        {
                            iIdTipoFactura = int.Parse(_sqlDataReader["IdTipoFactura"].ToString()),
                            sTipoFactura   = _sqlDataReader["TipoFactura"].ToString()
                        };
                        lista.Add(tipoFactura);
                    }
                }
            }
            catch (Exception)
            {
                lista = null;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return lista;
        }
    }
}
