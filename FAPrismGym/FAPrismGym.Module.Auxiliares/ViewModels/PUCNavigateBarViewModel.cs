
using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces;
using Prism.Regions;

namespace FAPrismGym.Module.Auxiliares.ViewModels
{
	public class PUCNavigateBarViewModel : RegionViewModelBase
	{
		public PUCNavigateBarViewModel(IRegionManager regionManager,INavegadorPG navegador) : base(regionManager, navegador)
		{
		}
	}
}
