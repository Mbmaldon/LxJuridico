using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    public class Prospeccion
    {
        private static Prospeccion _instancia = null;

        public bool bCurso      { get; set; }
        public int  iIdLlamada  { get; set; }

        private Prospeccion()
        {
            bCurso      = false;
            iIdLlamada  = 0;
        }

        public static Prospeccion Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Prospeccion();

                return _instancia;
            }
        }
    }
}
