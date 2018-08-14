using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.ListCoordinadores
{
    public class DatosCoorNoAsignados
    {
        /*Función que consume Store Procedure y obtiene una lista contadores asignados al cliente*/
        List<CoorNoAsignadoData> LCoordinador;
        public DatosCoorNoAsignados()
        {
            LCoordinador = new List<CoorNoAsignadoData>();
        }

        public List<CoorNoAsignadoData> contadorAsignado(int idContador)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            var vInfoCoord = ADB.ADMSPS_CONTADOR_ASIGNADO_CLIENTE(idContador);

            foreach (var c in vInfoCoord)
            {
                CoorNoAsignadoData ACoordinador = new CoorNoAsignadoData();
                ACoordinador.sIdUsuario = c.IdUsuario.ToString();
                ACoordinador.sNombre = c.Contador.ToString();

                LCoordinador.Add(ACoordinador);
            }

            return LCoordinador;
        }



    }
}
