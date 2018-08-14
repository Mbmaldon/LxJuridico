using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class Comision
    {
        public int     iIdOperacionComisionista { get; set; }
        public int     iIdTipoUsuario           { get; set; }
        public string  sNoOperacion             { get; set; }
        public string  sNombreComisionista      { get; set; }
        public decimal dImporte                 { get; set; }
        public bool    bPagada                  { get; set; }

        public Comision ()
        {
            this.iIdOperacionComisionista   = 0;
            this.iIdTipoUsuario             = 0;
            this.sNoOperacion               = string.Empty;
            this.sNombreComisionista        = string.Empty;
            this.dImporte                   = 0;
            this.bPagada                    = false;
        }

        /// <summary>
        /// Método Público que regresa una lista de comisiones
        /// </summary>
        /// <param name="iIdOperacion">ID o clave de la operación de la que se desea ver sus comisiones</param>
        /// <returns></returns>
        public List<Comision> listaComisiones(int iIdOperacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<Comision> lista = new List<Comision>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_ComisionesDetalles", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DE LA OPERACIÓN
                _SqlCommand.Parameters.AddWithValue("@IdOperacion", iIdOperacion);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Comision item = new Comision()
                            {
                                iIdOperacionComisionista = int.Parse(_SqlDataReader["IdOperacionComisionista"].ToString()),
                                sNoOperacion             = _SqlDataReader["NoOperacion"].ToString(),
                                sNombreComisionista      = _SqlDataReader["Nombre"].ToString(),
                                dImporte                 = decimal.Parse(_SqlDataReader["Importe"].ToString()),
                                bPagada                  = bool.Parse(_SqlDataReader["Pagado"].ToString()),
                                iIdTipoUsuario           = int.Parse(_SqlDataReader["IdUsuarioTipo"].ToString())
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
        /// Método Público para marcar una comisión como pagada
        /// </summary>
        /// <param name="iIdOperacionComisionista">ID de la comisión a la cual se le cambiara el estado de pago.</param>
        /// <returns></returns>
        public bool marcarPagada(int iIdOperacionComisionista)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SqlCommand _SqlCommand = new SqlCommand("LSOSPU_Pagar_Comision", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DE LA COMISIÓN
                _SqlCommand.Parameters.AddWithValue("@IdOperacionComisionista", iIdOperacionComisionista);

                try
                {
                    //ABRIMOS NUESTRA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
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
