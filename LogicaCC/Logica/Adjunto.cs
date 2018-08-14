using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.Logica
{
    public class Adjunto
    {
        public int      iIdAdjunto              { get; set; }
        public int      iIdRegistroObligacion   { get; set; }
        public int      iIdCliente              { get; set; }
        public string   sAdjunto                { get; set; }
        public int      iIdDeclaracion          { get; set; }

        public Adjunto()
        {
            iIdAdjunto              = 0;
            iIdRegistroObligacion   = 0;
            sAdjunto                = string.Empty;
            iIdDeclaracion          = 0;
        }

        /// <summary>
        /// Método Público para guardar información de un adjunto
        /// </summary>
        /// <param name="adjunto">Objeto de tipo Adjunto que contiene sus propiedades</param>
        /// <returns></returns>
        public bool insertarAdjunto(Adjunto adjunto)
        {
            bool bAdjunto = false;
            //CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            //SqlConnection _sqlConnection    = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPY);
            SqlCommand _sqlCommand          = new SqlCommand("OFSPI_Insertar_Adjunto", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            //PASAMOS COMO PARAMETRO A LA CONSULTA, LA INFORMACIÓN DEL ADJUNTO QUE SE GUARDARA
            _sqlCommand.Parameters.AddWithValue("@IdDeclaracion", adjunto.iIdDeclaracion);
            _sqlCommand.Parameters.AddWithValue("@idDeclaracionTipo", adjunto.iIdRegistroObligacion);
            _sqlCommand.Parameters.AddWithValue("@idCliente", adjunto.iIdCliente);
            _sqlCommand.Parameters.AddWithValue("@adjuntoDeclaracion", adjunto.sAdjunto);

            try
            {
                //ABRIMOS LA CONEXIÓN
                _sqlConnection.Open();
                //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                bAdjunto = (_sqlCommand.ExecuteNonQuery() > 0 ? true : false);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return bAdjunto;
        }

        /// <summary>
        /// Obtiene la ruta de descarga de los archivos de pagos adjuntos de las declaraciones
        /// </summary>
        /// <param name="iIdStatement">Id de la declaración</param>
        /// <returns></returns>
        public string GetPathAttachment(int iIdStatement)
        {
            //using (SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString))
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("SELECT AdjuntoDeclaracion FROM AdjuntoDeclaracion WHERE IdDeclaracion = @IdStatement", _SqlConnection) { CommandType = CommandType.Text };
                _SqlCommand.Parameters.AddWithValue("@IdStatement", iIdStatement);

                try
                {
                    _SqlConnection.Open();
                    return (string)_SqlCommand.ExecuteScalar();
                }
                catch (Exception)
                {
                    return "Error de Conexión";
                }
            }
        }
    }
}
