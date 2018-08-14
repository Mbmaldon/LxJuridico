using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.ListConsultores
{
    public class DatosConsultores
    {
        List<ConsultorData> LConsultor;

        public DatosConsultores()
        {
            LConsultor = new List<ConsultorData>();
        }
        /*Función para obtener una lista de consultores dependiendo la materia del coordinador*/
        public List<ConsultorData> listaConsultores(int iIdMateria)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vInfoConsul = ADB.ADMSPS_LISTA_CONSULTORES(iIdMateria);

            foreach (var c in vInfoConsul)
            {
                ConsultorData AConsultor = new ConsultorData();
                AConsultor.sIdUsuario = c.IdUsuario.ToString();
                AConsultor.sUsuario = c.Nombre.ToString();

                LConsultor.Add(AConsultor);
            }
            return LConsultor;

        }

        /*Función para obtener la lista de responsables a la solicitudes registradas*/
        public List<ConsultorData> listaResponsables()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vInfoUsuario = ADB.ADMSPS_RESPONSABLES_SOLICITUDES_TERMINADAS_GERENTE();

            foreach (var c in vInfoUsuario)
            {
                ConsultorData AConsultor = new ConsultorData();
                AConsultor.sIdUsuario = c.IdUsuario.ToString();
                AConsultor.sUsuario = c.Responsable.ToString();

                LConsultor.Add(AConsultor);
            }
            return LConsultor;

        }
    }
}
