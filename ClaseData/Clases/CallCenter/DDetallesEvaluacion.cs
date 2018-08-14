using ClaseData.Clases.CallCenter.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.CallCenter
{
    public class DDetallesEvaluacion
    {
        public DDetallesEvaluacion()
        {

        }
        /*Funcion para consumir procedimiento que regresa la información del cliente y el servicio que le fue brindado al cliente*/
        public EDetallesEvaluacion InfoEvaluacion(int iIdCallCenter)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EDetallesEvaluacion detalleEvaluacion = null;

            var vEvaluacionDetalle = ADB.ADMSPS_DETALLE_EVALUACION_SERVICIO(iIdCallCenter);

            foreach (var vDetalles in vEvaluacionDetalle)
            {
                detalleEvaluacion = new EDetallesEvaluacion(vDetalles.NumCliente.ToString(),
                                                            vDetalles.Cliente.ToString(),
                                                            vDetalles.RFC.ToString(),
                                                            vDetalles.NumeroMovil.ToString(),
                                                            vDetalles.NumeroLocal.ToString(),
                                                            vDetalles.IdCaso.ToString(),
                                                            vDetalles.FechaSolicitud.ToString(),
                                                            vDetalles.FechaResolucionRespuesta.ToString(),
                                                            vDetalles.Consultor.ToString(),
                                                            vDetalles.SolicitudTipo.ToString(),
                                                            vDetalles.FechaRegistro.ToString());
            }
            return detalleEvaluacion;
        }

        /*Función para consumir procedimiento almacenado y obtener la lista de evaluaciones registradas*/
        public List<EIEvaluaciones> obetenerEvaluacionesRegis(int idCallCenter)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<EIEvaluaciones> LEvaluaciones = new List<EIEvaluaciones>();

            var vDatos = ADB.ADMSPS_EVALUACIONES_SERVICIO_REGISTRADAS(idCallCenter);

            foreach (var vRow in vDatos)
            {
                EIEvaluaciones AEvaluaciones = new EIEvaluaciones();
                AEvaluaciones.sIdEvaluacion = vRow.idEvaluacionServicio.ToString();
                AEvaluaciones.sUsuario = vRow.Usuario.ToString();
                AEvaluaciones.sFechaRegistro = vRow.FechaRegistro.ToString();
                AEvaluaciones.sClienteContactado = vRow.ClienteContactado.ToString();

                LEvaluaciones.Add(AEvaluaciones);
            }
            return LEvaluaciones;
        }

        /*Función para obtener el detalle de la evaluacion registrada cuando se localiza al cliente*/
        public EDEvaluacionRegistradaS informacionEvaluacionS(int iIdEvaluacion)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EDEvaluacionRegistradaS detalleEvalu = null;
            var vEvaluacionDetalle = ADB.ADMSPS_DETALLE_EVALUACION_SERVICIO_REGISTRADA_S(iIdEvaluacion);

            foreach (var vDetalles in vEvaluacionDetalle)
            {
                detalleEvalu = new EDEvaluacionRegistradaS(vDetalles.P1.ToString(),
                                                            vDetalles.P2.ToString(),
                                                            vDetalles.P3.ToString(),
                                                            vDetalles.P4.ToString(),
                                                            vDetalles.P5.ToString(),
                                                            vDetalles.P6.ToString(),
                                                            vDetalles.Comentarios.ToString(),
                                                            vDetalles.FechaRegistro.ToString());


            }
            return detalleEvalu;
        }

        /*Función para obtener el detalle de la evaluacion registrada cuando no se localiza al cliente*/
        public EDEvaluacionRegistradaN informacionEvaluacionN(int iIdEvaluacion)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EDEvaluacionRegistradaN detalleEvalu = null;
            var vEvaluacionDetalle = ADB.ADMSPS_DETALLE_EVALUACION_SERVICIO_REGISTRADA_N(iIdEvaluacion);

            foreach (var vDetalles in vEvaluacionDetalle)
            {
                detalleEvalu = new EDEvaluacionRegistradaN(vDetalles.Observaciones.ToString(),
                                                            vDetalles.FechaRegistro.ToString());

            }
            return detalleEvalu;
        }

        /*Funcioón para realizar el cierre de la evaluación*/
        public void evaluacionRealizada(int idCallCenter)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPU_CIERRE_EVALUACION(idCallCenter);
        }
    }
}
