using ClaseData.Clases.Archivo.ArchivoEntidades;
using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Archivo
{
    public class CDocumentosOficialia
    {
        List<ERArchivo> LDocumentos;

        public CDocumentosOficialia()
        {
            LDocumentos = new List<ERArchivo>();
        }

        /*Función que consume procedimiento almacenado y regresa la lista de rutas registradas del idOficilia que se le pasa*/
        public List<ERArchivo> listaDocumentos(int iIdOficilia)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vListaDoc = ADB.ADMSPS_RUTA_DOCUMENTO_REGISTRADO_OFICIALIA(iIdOficilia);

            foreach (var l in vListaDoc)
            {
                ERArchivo Archivos = new ERArchivo();
                Archivos.sRuta = l.RutaArchivo.ToString();
                Archivos.sIdRuta = l.idArchivoAdjunto.ToString();

                LDocumentos.Add(Archivos);
            }
            return LDocumentos;
        }

        /*Función que consume procedimiento almacenado y regresa la lista de rutas registradas del idEvento que se le pasa*/
        public List<ERArchivo> listaArchivoEvento(int iIdEvento)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vListaArch = ADB.ADMSPS_RUTA_DOCUMENTO_REGISTRADO_EVENTO(iIdEvento);

            foreach (var l in vListaArch)
            {
                ERArchivo Arch = new ERArchivo();
                Arch.sIdRuta = l.idArchivoAdjunto.ToString();
                Arch.sRuta = l.RutaArchivo.ToString();

                LDocumentos.Add(Arch);
            }
            return LDocumentos;
        }

        /*Función que consume procedimiento almacenado y regresa la lista de rutas registradas del idPropuesta que se le pasa*/
        public List<ERArchivo> rutaArchivosPropuesta(int iIdPropuesta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vArchivo = ADB.ADMSPS_RUTA_PROPUESTA_REGISTRADO(iIdPropuesta);

            foreach (var ar in vArchivo)
            {
                ERArchivo rutArchivo = new ERArchivo();
                rutArchivo.sIdRuta = ar.idArchivoAdjunto.ToString();
                rutArchivo.sRuta = ar.RutaArchivo.ToString();

                LDocumentos.Add(rutArchivo);
            }
            return LDocumentos;
        }
    }
}
