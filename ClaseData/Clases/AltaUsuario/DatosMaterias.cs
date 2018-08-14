using ClaseData.Clases.AltaUsuario.Entidades;
using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.AltaUsuario
{
    public class DatosMaterias
    {
        List<cMateria> LMateria;
        public DatosMaterias()
        {
            LMateria = new List<cMateria>();
        }
        /*Función que consume procedimiento y regresa una lista de materias registradas en la tabla Materias de la BD*/
        public List<cMateria> listaMaterias()
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);

            var vInfoMateria = ADB.ADMSPS_LISTA_MATERIAS();

            foreach (var c in vInfoMateria)
            {
                cMateria AMateria = new cMateria();
                AMateria.sIdMateria = c.IdMateria.ToString();
                AMateria.sMateria = c.Materia.ToString();

                LMateria.Add(AMateria);
            }
            return LMateria;
        }
    }
}
