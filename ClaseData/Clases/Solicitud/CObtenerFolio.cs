using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class CObtenerFolio
    {
        public CObtenerFolio()
        {

        }

        /*Funcion para obtener el id que sera generado al registrar una propuesta de respuesta*/
        public EIOSFolioPropuesta obtenerID()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EIOSFolioPropuesta AValId = null;
            var vID = ADB.OBTENER_ULTIMO_ID_PRESPUESTA();

            foreach (var f in vID)
            {
                AValId = new EIOSFolioPropuesta(f.ID.ToString());
            }
            return AValId;
        }

        /*Funcion para obtener el id que sera generado al registrar un evento*/
        public EIOSFolioEvento obtenerIDEvento()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EIOSFolioEvento AValId = null;
            var vID = ADB.OBTENER_ULTIMO_ID_SOLICITUD_EVENTO();

            foreach (var fo in vID)
            {
                AValId = new EIOSFolioEvento(fo.ID.ToString());
            }
            return AValId;
        }
    }
}
