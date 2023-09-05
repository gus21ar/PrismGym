
using Prism.Events;

namespace FAPrismGym.Core.EventAggregator
{
	public class CDniSentEvent : PubSubEvent<int>
	{
	}
	public class AceptarBuscarEvent : PubSubEvent
	{
	}
	public class LoadPayEvent : PubSubEvent 
	{
	}
	public class EADniSentEvent : PubSubEvent<int>
	{
	}
	public class EAGoHomeEvent : PubSubEvent 
	{
	}
}
