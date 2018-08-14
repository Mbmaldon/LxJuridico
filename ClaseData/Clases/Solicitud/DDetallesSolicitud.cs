using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class DDetallesSolicitud
    {
        public DDetallesSolicitud()
        {
        }

        /*Función para obtener todos los detalles de la solicitud registrada*/
        public ISDetalleSolicitud IDetalleSolicitud(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISDetalleSolicitud detalles = null;

            var vSolicitud = ADB.ADMSPS_DETALLES_SOLICITUD(iIdSolicitud);

            foreach (var vDetalles in vSolicitud)
            {
                detalles = new ISDetalleSolicitud(vDetalles.IdCaso.ToString(),
                                                  vDetalles.Cliente.ToString(),
                                                  vDetalles.NomCliente.ToString(),
                                                  vDetalles.RFC.ToString(),
                                                  vDetalles.NumeroMovil.ToString(),
                                                  vDetalles.TipoPersona.ToString(),
                                                  vDetalles.ServicioTipo.ToString(),
                                                  vDetalles.UsuarioRegistra.ToString(),
                                                  vDetalles.Coordinador.ToString(),
                                                  vDetalles.Consultor.ToString(),
                                                  vDetalles.Gerente.ToString(),
                                                  vDetalles.IdSolicitudTipo.ToString(),
                                                  vDetalles.SolicitudTipo.ToString(),
                                                  vDetalles.Solicitud.ToString(),
                                                  vDetalles.FechaRegistro.ToString(),
                                                  vDetalles.DictamenFinal.ToString(),
                                                  vDetalles.UrlCitas.ToString(),
                                                  vDetalles.UrlArchivoResolucion.ToString(),
                                                  vDetalles.ResolucionRespuesta.ToString(),
                                                  vDetalles.tipificacion.ToString(),
                                                  vDetalles.Resolucion.ToString());
            }
            return detalles;
        }

        /*Función oara obtener la ruta del archivo cargado en la resolución de la solicitud*/
        public ISRutaArchivo rutaArchivoResolucion(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISRutaArchivo rutArchivo = null;

            var vArchivo = ADB.ADMSPS_RUTA_ARCHIVO_RESOLUCION(iIdSolicitud);

            foreach (var dtm in vArchivo)
            {
                rutArchivo = new ISRutaArchivo(dtm.RutaArchivo.ToString());
            }
            return rutArchivo;
        }
    }
}
