using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Llamadas
{
    public class Llamada
    {
        #region Entidades para vaciar la información del folio del cliente

        public int iIdFolio { get; set; }
        public int iIdUsuarioCreacion { get; set; }
        public int iIdUsuarioModifica { get; set; }
        public string sDescripcion { get; set; }
        public string sContadorNombre { get; set; }
        public string sContadorAPaterno { get; set; }
        public string sContadorAMaterno { get; set; }
        public DateTime dtFechaCreacion { get; set; }
        public DateTime dtFechaModifica { get; set; }
        public string sMotivo { get; set; }
        public bool bActivo { get; set; }
        public string sCliente { get; set; }
        public string sNombre { get; set; }
        public string sAPaterno { get; set; }
        public string sAMaterno { get; set; }
        public string sFechaCierre { get; set; }

        #endregion

        public Llamada()
        {
        }

        /*Función para consultar por folio de solicitud la información del caso*/
        public Llamada InformacionCaso(int iIdFolio)
        {
            Llamada caso = null;
            SqlConnection _sqlConnection = new SqlConnection(LogicaCC.ConnectionString.DbMPYSJDB);
            SqlCommand _sqlCommand = new SqlCommand("LXCCSPS_CASO_ABIERTO_INFO", _sqlConnection) { CommandType = CommandType.StoredProcedure };
            _sqlCommand.Parameters.Add("@IdFolio", SqlDbType.BigInt).Value = iIdFolio;

            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if (_sqlDataReader.HasRows)
                {
                    while (_sqlDataReader.Read())
                    {
                        caso = new Llamada()
                        {
                            iIdFolio = int.Parse(_sqlDataReader["IdCaso"].ToString()),
                            sDescripcion = _sqlDataReader["Descripcion"].ToString(),
                            dtFechaCreacion = DateTime.Parse(_sqlDataReader["FechaCreacion"].ToString()),
                            iIdUsuarioCreacion = int.Parse(_sqlDataReader["IdUsuarioCreacion"].ToString()),
                            sContadorNombre = _sqlDataReader["Nombre"].ToString(),
                            sContadorAPaterno = _sqlDataReader["APaterno"].ToString(),
                            sContadorAMaterno = _sqlDataReader["AMaterno"].ToString(),
                            sMotivo = _sqlDataReader["Motivo"].ToString(),
                            bActivo = bool.Parse(_sqlDataReader["Estado"].ToString()),
                            sCliente = _sqlDataReader["Cliente"].ToString(),
                            sNombre = _sqlDataReader["CNombre"].ToString(),
                            sAPaterno = _sqlDataReader["CAPaterno"].ToString(),
                            sAMaterno = _sqlDataReader["CAMaterno"].ToString(),
                            sFechaCierre = _sqlDataReader["FechaCierre"].ToString()
                        };
                    }
                }
            }
            catch (Exception)
            {
                caso = null;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return caso;
        }
    }
}
