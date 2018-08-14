using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCC.DB;

namespace LogicaCC.Logica
{
	public class DeclaracionTipo
	{
		// CONSTRUCTOR
		public DeclaracionTipo()
		{
		}

		// LISTADO DE TIPOS
		public DataSet Lista()
		{
			DBLXCCDataContext ADB = new DBLXCCDataContext(ConnectionString.DbMPY);
			DataTable dt = new DataTable("TDecTipo");
			DataSet ds = new DataSet();
			DataRow dr;

			dt.Columns.Add(new DataColumn("IdDecTipo", typeof(string)));
			dt.Columns.Add(new DataColumn("DecTipo", typeof(string)));

			var vLista = ADB.DeclaracionTipo;

			foreach(var x in vLista)
			{
				dr = dt.NewRow();
				dr["IdDecTipo"] = x.IdDeclaracionTipo.ToString();
				dr["DecTipo"] = x.DeclaracionTipo1.ToString();
				dt.Rows.Add(dr);
			}

			ds.Tables.Add(dt);

			return ds;
		}
	}
}
