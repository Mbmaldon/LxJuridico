using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class Vendedor
    {
        public int      iIdVendedor         { get; set; }
        public int      iIdComisionista     { get; set; }
        public int      iIdNivel            { get; set; }
        public string   sVendedor           { get; set; }
        public int      iActivo             { get; set; }
        public string   sNombre             { get; set; }
        public string   sAPaterno           { get; set; }
        public string   sAMaterno           { get; set; }
        public string   sRfc                { get; set; }
        public string   sDireccion          { get; set; }
        public string   sMunicipio          { get; set; }
        public string   sEstado             { get; set; }
        public string   sCodigoPostal       { get; set; }
        public string   sTelefono           { get; set; }
        public string   sExtension          { get; set; }
        public string   sMovil              { get; set; }
        public string   sCorreoElectronico  { get; set; }
        public string   sCurp               { get; set; }
        public string   sNoExpediente       { get; set; }

        public string   sNivel      { get; set; }
        public decimal  dComision   { get; set; }
        public decimal  dVariacion  { get; set; }
        public string   dImporte    { get; set; }

        public Vendedor()
        {
            this.iIdVendedor        = 0;
            this.iIdComisionista    = 0;
            this.iIdNivel           = 0;
            this.sVendedor          = string.Empty;
            this.iActivo            = 0;
            this.sNombre            = string.Empty;
            this.sAPaterno          = string.Empty;
            this.sAMaterno          = string.Empty;
            this.sRfc               = string.Empty;
            this.sDireccion         = string.Empty;
            this.sMunicipio         = string.Empty;
            this.sEstado            = string.Empty;
            this.sCodigoPostal      = string.Empty;
            this.sTelefono          = string.Empty;
            this.sExtension         = string.Empty;
            this.sMovil             = string.Empty;
            this.sCorreoElectronico = string.Empty;
            this.sCurp              = string.Empty;
            this.sNoExpediente      = string.Empty;

            this.sNivel         = string.Empty;
            this.dComision      = 0;
            this.dVariacion     = 0;
            this.dImporte       = "0";
        }

        /// <summary>
        /// Método Público que regresa información de un vendedor
        /// </summary>
        /// <param name="vendedor">Clave del vendedor</param>
        /// <returns></returns>
        public Vendedor busquedaVendedor(string vendedor)
        {
            //CREAMOS UN NUEVO OBJETO DE TIPO VENDEDOR
            Vendedor vVendedor              = null;
            //CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            //SqlConnection _sqlConnection    = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection    = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand          = new SqlCommand("LSOSPS_Busqueda_Vendedor", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            //PASAMOS COMO PARAMETRO A LA CONSULTA, LA CLAVE DEL VENDEDOR
            _sqlCommand.Parameters.Add("@vendedor", SqlDbType.NVarChar, 45).Value = vendedor;

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
                        //INICIALIZAMOS NUESTRO OBJETO VENDEDOR Y ASIGNAMOS INFORMACIÓN
                        vVendedor = new Vendedor()
                        {
                            sVendedor           = _sqlDataReader["Vendedor"].ToString(),
                            iIdComisionista     = int.Parse(_sqlDataReader["IdComisionista"].ToString()),
                            iIdNivel            = int.Parse(_sqlDataReader["IdNivel"].ToString()),
                            iActivo             = int.Parse(_sqlDataReader["Activo"].ToString()),
                            sNombre             = _sqlDataReader["Nombre"].ToString(),
                            sAPaterno           = _sqlDataReader["APaterno"].ToString(),
                            sAMaterno           = _sqlDataReader["AMaterno"].ToString(),
                            sRfc                = _sqlDataReader["RFC"].ToString(),
                            sDireccion          = _sqlDataReader["Direccion"].ToString(),
                            sMunicipio          = _sqlDataReader["Municipio"].ToString(),
                            sEstado             = _sqlDataReader["Estado"].ToString(),
                            sCodigoPostal       = _sqlDataReader["CodigoPostal"].ToString(),
                            sTelefono           = _sqlDataReader["Telefono"].ToString(),
                            sExtension          = _sqlDataReader["Extension"].ToString(),
                            sMovil              = _sqlDataReader["Movil"].ToString(),
                            sCorreoElectronico  = _sqlDataReader["CorreoElectronico"].ToString(),
                            sCurp               = _sqlDataReader["Curp"].ToString(),
                            sNoExpediente       = _sqlDataReader["NoExpediente"].ToString()
                        };
                    }
                }
            }
            catch (Exception)
            {
                vVendedor = null;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return vVendedor;
        }

        /// <summary>
        /// Método Público que regresa una lista de comisionistas mayores
        /// a un nivel que es pasado como parametro
        /// </summary>
        /// <param name="idNivel">ID del nivel</param>
        /// <returns></returns>
        public List<Vendedor> listaComisionistas(int idNivel)
        {
            //CREAMOS UNA LISTA DE VENDEDORES
            List<Vendedor> lista            = new List<Vendedor>();
            //CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            //SqlConnection _sqlConnection    = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection    = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand          = new SqlCommand("LSOSPS_Seleccionar_Comisionistas", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            //PASAMOS COMO PARAMETRO A LA CONSULTA, UN ID DE NIVEL
            _sqlCommand.Parameters.Add("@idNivel", SqlDbType.BigInt).Value = idNivel;

            try
            {
                //ABRIMOS NUESTRA CONEXIÓN
                _sqlConnection.Open();
                //EXECUTAMOS NUESTRA CONSULTA
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        //CREAMOS UN NUEVO OBJETO VENDEDOR Y LO AGREGAMOS A LA LISTA
                        Vendedor comisionista = new Vendedor()
                        {
                            iIdComisionista = int.Parse(_sqlDataReader["IdCliente"].ToString()),
                            sNombre         = _sqlDataReader["Nombre"].ToString()
                        };
                        lista.Add(comisionista);
                    }
                }
            }
            catch (Exception)
            {
                lista = null;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return lista;
        }
    }
}
