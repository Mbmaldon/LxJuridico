using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class Propuesta
    {
        public int      iIdPropuesta    { get; set; }
        public string   sPropuesta      { get; set; }

        public Propuesta()
        {
            iIdPropuesta    = 0;
            sPropuesta      = string.Empty;
        }

        /// <summary>
        /// Obtiene la propuesta de respuesta aprobada de una solicitud
        /// </summary>
        /// <param name="iIdSolicitud">Id de la solicitud que se requiere</param>
        /// <returns></returns>
        public Propuesta GetSucces(int iIdSolicitud)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(LogicaCC.ConnectionString.DbMPYSJDB))
            {
                Propuesta Propuesta = null;
                SqlCommand _SqlCommand = new SqlCommand("MDSPS_OBTENER_PROPUESTAAPROBADA", _SqlConnection) { CommandType = System.Data.CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdSolicitud", iIdSolicitud);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Propuesta = new Propuesta()
                            {
                                iIdPropuesta    = int.Parse(_SqlDataReader["IdPropuestaRespuesta"].ToString()),
                                sPropuesta      = _SqlDataReader["Propuesta"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    Propuesta = null;
                }
                return Propuesta;
            }
        }

    }
}
