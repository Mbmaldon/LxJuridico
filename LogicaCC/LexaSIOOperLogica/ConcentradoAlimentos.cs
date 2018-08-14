using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class ConcentradoAlimentos
    {
        public int      iIdConcentradoAlimentos     { get; set; }
        public string   sNoOperacion                { get; set; }
        public string   sEjecutivoCuentaAsignado    { get; set; }
        public string   sVendedor                   { get; set; }
        public string   sNoCuentaDisperso           { get; set; }
        public decimal  dComision                   { get; set; }
        public string   sNoSocio                    { get; set; }
        public string   sNombreSocio                { get; set; }
        public decimal  dMonto                      { get; set; }
        public string   sFechaDeposito              { get; set; }
        public string   sNumeroRecibo               { get; set; }
        public string   sPolizaContable             { get; set; }


        public ConcentradoAlimentos()
        {
            this.iIdConcentradoAlimentos    = 0;
            this.sNoOperacion               = string.Empty;
            this.sEjecutivoCuentaAsignado   = string.Empty;
            this.sVendedor                  = string.Empty;
            this.sNoCuentaDisperso          = string.Empty;
            this.dComision                  = 0;
            this.sNoSocio                   = string.Empty;
            this.sNombreSocio               = string.Empty;
            this.dMonto                     = 0;
            this.sFechaDeposito             = string.Empty;
            this.sNumeroRecibo              = string.Empty;
            this.sPolizaContable            = string.Empty;
        }

        /// <summary>
        /// Método Público para obtener como lista, un concetrado de alimentos de todos los vendedores
        /// </summary>
        /// <returns></returns>
        public List<ConcentradoAlimentos> ListaConcentradoAlimentos()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<ConcentradoAlimentos> lista = new List<ConcentradoAlimentos>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_ConcentradoAlimentos", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            ConcentradoAlimentos item = new ConcentradoAlimentos()
                            {
                                iIdConcentradoAlimentos  = int.Parse(_SqlDataReader["IdConcentradoAlimentos"].ToString()),
                                sNoOperacion             = _SqlDataReader["NoOperacion"].ToString(),
                                sEjecutivoCuentaAsignado = _SqlDataReader["EjecutivoCuentaAsignado"].ToString(),
                                sVendedor                = _SqlDataReader["Vendedor"].ToString(),
                                sNoCuentaDisperso        = _SqlDataReader["NoCuentaDisperso"].ToString(),
                                dComision                = decimal.Parse(_SqlDataReader["Comision"].ToString()),
                                sNoSocio                 = _SqlDataReader["NoSocio"].ToString(),
                                sNombreSocio             = _SqlDataReader["NombreSocio"].ToString(),
                                dMonto                   = decimal.Parse(_SqlDataReader["Monto"].ToString()),
                                sFechaDeposito           = _SqlDataReader["FechaDeposito"].ToString(),
                                sNumeroRecibo            = _SqlDataReader["NumeroRecibo"].ToString(),
                                sPolizaContable          = _SqlDataReader["PolizaContable"].ToString()
                            };
                            lista.Add(item);
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

        /// <summary>
        /// Método Público para insertar un layout(importación de excel) a la BD.
        /// </summary>
        /// <param name="_concentradoAlimentos"></param>
        /// <returns></returns>
        public bool ImportarLayout(ConcentradoAlimentos _concentradoAlimentos)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                SqlCommand _SqlCommand = new SqlCommand("LSOSPI_Insertar_Layout", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, LOS DATOS REQUERIDOS PARA LA TABLA EN DB
                _SqlCommand.Parameters.AddWithValue("@NoOperacion", _concentradoAlimentos.sNoOperacion);
                _SqlCommand.Parameters.AddWithValue("@EjecutivoCuentaAsignado", _concentradoAlimentos.sEjecutivoCuentaAsignado);
                _SqlCommand.Parameters.AddWithValue("@Vendedor", _concentradoAlimentos.sVendedor);
                _SqlCommand.Parameters.AddWithValue("@NoCuentaDisperso", _concentradoAlimentos.sNoCuentaDisperso);
                _SqlCommand.Parameters.AddWithValue("@Comision", _concentradoAlimentos.dComision);
                _SqlCommand.Parameters.AddWithValue("@NoSocio", _concentradoAlimentos.sNoSocio);
                _SqlCommand.Parameters.AddWithValue("@NombreSocio", _concentradoAlimentos.sNombreSocio);
                _SqlCommand.Parameters.AddWithValue("@Monto", _concentradoAlimentos.dMonto);
                _SqlCommand.Parameters.AddWithValue("@FechaDeposito", _concentradoAlimentos.sFechaDeposito);
                _SqlCommand.Parameters.AddWithValue("@NumeroRecibo", _concentradoAlimentos.sNumeroRecibo);
                _SqlCommand.Parameters.AddWithValue("@PolizaContable", _concentradoAlimentos.sPolizaContable);

                try
                {
                    _SqlConnection.Open();
                    // EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                    return (_SqlCommand.ExecuteNonQuery() > 0 ? true : false);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
