using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AGREGAMOS LIBRERIAS ADICIONALES
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class Adjunto
    {
        //CREAMOS PROPIEDADES
        public int    iIdAdjunto            { get; set; }
        public int    iIdRegistroObligacion { get; set; }
        public string sAdjunto              { get; set; }

        //CREAMOS CONSTRUCTOR
        public Adjunto()
        {
            iIdAdjunto              = 0;
            iIdRegistroObligacion   = 0;
            sAdjunto                = string.Empty;
        }

        /// <summary>
        /// Método público para agregar registros de archivos ajuntos
        /// a la base de datos
        /// </summary>
        /// <param name="adjunto">Objeto de tipo Adjunto con propiedades</param>
        /// <returns></returns>
        public bool insertarAdjunto(Adjunto adjunto)
        {
            bool bAdjunto = false;
            //CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            //SqlConnection _sqlConnection  = new SqlConnection(Conection.ConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYConta);
            SqlCommand _sqlCommand        = new SqlCommand("OFSPI_Insertar_Adjunto", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            //PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL REGISTRO DE LA OLBIGACIÓN Y LA RUTA DEL ADJUNTO
            _sqlCommand.Parameters.Add("@idRegistroObligacion", SqlDbType.BigInt).Value = adjunto.iIdRegistroObligacion;
            _sqlCommand.Parameters.Add("@adjunto", SqlDbType.NVarChar, 90).Value        = adjunto.sAdjunto;

            try
            {
                //ABRIMOS NUESTRA CONEXIÓN
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

        public string enviarNotificacion(string sCliente, string sArchivo)
        {
            //SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
            SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY);
            SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_NOTIFICAR_EXPEDIENTE", _SqlConnection) { CommandType = CommandType.StoredProcedure };
            _SqlCommand.Parameters.Add("@Cliente", SqlDbType.NVarChar, 50).Value = sCliente;
            _SqlCommand.Parameters.Add("@Archivo", SqlDbType.NVarChar, 500).Value = sArchivo;

            try
            {
                _SqlConnection.Open();
                _SqlCommand.ExecuteNonQuery();
                return "Correo enviado";
            }
            catch (Exception)
            {
                return "Correo no enviado";
            }
            finally
            {
                _SqlConnection.Close();
            }
        }
    }
}
