using ClaseData.Clases.Exportar.EExportar;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Exportar
{
    public class EDatosEvaluaciones
    {
        public EDatosEvaluaciones()
        {

        }
         /*Funció que trae una lista de evaluaciones realizadas de una fecha especifica*/
        public List<EDEvaluaciones> obtenerEvaluacion(int ibandera, DateTime Desde , DateTime Hasta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<EDEvaluaciones> LDatos = new List<EDEvaluaciones>();

            var vDetalleEvaluacion = ADB.ADMSPS_EXPORTAR_DETALLES_EVALUACIONES( ibandera,  Desde,  Hasta);

            foreach (var vDatos in vDetalleEvaluacion)
            {
                EDEvaluaciones AEvaluacion = new EDEvaluaciones();
                AEvaluacion.sfolio = vDatos.IdCaso.ToString();
                AEvaluacion.sFase = vDatos.Fase.ToString();
                AEvaluacion.sTipoSolicitud = vDatos.SolicitudTipo.ToString();
                AEvaluacion.sNumCliente = vDatos.Cliente.ToString();
                AEvaluacion.sResponsable = vDatos.Responsable.ToString();
                AEvaluacion.sFechaSolicitud = vDatos.FechaRegistro.ToString();
                AEvaluacion.sFechaVigencia = vDatos.FechaVigencia.ToString();
                AEvaluacion.sFechaEvalua = vDatos.FechaEvalua.ToString();
                AEvaluacion.sSemaforo = vDatos.Semaforo.ToString();
                AEvaluacion.SClienteContactado = vDatos.ClienteContactado.ToString();
                AEvaluacion.sP1 = vDatos.P1.ToString();
                AEvaluacion.sP2 = vDatos.P2.ToString();
                AEvaluacion.sP3 = vDatos.P3.ToString();
                AEvaluacion.sP4 = vDatos.P4.ToString();
                AEvaluacion.sP5 = vDatos.P5.ToString();
                AEvaluacion.sP6 = vDatos.P6.ToString();
                AEvaluacion.sComentario = vDatos.Comentarios.ToString();
                AEvaluacion.sFechaEvaluacion = vDatos.FechaEvaluacion.ToString();

                LDatos.Add(AEvaluacion);
            }
            return LDatos;

        }
    }
}
