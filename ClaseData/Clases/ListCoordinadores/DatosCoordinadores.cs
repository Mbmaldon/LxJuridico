using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.ListCoordinadores
{
    public class DatosCoordinadores
    {
        List<CoordinadorData> LCoordinador;
        public DatosCoordinadores()
        {
            LCoordinador = new List<CoordinadorData>();
        }

        /*Función que consume Store Procedure y obtiene una lista de coordinadores*/

        public List<CoordinadorData> listaCoordinadores()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            //List<CoordinadorData> ADCoordinador = new List<CoordinadorData>();

            var vInfoCoord =  ADB.ADMSPS_LISTA_COORDINADORES();

            foreach (var c in vInfoCoord)
            {
                CoordinadorData ACoordinador = new CoordinadorData();
                ACoordinador.sIdUsuario = c.IdUsuario.ToString();
                ACoordinador.sUsuarioTipo = c.IdUsuarioTipo.ToString();
                ACoordinador.sIdMateria = c.IdMateria.ToString();
                ACoordinador.sMateria = c.Materia.ToString();
                ACoordinador.sNombre = c.Nombre.ToString();

                LCoordinador.Add(ACoordinador);
            }
            
            return LCoordinador;
        }

        /*Función que consume Store Procedure y obtiene una lista de coordinadores no asignados*/

        public List<CoordinadorData> listaCoordinadoresNoAsignados(int iIdSolicitud)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            //List<CoordinadorData> ADCoordinador = new List<CoordinadorData>();

            var vInfoCoord = ADB.ADMSPS_LISTA_COORDINADORES_NO_ASIGNADOS(iIdSolicitud);

            foreach (var c in vInfoCoord)
            {
                CoordinadorData ACoordinador = new CoordinadorData();
                ACoordinador.sIdUsuario = c.IdUsuario.ToString();
                ACoordinador.sUsuarioTipo = c.IdUsuarioTipo.ToString();
                ACoordinador.sIdMateria = c.IdMateria.ToString();
                ACoordinador.sMateria = c.Materia.ToString();
                ACoordinador.sNombre = c.Coordinador.ToString();

                LCoordinador.Add(ACoordinador);
            }

            return LCoordinador;
        }
    }
}
