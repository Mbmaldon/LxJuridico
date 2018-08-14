using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCC.DB;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// Clase que obtiene el listado de 
	/// los estados de un servicio.
	/// 
	/// </summary>

	public class ServicioE
    {
		// CONSTRUCTOR
        public ServicioE() 
        { 
        }

		// LISTADO DE ESTADOS DE SERVICIO
        public DataSet ListadoServicioEstado() 
        {
            DBLXCCDataContext AData = new DBLXCCDataContext(ConnectionString.DbMPY);
            DataTable		  dt	= new DataTable("ServicioEstado");
            DataSet			  ds	= new DataSet();
            DataRow			  dr;

            dt.Columns.Add(new DataColumn("Id", typeof(string)));
            dt.Columns.Add(new DataColumn("ServicioEstado", typeof(string)));

            var vServE = from c in AData.ServicioStatus
                         orderby c.ServicioStatus1 ascending
                         select c;

            foreach (ServicioStatus e in vServE)
            {
                dr = dt.NewRow();
                dr["Id"] = e.IdServicioStatus.ToString();
                dr["ServicioEstado"] = e.ServicioStatus1.ToString();
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);

            return ds;
        }
    }
}
