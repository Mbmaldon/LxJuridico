using ClaseData.Clases.Archivo.ArchivoEntidades;
using ClaseData.Clases.Eventos;
using ClaseData.Clases.ListServicio;
using ClaseData.Clases.Solicitud.DetalleServicio;
using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class DSDetalleServicio
    {

        public DSDetalleServicio()
        {

        }

        /*Función para obtener los detalles de la solicitud*/
        public ISDetalleServicio InfoSolicitud(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISDetalleServicio detalleSoli = null;
            var vSolicitudDetalle = ADB.ADMSPS_DETALLE_SOLICITUD_F2(iIdSolicitud);

            foreach (var vDetalles in vSolicitudDetalle)
            {
                detalleSoli = new ISDetalleServicio(vDetalles.IdCaso.ToString(),
                                                    vDetalles.Cliente.ToString(),
                                                    vDetalles.NomCliente.ToString(),
                                                    vDetalles.RFC.ToString(),
                                                    vDetalles.NumeroMovil.ToString(),
                                                    vDetalles.CorreoElectronico.ToString(),
                                                    vDetalles.TipoPersona.ToString(),
                                                    vDetalles.ServicioTipo.ToString(),
                                                    vDetalles.UsuarioRegistra.ToString(),
                                                    vDetalles.Coordinador.ToString(),
                                                    vDetalles.Consultor.ToString(),
                                                    vDetalles.IdSolicitudTipo.ToString(),
                                                    vDetalles.SolicitudTipo.ToString(),
                                                    vDetalles.Solicitud.ToString(),
                                                    vDetalles.FechaRegistro.ToString(),
                                                    vDetalles.UrlCitas.ToString(),
                                                    vDetalles.IdContadorAsignado.ToString(),
                                                    //vDetalles.IdTipoServicio.ToString(),
                                                    vDetalles.tipificacion.ToString());
            }
            return detalleSoli;
        }

        /*Función para registrar un nuevo evento*/
        public void RegistrarEvento(int iIdSolicitud, int iIdUsuarioConsultor, int iIdEvento, int iIdTarea,
                                    string sExpOrigen, string sNumExpediente, string sJuzgado, string sContraparte,
                                    string sTipoJuicio, string sPropuesta, DateTime dtTerminoInterno, DateTime dtTerminoLegal, 
                                    int iOficilia, string sDescripcionActo)
        {

            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_ALTA_EVENTO(iIdSolicitud,
                                   iIdUsuarioConsultor,
                                   iIdEvento,
                                   iIdTarea,
                                   sExpOrigen,
                                   sNumExpediente,
                                   sJuzgado,
                                   sContraparte,
                                   sTipoJuicio,
                                   sPropuesta,
                                   dtTerminoInterno,
                                   dtTerminoLegal,
                                   iOficilia,
                                   sDescripcionActo);
        }

        /*Función para registrar una nueva solicitud de información */
        public void RegistrarSolicitudInformacion(int iIdSolicitud, int iIdConsultor, int iIdResponsable,
                                                   string sSolicitud, DateTime dtFechaVigencia)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_ALTA_SOLICITUD_INFORMACION(iIdSolicitud,
                                                  iIdConsultor,
                                                  iIdResponsable,
                                                  sSolicitud,
                                                  dtFechaVigencia);
        }

        /*Función para registrar un nuevo documento*/
        public void RegistrarDocumento(int iIdSolicitud, int iIdConsultor, string sRequisicion, string sTipoReq)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_ALTA_DOCUMENTO(iIdSolicitud,
                                      iIdConsultor,
                                      sRequisicion,
                                      sTipoReq);
        }

        /*Función para registrar una nueva propuesta de respuesta (Consultor)*/
        public void RegistrarPropuestaRespuesta(int iIdSolicitud, int iIdConsultor, string sPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_ALTA_PROPUESTA_RESPUESTA(iIdSolicitud,
                                                iIdConsultor,
                                                sPropuesta);
        }

        /*Función para registrar una nueva propuesta de respuesta (Contador)*/
        public void RegistrarPropuestaRespuestaContador(int iIdSolicitud, int iIdConsultor, string sPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_ALTA_PROPUESTA_RESPUESTA_CONTADOR(iIdSolicitud,
                                                         iIdConsultor,
                                                         sPropuesta);
        }

        /*Funcón para obtener información de la propuesta registrada*/
        public ISPropuesta InfoPropuesta(int iIdPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISPropuesta detalleProp = null;
            var vInfoPropuesta = ADB.ADMSPS_INFORMACION_PROPUESTA(iIdPropuesta);

            foreach (var vPropuesta in vInfoPropuesta)
            {
                detalleProp = new ISPropuesta(vPropuesta.Propuesta.ToString(),
                                               vPropuesta.DescripcionRechazo.ToString());
            }
            return detalleProp;
        }

        /*Función para obtener detalle de la solicitud fase Resolución*/
        public ISDetalleServicioR InfoSolicitudR(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISDetalleServicioR detalleSoli = null;
            var vSolicitudDetalle = ADB.ADMSPS_DETALLE_SOLICITUD_RESOLUCION(iIdSolicitud);

            foreach (var vDetalles in vSolicitudDetalle)
            {
                detalleSoli = new ISDetalleServicioR(vDetalles.IdCaso.ToString(),
                                                     vDetalles.Cliente.ToString(),
                                                     vDetalles.NomCliente.ToString(),
                                                     vDetalles.RFC.ToString(),
                                                     vDetalles.NumeroMovil.ToString(),
                                                     vDetalles.TipoPersona.ToString(),
                                                     vDetalles.ServicioTipo.ToString(),
                                                     vDetalles.UsuarioRegistra.ToString(),
                                                     vDetalles.Coordinador.ToString(),
                                                     vDetalles.Gerente.ToString(),
                                                     vDetalles.IdSolicitudTipo.ToString(),
                                                     vDetalles.SolicitudTipo.ToString(),
                                                     vDetalles.Solicitud.ToString(),
                                                     vDetalles.FechaRegistro.ToString(),
                                                     vDetalles.DictamenFinal.ToString(),
                                                     vDetalles.UrlCitas.ToString(),
                                                     vDetalles.tipificacion.ToString());
            }
            return detalleSoli;
        }

        /*Función para actualizar la propuesta de respuesta registrada*/
        public void ActualizarPropuestaRespuesta(int iIdPropuesta, string sPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_ACTUALIZAR_PROPUESTA(iIdPropuesta,
                                            sPropuesta);
        }

        /*Función para actualizar el evento registrado*/
        public void ActualizarEvento(int iIdEvento, string sExpOrigen, string sNumExpediente, string sJuzgado,
                                     string sContraparte, string sTipoJuicio, string sPropuesta, int iOficilia, string sDescripActo)
        {

            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_EVENTO_REGISTRADO(iIdEvento,
                                         sExpOrigen,
                                         sNumExpediente,
                                         sJuzgado,
                                         sContraparte,
                                         sTipoJuicio,
                                         sPropuesta,
                                         iOficilia,
                                         sDescripActo);
        }

        /*Funcion para obtener los detalles de la solicitud de información*/
        public ISDSolicitudInformacion InfoSolicitudInformacion(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISDSolicitudInformacion detalleSolInfor = null;
            var vSolicitudDetalle = ADB.ADMSPS_DETALLE_SOLICITUD_INFORMACION(iIdSolicitud);

            foreach (var vDetalles in vSolicitudDetalle)
            {
                detalleSolInfor = new ISDSolicitudInformacion(vDetalles.IdSolicitudInformacion.ToString(),
                                                              vDetalles.IdCaso.ToString(),
                                                              vDetalles.Cliente.ToString(),
                                                              vDetalles.NomCliente.ToString(),
                                                              vDetalles.RFC.ToString(),
                                                              vDetalles.NumeroMovil.ToString(),
                                                              vDetalles.CorreoElectronico.ToString(),
                                                              vDetalles.TipoPersona.ToString(),
                                                              vDetalles.ServicioTipo.ToString(),
                                                              vDetalles.Solicitante.ToString(),
                                                              vDetalles.SolicitudTipo.ToString(),
                                                              vDetalles.Solicitud.ToString(),
                                                              vDetalles.FechaRegistro.ToString(),
                                                              vDetalles.FechaVigencia.ToString());
            }
            return detalleSolInfor;
        }

        /*Función para actualizar la solicitud de información registrada*/
        public void respuestaSolicitudInformacion(int iIdSolicitudInformacion, string sRespuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_ACTUALIZAR_SOLICITUD_INFORMACION(iIdSolicitudInformacion, sRespuesta);
        }

        /*Función para actualizar la recepcion de documentos(Oficialia)*/
        public void recepcionDocumentoOficialia(int iIdOficialia)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_RECEPCION_OFICIALIA(iIdOficialia);
        }

        /*Función para pasar a inactivo el archivo registrado*/
        public void eliminarArchivo(int iIdAdjunto)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_ARCHIVO_INACTIVO(iIdAdjunto);
        }

        /*Función para obtener detalles de la solicitud de información solicitada*/
        public ESolicitudInformacion detSolicitudInformResp(int iIdSolInfo)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ESolicitudInformacion detalleSInfo = null;
            var vDetalleSol = ADB.ADMSPS_DETALLE_SOLICITUD_INFORMACION_ENTREGA(iIdSolInfo);

            foreach (var vSolicitud in vDetalleSol)
            {
                detalleSInfo = new ESolicitudInformacion(vSolicitud.Solicitud.ToString(),
                                                         vSolicitud.Responsable.ToString(),
                                                         vSolicitud.FechaVigencia.ToString(),
                                                         vSolicitud.Respuesta.ToString(),
                                                         vSolicitud.RutaArchivo.ToString(),
                                                         vSolicitud.FechaRespuesta.ToString());
            }
            return detalleSInfo;
        }

        /*Función para obtener la ruta del archivo cargado en la fase dictamen final*/
        public ISRutaDocumento rutaArchivoDictamen(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISRutaDocumento rutArchivo = null;

            var vArchivo = ADB.ADMSPS_RUTA_ARCHIVO_DICTAMEN(iIdSolicitud);

            foreach (var dtm in vArchivo)
            {
                rutArchivo = new ISRutaDocumento(dtm.idArchivoAdjunto.ToString(), dtm.RutaArchivo.ToString());
            }
            return rutArchivo;
        }

        /*Función que consume procedimiento almacenado para el envio de notificaciones al telefono del cliente*/
        public void enviarMensaje(string sMensaje, string sNumero)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            //ADB.CAJDBSPS_ENVIO_CORREO("lexa.sio@lexatax.com.mx", sMensaje, sNumero);
             ADB.CAJDBSPS_ENVIO_CORREO("soporte@lexatax.com.mx", sMensaje, sNumero);
        }



        int? iResultado;
        /*Función para registrar un nuevo evento*/
        public int agregarEvento(int iIdMateria, int iIdSolicitudTipo, string sEvento)
        {

            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_REGISTRO_EVENTO(iIdMateria,
                                   iIdSolicitudTipo,
                                   sEvento,
                                    ref iResultado);

            return Convert.ToInt32(iResultado);
        }


        public DExisteEvento existeEvento(int idMateria, int idTipoSolicitud, string sEvento)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            DExisteEvento idEvento = null;

            var vId = ADB.ADMSPS_EXISTE_EVENTO(idMateria, idTipoSolicitud, sEvento);
            try
            {
                foreach (var i in vId)
                {
                    idEvento = new DExisteEvento(int.Parse(i.IdEvento.ToString()));
                }

                return idEvento;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*Función para registrar un nuevo evento*/
        public int agregarTarea(int iIdMateria, int idEvento, string sTarea)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_REGISTRO_TAREA(iIdMateria,
                                       idEvento,
                                       sTarea,
                                       ref iResultado);

            return Convert.ToInt32(iResultado);
        }

        public DExisteTarea existeTarea(int idMateria, int idEvento, string sTarea)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            DExisteTarea iIdTarea = null;

            var vId = ADB.ADMSPS_EXISTE_TAREA(idMateria, idEvento, sTarea);
            try
            {
                foreach (var i in vId)
                {
                    iIdTarea = new DExisteTarea(int.Parse(i.IdTarea.ToString()));
                }

                return iIdTarea;
            }
            catch (Exception)
            {
                throw;
            }
        }

      
        /*Función para registrar un nuevo evento*/
        public int addServicio(int iIdMateria, int iIdSolicitudTipo, string sTipificacion)
        {

            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_REGISTRO_SERVICIO(iIdMateria,
                                           iIdSolicitudTipo,
                                           sTipificacion,
                                           ref iResultado);

            return Convert.ToInt32(iResultado);
        }



        public DExisteTipificacion existeTipif(int idMateria, int idEvento, string sTipifi)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            DExisteTipificacion iIdTipif = null;

            var vId = ADB.ADMSPS_EXISTE_SERVICIO(idMateria, idEvento, sTipifi);
            try
            {
                foreach (var i in vId)
                {
                    iIdTipif = new DExisteTipificacion(int.Parse(i.idTipoServicio.ToString()));
                }

                return iIdTipif;
            }
            catch (Exception)
            {
                throw;
            }
        }
        

    }
}
