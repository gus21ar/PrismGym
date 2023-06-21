using FAPrismGym.Services.Interfaces;

namespace FAPrismGym.Services
{
	public class MessageService : IMessageService
	{
		public string GetMessage()
		{
			return "Hello from the Message Service";
		}
	}
}
