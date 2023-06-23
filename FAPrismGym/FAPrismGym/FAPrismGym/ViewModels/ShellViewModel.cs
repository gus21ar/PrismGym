using FAPrismGym.Core;
using FAPrismGym.Core.Mvvm;
using FAPrismGym.Module.Auxiliares.Views;
using Prism.Mvvm;
using Prism.Regions;

namespace FAPrismGym.ViewModels
{
	public class ShellViewModel : RegionViewModelBase
	{
		public ShellViewModel(IRegionManager manager)
			:base(manager)
		{
			manager.RegisterViewWithRegion(RegionNames.TitleRegion, typeof(PUCTitleBar));
			manager.RegisterViewWithRegion(RegionNames.NavegateRegion, typeof(PUCNavigateBar));
			//manager.RegisterViewWithRegion("TitleRegion", "TitleBar");
			//manager.RegisterViewWithRegion(RegionNames.NavegateRegion, ViewNames.NavigateBar);
		}
	}
}
