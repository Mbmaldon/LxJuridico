using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class DSAsignarConsultor
    {

        public  DSAsignarConsultor()
        {

        }

        /*Función que obtiene los detalles de la solicitud registrada*/
        public ISAsignarConsultor InfoSolicitud(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISAsignarConsultor detalleSoli = null;
            var vSolicitudDetalle = ADB.ADMSPS_DETALLE_SOLICITUD_F1(iIdSolicitud);

            foreach (var vDetalles in vSolicitudDetalle)
            {
                detalleSoli = new ISAsignarConsultor(vDetalles.IdCaso.ToString(),
                                                    vDetalles.Cliente.ToString(),
                                                    vDetalles.NomCliente.ToString(),
                                                    vDetalles.RFC.ToString(),
                                                    vDetalles.NumeroMovil.ToString(),
                                                    vDetalles.TipoPersona.ToString(),
                                                    vDetalles.ServicioTipo.ToString(),
                                                    vDetalles.UsuarioRegistra.ToString(),
                                                    vDetalles.Solicitud.ToString(),
                                                    vDetalles.FechaRegistro.ToString(),
                                                    vDetalles.UrlLlamadas.ToString(),
                                                    vDetalles.IdContadorAsignado.ToString());
            }
            return detalleSoli;
        }

        /*Función para obtener el contador asignado al cliente*/
        public ISContadorCliente InfoContador(int iIdContador)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISContadorCliente Contador = null;
            var vInfoContador = ADB.ADMSPS_CONTADOR_CLIENTE(iIdContador);

            foreach (var iContador in vInfoContador)
            {
                Contador = new ISContadorCliente(iContador.IdUsuario.ToString(),
                                                  iContador.Contador.ToString());
            }
            return Contador;
        }
    }
}
