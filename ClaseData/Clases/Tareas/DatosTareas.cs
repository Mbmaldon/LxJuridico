using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Tareas
{
    public class DatosTareas
    {

        List<TareasData> LTareas;

        public DatosTareas()
        {
            LTareas = new List<TareasData>();
        }

        /*Función para obtener la lista de tareas registradas en la tabla tareas*/
        public List<TareasData> ListaTareas(int iIdMateria, int iIdEvento)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vTareas = ADB.ADMSPS_LISTA_TAREAS(iIdMateria, iIdEvento);

            foreach (var t in vTareas)
            {
                TareasData ATarea = new TareasData();
                ATarea.sIdTarea = t.IdTarea.ToString();
                ATarea.sTarea = t.Tarea.ToString();
                ATarea.sDiasTermInterno = t.DiasTerminoInterno.ToString();

                LTareas.Add(ATarea);
            }
            return LTareas;
        }
    }
}
