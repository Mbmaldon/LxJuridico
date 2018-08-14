using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica.Reportes
{
    public class RIngresosCliente
    {
        public int      iIdCliente  { get; set; }
        public string   sCliente    { get; set; }
        public string   sNombre     { get; set; }
        public decimal  dImporte    { get; set; }
        public DateTime dtFDesde    { get; set; }
        public DateTime dtFHasta    { get; set; }

        public List<RIngresosCliente> LIngresosCliente(RIngresosCliente fecha)
        {
            List<RIngresosCliente> lista = new List<RIngresosCliente>();
            //SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Reporte_IngresosCliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
            _SqlCommand.Parameters.Add("@FechaDesde", SqlDbType.Date).Value = fecha.dtFDesde;
            _SqlCommand.Parameters.Add("@FechaHasta", SqlDbType.Date).Value = fecha.dtFHasta;
            try
            {
                _SqlConnection.Open();
                SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                if(_SqlDataReader.HasRows)
                {
                    while(_SqlDataReader.Read())
                    {
                        RIngresosCliente cliente = new RIngresosCliente()
                        {
                            iIdCliente = int.Parse(_SqlDataReader["IdCliente"].ToString()),
                            sCliente   = _SqlDataReader["NoCliente"].ToString(),
                            sNombre    = _SqlDataReader["Cliente"].ToString(),
                            dImporte   = decimal.Parse(_SqlDataReader["Importe"].ToString())
                        };
                        lista.Add(cliente);
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
