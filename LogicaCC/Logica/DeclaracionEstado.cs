using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.Logica
{
    public class DeclaracionEstado
    {
        public int      iIdDeclaracionEstado  { get; set; }
        public int      iIdCliente            { get; set; }
        public string   sDeclaracionEstado    { get; set; }

        public int     iAnioDeclaracion     { get; set; }
        public string  sFechaPresentacion   { get; set; }
        public string  sMonto               { get; set; }
        public string  sFechaLimitePago     { get; set; }
        //public int iIdDeclaracionEstado   { get; set; }
        public int     iIdDeclaracionTipo   { get; set; }
        public string  sDeclaracionTipo     { get; set; }
        public int     iIdPeriodo           { get; set; }
        public string  sPeriodoDeclaracion  { get; set; }
        public string  sNumOperacion        { get; set; }
        public string  sLlavePago           { get; set; }
        public string  sLineaCaptura        { get; set; }

        public string sActivo             { get; set; }
        public string sNombre             { get; set; }
        public string sAPaterno           { get; set; }
        public string sAMaterno           { get; set; }
        public string sCorreoElectronico  { get; set; }
        public string sCliente            { get; set; }
        public string sDeclaracionModo { get; set; }
        public DateTime? dtFechaPago { get; set; }

        public DeclaracionEstado()
        {
            iIdDeclaracionEstado    = 0;
            iIdCliente              = 0;
            sDeclaracionEstado      = String.Empty;

            iAnioDeclaracion        = 0;
            sFechaPresentacion      = string.Empty;
            sMonto                  = string.Empty;
            sFechaLimitePago        = string.Empty;
            iIdDeclaracionTipo      = 0;
            sDeclaracionTipo        = string.Empty;
            iIdPeriodo              = 0;
            sPeriodoDeclaracion     = string.Empty;
            sNumOperacion           = string.Empty;
            sLlavePago              = string.Empty;
            sLineaCaptura           = string.Empty;
            sDeclaracionModo        = string.Empty;
            dtFechaPago             = DateTime.Now;
        }

        public List<DeclaracionEstado> listaDeclaracionEstado()
        {
            List<DeclaracionEstado> lista = new List<DeclaracionEstado>();
            //SqlConnection _sqlConnection  = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPY);
            SqlCommand _sqlCommand        = new SqlCommand("SELECT * FROM DeclaracionEstado", _sqlConnection) { CommandType = CommandType.Text };

            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        DeclaracionEstado declaracionEstado = new DeclaracionEstado()
                        {
                            iIdDeclaracionEstado   = int.Parse(_sqlDataReader["IdDeclaracionEstado"].ToString()),
                            sDeclaracionEstado     = _sqlDataReader["DeclaracionEstado"].ToString().Length > 0 ? string.Format("{0}{1}", char.ToUpper(_sqlDataReader["DeclaracionEstado"].ToString()[0]), _sqlDataReader["DeclaracionEstado"].ToString().ToLower().Substring(1)) : _sqlDataReader["DeclaracionEstado"].ToString()
						};
                        lista.Add(declaracionEstado);
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

        public List<DeclaracionEstado> listaDeclaracion(int idCliente)
        {
            List<DeclaracionEstado> lista = new List<DeclaracionEstado>();
            //SqlConnection _sqlConnection  = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
            SqlConnection _sqlConnection  = new SqlConnection(ConnectionString.DbMPY);
            SqlCommand _sqlCommand        = new SqlCommand("OFSPS_SeleccionarDeclaracionesPendientes", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            _sqlCommand.Parameters.Add("@idCliente", SqlDbType.BigInt).Value = idCliente;

            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        DeclaracionEstado declaracionEstado = new DeclaracionEstado()
                        {
                            iIdDeclaracionTipo = int.Parse(_sqlDataReader["IdDeclaracion"].ToString()),
                            sDeclaracionTipo   = _sqlDataReader["DeclaracionTipo"].ToString()
                        };
                        lista.Add(declaracionEstado);
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

        public DeclaracionEstado informacionDeclaracion(int idDeclaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                DeclaracionEstado _DecEstado = null;
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_Declaracion", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@idDeclaracion", idDeclaracion);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while(_SqlDataReader.Read())
                        {
                            _DecEstado = new DeclaracionEstado()
                            {
                                iAnioDeclaracion        = int.Parse(_SqlDataReader["AñoDeclaracion"].ToString()),
                                sFechaPresentacion      = _SqlDataReader["FechaPresentacion"].ToString(),
                                sMonto                  = _SqlDataReader["Monto"].ToString(),
                                sFechaLimitePago        = _SqlDataReader["FechaLimitePago"].ToString(),
                                iIdDeclaracionEstado    = int.Parse(_SqlDataReader["IdDeclaracionEstado"].ToString()),
                                iIdDeclaracionTipo      = int.Parse(_SqlDataReader["IdDeclaracionTipo"].ToString()),
                                sDeclaracionTipo        = _SqlDataReader["DeclaracionTipo"].ToString(),
                                iIdPeriodo              = int.Parse(_SqlDataReader["IdPeriodo"].ToString()),
                                sPeriodoDeclaracion     = _SqlDataReader["PeriodoDeclaracion"].ToString(),
                                sNumOperacion           = _SqlDataReader["NumOperacion"].ToString(),
                                sLlavePago              = _SqlDataReader["LlavePago"].ToString(),
                                sLineaCaptura           = _SqlDataReader["LineaCaptura"].ToString(),
                                sDeclaracionModo        = _SqlDataReader["DeclaracionModo"].ToString(),
                                dtFechaPago             = _SqlDataReader["FechaModificacion"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(_SqlDataReader["FechaModificacion"].ToString())
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    _DecEstado = null;
                }
                return _DecEstado;
            }
        }

        public int UpdateDeclaracion(int idDeclaracion, int idDeclaracionEstado, string sLlavePago, DateTime? dtFechaPago)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPU_Actualizar_Declaracion", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                _SqlCommand.Parameters.AddWithValue("@idDeclaracion", idDeclaracion);
                _SqlCommand.Parameters.AddWithValue("@idDeclarcionEstado", idDeclaracionEstado);
                _SqlCommand.Parameters.AddWithValue("@LlavePago", sLlavePago);
                _SqlCommand.Parameters.AddWithValue("@FechaPago", dtFechaPago);

                var Resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.Int);
                Resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return (int)Resultado.Value;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }


        public DeclaracionEstado obtenerClienteDC(int idUsuario, string cliente, string rfc)
        {
            DeclaracionEstado deCliente = null;
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXCCConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPY);
            SqlCommand _sqlCommand = new SqlCommand("OFSPI_Buscar_ClienteDC", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            _sqlCommand.Parameters.Add("@idUsuario", SqlDbType.BigInt).Value = idUsuario;
            _sqlCommand.Parameters.Add("@cliente", SqlDbType.NVarChar, 45).Value = cliente;
            _sqlCommand.Parameters.Add("@rfc", SqlDbType.NVarChar, 45).Value = rfc;

            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if (_sqlDataReader.HasRows)
                {
                    while (_sqlDataReader.Read())
                    {
                        deCliente = new DeclaracionEstado()
                        {
                            iIdCliente = int.Parse(_sqlDataReader["IdCliente"].ToString()),
                            sActivo = _sqlDataReader["Activo"].ToString(),
                            sNombre = _sqlDataReader["Nombre"].ToString(),
                            sAPaterno = _sqlDataReader["APaterno"].ToString(),
                            sAMaterno = _sqlDataReader["AMaterno"].ToString(),
                            sCorreoElectronico = _sqlDataReader["CorreoElectronico"].ToString(),
                            sCliente = _sqlDataReader["Cliente"].ToString()
                        };
                    }
                }
            }
            catch (Exception)
            {
                deCliente = null;
            }
            finally
            {
                _sqlConnection.Close();
            }

            return deCliente;
        }




    }
}
