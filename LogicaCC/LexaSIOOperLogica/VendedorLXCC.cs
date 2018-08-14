using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace LogicaCC.LexaSIOOperLogica
{
    public class VendedorLXCC
    {
        public string   sCliente             { get; set; }
        public int      iIdEstado            { get; set; }
        public int      iIdUsuario           { get; set; }
        public string   sNombre              { get; set; }
        public string   sAPaterno            { get; set; }
        public string   sAMaterno            { get; set; }
        public string   sRFC                 { get; set; }
        public string   sDireccion           { get; set; }
        public string   sMunicipio           { get; set; }
        public string   sCP                  { get; set; }
        public string   sTelefonoL           { get; set; }
        public string   sExtension           { get; set; }
        public string   sTelefonoM           { get; set; }
        public string   sCorreoE             { get; set; }
        public int      iIdServEstatus       { get; set; }
        public int      iIdServicioTipo      { get; set; }
        public string   sFechaContr          { get; set; }
        public string   sFechaVenci          { get; set; }
        public int      iIdContadorAsignado  { get; set; }
        public string   sNombreC1            { get; set; }
        public string   sAPaternoC1          { get; set; }
        public string   sAMaternoC1          { get; set; }
        public string   sTelefonoLC1         { get; set; }
        public string   sExtensionC1         { get; set; }
        public string   sTelefonoMC1         { get; set; }
        public string   sCorreoEC1           { get; set; }
        public string   sNombreC2            { get; set; }
        public string   sAPaternoC2          { get; set; }
        public string   sAMaternoC2          { get; set; }
        public string   sTelefonoLC2         { get; set; }
        public string   sExtensionC2         { get; set; }
        public string   sTelefonoMC2         { get; set; }
        public string   sCorreoEC2           { get; set; }
                                             
        public string   sServicioConta       { get; set; }
        public string   sServicioOD          { get; set; }
        public int      iIdComisionista      { get; set; }
        public int      iIdNivel             { get; set; }
                                             
        public string   sCURP                { get; set; }
        public string   sNoExpediente        { get; set; }



        public VendedorLXCC()
        {
            this.sCliente               = string.Empty;
            this.iIdEstado              = 0;
            this.iIdUsuario             = 0;
            this.sNombre                = string.Empty;
            this.sAPaterno              = string.Empty;
            this.sAMaterno              = string.Empty;
            this.sRFC                   = string.Empty;
            this.sDireccion             = string.Empty;
            this.sMunicipio             = string.Empty;
            this.sCP                    = string.Empty;
            this.sTelefonoL             = string.Empty;
            this.sExtension             = string.Empty;
            this.sTelefonoM             = string.Empty;
            this.sCorreoE               = string.Empty;
            this.iIdServEstatus         = 0;
            this.iIdServicioTipo        = 0;
            this.sFechaContr            = string.Empty;
            this.sFechaVenci            = string.Empty;
            this.iIdContadorAsignado    = 0;
            this.sNombreC1              = string.Empty;
            this.sAPaternoC1            = string.Empty;
            this.sAMaternoC1            = string.Empty;
            this.sTelefonoLC1           = string.Empty;
            this.sExtensionC1           = string.Empty;
            this.sTelefonoMC1           = string.Empty;
            this.sCorreoEC1             = string.Empty;
            this.sNombreC2              = string.Empty;
            this.sAPaternoC2            = string.Empty;
            this.sAMaternoC2            = string.Empty;
            this.sTelefonoLC2           = string.Empty;
            this.sExtensionC2           = string.Empty;
            this.sTelefonoMC2           = string.Empty;
            this.sCorreoEC2             = string.Empty;
            this.sServicioConta         = string.Empty;
            this.sServicioOD            = string.Empty;
            this.iIdComisionista        = 0;
            this.iIdNivel               = 0;

            this.sCURP                  = string.Empty;
            this.sNoExpediente          = string.Empty;
        }



        public bool registroVendedor(VendedorLXCC vendedor)
        {
            bool bVenededor                 = false;
            //CREAMOS UNA NUEVA CONEXIÓN Y UN COMANDO PARA PASAR UNA CONSULTA
            //SqlConnection _sqlConnection    = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
            SqlConnection _sqlConnection    = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand          = new SqlCommand("LXCCSPU_ALTA_ACT_CLIENTE", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            //PASAMOS COMO PARAMETRO A LA CONSULTA, LOS DATOS REQUERIDOS PARA GUARDAR AL NUEVO VENDEDOR
            _sqlCommand.Parameters.Add("@Cliente", SqlDbType.NVarChar, 45).Value        = vendedor.sCliente;
            _sqlCommand.Parameters.Add("@IdEstado", SqlDbType.BigInt).Value             = vendedor.iIdEstado;
            _sqlCommand.Parameters.Add("@IdUsuario", SqlDbType.BigInt).Value            = vendedor.iIdUsuario;
            _sqlCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 45).Value         = vendedor.sNombre;
            _sqlCommand.Parameters.Add("@APaterno",SqlDbType.NVarChar, 45).Value        = vendedor.sAPaterno;
            _sqlCommand.Parameters.Add("@AMaterno",SqlDbType.NVarChar, 45).Value        = vendedor.sAMaterno;
            _sqlCommand.Parameters.Add("@RFC", SqlDbType.NVarChar, 45).Value            = vendedor.sRFC;
            _sqlCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar, 250).Value     = vendedor.sDireccion;
            _sqlCommand.Parameters.Add("@Municipio", SqlDbType.NVarChar, 45).Value      = vendedor.sMunicipio;
            _sqlCommand.Parameters.Add("@CP", SqlDbType.NVarChar, 45).Value             = vendedor.sCP;
            _sqlCommand.Parameters.Add("@TelefonoL", SqlDbType.NVarChar, 45).Value      = vendedor.sTelefonoL;
            _sqlCommand.Parameters.Add("@Extension", SqlDbType.NVarChar, 45).Value      = vendedor.sExtension;
            _sqlCommand.Parameters.Add("@TelefonoM", SqlDbType.NVarChar, 45).Value      = vendedor.sTelefonoM;
            _sqlCommand.Parameters.Add("@CorreoE", SqlDbType.NVarChar, 45).Value        = vendedor.sCorreoE;
            _sqlCommand.Parameters.Add("@IdServEstatus", SqlDbType.BigInt).Value        = vendedor.iIdServEstatus;
            _sqlCommand.Parameters.Add("@idServicioTipo", SqlDbType.BigInt).Value       = vendedor.iIdServicioTipo;
            _sqlCommand.Parameters.Add("@FechaContr", SqlDbType.DateTime).Value         = vendedor.sFechaContr;
            _sqlCommand.Parameters.Add("@FechaVenci", SqlDbType.DateTime).Value         = vendedor.sFechaVenci;
            _sqlCommand.Parameters.Add("@IdContadorAsignado", SqlDbType.BigInt).Value   = vendedor.iIdContadorAsignado;
            _sqlCommand.Parameters.Add("@NombreC1", SqlDbType.NVarChar, 45).Value       = vendedor.sNombreC1;
            _sqlCommand.Parameters.Add("@APaternoC1", SqlDbType.NVarChar, 45).Value     = vendedor.sAPaternoC1;
            _sqlCommand.Parameters.Add("@AMaternoC1", SqlDbType.NVarChar, 45).Value     = vendedor.sAMaternoC1;
            _sqlCommand.Parameters.Add("@TelefonoLC1", SqlDbType.NVarChar, 45).Value    = vendedor.sTelefonoLC1;
            _sqlCommand.Parameters.Add("@ExtensionC1", SqlDbType.NVarChar, 45).Value    = vendedor.sExtensionC1;
            _sqlCommand.Parameters.Add("@TelefonoMC1", SqlDbType.NVarChar, 45).Value    = vendedor.sTelefonoMC1;
            _sqlCommand.Parameters.Add("@CorreoEC1", SqlDbType.NVarChar, 45).Value      = vendedor.sCorreoEC1;
            _sqlCommand.Parameters.Add("@NombreC2", SqlDbType.NVarChar, 45).Value       = vendedor.sNombreC2;
            _sqlCommand.Parameters.Add("@APaternoC2", SqlDbType.NVarChar, 45).Value     = vendedor.sAPaternoC2;
            _sqlCommand.Parameters.Add("@AMaternoC2", SqlDbType.NVarChar, 45).Value     = vendedor.sAMaternoC2;
            _sqlCommand.Parameters.Add("@TelefonoLC2", SqlDbType.NVarChar, 45).Value    = vendedor.sTelefonoLC2;
            _sqlCommand.Parameters.Add("@ExtensionC2", SqlDbType.NVarChar, 45).Value    = vendedor.sExtensionC2;
            _sqlCommand.Parameters.Add("@TelefonoMC2", SqlDbType.NVarChar, 45).Value    = vendedor.sTelefonoMC2;
            _sqlCommand.Parameters.Add("@CorreoEC2", SqlDbType.NVarChar, 45).Value      = vendedor.sCorreoEC2;
            _sqlCommand.Parameters.Add("@ServicioConta", SqlDbType.Bit).Value           = vendedor.sServicioConta;
            _sqlCommand.Parameters.Add("@ServicioOD", SqlDbType.Bit).Value              = vendedor.sServicioOD;
            _sqlCommand.Parameters.Add("@IdComisionista", SqlDbType.Int).Value          = vendedor.iIdComisionista;
            _sqlCommand.Parameters.Add("@IdNivel", SqlDbType.Int).Value                 = vendedor.iIdNivel;
            _sqlCommand.Parameters.Add("@CURP", SqlDbType.NVarChar, 45).Value           = vendedor.sCURP;
            _sqlCommand.Parameters.Add("@NoExpediente", SqlDbType.NVarChar, 45).Value   = vendedor.sNoExpediente;
            _sqlCommand.Parameters.Add("@Resultado", SqlDbType.BigInt).Value            = 0;

            try
            {
                //ABRIMOS NUESTRA CONEXIÓN
                _sqlConnection.Open();
                //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                bVenededor = (_sqlCommand.ExecuteNonQuery() == 0 ? true : false);
            }
            catch (Exception)
            {
                bVenededor = false;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return bVenededor;
        }


        public List<VendedorLXCC> clientesInactivos()
        {
            //using (SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString))
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                List<VendedorLXCC> lista = new List<VendedorLXCC>();
                SqlCommand _SqlCommand = new SqlCommand("LSOSPS_Seleccionar_ClientesInactivos", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            VendedorLXCC cliente = new VendedorLXCC()
                            {
                                iIdUsuario       = int.Parse(_SqlDataReader["IdCliente"].ToString()),
                                sCliente         = _SqlDataReader["Cliente"].ToString(),
                                sNombre          = _SqlDataReader["Nombre"].ToString(),
                                sTelefonoM       = _SqlDataReader["NumeroMovil"].ToString(),
                                sCorreoE         = _SqlDataReader["CorreoElectronico"].ToString(),
                                iIdServicioTipo  = int.Parse(_SqlDataReader["IdServicio"].ToString()),
                                sServicioConta   = _SqlDataReader["ServicioTipo"].ToString(),
                                sServicioOD      = _SqlDataReader["ServicioStatus"].ToString(),
                                sFechaContr      = DateTime.Parse(_SqlDataReader["FechaFactura"].ToString()).ToShortDateString(),
                                sFechaVenci      = DateTime.Parse(_SqlDataReader["FechaVencimiento"].ToString()).ToShortDateString(),
                            };
                            lista.Add(cliente);                            
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
