using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces.ContentNavegation;
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
		public PUCTitleBarViewModel(IRegionManager regionManager,INavigateContent navigate) : base(regionManager, navigate)
		{
			Titulo = "Prism Gym";
		}
	}
}
