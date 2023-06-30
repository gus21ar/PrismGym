using FAPrismGym.Services.Interfaces;
using Prism.Regions;
using System;

namespace FAPrismGym.Core.Mvvm
{
	public class RegionViewModelBase : ViewModelBase, INavegationPG
	{
		protected IRegionManager RegionManager { get; private set; }

		protected INavegadorPG ONavegador { get; set; }

		public RegionViewModelBase(IRegionManager regionManager, INavegadorPG navegadorPG)
		{
			RegionManager = regionManager;
			ONavegador = navegadorPG;
		}

		public void NavigateBack()
		{
			var nave = ONavegador.Back();
			if (nave != null)
			{
				NavigateTo(nave.RegionName, nave.ViewName);
			}
		}

		public void NavigateNext()
		{
			var nave = ONavegador.Fowar();
			if (nave != null)
			{
				NavigateTo(nave.RegionName, nave.ViewName);
			}
		}

		public void NavigateHome()
		{
			ONavegador.Add(RegionNames.ContentRegion, ViewNames.MenuInicial);
			NavigateTo(RegionNames.ContentRegion, ViewNames.MenuInicial);
		}

		public void NavigateTo(string regionName, string viewName)
		{
			throw new NotImplementedException();
		}
	}
}
