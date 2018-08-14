using ClaseData.Clases.CallCenter.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.CallCenter
{
    public class DListaEvaluaciones
    {
        List<EEvaluaciones> LEvaluaciones;

        public DListaEvaluaciones()
        {
            LEvaluaciones = new List<EEvaluaciones>();
        }

        /*Función para obtener la lista de evaluaciones registradad*/
        public List<EEvaluaciones> listaEvaluaciones ()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vListEvalu = ADB.ADMSPS_LISTA_EVALUACIONES();

            foreach (var e in vListEvalu)
            {
                EEvaluaciones lista = new EEvaluaciones();
                lista.sIdEvaluacion = e.idTipoEvaluacion.ToString();
                lista.sEvaluacion = e.Evaluacion.ToString();

                LEvaluaciones.Add(lista);
            }
            return LEvaluaciones;
        }
    }
}
