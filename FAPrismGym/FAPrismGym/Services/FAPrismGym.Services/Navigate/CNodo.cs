
namespace FAPrismGym.Services.Navigate
{
	public class CNodo
	{
		public string Nombre { get; set; }
		public CNodo Anterior { get; set; }
		public CNodo Posterior { get; set; }
	}
}
