using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class Diagnostico
    {
        public string sElaborador           { get; set; }
        public string sComentario           { get; set; }
        public string sComentarioRespuesa   { get; set; }
        public string sComentarioFinal      { get; set; }

        //private SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
        private SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY);

        public Diagnostico Elaborador(string sCliente)
        {
            Diagnostico elaborador = null;
            SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_DIAGNOSTICO_ELABORADOR", _SqlConnection) { CommandType = CommandType.StoredProcedure };
            _SqlCommand.Parameters.Add("@Cliente", SqlDbType.NVarChar, 40).Value = sCliente;
            try
            {
                _SqlConnection.Open();
                SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                if (_SqlDataReader.HasRows)
                {
                    while (_SqlDataReader.Read())
                    {
                        elaborador = new Diagnostico()
                        {
                            sElaborador = _SqlDataReader["Elaborador"].ToString()
                        };
                    }
                }
            }
            catch (Exception)
            {
                elaborador = null;
            }
            finally
            {
                _SqlConnection.Close();
            }
            return elaborador;
        }


        public  List<Diagnostico> lComentarios(string sCliente)
        {
            List<Diagnostico> lista = new List<Diagnostico>();
            SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_DIAGNOSTICO_COMENTARIOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
            _SqlCommand.Parameters.Add("@Cliente", SqlDbType.NVarChar, 50).Value = sCliente;
            try
            {
                _SqlConnection.Open();
                SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                if (_SqlDataReader.HasRows)
                {
                    while (_SqlDataReader.Read())
                    {
                        Diagnostico comentario = new Diagnostico()
                        {
                            sComentario         = _SqlDataReader["ComentarioDiagnostico"].ToString(),
                            sComentarioRespuesa = _SqlDataReader["Comentario"].ToString()
                        };
                        lista.Add(comentario);
                    }
                }
            }
            catch (Exception)
            {
                lista = null;
            }
            finally
            {
                _SqlConnection.Close();
            }
            return lista;
        }

        public List<Diagnostico> lComentarioFinal(string sCliente)
        {
            List<Diagnostico> lista = new List<Diagnostico>();
            SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_DIAGNOSTICO_COMENTARIO_FINAL", _SqlConnection) { CommandType = CommandType.StoredProcedure };
            _SqlCommand.Parameters.Add("@Cliente", SqlDbType.NVarChar, 50).Value = sCliente;
            try
            {
                _SqlConnection.Open();
                SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                if (_SqlDataReader.HasRows)
                {
                    while (_SqlDataReader.Read())
                    {
                        Diagnostico comentarioFinal = new Diagnostico()
                        {
                            sComentario         = _SqlDataReader["Comentario"].ToString(),
                            sComentarioFinal    = _SqlDataReader["ComentarioFinal"].ToString()
                        };
                        lista.Add(comentarioFinal);
                    }
                }
            }
            catch (Exception)
            {
                lista = null;
            }
            finally
            {
                _SqlConnection.Close();
            }
            return lista;
        }
    }
}
