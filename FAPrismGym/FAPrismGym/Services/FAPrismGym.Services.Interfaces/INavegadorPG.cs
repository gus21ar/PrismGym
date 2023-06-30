
namespace FAPrismGym.Services.Interfaces
{
	public interface INavegadorPG
	{
		void Add(string _regionName, string viewName);
		INodoNavigate Back();
		INodoNavigate Fowar();
	}
}
