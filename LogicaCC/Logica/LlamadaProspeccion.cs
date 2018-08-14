using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    public class LlamadaProspeccion
    {
        private static LlamadaProspeccion _instancia = null;

        public bool bCurso { get; set; }

        private LlamadaProspeccion()
        {
            bCurso = false;
        }

        public static LlamadaProspeccion Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new LlamadaProspeccion();

                return _instancia;
            }
        }
    }
}
