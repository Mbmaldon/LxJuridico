using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace LogicaCC.LexaSIOOperLogica
{
    public class OperacionComisionista
    {
        public int       iIdOperacion                   { get; set; }
        public string    sNoFactura                     { get; set; }
        public string    sFechaFactura                  { get; set; }
        public string    sFechaDeposito                 { get; set; }
        public decimal   dImporte                       { get; set; }
        public decimal   dPorcentajeComision            { get; set; }
        public decimal   dBeneficio                     { get; set; }
        public string    sNombre                        { get; set; }
        public string    sVendedor                      { get; set; }
        public int       iVentas                        { get; set; }
        public int       iPagadas                       { get; set; }
        public int       iIdCliente                     { get; set; }

        public string  sRfc         { get; set; }
        public string  sUUID        { get; set; }
        public string  sConcepto    { get; set; }
        public decimal dDescuento   { get; set; }
        public string  sMoneda      { get; set; }
        public string  sEstatus     { get; set; }
        public string  sNoOperacion { get; set; }
        public int     iAnio        { get; set; }

        public string    sNivel                         { get; set; }
        public decimal   dPorcentajeGlobalComisionVenta { get; set; }
        public decimal   dComisionGlobalVenta           { get; set; }
        public decimal   dCostoFiscalIsr                { get; set; }
        public decimal   dComisionNivel0                { get; set; }
        public decimal   dComisionNivel1                { get; set; }
        public decimal   dComisionNivel2                { get; set; }
        public decimal   dComisionNivel3                { get; set; }
        public decimal   dImporteNegocio                { get; set; }
        public OperacionComisionista()
        {
            iIdOperacion                   = 0;
            sNoFactura                     = string.Empty;
            sFechaFactura                  = string.Empty;
            sFechaDeposito                 = string.Empty;
            dImporte                       = 0;
            dPorcentajeComision            = 0;
            dBeneficio                     = 0;
            sNombre                        = string.Empty;
            sNivel                         = string.Empty;
            dPorcentajeGlobalComisionVenta = 0;
            dComisionGlobalVenta           = 0;
            dCostoFiscalIsr                = 0;
            dComisionNivel0                = 0;
            dComisionNivel1                = 0;
            dComisionNivel2                = 0;
            dComisionNivel3                = 0;
            dImporteNegocio                = 0;

            sRfc         = string.Empty;
            sUUID        = string.Empty;
            sConcepto    = string.Empty;
            dDescuento   = 0;
            sMoneda      = string.Empty;
            sEstatus     = string.Empty;
            sNoOperacion = string.Empty;
            iAnio        = 0;
        }

        /// <summary>
        /// Método Público que regresa una lista de comisionistas
        /// </summary>
        /// <returns></returns>
        public List<OperacionComisionista> ListaComisionistas(int iNoSemana, int iIdTipoFactura, int iActiva, int iAnio)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera)) // CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            {
                List<OperacionComisionista> lista = new List<OperacionComisionista>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_Comisiones", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@NoSemana", iNoSemana);
                _SqlCommand.Parameters.AddWithValue("@IdTipoFactura", iIdTipoFactura);
                _SqlCommand.Parameters.AddWithValue("@Activa", iActiva);
                _SqlCommand.Parameters.AddWithValue("@Anio", iAnio);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            OperacionComisionista item = new OperacionComisionista()
                            {
                                iIdOperacion   = int.Parse(_SqlDataReader["IdOperacion"].ToString()),
                                sNoFactura     = _SqlDataReader["NoFactura"].ToString(),
                                sFechaFactura  = _SqlDataReader["FechaFactura"].ToString()  == "" ? "NO APLICA POR PROMOCIÓN" : _SqlDataReader["FechaFactura"].ToString(),
                                sFechaDeposito = _SqlDataReader["FechaDeposito"].ToString() == "" ? "NO APLICA POR PROMOCIÓN" : _SqlDataReader["FechaDeposito"].ToString(),
                                dImporte       = decimal.Parse(_SqlDataReader["Importe"].ToString()),
                                sNombre        = _SqlDataReader["Nombre"].ToString(),
                                sVendedor      = _SqlDataReader["Vendedor"].ToString(),
                                iVentas        = int.Parse(_SqlDataReader["Ventas"].ToString()),
                                iPagadas       = int.Parse(_SqlDataReader["Pagadas"].ToString()),
                                sRfc           = _SqlDataReader["RFC"].ToString(),
                                sUUID          = _SqlDataReader["UUID"].ToString(),
                                sConcepto      = _SqlDataReader["Concepto"].ToString(),
                                dDescuento     = decimal.Parse(_SqlDataReader["Descuento"].ToString()),
                                sMoneda        = _SqlDataReader["Moneda"].ToString(),
                                sEstatus       = _SqlDataReader["Estatus"].ToString(),
                                sNoOperacion   = _SqlDataReader["NoOperacion"].ToString()
                            };
                            lista.Add(item);
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

        public OperacionComisionista OperacionInf(OperacionComisionista _OpeCom)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                OperacionComisionista informacion = null;
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_Operacion ", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("IdOperacion", _OpeCom.iIdOperacion);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            informacion = new OperacionComisionista()
                            {
                                sNoFactura     = _SqlDataReader["NoFactura"].ToString(),
                                dImporte       = decimal.Parse(_SqlDataReader["Importe"].ToString()),
                                sFechaFactura  = _SqlDataReader["FechaFactura"].ToString(),
                                sFechaDeposito = _SqlDataReader["FechaDeposito"].ToString(),
                                sNombre        = _SqlDataReader["Cliente"].ToString(),
                                sVendedor      = _SqlDataReader["Vendedor"].ToString(),
                                iIdCliente     = int.Parse(_SqlDataReader["IdCliente"].ToString())
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    informacion = null;
                }
                return informacion;
            }
        }

        public List<OperacionComisionista> lAnios()
        {
            using (SqlConnection _SqlConnetion = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                List<OperacionComisionista> anios = new List<OperacionComisionista>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_Anios_Facturas", _SqlConnetion) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnetion.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            OperacionComisionista anio = new OperacionComisionista()
                            {
                                iAnio = int.Parse(_SqlDataReader["Anio"].ToString())
                            };
                            anios.Add(anio);
                        }
                    }
                }
                catch (Exception)
                {
                    anios = null;
                }
                return anios;
            }
        }
    }
}
