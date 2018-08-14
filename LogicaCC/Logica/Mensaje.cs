using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    public class Mensaje
    {
        public int    iIdMensaje        { get; set; }
        public string sMensaje          { get; set; }
        public string sMensajeContenido { get; set; }

        public Mensaje()
        {
            iIdMensaje          = 0;
            sMensaje            = string.Empty;
            sMensajeContenido   = string.Empty;
        }

        public List<Mensaje> lMensajes()
        {
            //using (SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString))
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Mensaje> lista    = new List<Mensaje>();
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_MENSAJES", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Mensaje mensaje = new Mensaje()
                            {
                                iIdMensaje = int.Parse(_SqlDataReader["IdMensajeTexto"].ToString()),
                                sMensaje   = _SqlDataReader["MensajeTexto"].ToString()
                            };
                            lista.Add(mensaje);
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

        public Mensaje obtenerMensaje(int iIdMensaje)
        {
            //using (SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString))
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                Mensaje sms = null;
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_MENSAJE_CONTENIDO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdMensaje", iIdMensaje);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            sms = new Mensaje()
                            {
                                sMensajeContenido = _SqlDataReader["MensajeTextoContenido"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    sms = null;
                }
                return sms;
            }
        }
    }
}
