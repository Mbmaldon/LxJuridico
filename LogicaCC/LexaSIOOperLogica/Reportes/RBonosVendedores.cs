using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica.Reportes
{
    public class RBonosVendedores
    {
        public int     iIdVendedor      { get; set; }
        public string  sNombreVendedor  { get; set; }
        public decimal dBono            { get; set; }
        public int     iAnio            { get; set; }
        public int     iTrimestre       { get; set; }

        public List<RBonosVendedores> ObtenerAnios()
        {
            List<RBonosVendedores> lista = new List<RBonosVendedores>();
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _SqlCommand = new SqlCommand("SELECT DISTINCT Anio FROM Bono", _sqlConnection) { CommandType = CommandType.Text };
            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        RBonosVendedores Anio = new RBonosVendedores()
                        {
                            iAnio = int.Parse(_sqlDataReader["Anio"].ToString())
                        };
                        lista.Add(Anio);
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
