using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces;
using Prism.Regions;


namespace FAPrismGym.Module.Auxiliares.ViewModels
{
	public class PUCTitleBarViewModel : RegionViewModelBase
	{
		private string titulo;
		public string Titulo
		{
			get { return titulo; }
			set { SetProperty(ref titulo, value); }
		}
		public PUCTitleBarViewModel(IRegionManager regionManager, INavegadorPG navegador) : base(regionManager, navegador)
		{
			Titulo = "Prism Gym";
		}
	}
}
