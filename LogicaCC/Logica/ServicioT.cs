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
	/// Clase que devuelve el listado de 
	/// los tipos de servicio que puede
	/// contratar un cliente.
	/// 
	/// </summary>

    public class ServicioT
    {
		// CONSTRUCTOR
        public ServicioT() 
        { 
        }

		// LISTA TIPOS DE SERVICIO
        public DataSet ListaServiciosTipo() 
        {
            DBLXCCDataContext AData = new DBLXCCDataContext(ConnectionString.DbMPY);
            DataTable		  dt	= new DataTable("ServicioTipo");
            DataSet			  ds	= new DataSet();
            DataRow			  dr;

            dt.Columns.Add(new DataColumn("Id", typeof(string)));
            dt.Columns.Add(new DataColumn("ServicioTipo", typeof(string)));

            var vServT = from c in AData.ServicioTipo
                          where c.IdServicioTipo != 6
                           orderby c.ServicioTipo1 ascending
                           select c;

            foreach (ServicioTipo e in vServT)
            {
                dr = dt.NewRow();
                dr["Id"] = e.IdServicioTipo.ToString();
                dr["ServicioTipo"] = e.ServicioTipo1.ToString();
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);

            return ds;
        }
    }
}
