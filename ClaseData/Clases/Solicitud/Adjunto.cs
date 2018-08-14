using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class Adjunto
    {
        public Adjunto()
        {

        }

        /*Función para registrar la ruta del archivo que ha sido cargado en los formularios*/
        public void RegistrarRutaAdjunto(int idTabla, int iIdFolio, int iIdTipoDocumento, int iIdUsuario,
                                                 string sRuta)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_RUTA_ARCHIVO_ADJUNTO(idTabla,
                                            iIdFolio,
                                            iIdTipoDocumento,
                                            iIdUsuario,
                                            sRuta);
        }
    }
}
