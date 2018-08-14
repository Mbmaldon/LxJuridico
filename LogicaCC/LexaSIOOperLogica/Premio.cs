using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.LexaSIOOperLogica
{
    public class Premio
    {
        public int      iIdPremio       { get; set; }
        public int      iIdUsuario      { get; set; }
        public string   sNombre         { get; set; }
        public string   sPremioTipo     { get; set; }
        public string   sPeriodo        { get; set; }
        public string   sDescripcion    { get; set; }

        public List<Premio> lPremio()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                List<Premio> lista = new List<Premio>();
                SqlCommand _SqlCommand = new SqlCommand("MPYOPS_OBTENER_PREMIOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Premio premio = new Premio()
                            {
                                iIdPremio    = int.Parse(_SqlDataReader["IdPremio"].ToString()),
                                iIdUsuario   = int.Parse(_SqlDataReader["IdUsuario"].ToString()),
                                sNombre      = _SqlDataReader["Nombre"].ToString(),
                                sPremioTipo  = _SqlDataReader["PremioTipo"].ToString(),
                                sPeriodo     = _SqlDataReader["Periodo"].ToString(),
                                sDescripcion = _SqlDataReader["Descripcion"].ToString()
                            };
                            lista.Add(premio);
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
