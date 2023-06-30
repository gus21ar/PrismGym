namespace FAPrismGym.Services.Interfaces
{
	public interface INavegationPG
	{
		void NavigateBack();
		void NavigateNext();
		void NavigateHome();
		void NavigateTo(string regionName, string viewName);
	}
}
