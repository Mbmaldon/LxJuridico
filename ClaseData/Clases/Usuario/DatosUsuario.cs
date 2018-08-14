using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases
{
    public class DatosUsuario
    {
        // INSTANCIA UNICA A CLASE
        private static DatosUsuario AInstancia = null;

        public string sNombre { get; set; }
        public string sAPaterno { get; set; }
        public string sAMAterno { get; set; }
        public string sTipoUsuario { get; set; }
        public string sIdusuario { get; set; }
        public string sIdMateria { get; set; }
           

        private DatosUsuario()
        {
            sIdusuario      = null;
            sTipoUsuario    = null;
            sIdMateria      = null;
            sNombre         = null;
            sAPaterno       = null;
            sAMAterno       = null;
        }

        /*Clase singleton*/
        public static DatosUsuario Instancia
        {
            get
            {
				if(AInstancia == null)
				{
					AInstancia = new DatosUsuario();
				}

                return AInstancia;
            }
        }
    }
}
