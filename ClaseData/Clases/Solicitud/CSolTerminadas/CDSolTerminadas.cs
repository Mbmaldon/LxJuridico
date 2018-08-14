using ClaseData.Clases.Solicitud.CSolPendientes;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.CSolTerminadas
{
    public class CDSolTerminadas
    {
        public CDSolTerminadas()
        {

        }

        /*Función que obtiene una lista de las solicitudes terminadas por el usuario logueado*/
        public List<ISolTerminadas> obtenerDatos(int iIdUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_TERMINADAS(iIdUsuario);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Consultor.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaResolucionRespuesta.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes terminadas por el usuario logueado (Contador)*/
        public List<ISolTerminadas> solicitudesTerminadasContador(int iIdUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_TERMINADAS_CONTADOR(iIdUsuario);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Contador.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaResolucionRespuesta.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes terminadas del personal que tiene a su cargo*/
        public List<ISolTerminadas> solicitudesTerminadasSupervisorContable(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_TERMINADAS_SUPERVISOR_CONTABILIDAD(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Contador.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaResolucionRespuesta.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes que se encuentran en proceso de una resolución por el personal de su materia*/
        public List<ISolEnProceso> obtenerSolicitudesProcesoCoordinador(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolEnProceso> LDatos = new List<ISolEnProceso>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_EN_PROCESO_COORDINADOR(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolEnProceso ASolicitud    = new ISolEnProceso();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sResponsable     = vRow.Responsable.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de todas las solicitudes que estan en proceso de una resolución*/
        public List<ISolEnProceso> obtenerSolicitudesProcesoGerente()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolEnProceso> LDatos = new List<ISolEnProceso>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_EN_PROCESO_GERENTE();

            foreach (var vRow in vDatos)
            {
                ISolEnProceso ASolicitud    = new ISolEnProceso();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sResponsable     = vRow.Responsable.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes de información terminadas por el usuario logueado(Contador)*/
        public List<ISolTerminadas> DatosSolicitudInformacionRealizadas(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_INFORMACION_REALIZADAS(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitudInformacion.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Responsable.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVigencia.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaRespuesta.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes terminadas por el usuario logueado(Oficialia)*/
        public List<ISolTerminadas> datosSolicitudTerminadasOficialia(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_TERMINADAS_OFICILIA(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdOficialiaPartes.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Consultor.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaRecepción.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes terminadas por el usuario logueado*/
        public List<ISolTerminadas> datosSolicitudesTerminadasGerente(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_TERMINADAS_GERENTE(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Consultor.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaResolucionRespuesta.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes terminadas por los consultores de la materia del coordinador*/
        public List<ISolTerminadas> datosSolicitudesTerminadasCoordinador(int idUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_TERMINADAS_COORDINADOR(idUsuario);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Consultor.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaResolucionRespuesta.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de las solicitudes terminadas por el personal de su area, aplicando filtro de rango de fecha*/
        public List<ISolTerminadas> datosSolicitudesTerminadasFiltros(int idUsuario, DateTime Desde , DateTime Hasta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_TERMINADAS_GERENTE_FILTROS(idUsuario, Desde, Hasta);

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Consultor.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaResolucionRespuesta.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }

        /*Función que obtiene una lista de todas las solicitudes terminadas*/
        public List<ISolTerminadas> SolicitudesTerminadasDirectivos()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolTerminadas> LDatos = new List<ISolTerminadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_TERMINADAS_DIRECTIVOS();

            foreach (var vRow in vDatos)
            {
                ISolTerminadas ASolicitud   = new ISolTerminadas();
                ASolicitud.sIdSolicitud     = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso          = vRow.IdCaso.ToString();
                ASolicitud.sIdFase          = vRow.IdFase.ToString();
                ASolicitud.sFase            = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo   = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente       = vRow.Cliente.ToString();
                ASolicitud.sConsultor       = vRow.Responsable.ToString();
                ASolicitud.sFSolicitud      = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento    = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaResolucionRespuesta.ToString()).ToShortDateString();
                ASolicitud.sSemaforo        = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }
    }
}
