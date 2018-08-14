using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.ListServicio
{
    public class DExisteTipificacion
    {
        public int iIdTipoServicio { get; set; }

        public DExisteTipificacion(int IdTipoServicio)
        {
            iIdTipoServicio = IdTipoServicio;
        }
    }
}
