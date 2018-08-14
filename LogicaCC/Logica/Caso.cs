using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.Logica
{
    public class Caso
    {
        public int      iIdCaso             { get; set; }
        public int      iIdUsuarioCreacion  { get; set; }
        public int      iIdUsuarioModifica   { get; set; }
        public string   sDescripcion        { get; set; }
        public string   sContadorNombre     { get; set; }
        public string   sContadorAPaterno   { get; set; }
        public string   sContadorAMaterno   { get; set; }
        public DateTime dtFechaCreacion     { get; set; }
        public DateTime dtFechaModifica     { get; set; }
        public string   sMotivo             { get; set; }
        public bool     bActivo             { get; set; }
        public string   sCliente            { get; set; }
        public string   sNombre             { get; set; }
        public string   sAPaterno           { get; set; }
        public string   sAMaterno           { get; set; }
        public string   sFechaCierre        { get; set; }

        public Caso()
        { }

        public List<Caso> LAbiertos (int iIdCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Caso> list = new List<Caso>();
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_CASO_ABIERTOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.Add("@IdCliente", SqlDbType.BigInt).Value = iIdCliente;

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            Caso cCaso = new Caso()
                            {
                                iIdCaso      = int.Parse(_sqlDataReader["IdCaso"].ToString()),
                                sMotivo      = _sqlDataReader["Motivo"].ToString(),
                                sDescripcion = _sqlDataReader["Descripcion"].ToString()
                            };
                            list.Add(cCaso);
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

        public Caso InformacionCaso(int iIdCaso)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                Caso caso = null;
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_CASO_ABIERTO_INFO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdCaso", iIdCaso);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if(_SqlDataReader.HasRows)
                    {
                        while(_SqlDataReader.Read())
                        {
                            caso = new Caso()
                            {
                                iIdCaso             = int.Parse(_SqlDataReader["IdCaso"].ToString()),
                                sDescripcion        = _SqlDataReader["Descripcion"].ToString(),
                                dtFechaCreacion     = DateTime.Parse(_SqlDataReader["FechaCreacion"].ToString()),
                                iIdUsuarioCreacion  = int.Parse(_SqlDataReader["IdUsuarioCreacion"].ToString()),
                                sContadorNombre     = _SqlDataReader["Nombre"].ToString(),
                                sContadorAPaterno   = _SqlDataReader["APaterno"].ToString(),
                                sContadorAMaterno   = _SqlDataReader["AMaterno"].ToString(),
                                sMotivo             = _SqlDataReader["Motivo"].ToString(),
                                bActivo             = bool.Parse(_SqlDataReader["Estado"].ToString()),
                                sCliente            = _SqlDataReader["Cliente"].ToString(),
                                sNombre             = _SqlDataReader["CNombre"].ToString(),
                                sAPaterno           = _SqlDataReader["CAPaterno"].ToString(),
                                sAMaterno           = _SqlDataReader["CAMaterno"].ToString(),
                                sFechaCierre        = _SqlDataReader["FechaCierre"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {

                    caso = null;
                }
                return caso;
            }
        }

        public bool bCerrarCaso(Caso caso)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPU_CASO_ACT_CIERRE", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdCaso", SqlDbType.BigInt).Value = caso.iIdCaso;
                _SqlCommand.Parameters.AddWithValue("@IdUsuarioModifica", SqlDbType.BigInt).Value = caso.iIdUsuarioModifica;

                var Resultado = _SqlCommand.Parameters.Add("@Id", SqlDbType.BigInt);
                Resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    var Resp = Resultado.Value;
                    if (int.Parse(Resp.ToString()) != 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<Caso> LTodosBusqueda(string sCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Caso> list = new List<Caso>();
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPS_CASO_TODOS_CL", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@Cliente", sCliente);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if (_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            Caso cCaso = new Caso()
                            {
                                iIdCaso  = int.Parse(_sqlDataReader["IdCaso"].ToString()),
                                bActivo  = bool.Parse(_sqlDataReader["Estado"].ToString()),
                                sCliente = _sqlDataReader["Cliente"].ToString()
                            };
                            list.Add(cCaso);
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

        public Caso ClienteCaso(int iIdCaso)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                Caso NoCliente = null;
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_NOCLIENTE_CASO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdCaso", iIdCaso);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            NoCliente = new Caso()
                            {
                                sCliente = _SqlDataReader["Cliente"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    NoCliente = null;
                }
                return NoCliente;
            }
        }
    }
}
