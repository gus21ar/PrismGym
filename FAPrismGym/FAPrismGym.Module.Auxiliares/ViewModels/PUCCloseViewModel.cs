using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces.ContentNavegation;
using Prism.Regions;


namespace FAPrismGym.Module.Auxiliares.ViewModels
{
	public class PUCCloseViewModel : RegionViewModelBase
	{
		public PUCCloseViewModel(IRegionManager regionManager,INavigateContent navigate) : base(regionManager,navigate)
		{

		}
	}
}
