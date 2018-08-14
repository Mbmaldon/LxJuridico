using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class LimiteInferior
    {
        public int      iIdLimiteInferior   { get; set; }
        public decimal  dLimiteInferior     { get; set; }
        public decimal  dExcedente          { get; set; }
        public decimal  dCuotaFija          { get; set; }

        public LimiteInferior()
        {
            iIdLimiteInferior  = 0;
            dLimiteInferior    = 0;
            dExcedente         = 0;
            dCuotaFija         = 0;
        }

        /// <summary>
        /// Método Público para obtener el limite inferior pasando como parametro
        /// la base gravable.
        /// </summary>
        /// <param name="BaseGravable">Base gravable para obtener el limite inferior</param>
        /// <returns></returns>
        public LimiteInferior obtenerLimite(decimal BaseGravable)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                LimiteInferior limiteInferior = null;
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_LimiteInferior", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, LA BASE GRAVABLE
                _SqlCommand.Parameters.AddWithValue("@ldc_valor", BaseGravable);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            limiteInferior = new LimiteInferior()
                            {
                                dLimiteInferior = decimal.Parse(_SqlDataReader["LimiteInferior"].ToString()),
                                dExcedente      = decimal.Parse(_SqlDataReader["Excedente"].ToString()),
                                dCuotaFija      = decimal.Parse(_SqlDataReader["CuotaFija"].ToString())                          
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    limiteInferior = null;
                }
                return limiteInferior;
            }
        }
    }
}
