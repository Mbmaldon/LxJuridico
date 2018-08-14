using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
    /// <summary>
	/// 
    /// Función que guarda la información del usuario que seran
    /// usadas durante la sesión.
	/// 
    /// </summary>
    public class UsuarioData
    {
        // INSTANCIA UNICA A CLASE
        private static UsuarioData _instancia = null;

        public string sNombre { get; set; }
        public string sAPaterno { get; set; }
        public string sAMAterno { get; set; }
        public string sTipoUsuario { get; set; }
        public string sIdusuario { get; set; }

        // CONSTRUCTOR PRIVADO PARA QUE NO SE GENEREN INSTANCIAS
        private UsuarioData() 
        {
            sIdusuario      = null;
            sTipoUsuario    = null;
            sNombre         = null;
            sAPaterno       = null;
            sAMAterno       = null; 
        }

        // PROPIEDAD DE SOLO LECTURA Y GENERAR INSTANCIA AL MISMO
        public static UsuarioData Instancia 
        {
            get 
            { 
                if(_instancia == null)
                    _instancia = new UsuarioData();

                return _instancia;
            }
        }
    }
}
