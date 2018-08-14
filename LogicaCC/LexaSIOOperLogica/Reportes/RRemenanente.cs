using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica.Reportes
{
    public class RRemenanente
    {
        public decimal dBono            { get; set; }
        public decimal dComision        { get; set; }
        public decimal dBonoComision    { get; set; }
        public decimal dImporte         { get; set; }
        public decimal dRemanente       { get; set; }


        public int     iIdOperacionComisionista { get; set; }
        public string  sVendedor                { get; set; }
        public string  sTipo                    { get; set; }
        public decimal dImporteR                 { get; set; }


        public RRemenanente InfoRemanente(int iAnio)
        {
            RRemenanente remanente = null;
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Reporte_Remanente", _sqlConnection) { CommandType = CommandType.StoredProcedure };
            _SqlCommand.Parameters.Add("@Anio", SqlDbType.BigInt).Value = iAnio;

            try
            {
                _sqlConnection.Open();
                SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                if(_SqlDataReader.HasRows)
                {
                    while(_SqlDataReader.Read())
                    {
                        remanente = new RRemenanente()
                        {
                            dBono           = decimal.Parse(_SqlDataReader["Bono"].ToString()),
                            dComision       = decimal.Parse(_SqlDataReader["Comision"].ToString()),
                            dBonoComision   = decimal.Parse(_SqlDataReader["Bono + Comision"].ToString()),
                            dImporte        = decimal.Parse(_SqlDataReader["Importe"].ToString()),
                            dRemanente      = decimal.Parse(_SqlDataReader["Remanente"].ToString())
                        };
                    }
                }
            }
            catch (Exception)
            {
                remanente = null;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return remanente;
        }

        public List<RRemenanente> lRemanente(int iAnio)
        {
            List<RRemenanente> lista = new List<RRemenanente>();
            //SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Reporte_RemanenteRegistros", _SqlConnection) { CommandType = CommandType.StoredProcedure };
            _SqlCommand.Parameters.Add("@Anio", SqlDbType.BigInt).Value = iAnio;
            try
            {
                _SqlConnection.Open();
                SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                if(_SqlDataReader.HasRows)
                {
                    while(_SqlDataReader.Read())
                    {
                        RRemenanente comision = new RRemenanente()
                        {
                            iIdOperacionComisionista = int.Parse(_SqlDataReader["IdOperacionComisionista"].ToString()),
                            sVendedor = _SqlDataReader["Vendedor"].ToString(),
                            sTipo = _SqlDataReader["Tipo"].ToString(),
                            dImporteR = decimal.Parse(_SqlDataReader["Importe"].ToString())
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
