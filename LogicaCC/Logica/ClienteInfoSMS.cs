using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC.Logica
{
	/// <summary>
	/// 
	/// CLASE QUE GUARDA LOS DATOS DEL CLIENTE
	/// AL QUE SE LE ENVIARA EL SMS.
	/// 
	/// </summary>
	public class ClienteInfoSMS
	{
		string sEmail;
		string sMovil;

		public string EMail
		{
			get
			{
				return sEmail;
			}

			set
			{
				sEmail = value;
			}
		}

		public string TelMovil
		{
			get
			{
				return sMovil;
			}

			set
			{
				sMovil = value;
			}
		}
	}
}
