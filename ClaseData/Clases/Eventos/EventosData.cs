using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Eventos
{
    public class EventosData
    {
        /*Entidad para vaciar la información de los eventos registrados en la tabla Eventos de la BD*/
        public EventosData()
        {

        }

        public string sIdEvento { get; set; }
        public string sEvento { get; set; }
    }
}
