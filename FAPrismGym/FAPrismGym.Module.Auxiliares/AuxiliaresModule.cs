using FAPrismGym.Module.Auxiliares.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FAPrismGym.Module.Auxiliares
{
	public class AuxiliaresModule : IModule
	{
		public void OnInitialized(IContainerProvider containerProvider)
		{
			
		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<PUCNavigateBar>();
			containerRegistry.RegisterForNavigation<PUCTitleBar>();
			containerRegistry.RegisterForNavigation<PUCClose>();
		}
	}
}