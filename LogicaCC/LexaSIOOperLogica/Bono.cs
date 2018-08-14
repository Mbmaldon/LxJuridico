using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class Bono
    {
        public int iIdBonoUsuario { get; set; }
        public int      iIdVendedor              { get; set; }
        public int      iIdUsuarioCreacion       { get; set; }
        public string   sVendedor                { get; set; }
        public string   sNoOperacionBancaria     { get; set; }
        public decimal  dTotalImporteFac         { get; set; }
        public decimal  dTotalComisionVendedor   { get; set; }
        public decimal  dTotalComisionSupervisor { get; set; }
        public decimal  dTotalComisionGerente    { get; set; }
        public decimal  dTotalBolsa              { get; set; }
        public decimal  dBono                    { get; set; }
        public int      iTrimestre               { get; set; }
        public string  sTipo                     { get; set; }
        public decimal dImporte                  { get; set; }
        public DateTime dtFechaPago              { get; set; }
        public int      iIdTipoUsuario           { get; set; }

        public decimal  dPorcentajeBono          { get; set; }
        public string sPagado { get; set; }

        #region Código para esquema anterior

        public List<Bono> LeerBonos()
        {
            List<Bono> lBono = new List<Bono>();
            //SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _SqlCommand       = new SqlCommand("LSOSPS_Seleccionar_Bonos", _SqlConnection) { CommandType = CommandType.StoredProcedure };

            try
            {
                _SqlConnection.Open();
                SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                if(_SqlDataReader.HasRows)
                {
                    while(_SqlDataReader.Read())
                    {
                        Bono bono = new Bono()
                        {
                            //iIdVendedor             = int.Parse(_SqlDataReader["IdVendedor"].ToString()),
                            //sVendedor               = _SqlDataReader["Vendedor"].ToString(),
                            dTotalImporteFac         = decimal.Parse(_SqlDataReader["TotalImporteFac"].ToString()),
                            dTotalComisionVendedor   = decimal.Parse(_SqlDataReader["TotalComisionesVendedor"].ToString()),
                            dTotalComisionSupervisor = decimal.Parse(_SqlDataReader["TotalComisionesSupervisor"].ToString()),
                            dTotalComisionGerente    = decimal.Parse(_SqlDataReader["TotalComisionesGerente"].ToString()),
                            dTotalBolsa              = decimal.Parse(_SqlDataReader["TotalBolsa"].ToString()),
                            dBono                    = decimal.Parse(_SqlDataReader["Bono"].ToString()),
                            iTrimestre               = int.Parse(_SqlDataReader["Trimestre"].ToString()),
                            sNoOperacionBancaria     = _SqlDataReader["NoOperacionBancaria"].ToString(),
                            sTipo                    = _SqlDataReader["Tipo"].ToString(),
                            dImporte                 = decimal.Parse(_SqlDataReader["Importe"].ToString()),
                            dtFechaPago              = DateTime.Parse(_SqlDataReader["FechaPago"].ToString())
                        };
                        lBono.Add(bono);
                    }
                }
            }
            catch (Exception)
            {
                lBono = null;
            }
            finally
            {
                _SqlConnection.Close();
            }
            return lBono;
        }

        public bool bInsertarBono(Bono bono)
        {
            bool bAlta = false;
            //SqlConnection _SqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _SqlCommand       = new SqlCommand("LSOSPI_Insertar_Bono", _SqlConnection) { CommandType = CommandType.StoredProcedure };

            //_SqlCommand.Parameters.Add("@IdVendedor", SqlDbType.BigInt).Value                   = bono.iIdVendedor;
            //_SqlCommand.Parameters.Add("@IdTipoUsuario", SqlDbType.BigInt).Value                = bono.iIdTipoUsuario;
            _SqlCommand.Parameters.Add("@IdUsuarioCreacion", SqlDbType.BigInt).Value            = bono.iIdUsuarioCreacion;
            _SqlCommand.Parameters.Add("@NoOperacionBancaria", SqlDbType.NVarChar, 30).Value    = bono.sNoOperacionBancaria;
            _SqlCommand.Parameters.Add("@TotalImporteFac", SqlDbType.Money).Value               = bono.dTotalImporteFac;
            _SqlCommand.Parameters.Add("@TotalComisionVendedor", SqlDbType.Money).Value         = bono.dTotalComisionVendedor;
            _SqlCommand.Parameters.Add("@TotalComisionSupervisor", SqlDbType.Money).Value       = bono.dTotalComisionSupervisor;
            _SqlCommand.Parameters.Add("@TotalComisionGerente", SqlDbType.Money).Value          = bono.dTotalComisionGerente;
            _SqlCommand.Parameters.Add("@TotalBolsa", SqlDbType.Money).Value                    = bono.dTotalBolsa;
            _SqlCommand.Parameters.Add("@Bono", SqlDbType.Money).Value                          = bono.dBono;
            _SqlCommand.Parameters.Add("@Trimestre", SqlDbType.Int).Value                       = bono.iTrimestre;
            _SqlCommand.Parameters.Add("@FechaPago", SqlDbType.Date).Value                      = bono.dtFechaPago;
            _SqlCommand.Parameters.Add("@Tipo", SqlDbType.NVarChar, 45).Value                   = bono.sTipo;
            _SqlCommand.Parameters.Add("@Importe", SqlDbType.Money).Value                       = bono.dImporte;

            var parameterResult         = _SqlCommand.Parameters.Add("@Status", SqlDbType.Int);
            parameterResult.Direction   = ParameterDirection.ReturnValue;

            try
            {
                _SqlConnection.Open();
                _SqlCommand.ExecuteNonQuery();
                var result = parameterResult.Value;
                if (int.Parse(result.ToString()) == 1)
                    bAlta = true;
                else
                    bAlta = false;
            }
            catch (Exception)
            {
                bAlta = false;
            }
            finally
            {
                _SqlConnection.Close();
            }
            return bAlta;
        }

        public List<Bono> lBonosVendedores()
        {
            List<Bono> lista = new List<Bono>();
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand       = new SqlCommand("LSOSPS_Seleccionar_BonosVendedores", _sqlConnection) { CommandType = CommandType.StoredProcedure };

            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        Bono comision = new Bono()
                        {
                            //iIdVendedor             = int.Parse(_sqlDataReader["IdVendedor"].ToString()),
                            //sVendedor               = _sqlDataReader["Vendedor"].ToString(),
                            dTotalImporteFac         = decimal.Parse(_sqlDataReader["TotalImportesFacturas"].ToString()),
                            dTotalComisionSupervisor = decimal.Parse(_sqlDataReader["TotalComisionesSupervisor"].ToString()),
                            dTotalComisionVendedor   = decimal.Parse(_sqlDataReader["TotalComisionVendedor"].ToString()),
                            dTotalComisionGerente    = decimal.Parse(_sqlDataReader["TotalComisionGerente"].ToString()),
                            dBono                    = decimal.Parse(_sqlDataReader["Bono"].ToString()),
                            iTrimestre               = int.Parse(_sqlDataReader["Anio"].ToString()),
                            sTipo                    = _sqlDataReader["Tipo"].ToString(),
                            dImporte                 = decimal.Parse(_sqlDataReader["Importe"].ToString()),
                            //iIdTipoUsuario          = int.Parse(_sqlDataReader["IdTipoUsuario"].ToString()),
                            dPorcentajeBono = LeerPorcentajeBono().dPorcentajeBono
                        };
                        lista.Add(comision);
                        
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

        public Bono LeerPorcentajeBono()
        {
            Bono bono = null;
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand = new SqlCommand("LSOSPU_Seleccionar_PorcentajeBono", _sqlConnection) { CommandType = CommandType.StoredProcedure };
            try
            {
                _sqlConnection.Open();
                SqlDataReader _sqlDataReader = _sqlCommand.ExecuteReader();
                if(_sqlDataReader.HasRows)
                {
                    while(_sqlDataReader.Read())
                    {
                        bono = new Bono()
                        {
                            dPorcentajeBono = decimal.Parse(_sqlDataReader["PorcentajeBono"].ToString())
                        };
                    }
                }
            }
            catch (Exception)
            {
                bono = null;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return bono;
        }

        public int iPorcentajeBono(decimal dPorcentajeBono)
        {
            int Id = 0;
            //SqlConnection _sqlConnection = new SqlConnection(Properties.Settings.Default.LXSOConnectionString);
            SqlConnection _sqlConnection = new SqlConnection(ConnectionString.DbMPYOpera);
            SqlCommand _sqlCommand       = new SqlCommand("LSOSPU_Actualizar_PorcentajeBono", _sqlConnection) { CommandType = CommandType.StoredProcedure };
            _sqlCommand.Parameters.Add("@Porcentaje", SqlDbType.Decimal).Value = dPorcentajeBono;
            var parameterReturn = _sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
            parameterReturn.Direction = ParameterDirection.ReturnValue;
            try
            {
                _sqlConnection.Open();
                _sqlCommand.ExecuteNonQuery();
                Id = int.Parse(parameterReturn.Value.ToString());
            }
            catch (Exception)
            {
                Id = 0;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return Id;
        }
        #endregion

        public List<Bono> lBono()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                List<Bono> lista = new List<Bono>();
                SqlCommand _SqlCommand = new SqlCommand("MPYOPS_OBTENER_BONOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Bono bono = new Bono()
                            {
                                iIdBonoUsuario = int.Parse(_SqlDataReader["IdBonoUsuario"].ToString()),
                                iIdVendedor    = int.Parse(_SqlDataReader["IdUsuario"].ToString()),
                                sVendedor      = _SqlDataReader["Nombre"].ToString(),
                                dtFechaPago    = DateTime.Parse(_SqlDataReader["FechaRegistro"].ToString()),
                                dImporte       = decimal.Parse(_SqlDataReader["Importe"].ToString()),
                                sPagado        = _SqlDataReader["Pagado"].ToString()
                            };
                            lista.Add(bono);
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

        public int iPagaBono(int iIdBono, int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYOPU_ACTUALIZA_BONO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdBono", iIdBono);
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                var parameterReturn = _SqlCommand.Parameters.Add("@Status", SqlDbType.Int);
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
