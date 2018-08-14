using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class VendedorBusqueda
    {
        public string   sCliente       { get; set; }
        public int      iIdCliente     { get; set; }
        //public int      iIdComisionista { get; set; }
        //public int      iIdNivel        { get; set; }
        public string   sActivo         { get; set; }
        public string   sNombreCliente  { get; set; }
        public int      iIdVendedor     { get; set; }
        public string   sNombreVendedor { get; set; }
        //public string   sNivel          { get; set; }
        //public decimal  dComision       { get; set; }
        //public decimal  dVariacion      { get; set; }

        //public int       iIdPapelTrabajo                { get; set; }
        //public decimal   dPorcentajeComision            { get; set; }
        //public decimal   dPuntosBeneficio               { get; set; }
        //public decimal   dPorcentajeGlobalComisionVenta { get; set; }
        //public decimal   dPorcentajeUtilidadEstamadaIW  { get; set; }

        public VendedorBusqueda()
        {
            this.sCliente          = string.Empty;
            this.iIdCliente        = 0;
            //this.iIdComisionista    = 0;
            //this.iIdNivel           = 0;
            this.sActivo            = string.Empty;
            this.sNombreCliente     = string.Empty;
            this.iIdVendedor        = 0;
            this.sNombreVendedor    = string.Empty;
            //this.sNivel             = string.Empty;
            //this.dComision          = 0;
            //this.dVariacion         = 0;


            //this.iIdPapelTrabajo                = 0;
            //this.dPorcentajeComision            = 0;
            //this.dPuntosBeneficio               = 0;
            //this.dPorcentajeGlobalComisionVenta = 0;
            //this.dPorcentajeUtilidadEstamadaIW  = 0;
        }

        /// <summary>
        /// Método Público que regresa inforación de un vendedor pasando
        /// como parametro la clave del vendedor
        /// </summary>
        /// <param name="sVendedor">Clave del vendedor</param>
        /// <returns></returns>
        public VendedorBusqueda busquedaVendedor(string sVendedor)
        {
            //CREAMOS UN NUEVO OBJETO DE TIPO VENDEDORBUSQUEDA
            VendedorBusqueda vendedor       = null;
            //CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            //SqlConnection _sqlConnection    = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection    = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand          = new SqlCommand("LSOSPS_Busqueda_VendedorPT", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            //PASAMOS COMO PARAMETRO A LA CONSULTA, LA CLAVE DEL VENDEDOR
            _sqlCommand.Parameters.Add("@vendedor", SqlDbType.NVarChar, 45).Value = sVendedor;

            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        //INICIALIZAMOS EL OBJETO VENDEDOR Y ASIGNAMOS INFORMACIÓNA SUS PROPIEDADES
                        vendedor = new VendedorBusqueda()
                        {
                            sCliente        = _sqlDataReader["Cliente"].ToString(),
                            iIdCliente      = int.Parse(_sqlDataReader["IdCliente"].ToString()),
                            sActivo         = _sqlDataReader["Activo"].ToString(),
                            sNombreCliente  = _sqlDataReader["Nombre"].ToString(),
                            iIdVendedor     = int.Parse(_sqlDataReader["IdVendedor"].ToString()),
                            sNombreVendedor = _sqlDataReader["Vendedor"].ToString()
                        };
                    }
                }
            }
            catch
            {
                vendedor = null;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return vendedor;
        }
    }
}
