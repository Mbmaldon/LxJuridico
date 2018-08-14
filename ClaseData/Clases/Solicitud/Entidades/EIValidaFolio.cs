using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Solicitud.Entidades
{
    /*Entidad para vaciar resultado de folio existente*/
    public class EIValidaFolio
    {

        public string sExiste { get; set; }
        public EIValidaFolio(string sExiste)
        {
            this.sExiste = sExiste;
        }
    }
}
