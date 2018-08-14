using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class Categoria
    {
        public int    iIdCategoria      { get; set; }
        public int    iIdSubcategoria   { get; set; }
        public string sCategoria        { get; set; }
        public string sSubcategoria     { get; set; }

        public List<Categoria> lCatergorias()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Categoria> lista = new List<Categoria>();
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_CATEGORIAS", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Categoria categoria = new Categoria()
                            {
                                iIdCategoria = int.Parse(_SqlDataReader["IdCategoria"].ToString()),
                                sCategoria   = _SqlDataReader["Categoria"].ToString()
                            };
                            lista.Add(categoria);
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

        public List<Categoria> lSubcategorias(int iIdCategoria)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Categoria> lista = new List<Categoria>();
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_SUBCATEGORIAS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdCategoria", iIdCategoria);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Categoria subcategoria = new Categoria()
                            {
                                iIdSubcategoria = int.Parse(_SqlDataReader["IdSubcategoria"].ToString()),
                                sSubcategoria   = _SqlDataReader["Subcategoria"].ToString()
                            };
                            lista.Add(subcategoria);
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

        public Categoria CategoriaCliente(string sNoCliente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                Categoria categoria = null;
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_SUBCATEGORIA_CLIENTE", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@Cliente", sNoCliente);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            categoria = new Categoria()
                            {
                                iIdCategoria    = int.Parse(_SqlDataReader["IdCategoria"].ToString()),
                                iIdSubcategoria = int.Parse(_SqlDataReader["IdSubcategoria"].ToString())
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    categoria = null;
                }
                return categoria;
            }
        }

        public int iAsignarCategoria(string sNoCliente, int iIdSubcategoria)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPU_SUBCATEGORIA_CLIENTE", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@Cliente", sNoCliente);
                _SqlCommand.Parameters.AddWithValue("@IdSubcategoria", iIdSubcategoria);

                var parameterReturn       = _SqlCommand.Parameters.Add("@resultado", SqlDbType.Int);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return int.Parse(parameterReturn.Value.ToString());
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
    }
}
