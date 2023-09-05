using FAPrismGym.Core.Mvvm;
using FAPrismGym.Module.Auxiliares;
using FAPrismGym.Module.Menu;
using FAPrismGym.Services;
using FAPrismGym.Services.DataView;
using FAPrismGym.Services.Interfaces;
using FAPrismGym.Services.Interfaces.ContentNavegation;
using FAPrismGym.Services.Interfaces.DataView;
using FAPrismGym.Services.Navigate;
using FAPrismGym.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace FAPrismGym
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App
	{
		protected override Window CreateShell()
		{
			return Container.Resolve<Shell>();
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterSingleton<IMessageService, MessageService>();		
			containerRegistry.Register<INavigateContent,CNavigateContent>();
			containerRegistry.Register<IPagosView, CPagosView>();
		}

		protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
		{
			moduleCatalog.AddModule<AuxiliaresModule>();
			moduleCatalog.AddModule<MenuModule>();
		}
	}
}
