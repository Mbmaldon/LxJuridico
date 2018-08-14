using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.Cliente
{
    public class ClienteInfo
    {
       public ClienteInfo()
        {

        }

        /*Función para obtener la información del cliente dependiento el parametro enviado al procedimiento almacenado*/
        public ClienteData informacionCliente(string sCliente, int iTipoBusqueda)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ClienteData AclienteInfo = null;

            var vInfoCLiente = ADB.ADMSPS_CLIENTE_INFO(sCliente, iTipoBusqueda);

            foreach (var c in vInfoCLiente)
            {
                AclienteInfo = new ClienteData(c.IdCliente.ToString(), c.IdServicioTipo.ToString(), c.IdTipoPersona.ToString(),
                                               c.NoCliente.ToString(), c.RFC.ToString(), c.NombreCliente.ToString(), 
                                               c.NumeroMovil.ToString(), c.ServicioTipo.ToString(), c.TipoPersona.ToString());
                           
            }           
           
            return AclienteInfo;
        }
    }
}
