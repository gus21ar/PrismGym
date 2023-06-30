
namespace FAPrismGym.Services.Interfaces
{
	public interface INodoNavigate
	{
		string ViewName { get; set; }
		string RegionName { get; set; }
		INodoNavigate NodoBack { get; set; }
		INodoNavigate NodoForward { get; set; }
	}
}
