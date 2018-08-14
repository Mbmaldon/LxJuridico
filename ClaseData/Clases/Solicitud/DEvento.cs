using ClaseData.Clases.Solicitud.DetalleServicio;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud
{
    public class DEvento
    {
        public DEvento()
        {
        }

        /*Función que obtiene los detalles del evento registrado*/
        public EDetalleEvento infoEvento(int iIdEvento)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EDetalleEvento detalleEvento = null;
            var vDetalleE = ADB.ADMSPS_DETALLES_EVENTO(iIdEvento);

            foreach (var vDetalle in vDetalleE)
            {
                detalleEvento = new EDetalleEvento(vDetalle.ExpOrigen.ToString(),
                                                   vDetalle.NumExpediente.ToString(),
                                                   vDetalle.Juzgado.ToString(),
                                                   vDetalle.Contraparte.ToString(),
                                                   vDetalle.TipoJuicio.ToString(),
                                                   vDetalle.Evento.ToString(),
                                                   vDetalle.Tarea.ToString(),
                                                   vDetalle.TerminoLegal.ToString(),
                                                   vDetalle.TerminoInterno.ToString(),
                                                   vDetalle.Propuesta.ToString(),
                                                   vDetalle.DescripcionActo.ToString());
            }
            return detalleEvento;
        }

        /*Función que obtiene los detalles de la solicitud de oficilia registrada*/
        public EDetalleOficilia infoOficialia(int iIdOficlia)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            EDetalleOficilia detalleOficialia = null;
            var vDetalleOf = ADB.ADMSPS_DETALLES_OFICIALIA(iIdOficlia);

            foreach (var vDetalle in vDetalleOf)
            {
                detalleOficialia = new EDetalleOficilia(vDetalle.ExpOrigen.ToString(),
                                                        vDetalle.NumExpediente.ToString(),
                                                        vDetalle.Juzgado.ToString(),
                                                        vDetalle.Contraparte.ToString(),
                                                        vDetalle.TipoJuicio.ToString(),
                                                        vDetalle.Oficialia.ToString());
            }
            return detalleOficialia;
        }
    }
}
