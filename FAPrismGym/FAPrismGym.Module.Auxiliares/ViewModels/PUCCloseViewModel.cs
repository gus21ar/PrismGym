using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces;
using Prism.Regions;

namespace FAPrismGym.Module.Auxiliares.ViewModels
{
	public class PUCCloseViewModel : RegionViewModelBase
	{
		public PUCCloseViewModel(IRegionManager regionManager,INavegadorPG navegador) : base(regionManager, navegador)
		{
		}
	}
}
