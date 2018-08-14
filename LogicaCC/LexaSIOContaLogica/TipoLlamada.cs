using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class TipoLlamada
    {
        public int     iIdUsuario     { get; set; }
        public string  sTipoLlamada   { get; set; }

        public TipoLlamada()
        {
            this.iIdUsuario     = 0;
            this.sTipoLlamada   = string.Empty;
        }

        /// <summary>
        /// Método Público para insertar un registro de un nuevo tipo de llamada
        /// </summary>
        /// <param name="tipoLlamada">Objeto TipoLlamada que contiene sus propiedades.</param>
        /// <returns></returns>
        public bool InsertarTipoLlamada(TipoLlamada tipoLlamada)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPI_Insertar_TipoLlamada", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                //PASAMOS COMO PARAMETRO A LA CONSULTA, LA INFORMACIÓN QUE SE GUARDARA EN EL REGISTRO DE LA OBLIGACIÓN
                _SqlCommand.Parameters.AddWithValue("@idUsuarioCreacion", tipoLlamada.iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@motivo", tipoLlamada.sTipoLlamada);

                try
                {
                    //ABRIMOS LA CONEXIÓN
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
