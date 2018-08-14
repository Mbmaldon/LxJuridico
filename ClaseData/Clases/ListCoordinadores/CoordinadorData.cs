using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.ListCoordinadores
{
    public class CoordinadorData
    {
        /*Entidad para vaciar la información del coordiandor*/
        public string sIdUsuario { get; set; }
        public string sUsuarioTipo { get; set; }
        public string sIdMateria { get; set; }
        public string sMateria { get; set; }
        public string sNombre { get; set; }

        public  CoordinadorData()
        {
            
        }
    }
}
