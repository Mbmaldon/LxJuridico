using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.ListServicio
{
    public class DatosServicios
    {
        List<ServicioData> LServicio;
        public DatosServicios()
        {
            LServicio = new List<ServicioData>();
        }

        /*Función que consume Store Procedure y obtiene una lista de servicios*/

        public List<ServicioData> listaServicios(int iIdMateria, int iIdSolicitudTipo)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            //List<CoordinadorData> ADCoordinador = new List<CoordinadorData>();

            var vInfoServ = ADB.ADMSPS_LISTA_TIPO_SERVICIOS(iIdMateria, iIdSolicitudTipo);

            foreach (var c in vInfoServ)
            {
                ServicioData AServicio = new ServicioData();
                AServicio.sIdServicio = c.idTipoServicio.ToString();
                AServicio.sTipificacion = c.tipificacion.ToString();


                LServicio.Add(AServicio);
            }
            return LServicio;
        }
    }
}
