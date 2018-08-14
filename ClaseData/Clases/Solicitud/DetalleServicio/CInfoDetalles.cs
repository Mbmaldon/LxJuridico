using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.DetalleServicio
{
    public class CInfoDetalles
    {

        public CInfoDetalles()
        {
        }

        /*Función que obtiene un listado de eventos registrados respecto al id de la solicitud levantada*/
        public List<EEventos> obtenerEventoS(int IdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<EEventos> LEventos = new List<EEventos>();

            var vDatos = ADB.ADMSPS_EVENTOS_SOLICITUD(IdSolicitud);

            foreach (var vRow in vDatos)
            {
                EEventos AEvento = new EEventos();
                AEvento.sIdSolicitudEvento = vRow.IdSolicitudEvento.ToString();
                AEvento.sConsultor = vRow.Consultor.ToString();
                AEvento.sExpOrigen = vRow.ExpOrigen.ToString();
                AEvento.sNumExpediente = vRow.NumExpediente.ToString();
                AEvento.sJuzgado = vRow.Juzgado.ToString();
                AEvento.sContraparte = vRow.Contraparte.ToString();
                AEvento.sTipoJuicio = vRow.TipoJuicio.ToString();
                AEvento.sEvento = vRow.Evento.ToString();
                AEvento.sTarea = vRow.Tarea.ToString();
                AEvento.sFTerInterno = vRow.TerminoInterno.ToString();
                AEvento.sFTerLegal = vRow.TerminoLegal.ToString();
                AEvento.sPropuesta = vRow.Propuesta.ToString();
                AEvento.sArchivo = vRow.RutaArchivo.ToString();

                LEventos.Add(AEvento);
            }
            return LEventos;
        }

        /*Función que obtiene un listado de solicitudes de información registradas respecto al id de la solicitud levantada*/
        public List<ESolicitudesInformacion> obtenerSolicitudesI(int IdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ESolicitudesInformacion> LSolicitudes = new List<ESolicitudesInformacion>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_INFORMACION(IdSolicitud);

            foreach (var vRow in vDatos)
            {
                ESolicitudesInformacion ASolicitudes = new ESolicitudesInformacion();
                ASolicitudes.sIdSolicitudInformacion = vRow.IdSolicitudInformacion.ToString();
                ASolicitudes.sConsultor = vRow.Consultor.ToString();
                ASolicitudes.sSolicitud = vRow.Solicitud.ToString();
                ASolicitudes.sFechaRegistro = vRow.FechaRegistro.ToString();
                ASolicitudes.sFechaVigencia = vRow.FechaVigencia.ToString();
                ASolicitudes.sResponsable = vRow.Responsable.ToString();
                ASolicitudes.sEstatus = vRow.Estatus.ToString();

                LSolicitudes.Add(ASolicitudes);
            }
            return LSolicitudes;
        }

        /*Función que obtiene un listado de documentos registrados respecto al id de la solicitud levantada*/
        public List<EDocumento> obtenerDocumentosSolicitados(int IdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<EDocumento> LDocumentos = new List<EDocumento>();

            var vDatos = ADB.ADMSPS_DOCUMENTOS_SOLICITADOS(IdSolicitud);

            foreach (var vRow in vDatos)
            {
                EDocumento ADocumentos = new EDocumento();
                ADocumentos.sIdIdSolicitudDocumento = vRow.IdSolicitudDocumento.ToString();
                ADocumentos.sRequisicion = vRow.Requisicion.ToString();
                ADocumentos.sTipoReq = vRow.TipoRequisicion.ToString();
                ADocumentos.sRecibido = vRow.Recibido.ToString();
               

                LDocumentos.Add(ADocumentos);
            }
            return LDocumentos;
        }

        /*Función que obtiene un listado de propuestas registradas respecto al id de la solicitud levantada*/
        public List<EPropuestaRespuesta> obtenerPropuestasRegistradas(int IdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<EPropuestaRespuesta> LPropuestas = new List<EPropuestaRespuesta>();

            var vDatos = ADB.ADMSPS_PROPUESTAS_REGISTRADAS(IdSolicitud);

            foreach (var vRow in vDatos)
            {
                EPropuestaRespuesta APropuesta= new EPropuestaRespuesta();
                APropuesta.sIdPropuestaRespuesta = vRow.IdPropuestaRespuesta.ToString();
                APropuesta.sAprobada = vRow.Aprobada.ToString();
                APropuesta.sConsultor = vRow.Consultor.ToString();
                APropuesta.sCoordinador = vRow.Coordinador.ToString();
                APropuesta.sPropuesta = vRow.Propuesta.ToString();
                APropuesta.sArchivo  = vRow.Archivo.ToString();
                APropuesta.sAprobacion = vRow.Aprobacion.ToString();
                APropuesta.sDescripcionRechazo = vRow.DescripcionRechazo.ToString();

                LPropuestas.Add(APropuesta);
            }
            return LPropuestas;
        }

        /*Función que obtiene un listado de recepciones de documentos registrados respecto al id de la solicitud*/
        public List<EOficialia> obtenerOficialias(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            List<EOficialia> LOficialias = new List<EOficialia>();
            var vDatos = ADB.ADMSPS_SOLICITUD_OFICIALIAS(iIdSolicitud);

            foreach (var vRow in vDatos)
            {
                EOficialia Oficialia = new EOficialia();
                Oficialia.sIdOficialia = vRow.IdOficialiaPartes.ToString();
                Oficialia.sConsultor = vRow.Consultor.ToString();
                Oficialia.sExpOrigen = vRow.ExpOrigen.ToString();
                Oficialia.sNumExpediente = vRow.NumExpediente.ToString();
                Oficialia.sJuzgado = vRow.Juzgado.ToString();
                Oficialia.sContraparte = vRow.Contraparte.ToString();
                Oficialia.sTipoJuicio = vRow.TipoJuicio.ToString();
                Oficialia.sOficialia = vRow.Oficialia.ToString();

                LOficialias.Add(Oficialia);
            }
            return LOficialias;
        }
    }
}
