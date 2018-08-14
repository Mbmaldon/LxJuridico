using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.ListTEventos
{
    public class DatosTipoEventos
    {
        /*Función que consume Store Procedure y obtiene una lista de eventos*/
        List<TipoEventosData> LTipoEvento;

        public DatosTipoEventos()
        {
            LTipoEvento = new List<TipoEventosData>();
        }

        public List<TipoEventosData> listaTipoEventos()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vITipoEvento = ADB.ADMSPS_LISTA_TIPO_EVENTOS();

            foreach (var e in vITipoEvento)
            {
                TipoEventosData AEventos = new TipoEventosData();
                AEventos.sIdTipoEvento = e.IdSolicitudTipo.ToString();
                AEventos.sTipoEvento = e.SolicitudTipo.ToString();

                LTipoEvento.Add(AEventos);
            }
            return LTipoEvento;
        }
    }
}
