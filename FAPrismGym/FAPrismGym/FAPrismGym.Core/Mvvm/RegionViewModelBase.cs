using FAPrismGym.Services.Interfaces.ContentNavegation;
using Prism.Regions;
using System;

namespace FAPrismGym.Core.Mvvm
{
	public class RegionViewModelBase : ViewModelBase
	{
		protected IRegionManager RegionManager { get; private set; }
		protected INavigateContent Navigate { get; private set; }

		public RegionViewModelBase(IRegionManager regionManager, INavigateContent navigate)
			{
				RegionManager = regionManager;			
				Navigate = navigate;
			}
		public void AddPage(string pageName)
		{
			try
			{
				NavigateToContentRegion(pageName);
				Navigate.Add(pageName);
			}
			catch { }
		}
		public void Back()
		{
			var page = Navigate.Back();
			if (page != "No") NavigateToContentRegion(page);
		}
		public void Fowar()
		{
			var page = Navigate.Next();
			if (page != "No") NavigateToContentRegion(page);
		}
		private void NavigateToContentRegion(string viewName)
			{
				var myregion = RegionManager.Regions["ContentRegion"];
				myregion.RemoveAll();
				myregion.RequestNavigate(viewName);
			}
	}
}
