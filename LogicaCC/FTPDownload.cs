using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC
{
    public class FTPDownload
    {
        private static FTPDownload _instancia = null;

        public string sRutaArchivo      { get; set; }
        public string sNombreArchivo    { get; set; }

        private FTPDownload()
        {
            sRutaArchivo    = "";
            sNombreArchivo  = "";
        }

        public static FTPDownload Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new FTPDownload();
                return _instancia;
            }
        }
    }
}
