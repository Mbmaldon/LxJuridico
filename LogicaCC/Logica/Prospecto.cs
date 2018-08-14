using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    public class Prospecto
    {
        private static Prospecto _instancia = null;
        public int      iIdProspecto    { get; set; }
        public int      iIdLlamada      { get; set; }
        public int      iIdEtapa        { get; set; }
        public string   sNombre         { get; set; }
        public string   sAPaterno       { get; set; }
        public string   sAMaterno       { get; set; }
        public string   sTelefono       { get; set; }
        public string   sTelOpcional    { get; set; }
        public string   sObservaciones  { get; set; }
        public string   sDireccion      { get; set; }
        public string   sMotivoCancelacion { get; set; }
        public DateTime dtFecha         { get; set; }
        public TimeSpan tsHora          { get; set; }

        public Prospecto()
        {
            iIdProspecto    = 0;
            iIdLlamada      = 0;
            iIdEtapa        = 0;
            sNombre         = "";
            sAPaterno       = "";
            sAMaterno       = "";
            sTelefono       = "";
            sTelOpcional    = "";
            sObservaciones  = "";
            sDireccion      = "";
            sMotivoCancelacion = "";
            dtFecha         = DateTime.Now;
            tsHora          = DateTime.Now.TimeOfDay;
        }

        public static Prospecto Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Prospecto();

                return _instancia;
            }
        }

        /// <summary>
        /// Obtiene un listado de prospectos pertenecientes a un usuario en CallCenter para realizar
        /// llamadas para prospección. Estos usuarios pertencen al usuario que se envía como parametro.
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que se requiere.</param>
        /// <returns></returns>
        public List<Prospecto> GetList(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Prospecto> list = new List<Prospecto>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_PROSPECTOS_OBTENER_BY_USER", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Prospecto item = new Prospecto()
                            {
                                iIdProspecto = int.Parse(_SqlDataReader["IdPersona"].ToString()),
                                sNombre      = string.Format("{0} {1} {2}", _SqlDataReader["Nombre"].ToString(), _SqlDataReader["AP"].ToString(), _SqlDataReader["AM"].ToString()),
                                sTelefono    = _SqlDataReader["Telefono"].ToString(),
                                iIdEtapa     = int.Parse(_SqlDataReader["IdEtapa"].ToString()),
                                sDireccion   = _SqlDataReader["Domicilio"].ToString()
                            };
                            list.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    list = null;
                }
                return list;
            }
        }

        /// <summary>
        /// Obtiene un listado de las llamadas agendadas
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que requiere el listado</param>
        /// <returns></returns>
        public List<Prospecto> GetListScheduleCalls(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Prospecto> list = new List<Prospecto>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_GET_LLAMADAS_AGENDADAS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Prospecto item = new Prospecto()
                            {
                                iIdLlamada   = int.Parse(_SqlDataReader["IdLlamadaAgenda"].ToString()),
                                iIdProspecto = int.Parse(_SqlDataReader["IdPersona"].ToString()),
                                sNombre      = string.Format("{0} {1} {2}", _SqlDataReader["Nombre"].ToString(), _SqlDataReader["AP"].ToString(), _SqlDataReader["AM"].ToString()),
                                dtFecha      = DateTime.Parse(_SqlDataReader["FechaAgenda"].ToString()),
                                tsHora       = TimeSpan.Parse(_SqlDataReader["HoraAgenda"].ToString()),
                                iIdEtapa     = int.Parse(_SqlDataReader["IdEtapa"].ToString()),
                                sTelefono    = _SqlDataReader["Telefono"].ToString(),
                                sTelOpcional = _SqlDataReader["TelefonoOpcional"].ToString(),
                                sObservaciones = _SqlDataReader["Comentario"].ToString(),
                                sDireccion   = _SqlDataReader["Domicilio"].ToString()
                            };
                            list.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    list = null;
                }
                return list;
            }
        }

        /// <summary>
        /// Obtiene un listado de prospectos cancelados
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que tiene asignado los usuarios</param>
        /// <returns></returns>
        public List<Prospecto> GetCanceledList(int iIdUsuario)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Prospecto> list = new List<Prospecto>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_PROSPECTOS_CANCELADOS_OBTENER_BY_USER", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Prospecto item = new Prospecto()
                            {
                                iIdProspecto = int.Parse(_SqlDataReader["IdPersona"].ToString()),
                                sNombre      = string.Format("{0} {1} {2}", _SqlDataReader["Nombre"].ToString(), _SqlDataReader["AP"].ToString(), _SqlDataReader["AM"].ToString()),
                                dtFecha      = DateTime.Parse(_SqlDataReader["Fecha"].ToString()),
                                sMotivoCancelacion = _SqlDataReader["MotivoCancelacion"].ToString()
                            };
                            list.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    list = null;
                }
                return list;
            }
        }
        
        /// <summary>
        /// Realiza el registro de un nuevo prospecto con regimen de Persona Física en la base de datos.
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que registra</param>
        /// <param name="sNombre">Nombre del prospecto</param>
        /// <param name="sAPaterno">Apellido paterno del prospecto</param>
        /// <param name="sAMaterno">Apellido materno del prospecto</param>
        /// <param name="iEdad">Edad del prospecto</param>
        /// <param name="sCorreo">Correo electrónico del prospecto</param>
        /// <param name="sTelefono">Teléfono del prospecto</param>
        /// <param name="iIdGenero">Id del genero del prospecto</param>
        /// <param name="sCodigoPostal">Código postal del prospecto</param>
        /// <param name="iIdEstado">Id del estado del prospecto</param>
        /// <param name="sDomicilio">Domicilio del prospecto</param>
        /// <param name="iIdAgente">Id del agente de call center asignado</param>
        /// <returns></returns>
        public int NewItem(int iIdUsuario, string sNombre, string sAPaterno, string sAMaterno, int iEdad, string sCorreo, string sTelefono, int iIdGenero, string sCodigoPostal, int iIdEstado, string sDomicilio, int iIdAgente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYSPI_ADD_PROSPECTO_CRM", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@IdGenero", iIdGenero);
                _SqlCommand.Parameters.AddWithValue("@IdEstado", iIdEstado);
                _SqlCommand.Parameters.AddWithValue("@Edad", iEdad);
                _SqlCommand.Parameters.AddWithValue("@Nombre", sNombre);
                _SqlCommand.Parameters.AddWithValue("@APaterno", sAPaterno);
                _SqlCommand.Parameters.AddWithValue("@AMaterno", sAMaterno);
                _SqlCommand.Parameters.AddWithValue("@Correo", sCorreo);
                _SqlCommand.Parameters.AddWithValue("@Telefono", sTelefono);
                _SqlCommand.Parameters.AddWithValue("@CP", sCodigoPostal);
                _SqlCommand.Parameters.AddWithValue("@Domicilio", sDomicilio);
                _SqlCommand.Parameters.AddWithValue("@IdAgente", iIdAgente);

                var Result = _SqlCommand.Parameters.Add("@Resutaldo", SqlDbType.BigInt);
                Result.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return (int)Result.Value;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Realiza el registro de un nuevo prospecto con regimen de Persona Moral en la base de datos.
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que registra</param>
        /// <param name="sRazonSocial">Razón social</param>
        /// <param name="sRfc">RFC de la razón social</param>
        /// <param name="iIdEstado">Id del estado del prospecto</param>
        /// <param name="sCodigoPostal">Código postal del prospecto</param>
        /// <param name="sDomicilio">Domicilio del prospecto</param>
        /// <param name="sCNombre">Nombre del contacto del prospecto</param>
        /// <param name="sCAPaterno">Apellido paterno del contacto del prospecto</param>
        /// <param name="sCAMaterno">Apellido materno del contacto del prospecto</param>
        /// <param name="sPuesto">Puesto del contacto del prospecto</param>
        /// <param name="sCCorreo">Correo del contacto del prospecto</param>
        /// <param name="sCTelefono">Teléfono del contacto del prospecto</param>
        /// <param name="iIdAgente">Id del agente de call center asignado</param>
        /// <returns></returns>
        public int NewItem(int iIdUsuario, string sRazonSocial, string sRfc, int iIdEstado, string sCodigoPostal, string sDomicilio, string sCNombre, string sCAPaterno, string sCAMaterno, string sPuesto, string sCCorreo, string sCTelefono, int iIdAgente)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYSPI_ADD_PROSPECTO_MORAL_CRM", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@IdEstado", iIdEstado);
                _SqlCommand.Parameters.AddWithValue("@RazonSocial", sRazonSocial);
                _SqlCommand.Parameters.AddWithValue("@Rfc", sRfc);
                _SqlCommand.Parameters.AddWithValue("@CP", sCodigoPostal);
                _SqlCommand.Parameters.AddWithValue("@Domicilio", sDomicilio);
                _SqlCommand.Parameters.AddWithValue("@CNombre", sCNombre);
                _SqlCommand.Parameters.AddWithValue("@CAPaterno", sCAPaterno);
                _SqlCommand.Parameters.AddWithValue("@CAMaterno", sCAMaterno);
                _SqlCommand.Parameters.AddWithValue("@Puesto", sPuesto);
                _SqlCommand.Parameters.AddWithValue("@CCorreo", sCCorreo);
                _SqlCommand.Parameters.AddWithValue("@CTelefono", sCTelefono);
                _SqlCommand.Parameters.AddWithValue("@IdAgente", iIdAgente);

                var Resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.BigInt);
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

        /// <summary>
        /// Envía un prospecto al final de la lista
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que modifica</param>
        /// <param name="iIdProspecto">Id del prospecto</param>
        /// <param name="iIdLlamada">Id de la llamada</param>
        /// <param name="sComentario">Comentario de la llamada</param>
        /// <returns></returns>
        public bool SendQueue(int iIdUsuario, int iIdProspecto, int iIdLlamada, string sComentario, int? iIdLlamadaAgendada)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYSPU_UPDATE_PROSPECTO_COLA", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@IdProspecto", iIdProspecto);
                _SqlCommand.Parameters.AddWithValue("@IdLlamada", iIdLlamada);
                _SqlCommand.Parameters.AddWithValue("@Comentario", sComentario);
                _SqlCommand.Parameters.AddWithValue("@IdLlamadaAge", iIdLlamadaAgendada);

                var Resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.Bit);
                Resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    //return bool.Parse(Resultado.Value.ToString());
                    return Resultado.Value.ToString() == "1" ? true : false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Envía un prospecto al final de la lista
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que modifica</param>
        /// <param name="iIdProspecto">Id del prospecto</param>
        /// <param name="iIdLlamada">Id de la llamada</param>
        /// <param name="sComentario">Comentario de la llamada</param>
        /// <returns></returns>
        public bool CancelProsp(int iIdUsuario, int iIdProspecto, int iIdLlamada, string sComentario, int? iIdLlamadaAge, string sMotivoCancelacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYSPU_CANCEL_PROSPECTO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@IdProspecto", iIdProspecto);
                _SqlCommand.Parameters.AddWithValue("@IdLlamada", iIdLlamada);
                _SqlCommand.Parameters.AddWithValue("@Comentario", sComentario);
                _SqlCommand.Parameters.AddWithValue("@IdLlamadaAge", iIdLlamadaAge);
                _SqlCommand.Parameters.AddWithValue("@Motivo", sMotivoCancelacion);

                var Resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.Bit);
                Resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return Resultado.Value.ToString() == "1" ? true : false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Activa nuevamente a un prospecto que se encuentra desactivado
        /// </summary>
        /// <param name="iIdPersona">Id del prospecto que se reactiva</param>
        /// <returns></returns>
        public bool Active(int iIdPersona)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYSPU_PROSPECTO_REACTIVAR", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdPersona", iIdPersona);

                var Resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.Int);
                Resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return Resultado.Value.ToString() == "1" ? true : false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Agenda una llamada en el sistema
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que agenda</param>
        /// <param name="iIdPersona">Id de la persona a la que se le agenda</param>
        /// <param name="iIdLlamada">Id de la llamada dsede la cual se agenda la llamada</param>
        /// <param name="sComentario">Comentarios de la llamada</param>
        /// <param name="sComentarioAgenda">Comentarios de la llamada agendada</param>
        /// <param name="dtFechaAgenda">Fecha de la llamada agendada</param>
        /// <param name="dtHoraAgenda">Hora de la llamada agendad</param>
        /// <param name="sTelefono">Teléfono opcional para realizar la llamada</param>
        /// <returns></returns>
        public int ScheduleCall(int iIdUsuario, int iIdPersona, int iIdLlamada, string sComentario, string sComentarioAgenda, DateTime dtFechaAgenda, DateTime dtHoraAgenda, string sTelefono, int? IdLlamadaAge)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYSPI_AGENDAR_LLAMADA", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@IdPersona", iIdPersona);
                _SqlCommand.Parameters.AddWithValue("@IdLlamada", iIdLlamada);
                _SqlCommand.Parameters.AddWithValue("@Comentario", sComentario);
                _SqlCommand.Parameters.AddWithValue("@ComentarioAgenda", sComentarioAgenda);
                _SqlCommand.Parameters.AddWithValue("@FechaAgenda", dtFechaAgenda);
                _SqlCommand.Parameters.AddWithValue("@HoraAgenda", dtHoraAgenda.ToString("hh:mm"));
                _SqlCommand.Parameters.AddWithValue("@Telefono", sTelefono);
                _SqlCommand.Parameters.AddWithValue("@IdLlamadaAge", IdLlamadaAge);

                var Resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.BigInt);
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

        /// <summary>
        /// Agenda una nueva cita en el sistema
        /// </summary>
        /// <returns></returns>
        public int ScheduleAppointment(int iIdUsuario, int iIdPersona, int iIdLlamada, string sComentario, string sComentarioCita, DateTime dtFechaAgenda, DateTime dtHoraAgenda, int? iIdLlamadaAge, string sDireccion, string sNombreAtiende, string sPuesto, string sTelefono)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("MPYSPSU_AGENDAR_CITA", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuarioRegistra", iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@IdPersona", iIdPersona);
                _SqlCommand.Parameters.AddWithValue("@IdLlamada", iIdLlamada);
                _SqlCommand.Parameters.AddWithValue("@Comentarios", sComentario);
                _SqlCommand.Parameters.AddWithValue("@Observaciones", sComentarioCita);
                _SqlCommand.Parameters.AddWithValue("@FechaCita", dtFechaAgenda);
                _SqlCommand.Parameters.AddWithValue("@HoraEntrada", dtHoraAgenda);
                _SqlCommand.Parameters.AddWithValue("@IdLlamadaAge", iIdLlamadaAge);
                _SqlCommand.Parameters.AddWithValue("@Direccion", sDireccion);
                _SqlCommand.Parameters.AddWithValue("@NombreAtiende", sNombreAtiende);
                _SqlCommand.Parameters.AddWithValue("@Puesto", sPuesto);
                _SqlCommand.Parameters.AddWithValue("@Telefono", sTelefono);

                var Resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.BigInt);
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

        /// <summary>
        /// Obtiene un listado de horarios disponibles para agendar una cita
        /// </summary>
        /// <param name="iIdUsuario">Id del usuario que desea agendar la cita</param>
        /// <returns></returns>
        public List<Prospecto> GetSchedules(int iIdUsuario, DateTime dtFechaCita)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Prospecto> list = new List<Prospecto>();
                SqlCommand _SqlCommand = new SqlCommand("MPYSPS_OBTENER_HORARIOS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@Fecha", dtFechaCita);

                try
                {
                    _SqlConnection.Open();
                    SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
                    if (_SqlDataReader.HasRows)
                    {
                        while (_SqlDataReader.Read())
                        {
                            Prospecto item = new Prospecto()
                            {
                                tsHora = TimeSpan.Parse(_SqlDataReader["Hora"].ToString())
                            };
                            list.Add(item);
                        }
                    }
                }
                catch (Exception)
                {
                    list = null;
                }
                return list;
            }
        }
    }
}
