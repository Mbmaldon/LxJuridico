using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica.Reportes
{
    public class RComisionesVendedores
    {

        public int      iIdVendedor  { get; set; }
        public string   sVendedor    { get; set; }
        public decimal  dComision    { get; set; }
        public string   sEstado      { get; set; }
        public DateTime dtFechaDesde { get; set; }
        public DateTime dtFechaHasta { get; set; }

        public List<RComisionesVendedores> lComisionesVendedores(RComisionesVendedores fecha)
        {
            List<RComisionesVendedores> lista = new List<RComisionesVendedores>();
            //SqlConnection _SqlConnection      = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _SqlConnection      = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _SqlCommand            = new SqlCommand("LSOSPS_Reporte_ComisionesVendedor", _SqlConnection) { CommandType = CommandType.StoredProcedure };
            _SqlCommand.Parameters.Add("@FechaDesde", SqlDbType.Date).Value = fecha.dtFechaDesde;
            _SqlCommand.Parameters.Add("@FechaHasta", SqlDbType.Date).Value = fecha.dtFechaHasta;

            try
            {
                _SqlConnection.Open();
                SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                if(_SqlDataReader.HasRows)
                {
                    while(_SqlDataReader.Read())
                    {
                        RComisionesVendedores comision = new RComisionesVendedores()
                        {
                            iIdVendedor = int.Parse(_SqlDataReader["IdUsuarioComision"].ToString()),
                            sVendedor   = _SqlDataReader["Vendedor"].ToString(),
                            dComision   = decimal.Parse(_SqlDataReader["Comision"].ToString()),
                            sEstado     = _SqlDataReader["Estado"].ToString()
                        };
                        lista.Add(comision);
                    }
                }
            }
            catch (Exception)
            {
                lista = null;
            }
            finally
            {
                _SqlConnection.Close();
            }
            return lista;
        }
    }
}
