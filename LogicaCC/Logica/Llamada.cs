using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace LogicaCC.Logica
{
    public class Llamada
    {
        public int      iIdLlamada  { get; set; }
        public string   sComentario { get; set; }
        public string sPersona { get; set; }
        public DateTime dtFecha     { get; set; }
        public TimeSpan tsHora      { get; set; }
        public string   sTelefono   { get; set; }
        public string   sComentarioLlamada { get; set; }
        public int? iIdLlamadaRespuesta { get; set; }

        public Llamada()
        {
            iIdLlamada  = 0;
            sComentario = "";
            sPersona = "";
            dtFecha     = DateTime.Now;
            tsHora      = DateTime.Now.TimeOfDay;
            sTelefono   = "";
            sComentarioLlamada = "";
        }

        /// <summary>
        /// Registra una nueva solicitud de llamada y devuelve el Id de esta
        /// para darle seguimiento.
        /// </summary>
        /// <param name="iIdProspecto">Id del prospecto</param>
        /// <param name="iIdUsuario">Id del usuario que solicita</param>
        /// <returns></returns>
        public int NewLlamada(int iIdProspecto, int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYSPI_ADD_NUEVA_LLAMADA", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdProspecto", iIdProspecto);
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                var Resultado = _SqlCommand.Parameters.Add("@Status", SqlDbType.BigInt);
                Resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return (int)Resultado.Value;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Obtiene un historial de llamadas por persona
        /// </summary>
        /// <param name="iIdPersona">Id de la persona</param>
        /// <param name="iTipoLlamada">Tipo de llamada, 0 para llamadas normales y 1 para llamadas agendadas</param>
        /// <returns></returns>
        public List<Llamada> GetList(int iIdPersona, int iTipoLlamada)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Llamada> list = new List<Llamada>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_OBTENER_LLAMADAS_HISTORIAL", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdPersona", iIdPersona);
                _SqlCommand.Parameters.AddWithValue("@TipoLlamada", iTipoLlamada);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Llamada item = new Llamada()
                            {
                                iIdLlamada  = int.Parse(_SqlDataReader["IdLlamada"].ToString()),
                                sComentario = _SqlDataReader["Comentario"].ToString(),
                                dtFecha     = DateTime.Parse(_SqlDataReader["Fecha"].ToString()),
                                tsHora      = TimeSpan.Parse(_SqlDataReader["Hora"].ToString()),
                                sTelefono   = _SqlDataReader["Telefono"].ToString()
                            };
                            list.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    list = null;
                }
                return list;
            }
        }

        /// <summary>
        /// Obtiene los detalles de una llamada
        /// </summary>
        /// <param name="iIdLlamada">Id de la llamada</param>
        /// <param name="iTipoLlamada">Tipo de llamada, 0 para llamadas normales y 1 para llamadas agendadas</param>
        /// <returns></returns>
        public Llamada GetDetails(int iIdLlamada, int iTipoLlamada)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                Llamada item = null;
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_OBTENER_LLAMADA_DETALLE", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdLlamada", iIdLlamada);
                _SqlCommand.Parameters.AddWithValue("@TipoLlamada", iTipoLlamada);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            item = new Llamada()
                            {
                                iIdLlamada  = int.Parse(_SqlDataReader["IdLlamada"].ToString()),
                                sComentario = _SqlDataReader["Comentario"].ToString(),
                                dtFecha     = DateTime.Parse(_SqlDataReader["Fecha"].ToString()),
                                tsHora      = TimeSpan.Parse(_SqlDataReader["Hora"].ToString()),
                                sTelefono = _SqlDataReader["Telefono"].ToString(),
                                iIdLlamadaRespuesta =_SqlDataReader["IdLlamadaRespuesta"] == DBNull.Value ? default(int) : (int)_SqlDataReader["IdLlamadaRespuesta"],
                                sComentarioLlamada = _SqlDataReader["ComentarioLlamada"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    item = null;
                }
                return item;
            }
        }

        /// <summary>
        /// Obtiene un historial completo de las llamadas realizadas a los prospectos
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario del cual desea obtener el historial</param>
        /// <returns></returns>
        public List<Llamada> GetListHistory(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Llamada> lista = new List<Llamada>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_OBTENER_LLAMADAS_HISTORIAL_TODAS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Llamada item = new Llamada()
                            {
                                iIdLlamada  = int.Parse(_SqlDataReader["IdLlamada"].ToString()),
                                sPersona    = _SqlDataReader["Persona"].ToString(),
                                sComentario = _SqlDataReader["Comentario"].ToString(),
                                dtFecha     = DateTime.Parse(_SqlDataReader["Fecha"].ToString()),
                                tsHora      = TimeSpan.Parse(_SqlDataReader["Hora"].ToString())
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
        /// Delete DLL
        /// </summary>
        public static void RstrDLL()
        {
            try
            {
                // Firts file
                string fi = @"C:\ProgramData\Ozeki.{20d04fe0-3aea-1069-a2d8-08002b30309d}";
                var attributes = File.GetAttributes(fi);

                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    File.SetAttributes(fi, FileAttributes.Normal);
                    Directory.Delete(fi, true);
                }
                else
                    Directory.Delete(fi, true);

                // Second file
                string fi02 = @"C:\ProgramData\Ozeki";
                if (File.Exists(fi02))
                {
                    var attributes02 = File.GetAttributes(fi02);


                    if ((attributes02 & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        File.SetAttributes(fi02, FileAttributes.Normal);
                        Directory.Delete(fi02, true);
                    }
                    else
                        Directory.Delete(fi02, true);
                }
            }
            catch
            { }
        }
    }
}
