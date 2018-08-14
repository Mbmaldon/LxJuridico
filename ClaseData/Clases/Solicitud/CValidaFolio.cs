using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class CValidaFolio
    {
        public CValidaFolio()
        {
        }

        /*Función para validar que el folio ingresado exista en la tabla Caso de la BD MPYCC*/
        public EIValidaFolio ValidaFolioMPYCC(int iIdCaso)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EIValidaFolio AValFolio = null;
            var vFolio = ADB.ADMSPS_FOLIO_EXISTENTE_MPYCC(iIdCaso);

            foreach (var f in vFolio)
            {
                AValFolio = new EIValidaFolio(f.Validacion.ToString());
            }
            return AValFolio;
        }

        /*Función para validar que el folio ingresado no exista en la tabla Solicitud de la BD CAJBD*/
        public EIValidaFolio ValidaFolio(int iIdCaso)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EIValidaFolio AValFolio = null;
            var vFolio = ADB.ADMSPS_FOLIO_EXISTENTE(iIdCaso);

            foreach (var f in vFolio)
            {
                AValFolio = new EIValidaFolio(f.Validacion.ToString());
            }
            return AValFolio;
        }
    }
}
