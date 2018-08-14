using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LogicaCC.LexaSIOOperLogica
{
    public class InformacionVendedor
    {
        public string sNumVendedor          { get; set; }
        public string sRfc                  { get; set; }
        public string sActivo               { get; set; }
        public string sNombre               { get; set; }
        public string sAPaterno             { get; set; }
        public string sAMaterno             { get; set; }
        public string sDireccion            { get; set; }
        public string sMunicipio            { get; set; }
        public string sEstado               { get; set; }
        public string sCodigoPostal         { get; set; }
        public string sTelefono             { get; set; }
        public string sExtension            { get; set; }
        public string sMovil                { get; set; }
        public string sCorreoElectronico    { get; set; }
        public string sNivel                { get; set; }
        public string sComisionista         { get; set; }

        public InformacionVendedor()
        {
            sNumVendedor       = string.Empty;
            sRfc               = string.Empty;
            sActivo            = string.Empty;
            sNombre            = string.Empty;
            sAPaterno          = string.Empty;
            sAMaterno          = string.Empty;
            sDireccion         = string.Empty;
            sMunicipio         = string.Empty;
            sEstado            = string.Empty;
            sCodigoPostal      = string.Empty;
            sTelefono          = string.Empty;
            sExtension         = string.Empty;
            sMovil             = string.Empty;
            sCorreoElectronico = string.Empty;
            sNivel             = string.Empty;
            sComisionista      = string.Empty;
        }

        /// <summary>
        /// Método público para obtener información de un vendedor pasando como parametro su ID (Clave).
        /// </summary>
        /// <param name="_vendedor">Clave del vendedor.</param>
        /// <returns></returns>
        public InformacionVendedor detalleVendedor(string _vendedor)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                InformacionVendedor vendedor = null;
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Informacion_Vendedor", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, LA CLAVE DEL VENDEDOR
                _SqlCommand.Parameters.AddWithValue("@Vendedor", _vendedor);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            vendedor = new InformacionVendedor()
                            {
                                sNumVendedor       = _SqlDataReader["Vendedor"].ToString(),
                                sRfc               = _SqlDataReader["RFC"].ToString(),
                                sActivo            = _SqlDataReader["Activo"].ToString(),
                                sNombre            = _SqlDataReader["Nombre"].ToString(),
                                sAPaterno          = _SqlDataReader["APaterno"].ToString(),
                                sAMaterno          = _SqlDataReader["AMaterno"].ToString(),
                                sDireccion         = _SqlDataReader["Direccion"].ToString(),
                                sMunicipio         = _SqlDataReader["Municipio"].ToString(),
                                sEstado            = _SqlDataReader["Estado"].ToString(),
                                sCodigoPostal      = _SqlDataReader["CodigoPostal"].ToString(),
                                sTelefono          = _SqlDataReader["Telefono"].ToString(),
                                sExtension         = _SqlDataReader["Extension"].ToString(),
                                sMovil             = _SqlDataReader["Movil"].ToString(),
                                sCorreoElectronico = _SqlDataReader["CorreoElectronico"].ToString(),
                                sNivel             = _SqlDataReader["Nivel"].ToString(),
                                sComisionista      = _SqlDataReader["Comisionista"].ToString()
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    vendedor = null;
                }
                return vendedor;
            }
        }
    }
}
