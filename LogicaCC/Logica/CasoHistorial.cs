using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.Logica
{
    public class CasoHistorial
    {
        public int      iIdCasoHistorial   { get; set; }
        public int      iIdCaso            { get; set; }
        public int      iIdUsuarioRegistra { get; set; }
        public string   sComentario        { get; set; }
        public DateTime dtFechaCreacion    { get; set; }
        public string   sUsuario            { get; set; }
        public CasoHistorial()
        { }

        /// <summary>
        /// Obtiene un listado del historial de un folio
        /// </summary>
        /// <param name="iIdCaso">Id del Folio que se desea</param>
        /// <returns></returns>
        public List<CasoHistorial> GetListCasoHistorial(int iIdCaso)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<CasoHistorial> lista = new List<CasoHistorial>();
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_CASO_HISTORIAL", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.Add("@IdCaso", SqlDbType.BigInt).Value = iIdCaso;
                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            CasoHistorial cCasoH = new CasoHistorial()
                            {
                                iIdCasoHistorial    = int.Parse(_SqlDataReader["IdCasoHistorial"].ToString()),
                                dtFechaCreacion     = DateTime.Parse(_SqlDataReader["FechaCreacion"].ToString())
                            };
                            lista.Add(cCasoH);
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
        /// Obtiene los detalles de un historico
        /// </summary>
        /// <param name="iIdCasoHistorial">Id del historico</param>
        /// <returns></returns>
        public CasoHistorial GetInfoCasoHistorial(int iIdCasoHistorial)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                CasoHistorial casoH = null;
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_CASO_HISTORIAL_INFO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.Add("@IdCasoHistorial", SqlDbType.BigInt).Value = iIdCasoHistorial;

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if(_SqlDataReader.HasRows)
                    {
                        while(_SqlDataReader.Read())
                        {
                            casoH = new CasoHistorial()
                            {
                                iIdCasoHistorial = int.Parse(_SqlDataReader["IdCasoHistorial"].ToString()),
                                dtFechaCreacion  = DateTime.Parse(_SqlDataReader["FechaCreacion"].ToString()),
                                sComentario      = _SqlDataReader["Comentario"].ToString(),
                                sUsuario         = _SqlDataReader["Usuario"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    casoH = null;
                }
                return casoH;
            }
        }

        /// <summary>
        /// Actualiza el nombre la grabación de un historico
        /// </summary>
        /// <param name="iIdCasoHistorial">Id del historico</param>
        /// <param name="sRutaGrabacion">Ruta de la grabación</param>
        /// <returns></returns>
        public int UpdateHistorialRecord(int iIdCasoHistorial, string sRutaGrabacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MDSPU_HISTORIAL_CASO_GRABACION", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdCasoHistorial", iIdCasoHistorial);
                _SqlCommand.Parameters.AddWithValue("@RutaGrabacion", sRutaGrabacion);

                var resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.Int);
                resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return (int)resultado.Value;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Guarda un registro historico de folio principal
        /// </summary>
        /// <param name="_Historial">Nuevo objeto CasoHistorial con sus respectivas propiedades</param>
        /// <returns></returns>
        public int AddHistorial(CasoHistorial _Historial)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPI_CASO_NUEVO_HIS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdCaso", _Historial.iIdCaso);
                _SqlCommand.Parameters.AddWithValue("@IdUsuarioRegistra", _Historial.iIdUsuarioRegistra);
                _SqlCommand.Parameters.AddWithValue("@Comentario", _Historial.sComentario);

                var resultado = _SqlCommand.Parameters.Add("@IdCasoHistorial", SqlDbType.BigInt);
                resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return (int)resultado.Value;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
    }
}
