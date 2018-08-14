using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
	public class Comisionista
	{
		public int		iIdComisionista		{ get; set; }
		public string	sComisionista		{ get; set; }
		public string	sNoCuenta			{ get; set; }
		public string	sIdBancario			{ get; set; }
		public string	sClabeInterbancaria { get; set; }
		public string	sBanco				{ get; set; }

		public Comisionista()
		{
			iIdComisionista		= 0;
			sComisionista		= string.Empty;
			sNoCuenta			= string.Empty;
			sIdBancario			= string.Empty;
			sClabeInterbancaria = string.Empty;
			sBanco				= string.Empty;
		}

		/// <summary>
		/// Obtiene un listado de comisionistas
		/// </summary>
		/// <returns></returns>
		public List<Comisionista> GetList()
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				List<Comisionista> lista = new List<Comisionista>();
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_COMISIONISTAS", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							Comisionista item = new Comisionista()
							{
								iIdComisionista = int.Parse(_SqlDataReader["IdUsuario"].ToString()),
								sComisionista	= _SqlDataReader["Nombre"].ToString(),
								sNoCuenta		= _SqlDataReader["Cuenta"].ToString(),
								sIdBancario		= _SqlDataReader["IdBancario"].ToString()
							};
							lista.Add(item);
						}
					}
				}
				catch (Exception)
				{
					lista = null;
				}
				return lista;
			}
		}

		/// <summary>
		/// Obtiene la información basica de un comisionista
		/// </summary>
		/// <param name="iIdComisionista"></param>
		/// <returns></returns>
		public Comisionista GetInfoComisionista(int iIdComisionista)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				Comisionista _Com = null;
				SqlCommand _SqlCommand = new SqlCommand("MDOSPS_OBTENER_COMISIONISTA_BY_ID", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdComisionista);

				try
				{
					_SqlConnection.Open();
					SqlDataReader _SqlDataReader = _SqlCommand.ExecuteReader();
					if (_SqlDataReader.HasRows)
					{
						while (_SqlDataReader.Read())
						{
							_Com = new Comisionista()
							{
								iIdComisionista		= int.Parse(_SqlDataReader["IdUsuario"].ToString()),
								sComisionista		= _SqlDataReader["Nombre"].ToString(),
								sNoCuenta			= _SqlDataReader["Cuenta"].ToString(),
								sIdBancario			= _SqlDataReader["IdBancario"].ToString(),
								sClabeInterbancaria = _SqlDataReader["ClabeInterbancaria"].ToString(),
								sBanco				= _SqlDataReader["Banco"].ToString()
							};
						}
					}
				}
				catch (Exception)
				{
					_Com = null;
				}
				return _Com;
			}
		}

		/// <summary>
		/// Actualiza en la base de datos el id bancario de un comisionista
		/// </summary>
		/// <param name="iIdComisionista"></param>
		/// <param name="sIdBancario"></param>
		/// <returns></returns>
		public int UpdateInfoComisionista(int iIdUsuario, int iIdComisionista, string sIdBancario, string sBanco)
		{
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
				SqlCommand _SqlCommand = new SqlCommand("MDOSPU_ACTUALZIAR_COMISIONISTA_IDBANCARIO", _SqlConnection) { CommandType = CommandType.StoredProcedure };
				_SqlCommand.Parameters.AddWithValue("@IdUsuarioModifica", iIdUsuario);
				_SqlCommand.Parameters.AddWithValue("@IdUsuario", iIdComisionista);
				_SqlCommand.Parameters.AddWithValue("@IdBancario", sIdBancario);
				_SqlCommand.Parameters.AddWithValue("@Banco", sBanco);

				var resultado = _SqlCommand.Parameters.Add("@Resultado", SqlDbType.Int);
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
