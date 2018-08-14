using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class DDRegistrado
    {
        public DDRegistrado()
        {

        }

        /*Función para obtener los detalles del documento registrado*/
        public ISDocumento documentoRegistrado (int iIdDocumento)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISDocumento documento = null;

            var vDocumento = ADB.ADMSPS_DOCUMENTO_REGISTRADO(iIdDocumento);

            foreach (var vDetalle in vDocumento)
            {
                documento = new ISDocumento(vDetalle.Requisicion.ToString(),
                                            vDetalle.TipoRequisicion.ToString());
            }
            return documento;

        }

        /*Función para obtener la ruta del archivo del documento registrado*/
        public ISRutaDocumento rutaDocumentoRegistrado(int iIdDocumento)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ISRutaDocumento rutaDocumento = null;

            var vDocumento = ADB.ADMSPS_RUTA_DOCUMENTO_REGISTRADO(iIdDocumento);

            foreach (var vDetalle in vDocumento)
            {
                rutaDocumento = new ISRutaDocumento(vDetalle.idArchivoAdjunto.ToString()
                                                    ,vDetalle.RutaArchivo.ToString());
            }
            return rutaDocumento;
        }
    }
}
