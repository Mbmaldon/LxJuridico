using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para vaciar el id del evento que se registrara*/
    public class EIOSFolioEvento
    {
        public string sIdEvento { get; set; }
        public EIOSFolioEvento(string sIdEvento)
        {
            this.sIdEvento = sIdEvento;
        }
    }
}
