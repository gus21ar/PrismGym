using FAPrismGym.Core;
using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FAPrismGym.Module.Menu.ViewModels
{
	public class PUCMenuInicialViewModel : RegionViewModelBase
	{
		public PUCMenuInicialViewModel(IRegionManager region)
			:base(region)
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
			NavigateToContentRegion(ViewNames.MenuClientes);
		}
		void Asistencias() 
		{ }
		void Pagos() 
		{
			
		}
		void Reportes() 
		{
			
		}

		#endregion
	}
}
