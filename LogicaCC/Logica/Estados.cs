using System;
using System.Collections;
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
	/// Clase que retorna el listado de los
	/// estados de la republica.
	/// 
	/// </summary>

    public class Estados
    {
		// CONSTRUCTOR
        public Estados() 
        { 
        }

		// LISTADO DE ESTADOS
        public DataSet ListaEstados() 
        {
            DBLXCCDataContext AData = new DBLXCCDataContext(ConnectionString.DbMPY);
            DataTable            dt = new DataTable("Estados");
            DataSet              ds = new DataSet();
            DataRow              dr;

            dt.Columns.Add(new DataColumn("id", typeof(string)));
            dt.Columns.Add(new DataColumn("estado", typeof(string)));
            
            var vEstados = from c in AData.Estado
                            orderby c.Estado1 ascending
                           select c;

            foreach (Estado e in vEstados) 
            {
                dr = dt.NewRow();
                dr["id"] = e.IdEstado.ToString();
                dr["estado"] = e.Estado1.ToString();
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);

            return ds;
        }
    }
}
