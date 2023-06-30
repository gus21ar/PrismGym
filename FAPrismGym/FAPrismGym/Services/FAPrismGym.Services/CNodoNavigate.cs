
using FAPrismGym.Services.Interfaces;

namespace FAPrismGym.Services
{
	public class CNodoNavigate : INodoNavigate
	{
		public string ViewName { get; set; }
		public string RegionName { get; set; }
		public INodoNavigate NodoBack { get; set; }
		public INodoNavigate NodoForward { get; set; }
	}
}
