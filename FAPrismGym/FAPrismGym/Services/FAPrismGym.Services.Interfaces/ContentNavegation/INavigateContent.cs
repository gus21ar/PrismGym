
using System.ComponentModel;

namespace FAPrismGym.Services.Interfaces.ContentNavegation
{
	public interface INavigateContent
	{
		bool Add(string view);
		string Back();		
		string Next();
	}
}
