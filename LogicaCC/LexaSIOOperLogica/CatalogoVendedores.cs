using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class CatalogoVendedores
    {
        public int      iIdCliente      { get; set; }
        public string   sVendedor       { get; set; }
        public string   sNombre         { get; set; }
        public string   sNivel          { get; set; }
        public decimal  dImporte        { get; set; }
        public decimal  dPorcentaje     { get; set; }
        public string   sNoOperacion    { get; set; }

        public CatalogoVendedores()
        {
            this.iIdCliente     = 0;
            this.sVendedor      = string.Empty;
            this.sNombre        = string.Empty;
            this.sNivel         = string.Empty;
            this.dImporte       = 0;
            this.dPorcentaje    = 0;
            this.sNoOperacion   = string.Empty;
        }

        /// <summary>
        /// Método público que regresa una lista de vendedores
        /// </summary>
        /// <returns></returns>
        public List<CatalogoVendedores> listaCatalogoVendedores()
        {
            //CREAMOS UNA LISTA DE VENDEDORES
            List<CatalogoVendedores> lista = new List<CatalogoVendedores>();
            //CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            //SqlConnection _sqlConnection    = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand          = new SqlCommand("LSOSPS_Seleccionar_CVendedores", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            try
            {
                //ABRIMOS NUESTRA CONEXIÓN
                _sqlConnection.Open();
                //EJECUTAMOS NUESTRA CONSULTA
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        //CREAMOS UN NUEVO OBJETO VENDEDOR Y LO AGREGAMOS A UNA LISTA
                        CatalogoVendedores vendedor = new CatalogoVendedores()
                        {
                            iIdCliente      = int.Parse(_sqlDataReader["IdCliente"].ToString()),
                            sVendedor       = _sqlDataReader["Vendedor"].ToString(),
                            sNombre         = _sqlDataReader["Nombre"].ToString(),
                            sNivel          = _sqlDataReader["Nivel"].ToString(),
                            dImporte        = decimal.Parse(_sqlDataReader["Importe"].ToString()),
                            dPorcentaje     = decimal.Parse(_sqlDataReader["Porcentaje"].ToString()) / 100,
                            sNoOperacion    = _sqlDataReader["NoOperacion"].ToString()
                        };
                        lista.Add(vendedor);
                    }
                }
            }
            catch (Exception)
            {
                lista = null;
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return lista;
        }
    }
}
