
using System.Collections.Generic;

namespace FAPrismGym.Services.Interfaces.DataView
{
	public interface IPagosView
	{
		double Importe { get; set; }
		string ClienteDescripcion(int dni);
		List<string> LMedios();
		bool AddPay(int dni, string medio);
	}
}
