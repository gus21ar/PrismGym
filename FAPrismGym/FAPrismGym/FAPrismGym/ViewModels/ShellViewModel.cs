using FAPrismGym.Core;
using FAPrismGym.Core.EventAggregator;
using FAPrismGym.Core.Mvvm;
using FAPrismGym.Module.Auxiliares.Views;
using FAPrismGym.Module.Menu.Views;
using FAPrismGym.Services.Interfaces.ContentNavegation;
using Prism.Events;
using Prism.Regions;
using System;

namespace FAPrismGym.ViewModels
{
	public class ShellViewModel : RegionViewModelBase
	{
		IEventAggregator aggregator;
		private int _dni;
		public int Dni
		{
			get { return _dni; }
			set { SetProperty(ref _dni, value); }
		}
		private string textoAMostrar;
		public string TextoAMostrar
		{
			get { return textoAMostrar; }
			set { SetProperty(ref textoAMostrar, value); }
		}
		public ShellViewModel(IRegionManager manager,INavigateContent navigate, IEventAggregator ea )
			:base(manager, navigate)
		{
			manager.RegisterViewWithRegion(RegionNames.TitleRegion, typeof(PUCTitleBar));
			manager.RegisterViewWithRegion(RegionNames.NavegateRegion, typeof(PUCNavigateBar));
			manager.RegisterViewWithRegion(RegionNames.CloseRegion, typeof(PUCClose));
			manager.RegisterViewWithRegion(RegionNames.ContentRegion,typeof(PUCMenuInicial));
			aggregator = ea;
			ea.GetEvent<CDniSentEvent>().Subscribe(DniRecibido);
			ea.GetEvent<AceptarBuscarEvent>().Subscribe(CargarPagos);
			ea.GetEvent<LoadPayEvent>().Subscribe(MandarDni);
			ea.GetEvent<EAGoHomeEvent>().Subscribe(GoHomeRequest);
		}

		private void DniRecibido(int dni)
		{
			Dni = dni;
			TextoAMostrar = Dni.ToString();			
		}

		private void CargarPagos()
		{
			AddPage(ViewNames.Pagos);
		}

		private void MandarDni() 
		{ 
			aggregator.GetEvent<EADniSentEvent>().Publish(Dni);
		}
		private void GoHomeRequest()
		{
			AddPage(ViewNames.MenuInicial);
		}
	}
}
