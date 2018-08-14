using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.CSolRealizadas
{
    public class CDSolRealizadas
    {
        public CDSolRealizadas()
        {
        }

        /*Función para obtener la información de las solicitudes realizadas del usuario logueado*/
        public List<ISolRealizadas> obtenerDatos(int iIdUsuario)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            List<ISolRealizadas> LDatos = new List<ISolRealizadas>();

            var vDatos = ADB.ADMSPS_SOLICITUDES_REALIZADAS(iIdUsuario);

            foreach (var vRow in vDatos)
            {
                ISolRealizadas ASolicitud = new ISolRealizadas();
                ASolicitud.sIdSolicitud = vRow.IdSolicitud.ToString();
                ASolicitud.sIdCaso = vRow.IdCaso.ToString();
                ASolicitud.sIdFase = vRow.IdFase.ToString();
                ASolicitud.sFase = vRow.Fase.ToString();
                ASolicitud.sSolicitudTipo = vRow.SolicitudTipo.ToString();
                ASolicitud.sNoCliente = vRow.Cliente.ToString();
                ASolicitud.sConsultor = vRow.Responsable.ToString();
                ASolicitud.sFSolicitud = Convert.ToDateTime(vRow.FechaRegistro.ToString()).ToShortDateString();
                ASolicitud.sFVencimiento = Convert.ToDateTime(vRow.FechaVencimiento.ToString()).ToShortDateString();
                if (vRow.FechaResolucionRespuesta == null)
                {
                    ASolicitud.sFechaResolucion = " ";
                }
                else
                {
                    ASolicitud.sFechaResolucion = Convert.ToDateTime(vRow.FechaResolucionRespuesta.ToString()).ToShortDateString();
                }
                ASolicitud.sSemaforo = vRow.Semaforo.ToString();

                LDatos.Add(ASolicitud);
            }
            return LDatos;
        }
    }
}
