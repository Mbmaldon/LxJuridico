using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCC.DB;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// DADO UN NUMERO DE CLIENTE SE BUSCA, SU
	/// INFORMACION Y SE GUARDA DE MANERA TEMPORAL
	/// PARA POSTERIORMENTE TRABAJARLA.
	/// 
	/// </summary>
    public class Cliente
    {
		// CONSTRUCTOR
        public Cliente() 
        { 
            
        }

		// BUSCA UN CLIENTE Y OBTIENE SU INFORMACIÓN
        public ClienteData ClienteInfo(string sNCliente) 
        {
            DBLXCCDataContext   ADB             = new DBLXCCDataContext(ConnectionString.DbMPY);
            ClienteData         AClienteInfo    =  null;

            var vClienteInf = ADB.LXCCSPS_CLIENTE_INFO(sNCliente);

            foreach (var c in vClienteInf)
            {
                 AClienteInfo = new ClienteData(c.Cliente,c.Activo.ToString(),c.RFC,c.Nombre,c.APaterno,c.AMaterno,
												c.Direccion,c.Municipio,c.IdEstado.ToString(),c.CodigoPostal,
												c.NumeroLocal,c.Extension,c.NumeroMovil,c.CorreoElectronico,
												c.IdServicioTipo.ToString(),c.IdServicioStatus.ToString(),
												c.FechaContratado.ToString(),c.FechaVencimiento.ToString(),
												c.IdContadorAsignado.ToString(),c.IdCliente.ToString(),
                                                c.ServicioConta.ToString(), c.ServicioOD.ToString(),
                                                c.IdComisionista.ToString(), c.IdNivel.ToString(), c.Curp,
                                                c.NoExpediente);
            }

            return AClienteInfo;
        }
    }
}
