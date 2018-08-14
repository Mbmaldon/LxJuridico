using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Eventos
{
    public class DatosEventos
    {
        List<EventosData> LEventos;

        public DatosEventos()
        {
            LEventos = new List<EventosData>();
        }

        /*Función que regresa un listado de eventos existente en la tabla eventos de la BD*/
        public List<EventosData> ListaEventos(int iIdMateria, int iIdSolicitudTipo)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            var vEventos = ADB.ADMSPS_LISTA_EVENTOS(iIdMateria, iIdSolicitudTipo);

            foreach (var ev in vEventos)
            {
                EventosData AEvento = new EventosData();
                AEvento.sIdEvento = ev.IdEvento.ToString();
                AEvento.sEvento = ev.Evento.ToString();

                LEventos.Add(AEvento);
            }
            return LEventos;
        }
    }
}
