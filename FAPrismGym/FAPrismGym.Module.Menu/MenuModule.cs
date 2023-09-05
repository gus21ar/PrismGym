using FAPrismGym.Module.Menu.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace FAPrismGym.Module.Menu
{
	public class MenuModule : IModule
	{
		public void OnInitialized(IContainerProvider containerProvider)
		{

		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<PUCMenuInicial>();
			containerRegistry.RegisterForNavigation<PUCMenuClientes>();
			containerRegistry.RegisterForNavigation<PUCAsistencias>();
			containerRegistry.RegisterForNavigation<PUCPagos>();
			containerRegistry.RegisterForNavigation<PUCReportes>();
			containerRegistry.RegisterForNavigation<PUCBuscar>();
			
		}
	}
}