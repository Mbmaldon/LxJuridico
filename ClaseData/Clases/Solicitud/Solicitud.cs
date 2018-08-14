using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class Solicitud
    {
        public Solicitud()
        {

        }

        /*Función para registrar solicitud*/
        public void RegistrarSolicitud( int iUserActual, int iCliente,
                                        int iCoordinador, int iRegistra,
                                        int iMateria, int iFolio, string sSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            ADB.SOLSPI_ALTA_SOLICITUD(iUserActual,
                                        iCliente,
                                        iCoordinador,
                                        iRegistra,
                                        iMateria,
                                        iFolio,
                                        sSolicitud);
        }

        /*Función para actualizar solicitud al ser asignado a consultor*/
        public void ACActualizarSolicitud (int iDesicion, int iIdSolicitud, int iIdUsuarioAsigna
                                          ,int iIdUsuarioAsignado, int iIdTipoEvento, int IdTipificacion 
                                          ,string sObservaciones, string sResolucion)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_ASIGNA_EVENTO(iDesicion,
                                        iIdSolicitud,
                                        iIdUsuarioAsigna,
                                        iIdUsuarioAsignado,
                                        iIdTipoEvento,
                                        IdTipificacion,
                                        sObservaciones,
                                        sResolucion);
        }
        
        /*Función para solicitar la aprobacion de la propuesta de respuesta*/
        public void SolicitudAprobacion (int IdSolicitud, int IdPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_ENVIAR_A_APROBACION(IdSolicitud, IdPropuesta);
        }

        /*Función para solicitar la aprobación de la propuesta de respuesta por el supervisor*/
        public void envioPropuestaContador(int IdSolicitud, int IdPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_ENVIAR_A_APROBACION_CONTADOR(IdSolicitud, IdPropuesta);
        }

        /*Función para solicitar la aprobación de la propuesta de respuesta por el supervisor*/
        public void AprobacionPropuesta(int iDecision, int iIdPropuesta, string Rechazo)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_APROBACION_PROPUESTA(iDecision,
                                            iIdPropuesta,
                                            Rechazo);
        }

        /*Función para enviar la aprobación de la propuesta de respuesta(Coordinador)*/
        public void AprobacionFolio(int iIdSolicitud, int iAprobacion, int Registro, int iIdPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_ENVIAR_APROBACION(iIdSolicitud,
                                         iAprobacion,
                                         Registro,
                                         iIdPropuesta);
        }

        /*Función para enviar la aprobación de la propuesta de respuesta(Supervisor Contabilidad)*/
        public void AprobacionFolioSupConta(int iIdSolicitud, int iAprobacion, int iIdPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_ENVIAR_APROBACION_SUPERVISOR_CONTABILIDAD(iIdSolicitud,
                                         iAprobacion,
                                         iIdPropuesta);
        }

        /*Función para registrar el dictamen final de la solicitud(Gerente)*/
        public void DictamenFinal (int iIdSolicitud, int iIdUsuario, string Dictamen)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_REGISTRAR_DICTAMEN(iIdSolicitud,
                                          iIdUsuario,
                                          Dictamen);
        }

        /*Función para registrar la resolución de la solicitud (Consultor)*/
        public void Resolucion(int iIdSolicitud, string sResolucion, string sResServicio)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_REGISTRAR_RESOLUCION(iIdSolicitud,
                                            sResolucion,
                                            sResServicio);
        }

        /*Función para registrar la resolución de la solicitud (Contador)*/
        public void ResolucionContador(int iIdSolicitud, string sResolucion)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_REGISTRAR_RESOLUCION_CONTADOR(iIdSolicitud,
                                            sResolucion);
        }

        /*Función para actualizar la recepcion de documentos*/
        public void RecepcionDocumento(int iIdDocumento)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_RECEPCION_DOCUMENTO(iIdDocumento);
        }
    }
}
