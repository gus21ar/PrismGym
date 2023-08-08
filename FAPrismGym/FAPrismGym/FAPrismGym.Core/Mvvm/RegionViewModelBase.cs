using FAPrismGym.Services.Interfaces;
using Prism.Regions;
using System;

namespace FAPrismGym.Core.Mvvm
{
	public class RegionViewModelBase : ViewModelBase
	{
		protected IRegionManager RegionManager { get; private set; }
		

		public RegionViewModelBase(IRegionManager regionManager)
		{
			RegionManager = regionManager;			
		}

		protected void NavigateToContentRegion(string viewName)
		{
			var myregion = RegionManager.Regions["ContentRegion"];
			myregion.RemoveAll();
			myregion.RequestNavigate(viewName);
		}
	}
}
