using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.Logica
{
    public class Grupo
    {
        public int    iIdGrupo  { get; set; }
        public string sGrupo    { get; set; }

        public Grupo()
        {
            iIdGrupo = 0;
            sGrupo   = "";
        }

        /// <summary>
        /// Obtiene un listado de grupos filtrados por tipo de grupo
        /// </summary>
        /// <param name="iIdGrupoTipo">Id del tipo de grupo que se requiere.</param>
        /// <returns></returns>
        public List<Grupo> GetList(int iIdGrupoTipo)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Grupo> list = new List<Grupo>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_OBTENER_GRUPOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdGrupoTipo", iIdGrupoTipo);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Grupo item = new Grupo()
                            {
                                iIdGrupo    = int.Parse(_SqlDataReader["IdGrupo"].ToString()),
                                sGrupo      = _SqlDataReader["Grupo"].ToString()
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
    }
}
