using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class Nivel
    {
        public int      iIdNivel    { get; set; }
        public string   sNivel      { get; set; }
        public decimal  dComision   { get; set; }
        public decimal  dVariacion  { get; set; }
        public string   dImporte    { get; set; }

        public Nivel()
        {
            iIdNivel   = 0;
            sNivel     = string.Empty;
            dComision  = 0;
            dVariacion = 0;
            dImporte   = "0";
        }

        /// <summary>
        /// Método Público que regresa una lista de niveles disponibles
        /// </summary>
        /// <returns></returns>
        public List<Nivel> listaNiveles()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<Nivel> lista = new List<Nivel>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_Niveles", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Nivel nivel = new Nivel()
                            {
                                iIdNivel = int.Parse(_SqlDataReader["IdNivel"].ToString()),
                                sNivel   = _SqlDataReader["Nivel"].ToString()
                            };
                            lista.Add(nivel);
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
    }
}
