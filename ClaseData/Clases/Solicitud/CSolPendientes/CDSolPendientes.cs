using ClaseData.Clases.Solicitud.CSolTerminadas;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.CSolPendientes
{
    public class CDSolPendientes
    {
        public CDSolPendientes()
        {

        }

        /*Función que obtiene una lista de las solicitudes pendientes asignadas al usuario logueado*/
        public List<ISolPendiente> obtenerDatos(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolPendiente> LDatos = new List<ISolPendiente>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_PENDIENTES(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolPendiente ASolicitud    = new ISolPendiente();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sSolicitante     = vRow.Solicitante.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes pendientes asignadas al usuario logueado de tipo oficialia*/
        public List<ISolPendiente> obtenerDatosOficilia(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolPendiente> LDatos = new List<ISolPendiente>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_PENDIENTES_OFICILIA(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolPendiente ASolicitud    = new ISolPendiente();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sSolicitante     = vRow.Solicitante.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes pendientes asignadas al usuario logueado (Contador del cliente)*/
        public List<ISolPendiente> obtenerDatosSolicitudInformacion(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolPendiente> LDatos = new List<ISolPendiente>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_INFORMACION_PENDIENTES(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolPendiente ASolicitud    = new ISolPendiente();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitudInformacion.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sSolicitante     = vRow.Solicitante.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVigencia.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes pendientes asignadas al usuario logueado aplicando filtro de busqueda*/
        public List<ISolPendiente> buscarDatosSolicitudesOficilia(int idUsuario, string sParametro)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolPendiente> LDatos = new List<ISolPendiente>();

            var vDatos = ADB.ADMSPS_BUCAR_SOLICITUDES_PENDIENTES_OFICILIA(idUsuario, sParametro);

            foreach (var vRow in vDatos)
            {
                ISolPendiente ASolicitud    = new ISolPendiente();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sSolicitante     = vRow.Solicitante.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes de evaluación pendientes asignadas al usuario logueado (CallCenter)*/
        public List<ISolPendiente> DatosSolicitudesEvaluacionCallCenter(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolPendiente> LDatos = new List<ISolPendiente>();

            var vDatos = ADB.ADMSPS_EVALUACIONES_PENDIENTES(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolPendiente ASolicitud    = new ISolPendiente();
                ASolicitud.sIdSolicitud     = vRow.idCallCenter.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.idFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sSolicitante     = vRow.Consultor.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVigencia.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes pendientes asignadas al personal(CallCenter)*/
        public List<ISolPendiente> datosSolicitudesEvaluacionSupCallCenter(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolPendiente> LDatos = new List<ISolPendiente>();

            var vDatos = ADB.ADMSPS_EVALUACIONES_PENDIENTES_SUPERVISOR_CALL(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolPendiente ASolicitud    = new ISolPendiente();
                ASolicitud.sIdSolicitud     = vRow.idCallCenter.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.idFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sSolicitante     = vRow.Responsable.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVigencia.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes de evaluación realizadas por el usuario (CallCenter)*/
        public List<ISolTerminadas> DatosEvaluacionesRealizadasCallCenter(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_EVALUACIONES_REALIZADAS(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.idCallCenter.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.idFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Consultor.ToString();
                ASolicitud.sFSolicitud      = vRow.FechaRegistro.ToString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVigencia.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaEvalua.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes de evaluaciones realizadas por el personal(CallCenter)*/
        public List<ISolTerminadas> datosEvaluacionesRealizadasSupCallCenter()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_EVALUACIONES_REALIZADAS_SUPERVISOR_CALL();

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.idCallCenter.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.idFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Responsable.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVigencia.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaEvalua.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes de evaluaciones realizadas por el personal(CallCenter) aplicando filtro de fecha*/
        public List<ISolTerminadas> EvaluacionesRealizadasSupCallCenterFiltros(DateTime Desde, DateTime Hasta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_EVALUACIONES_REALIZADAS_SUPERVISOR_CALL_FILTROS(Desde, Hasta);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.idCallCenter.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.idFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Responsable.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVigencia.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaEvalua.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }


    }
}
