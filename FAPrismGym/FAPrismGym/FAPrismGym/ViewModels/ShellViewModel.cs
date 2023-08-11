using FAPrismGym.Core;
using FAPrismGym.Core.Mvvm;
using FAPrismGym.Module.Auxiliares.Views;
using FAPrismGym.Module.Menu.Views;
using FAPrismGym.Services.Interfaces.ContentNavegation;
using Prism.Regions;

namespace FAPrismGym.ViewModels
{
	public class ShellViewModel : RegionViewModelBase
	{
		public ShellViewModel(IRegionManager manager,INavigateContent navigate )
			:base(manager, navigate)
		{
			manager.RegisterViewWithRegion(RegionNames.TitleRegion, typeof(PUCTitleBar));
			manager.RegisterViewWithRegion(RegionNames.NavegateRegion, typeof(PUCNavigateBar));
			manager.RegisterViewWithRegion(RegionNames.CloseRegion, typeof(PUCClose));
			manager.RegisterViewWithRegion(RegionNames.ContentRegion,typeof(PUCMenuInicial));
		}
	}
}
