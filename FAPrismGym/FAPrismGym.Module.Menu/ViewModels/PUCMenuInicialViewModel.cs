using FAPrismGym.Core;
using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces.ContentNavegation;
using Prism.Commands;
using Prism.Regions;

namespace FAPrismGym.Module.Menu.ViewModels
{
	public class PUCMenuInicialViewModel : RegionViewModelBase
	{
		string viewBuscada;
		public PUCMenuInicialViewModel(IRegionManager region,INavigateContent navigate)
			:base(region, navigate)
		{
			IniciarComandos();		
		}
		#region Commandos
		private DelegateCommand clientesCommand;
		public DelegateCommand ClientesCommand
		{
			get { return clientesCommand; }
			set { SetProperty(ref clientesCommand, value); }
		}
		private DelegateCommand asistenciasCommand;
		public DelegateCommand AsistenciasCommand
		{
			get { return asistenciasCommand; }
			set { SetProperty(ref asistenciasCommand, value); }
		}
		private DelegateCommand pagosCommand;
		public DelegateCommand PagosCommand
		{
			get { return pagosCommand; }
			set { SetProperty(ref pagosCommand, value); }
		}
		private DelegateCommand reportesCommand;
		public DelegateCommand ReportesCommand
		{
			get { return reportesCommand; }
			set { SetProperty(ref reportesCommand, value); }
		}
		void IniciarComandos() 
		{
			ClientesCommand = new DelegateCommand(Clientes);
			AsistenciasCommand = new DelegateCommand(Asistencias);
			PagosCommand = new DelegateCommand(Pagos);
			ReportesCommand = new DelegateCommand(Reportes);
		}
		void Clientes() 
		{
			AddPage(ViewNames.MenuClientes);
		}
		void Asistencias() 
		{
			AddPage(ViewNames.Asistencias); 
		}
		void Pagos() 
		{
			viewBuscada = ViewNames.Pagos;
			AddPage(ViewNames.Buscar); 
		}
		void Reportes() 
		{
			AddPage( ViewNames.Reportes);
		}

		#endregion
	}
}
