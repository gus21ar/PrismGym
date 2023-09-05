
using FAPrismGym.Core.EventAggregator;
using Prism.Events;

namespace FAPrismGym.Core.Mvvm
{
	public class VMBPS : ViewModelBase
	{
		protected IEventAggregator aggregator;
		public VMBPS(IEventAggregator ea) 
		{
			aggregator = ea;
		}
		protected void GoHome()
		{
			aggregator.GetEvent<EAGoHomeEvent>().Publish();
		}
	}
}
