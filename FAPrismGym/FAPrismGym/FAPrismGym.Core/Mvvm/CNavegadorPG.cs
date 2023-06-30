
using FAPrismGym.Services;
using FAPrismGym.Services.Interfaces;

namespace FAPrismGym.Core.Mvvm
{
	public class CNavegadorPG : INavegadorPG
	{		
		static INodoNavigate Active { get; set; }
		bool CanBack { get; set; }
		bool CanFowar { get; set; }

		static CNavegadorPG() 
		{ 
			Active = new CNodoNavigate();
			Active.RegionName = RegionNames.ContentRegion;
			Active.ViewName = ViewNames.MenuInicial;
		}
		public CNavegadorPG() { }

		public void Add(string _regionName, string _viewName)
		{
			INodoNavigate OnodoNavigate = new CNodoNavigate();
			OnodoNavigate.RegionName = _regionName;
			OnodoNavigate.ViewName = _viewName;
			OnodoNavigate.NodoBack = Active;
			Active.NodoForward = OnodoNavigate;
			Active = OnodoNavigate;
			CanBack = true;
		}
		public INodoNavigate Back()
		{
			if(CanBack)
			{
				Active = Active.NodoBack;
				CanFowar = true;
				CanBack = Active.NodoBack != null;
			}
			return Active;
		}
		public INodoNavigate Fowar() 
		{
			if(CanFowar)
			{
				Active = Active.NodoForward;
				CanBack = true;
				CanFowar = Active.NodoForward != null;
			}
			return Active;
		}


	}
}
