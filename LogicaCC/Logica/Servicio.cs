using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    public class Servicio
    {
        //INFORMACIÓN SERVICIO
        public int      iIdServicio         { get; set; }
        public string   sServicio           { get; set; }
        public string   sEstadoServicio     { get; set; }
        public DateTime dtFechaContratacion { get; set; }
        public DateTime dtFechaVencimiento  { get; set; }
        //INFORMACIÓN CLIENTE
        public string sNoCliente    { get; set; }
        public string sRfc          { get; set; }
        public string sCurp         { get; set; }
        public string sNombre       { get; set; }
        public string sContadorA    { get; set; }
        public string sActivo       { get; set; }
        public int    iFacturaBaja  { get; set; }
        public int    iIdUsuario    { get; set; }

        /// <summary>
        /// Metodo para realizar una busqueda de servicio por medio del número del cliente
        /// mostrando solo si el cliente tiene el servicio activado.
        /// </summary>
        /// <param name="sNoCliente">Número de cliente</param>
        /// <returns></returns>
        public Servicio BuscarServicio(string sNoCliente)
        {
            Servicio servicio            = null;
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPY);
            SqlCommand _sqlCommand       = new SqlCommand("LXCCSPS_SERVICIO_BUSQUEDA", _sqlConnection) { CommandType = CommandType.StoredProcedure };
            _sqlCommand.Parameters.Add("@NoCliente", SqlDbType.NVarChar, 45).Value = sNoCliente;

            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        servicio = new Servicio()
                        {
                            iIdServicio         = int.Parse(_sqlDataReader["IdServicio"].ToString()),
                            sServicio           = _sqlDataReader["ServicioTipo"].ToString(),
                            sEstadoServicio     = _sqlDataReader["ServicioStatus"].ToString(),
                            dtFechaContratacion = DateTime.Parse(_sqlDataReader["FechaContratado"].ToString()),
                            dtFechaVencimiento  = DateTime.Parse(_sqlDataReader["FechaVencimiento"].ToString()),

                            sNoCliente   = _sqlDataReader["Cliente"].ToString(),
                            sRfc         = _sqlDataReader["RFC"].ToString(),
                            sCurp        = _sqlDataReader["CURP"].ToString(),
                            sNombre      = _sqlDataReader["Nombre"].ToString(),
                            sContadorA   = _sqlDataReader["ContadorA"].ToString(),
                            sActivo      = _sqlDataReader["Activo"].ToString(),
                            iFacturaBaja = int.Parse(_sqlDataReader["FacturaBajaServicio"].ToString())
                        };
                    }
                }
            }
            catch (Exception)
            {
                servicio = null;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return servicio;
        }

        /// <summary>
        /// Metodo para cambiar el estado de servicio de un cliente pasando de activo a cancelado
        /// </summary>
        /// <param name="servicio">Objeto servicio con propiedades internas</param>
        /// <returns></returns>
        public bool bCancelarServicio(Servicio servicio)
        {
            bool bCancela                = false;
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPY);
            SqlCommand _sqlCommand       = new SqlCommand("LXCCSPU_SERVICIO_CANCELAR", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            _sqlCommand.Parameters.Add("@IdServicio", SqlDbType.BigInt).Value            = servicio.iIdServicio;
            _sqlCommand.Parameters.Add("@IdUsuarioModificacion", SqlDbType.BigInt).Value = servicio.iIdUsuario;

            var paramaterReturn         = _sqlCommand.Parameters.Add("@Result", SqlDbType.Int);
            paramaterReturn.Direction   = ParameterDirection.ReturnValue;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.ExecuteNonQuery();
                var result = paramaterReturn.Value;
                if (int.Parse(result.ToString()) == 1)
                    bCancela = true;
                else
                    bCancela = false;
            }
            catch (Exception)
            {
                bCancela = false;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return bCancela;
        }
    }
}
