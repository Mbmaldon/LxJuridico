using ClaseData.Clases.AltaUsuario.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.AltaUsuario
{
    public class DatosTipoUsuarios
    {
        List<cTipoUsuario> LTipoUsuario;
        public DatosTipoUsuarios()
        {
            LTipoUsuario = new List<cTipoUsuario>();
        }

        /*Función que consume procedimiento almanceando y regresa una lista de los tipos de usuarios registrados en la tabla UsuarioTipo de la BD*/
        public List<cTipoUsuario> listaTiposUsuarios()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            //List<CoordinadorData> ADCoordinador = new List<CoordinadorData>();

            var vInfoTipoUsuarios= ADB.ADMSPS_LISTA_TIPO_USUARIOS();

            foreach (var c in vInfoTipoUsuarios)
            {
                cTipoUsuario ATipoUsuario = new cTipoUsuario();
                ATipoUsuario.sIdUsuarioTipo = c.IdUsuarioTipo.ToString();
                ATipoUsuario.sUsuarioTipo = c.UsuarioTipo.ToString();

                LTipoUsuario.Add(ATipoUsuario);
            }
            return LTipoUsuario;
        }
    }
}
