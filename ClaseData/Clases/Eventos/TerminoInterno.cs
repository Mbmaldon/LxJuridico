using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LogicaCC;

namespace ClaseData.Clases.Eventos
{
    public class TerminoInterno
    {
        public DateTime dtFechaTerminoLegal     { get; set; }
        public DateTime dtFechaTerminoInterno   { get; set; }

        public TerminoInterno()
        {
            dtFechaTerminoLegal     = DateTime.Now;
            dtFechaTerminoInterno   = DateTime.Now;
        }

        /// <summary>
        /// Obtiene la fecha de termino interno para un nuevo evento
        /// en base al tipo de solicitud y a la fecha de termino legal
        /// </summary>
        /// <param name="iIdSolicitudTipo">Id del Tipo de Solicitud</param>
        /// <param name="dtFechaTerminoLegal">Fecha de Termino Legal</param>
        /// <returns></returns>
        public DateTime GetDate(int iIdSolicitudTipo ,DateTime dtFechaTerminoLegal)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYSJDB))
            {
                TerminoInterno Termino = null;
                SqlCommand _SqlCommand = new SqlCommand("MDSPS_OBTENER_FECHATERMINO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdSolicitudTipo", iIdSolicitudTipo);
                _SqlCommand.Parameters.AddWithValue("@FechaTerminoLegal", dtFechaTerminoLegal);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    while (_SqlDataReader.Read())
                    {
                        Termino = new TerminoInterno()
                        {
                            dtFechaTerminoInterno = DateTime.Parse(_SqlDataReader["FechaTerminoInterno"].ToString())
                        };
                    }
                }
                catch (Exception)
                {
                    Termino = null;
                }
                return Termino.dtFechaTerminoInterno;
            }
        }
    }
}
