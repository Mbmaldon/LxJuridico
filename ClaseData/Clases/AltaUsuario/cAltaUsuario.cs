using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.AltaUsuario
{
    public class cAltaUsuario
    {
        public cAltaUsuario()
        {

        }

        /*Función que consume procedimiento almacenado y manda los parametros para realizar el alta de un usuario en el sistema*/
        public void AltaUsuario(int iIdUsuarioTipo, int iIdMateri,
                                string sNombre, string sAPaterno, string sAMaterno,
                                string sUsuario, string sContrasena, string sCorreo,
                                string sTelefono, string sExtension)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            ADB.SOLSPI_ALTA_USUARIO(iIdUsuarioTipo,
                                        iIdMateri,
                                        sNombre,
                                        sAPaterno,
                                        sAMaterno,
                                        sUsuario,
                                        sContrasena,
                                        sCorreo,
                                        sTelefono,
                                        sExtension);
        }
    }
}
