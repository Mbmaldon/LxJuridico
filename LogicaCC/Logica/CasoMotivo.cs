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
	/// Clase para obtener el listado de los posibles 
	/// motivos de una llamada
	/// 
	/// </summary>
	public class CasoMotivo
	{
		// CONSTRUCTOR
		public CasoMotivo()
		{
		}

		// DEVUELVE EL LISTADO DE MOTIVOS
		public DataSet ListadoMotivos()
		{
			DBLXCCDataContext	ADB = new DBLXCCDataContext(ConnectionString.DbMPY);
			DataTable			dt	= new DataTable("Motivos");
			DataSet				ds	= new DataSet();
			DataRow				dr;

			dt.Columns.Add(new DataColumn("IdCasoMotivo", typeof(string)));
			dt.Columns.Add(new DataColumn("Motivo", typeof(string)));

			var vLista = ADB.LXCCSPS_LISTADO_MOTIVO_LLAMADA();

			foreach(var x in vLista)
			{
				dr = dt.NewRow();
				dr["IdCasoMotivo"] = x.IdCasoMotivo.ToString();
				dr["Motivo"] = x.Motivo.ToString();
				dt.Rows.Add(dr);
			}

			ds.Tables.Add(dt);

			return ds;
		}
	}
}
