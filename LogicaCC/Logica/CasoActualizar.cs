using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaCC.DB;
using System.Data.SqlClient;
using System.Data;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// Clase que actualiza el un caso generado,
	/// es decir una llamada telefonica, cuando
	/// el cliente se comunica al callcenter
	/// 
	/// </summary>
	public class CasoActualizar
	{
		// CONSTRUCTOR
		public CasoActualizar()
		{

		}

		// GUARDA LOS DATOS DEL CASO O LLAMADA
		public int Actualizar(string sIdCasoMotivo, 
							  string sIdCliente, 
							  string sIdUsuario, 
							  string sDescripcion, 
							  string sIdCaso)
		{
			DBLXCCDataContext ADB = new DBLXCCDataContext(ConnectionString.DbMPY);
			int		iResultado	= 0;
			int?	iIResultado = null;

			ADB.LXCCSPU_CASO_ACT(Convert.ToInt64(sIdCasoMotivo),
								 Convert.ToInt64(sIdCliente),
								 Convert.ToInt64(sIdUsuario),
								 sDescripcion,
								 Convert.ToInt64(sIdCaso),
								 ref iIResultado);

			return iResultado;
		}

        public int ActualizarCaso(string sIdCasoMotivo, string sIdCliente, string sIdUsuario, string sDescripcion, string sIdCaso, string sMateria, int iIdCoordinador, string sRutaGrabacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                SqlCommand _SqlCommand = new SqlCommand("LXCCSPU_CASO_ACT_V2 ", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdCasoMotivo", sIdCasoMotivo);
                _SqlCommand.Parameters.AddWithValue("@IdCliente", sIdCliente);
                _SqlCommand.Parameters.AddWithValue("@IdUsuarioCreacion", sIdUsuario);
                _SqlCommand.Parameters.AddWithValue("@Descripcion", sDescripcion);
                _SqlCommand.Parameters.AddWithValue("@IdCaso", sIdCaso);
                _SqlCommand.Parameters.AddWithValue("@Area", sMateria);
                _SqlCommand.Parameters.AddWithValue("@IdCoordinador", iIdCoordinador);
                _SqlCommand.Parameters.AddWithValue("@RutaGrabacion", sRutaGrabacion);

                var resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.BigInt);
                resultado.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    return (int)resultado.Value;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
	}
}
