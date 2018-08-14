using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class RegistroConcepto
    {
        public int      iIdRegistroConcepto { get; set; }
        public int      iIdConcepto         { get; set; }
        public decimal  dMonto              { get; set; }
        public decimal  dActualizacion      { get; set; }
        public decimal  dRecargos           { get; set; }
        public decimal  dMultas             { get; set; }
        public decimal  dTotal              { get; set; }
        public int      iIdDeclaracion      { get; set; }
        public string   sConcepto           { get; set; }
        public string   sEstado             { get; set; }
        public int      iRegistrado         { get; set; }

        public RegistroConcepto()
        {
            iIdRegistroConcepto = 0;
            iIdConcepto         = 0;
            dMonto              = 0;
            dActualizacion      = 0;
            dRecargos           = 0;
            dMultas             = 0;
            dTotal              = 0;
            iIdDeclaracion      = 0;
            sConcepto           = string.Empty;
            sEstado             = string.Empty;
            iRegistrado         = 0;
        }

        /// <summary>
        /// Método Público para generar un nuevo registro de un concepto
        /// </summary>
        /// <param name="registroConcepto">Objeto de tipo Concepto que contiene sus propiedades</param>
        /// <returns></returns>
        public bool InsertarRegistroObligacion(RegistroConcepto registroConcepto)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPI_Crear_RegistroConcepto", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                //PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DEL CONCEPTO Y EL MONTO
                _SqlCommand.Parameters.AddWithValue("@IdConcepto", registroConcepto.iIdConcepto);
                _SqlCommand.Parameters.AddWithValue("@Estado", registroConcepto.sEstado);
                _SqlCommand.Parameters.AddWithValue("@Monto", registroConcepto.dMonto);
                _SqlCommand.Parameters.AddWithValue("@Actualizacion", registroConcepto.dActualizacion);
                _SqlCommand.Parameters.AddWithValue("@Recargos", registroConcepto.dRecargos);
                _SqlCommand.Parameters.AddWithValue("@Multas", registroConcepto.dMultas);
                _SqlCommand.Parameters.AddWithValue("@Total", registroConcepto.dTotal);
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracion", registroConcepto.iIdDeclaracion);

                try
                {
                    //ABRIMOS LA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA Y OBTENEMOS UN RESULTADO
                    return (_SqlCommand.ExecuteNonQuery() > 0 ? true : false);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Obtiene el listado de conceptos registrados sobre una declaración
        /// </summary>
        /// <param name="iIdDeclaracion">Id de la declaración</param>
        /// <returns></returns>
        public List<RegistroConcepto> GetConceptsStatement(int iIdDeclaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<RegistroConcepto> List = new List<RegistroConcepto>();
                SqlCommand _SqlCommand = new SqlCommand("MDSPS_OBTENER_CONCEPTOS_DECLARACION", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracion", iIdDeclaracion);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            RegistroConcepto item = new RegistroConcepto()
                            {
                                iIdRegistroConcepto = int.Parse(_SqlDataReader["IdRegistroConcepto"].ToString()),
                                iIdConcepto         = int.Parse(_SqlDataReader["IdConcepto"].ToString()),
                                sConcepto           = _SqlDataReader["Concepto"].ToString(),
                                sEstado             = _SqlDataReader["Estado"].ToString(),
                                dMonto              = decimal.Parse(_SqlDataReader["Monto"].ToString()),
                                dActualizacion      = decimal.Parse(_SqlDataReader["Actualizacion"].ToString()),
                                dRecargos           = decimal.Parse(_SqlDataReader["Recargos"].ToString()),
                                dMultas             = decimal.Parse(_SqlDataReader["Multas"].ToString()),
                                dTotal              = decimal.Parse(_SqlDataReader["Total"].ToString()),
                                iRegistrado         = int.Parse(_SqlDataReader["Registrado"].ToString())
                            };
                            List.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    List = null;
                }
                return List;
            }
        }

        public List<RegistroConcepto> lConceptosRegistrados (int iIdDeclaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<RegistroConcepto> lista = new List<RegistroConcepto>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_RegistrosConceptos", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdDeclaracion", iIdDeclaracion);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            RegistroConcepto concepto = new RegistroConcepto()
                            {
                                iIdConcepto     = int.Parse(_SqlDataReader["IdConcepto"].ToString()),
                                sConcepto       = _SqlDataReader["Concepto"].ToString(),
                                sEstado         = _SqlDataReader["Estado"].ToString(),
                                dMonto          = decimal.Parse(_SqlDataReader["Monto"].ToString()),
                                dActualizacion  = decimal.Parse(_SqlDataReader["Actualizacion"].ToString()),
                                dRecargos       = decimal.Parse(_SqlDataReader["Recargos"].ToString()),
                                dMultas         = decimal.Parse(_SqlDataReader["Multas"].ToString()),
                                dTotal          = decimal.Parse(_SqlDataReader["Total"].ToString())
                            };
                            lista.Add(concepto);
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

        /// <summary>
        /// Elimina un concepto
        /// </summary>
        /// <param name="iIdRegistroConcepto">Id del registro del concepto</param>
        /// <returns></returns>
        public int DeleteConcept(int iIdRegistroConcepto)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("OFSPD_RegistroConcepto_Eliminar", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdRegistroConcepto", iIdRegistroConcepto);

                var Resultado       = _SqlCommand.Parameters.Add("@Status", SqlDbType.Int);
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
    }
}
