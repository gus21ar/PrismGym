using FAPrismGym.Core;
using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces.ContentNavegation;
using Prism.Commands;
using Prism.Regions;

namespace FAPrismGym.Module.Auxiliares.ViewModels
{
	public class PUCNavigateBarViewModel : RegionViewModelBase
	{
		#region Comandos
		private DelegateCommand backCommand;
		public DelegateCommand BackCommand
		{
			get { return backCommand; }
			set { SetProperty(ref backCommand, value); }
		}
		private DelegateCommand homeCommand;
		public DelegateCommand HomeCommand
		{
			get { return homeCommand; }
			set { SetProperty(ref homeCommand, value); }
		}
		private DelegateCommand nextCommand;
		public DelegateCommand NextCommand
		{
			get { return nextCommand; }
			set { SetProperty(ref nextCommand, value); }
		}
		private DelegateCommand cancelCommand;
		public DelegateCommand CancelCommand
		{
			get { return cancelCommand; }
			set { SetProperty(ref cancelCommand, value); }
		}
		#endregion
		public PUCNavigateBarViewModel(IRegionManager regionManager,INavigateContent navigate) : base(regionManager, navigate)
		{
			IniciarComandos();
		}
		#region Metodos
		private void IniciarComandos()
		{
			BackCommand = new(Back);
			HomeCommand = new(NavigateHome);
			NextCommand = new(Fowar);
			cancelCommand = new(Cancel);
		}		
		private void NavigateHome()
		{
			AddPage(ViewNames.MenuInicial);
		}
		
		private void Cancel() { }
		#endregion
	}
}
