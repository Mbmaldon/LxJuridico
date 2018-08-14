using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class PapelTrabajo
    {
        //PROPIEDADES PAPEL DE TRABAJO
        public int       iIdVendedor                    { get; set; }
        public int       iIdTipoFactura                 { get; set; }
        public decimal   dPorcentajeComision            { get; set; }
        public int       iPuntosBeneficio               { get; set; }
        public decimal   dPorcentajeComisionVenta       { get; set; }
        public decimal   dPorcentajeComisionMultinivel  { get; set; }
        public decimal   dPorcentajeUtilidadEstimadaIW  { get; set; }

        //PROPIEDADES OPERACIONES
        public string    sNoOperacion           { get; set; }
        public decimal   dImporte               { get; set; }
        public string    sNoFactura             { get; set; }
        public DateTime  dtFechaFactura         { get; set; }
        public DateTime  dtFechaDeposito        { get; set; }
        public decimal   dBeneficio             { get; set; }
        public decimal   dComisionGlobalVenta   { get; set; }
        public decimal   dCostoFiscalIsr        { get; set; }
        public decimal   dImporteNegocio        { get; set; }
        public int       iIdUsuario             { get; set; }

        public string    sUUID                  { get; set; }
        public string    sCliente               { get; set; }

        public PapelTrabajo()
        {
            iIdVendedor                    = 0;
            iIdTipoFactura                 = 0;
            dPorcentajeComision            = 0;
            iPuntosBeneficio               = 0;
            dPorcentajeComisionVenta       = 0;
            dPorcentajeComisionMultinivel  = 0;
            dPorcentajeUtilidadEstimadaIW  = 0;

            sNoOperacion           = string.Empty;
            dImporte               = 0;
            sNoFactura             = string.Empty;
            dtFechaFactura         = DateTime.Now;
            dtFechaDeposito        = DateTime.Now;
            dBeneficio             = 0;
            dComisionGlobalVenta   = 0;
            dCostoFiscalIsr        = 0;
            dImporteNegocio        = 0;

            sUUID                  = string.Empty;
            sCliente               = string.Empty;
        }

        /// <summary>
        /// Método Público para crear un nuevo papel de trabajo
        /// </summary>
        /// <param name="_papelTrabajo">Objeto de tipo PapelTrabajo que contiene sus propiedades</param>
        /// <returns></returns>
        public int CrearPapelTrabajo(PapelTrabajo _papelTrabajo)
        {
            //bool bPapelTrabajo = false;
            //CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            //SqlConnection _sqlConnection    = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection    = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand          = new SqlCommand("LSOSPI_Insertar_PapelDeTrabajo", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            //PASAMOS COMO PARAMETRO A LA CONSULTA, LOS DATOS QUE SE GUARDARAN EN EL PAPEL DE TRABAJO
            _sqlCommand.Parameters.Add("@IdVendedor", SqlDbType.BigInt).Value                       = _papelTrabajo.iIdVendedor;
            _sqlCommand.Parameters.Add("@IdTipoFactura", SqlDbType.Int).Value                       = _papelTrabajo.iIdTipoFactura;

            //PASAMOS COMO PARAMETRO A LA CONSULTA, LOS DATOS QUE SE GUARDARAN EN LA OPERACIÓN
            _sqlCommand.Parameters.Add("@NoOperacion", SqlDbType.NVarChar, 45).Value        = _papelTrabajo.sNoOperacion;
            _sqlCommand.Parameters.Add("@Importe", SqlDbType.Money).Value                   = _papelTrabajo.dImporte;
            _sqlCommand.Parameters.Add("@NoFactura", SqlDbType.NVarChar, 45).Value          = _papelTrabajo.sNoFactura;
            _sqlCommand.Parameters.Add("@FechaFactura", SqlDbType.DateTime).Value           = _papelTrabajo.dtFechaFactura;
            _sqlCommand.Parameters.Add("@FechaDeposito", SqlDbType.DateTime).Value          = _papelTrabajo.dtFechaDeposito;
            _sqlCommand.Parameters.Add("@IdUsuario", SqlDbType.BigInt).Value                = _papelTrabajo.iIdUsuario;
            _sqlCommand.Parameters.Add("@UUID", SqlDbType.NVarChar, 50).Value               = _papelTrabajo.sUUID;

            var parameterReturn = _sqlCommand.Parameters.Add("@Status", SqlDbType.Int);
            parameterReturn.Direction = ParameterDirection.ReturnValue;

            try
            {
                //ABRIMOS LA CONEXIÓN
                _sqlConnection.Open();
                //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                _sqlCommand.ExecuteNonQuery();
                return int.Parse(parameterReturn.Value.ToString());
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                _sqlConnection.Close();
            }

            //return bPapelTrabajo;
        }

        /// <summary>
        /// Inserta facturas de forma masiva, pasando como parametro el número de cliente en lugar de su ID.
        /// </summary>
        /// <param name="_Factura">Objeto de tipo PapelTrabajo que contiene sus propiedades</param>
        /// <returns></returns>
        public int iCargaFacturasBatch(PapelTrabajo _Factura)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                SqlCommand _SqlCommand = new SqlCommand("LSOSPI_Insertar_PapelDeTrabajo_Batch", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@Cliente",       _Factura.sCliente);
                _SqlCommand.Parameters.AddWithValue("@IdTipoFactura", _Factura.iIdTipoFactura);
                _SqlCommand.Parameters.AddWithValue("@NoOperacion",   _Factura.sNoOperacion);
                _SqlCommand.Parameters.AddWithValue("@Importe",       _Factura.dImporte);
                _SqlCommand.Parameters.AddWithValue("@NoFactura",     _Factura.sNoFactura);
                _SqlCommand.Parameters.AddWithValue("@FechaFactura",  _Factura.dtFechaFactura);
                _SqlCommand.Parameters.AddWithValue("@FechaDeposito", _Factura.dtFechaDeposito);
                _SqlCommand.Parameters.AddWithValue("@UUID",          _Factura.sUUID);

                var parameterReturn       = _SqlCommand.Parameters.Add("@Status", SqlDbType.Int);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return int.Parse(parameterReturn.Value.ToString());
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
    }
}
