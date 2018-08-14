using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    public class UsuarioLinea
    {
        public int    iIdUsuario        { get; set; }
        public string sDisplayName      { get; set; }
        public string sUserName         { get; set; }
        public string sRegisterName     { get; set; }
        public string sRegisterPassword { get; set; }
        public string sDomainHost       { get; set; }
        public int    iDomainPort       { get; set; }

        public UsuarioLinea()
        {
            iIdUsuario          = 0;
            sDisplayName        = string.Empty;
            sUserName           = string.Empty;
            sRegisterName       = string.Empty;
            sRegisterPassword   = string.Empty;
            sDomainHost         = string.Empty;
            iDomainPort         = 0;
        }         

        public int iNuevaLinea(UsuarioLinea _Linea)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _sqlCommand = new SqlCommand("MPYCCSPI_USUARIO_LINEA", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _sqlCommand.Parameters.AddWithValue("@IdUsuario", _Linea.iIdUsuario);
                _sqlCommand.Parameters.AddWithValue("@DisplayName", _Linea.sDisplayName);
                _sqlCommand.Parameters.AddWithValue("@UserName", _Linea.sUserName);
                _sqlCommand.Parameters.AddWithValue("@RegisterName", _Linea.sRegisterName);
                _sqlCommand.Parameters.AddWithValue("@RegisterPassword", _Linea.sRegisterPassword);
                _sqlCommand.Parameters.AddWithValue("@DomainHost", _Linea.sDomainHost);
                _sqlCommand.Parameters.AddWithValue("@DomainPort", _Linea.iDomainPort);

                var parameterReturn       = _sqlCommand.Parameters.Add("@Status", SqlDbType.BigInt);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _sqlCommand.ExecuteNonQuery();
                    return int.Parse(parameterReturn.Value.ToString());
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public UsuarioLinea ObtenerLinea(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                UsuarioLinea linea = null;
                SqlCommand _SqlCommand = new SqlCommand("MPYCCSPS_USUARIO_LINEA", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            linea = new UsuarioLinea()
                            {
                                iIdUsuario        = int.Parse(_SqlDataReader["Usuario"].ToString()),
                                sDisplayName      = _SqlDataReader["DisplayName"].ToString(),
                                sUserName         = _SqlDataReader["UserName"].ToString(),
                                sRegisterName     = _SqlDataReader["RegisterName"].ToString(),
                                sRegisterPassword = _SqlDataReader["RegisterPassword"].ToString(),
                                sDomainHost       = _SqlDataReader["DomainHost"].ToString(),
                                iDomainPort       = int.Parse(_SqlDataReader["DomainPort"].ToString())
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    linea = null;
                }
                return linea;
            }
        }

        public int iActualizarLinea(UsuarioLinea _Linea)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _sqlCommand = new SqlCommand("MPYCCSPU_USUARIO_LINEA", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _sqlCommand.Parameters.AddWithValue("@IdUsuario", _Linea.iIdUsuario);
                _sqlCommand.Parameters.AddWithValue("@DisplayName", _Linea.sDisplayName);
                _sqlCommand.Parameters.AddWithValue("@UserName", _Linea.sUserName);
                _sqlCommand.Parameters.AddWithValue("@RegisterName", _Linea.sRegisterName);
                _sqlCommand.Parameters.AddWithValue("@RegisterPassword", _Linea.sRegisterPassword);
                _sqlCommand.Parameters.AddWithValue("@DomainHost", _Linea.sDomainHost);
                _sqlCommand.Parameters.AddWithValue("@DomainPort", _Linea.iDomainPort);

                var parameterReturn = _sqlCommand.Parameters.Add("@Status", SqlDbType.BigInt);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _sqlCommand.ExecuteNonQuery();
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
