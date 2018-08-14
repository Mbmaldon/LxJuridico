using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.LexaSIOContaLogica
{
    public class TipoPersona
    {
        public int     iIdCliente       { get; set; }
        public int     iIdTipoPersona   { get; set; }
        public string  sTipoPersona     { get; set; }
        

        public TipoPersona()
        {
            iIdCliente     = 0;
            iIdTipoPersona = 0;
            sTipoPersona   = string.Empty;
        }

        /// <summary>
        /// Método Público para validar si un cliente ya tiene
        /// un tipo de persona asignado.
        /// </summary>
        /// <param name="idCliente">ID del cliente</param>
        /// <returns></returns>
        public TipoPersona validarPersona(int idCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta))
            {
                //CREAMOS UN NUEVO OBJETO DE TIPO TIPOPERSONA
                TipoPersona tipoPersona = null;
                SqlCommand _SqlCommand = new SqlCommand("OFSPU_ValidarTipoPersona_Cliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@idCliente", idCliente);

                try
                {
                    //ABRIMOS LA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            //INICIALIZAMOS EL OBJETO TIPO PERSONA Y ASIGNAMOS INFORMACIÓN A SUS PROPIEDADES
                            tipoPersona = new TipoPersona()
                            {
                                sTipoPersona = _sqlDataReader["TipoPersona"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    tipoPersona = null;
                }
                return tipoPersona;
            }
        }

        /// <summary>
        /// Método Público para asignar un tipo de persona
        /// </summary>
        /// <param name="tipoPersona">Objeto de tipo TipoPersona que contiene sus propiedades.</param>
        /// <returns></returns>
        public bool bAsignarTipoPersona(TipoPersona tipoPersona)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYConta)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPU_AsignarTipoPersona_Cliente", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                //PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DE TIPO PERSONA Y EL ID DEL CLIENTE
                _SqlCommand.Parameters.AddWithValue("@idTipoPersona", tipoPersona.iIdTipoPersona);
                _SqlCommand.Parameters.AddWithValue("@idCliente", tipoPersona.iIdCliente);

                try
                {
                    //ABRIMOS LA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                    return _SqlCommand.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
