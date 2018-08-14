using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LogicaCC.Logica
{
    public class Cita
    {
        public int      iIdCita        { get; set; }
        public string   sObservaciones { get; set; }
        public string   sNombre        { get; set; }
        public string   sHora          { get; set; }
        public string   sAgente        { get; set; }
        public DateTime dtFecha        { get; set; }
        public int iTotal { get; set; }
        public int iContando { get; set; }


        public Cita()
        {
            iIdCita        = 0;
            sObservaciones = "";
            sNombre        = "";
            sAgente        = "";
            sHora          = "";
            dtFecha        = DateTime.Now;
            iTotal = 0;
            iContando = 0;
        }

        /// <summary>
        /// Obtiene un listado de citas agendadas por un usuario
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que agendo las citas</param>
        /// <returns></returns>
        public List<Cita> GetList(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Cita> lista = new List<Cita>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_GET_CITAS_AGENDADAS_BY_USER", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Cita item = new Cita()
                            {
                                iIdCita        = int.Parse(_SqlDataReader["IdCita"].ToString()),
                                dtFecha        = DateTime.Parse(_SqlDataReader["Fecha"].ToString()),
                                sHora          = _SqlDataReader["HoraEntrada"].ToString(),
                                sNombre        = _SqlDataReader["Nombre"].ToString(),
                                sObservaciones = _SqlDataReader["Observaciones"].ToString(),
                                sAgente        =_SqlDataReader["Agente"].ToString()
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
        /// Obtiene un listado de citas agendadas para el día de hoy por usuario
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que deseas obtener</param>
        /// <returns></returns>
        public List<Cita> GetListToday(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Cita> lista = new List<Cita>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_GET_CITAS_AGENDADAS_BY_USER_TODAY", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Cita item = new Cita()
                            {
                                iIdCita        = int.Parse(_SqlDataReader["IdCita"].ToString()),
                                dtFecha        = DateTime.Parse(_SqlDataReader["Fecha"].ToString()),
                                sHora          = _SqlDataReader["HoraEntrada"].ToString(),
                                sNombre        = _SqlDataReader["Nombre"].ToString(),
                                sObservaciones = _SqlDataReader["Observaciones"].ToString(),
                                sAgente        =_SqlDataReader["Agente"].ToString()
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
        /// Obtiene numero de citas solicitadas a los agentes de call center
        /// </summary>
        /// <returns></returns>
        public Cita GetNoCitas(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                Cita item = null;
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_OBTENER_NO_CITAS_PROGRAMADAS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            item = new Cita()
                            {
                                iTotal = int.Parse(_SqlDataReader["NoCitas"].ToString()),
                                iContando = int.Parse(_SqlDataReader["Contando"].ToString())
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
    }
}
