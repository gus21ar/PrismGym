
using FAPrismGym.Services.Interfaces.DataView;
using System.Collections.Generic;

namespace FAPrismGym.Services.DataView
{
	public class CPagosView : IPagosView
	{
		public double Importe { get; set; }

		public bool AddPay(int dni, string medio)
		{
			return Importe > 0;
		}

		public string ClienteDescripcion(int dni)
		{
			return "Fulano Mock " + dni.ToString();
		}

		public List<string> LMedios()
		{
			List<string> list = new List<string>();
			list.Add("Efectivo");
			list.Add("Cuenta Dni");
			list.Add("Mercado Pago");
			list.Add("Uala");
			return list;
		}
	}
}
