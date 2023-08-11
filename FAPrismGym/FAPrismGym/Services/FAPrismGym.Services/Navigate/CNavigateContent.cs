
using FAPrismGym.Services.Interfaces.ContentNavegation;

namespace FAPrismGym.Services.Navigate
{
	public class CNavigateContent : INavigateContent
	{
		static CNodo ONodo;

		static CNavigateContent()
		{
			ONodo = new CNodo();
			ONodo.Nombre = "Raiz";
			
		}

		public bool Add(string view)
		{
			try
			{
				CNodo nodo = new CNodo();
				nodo.Nombre = view;
				nodo.Anterior = ONodo;
				ONodo.Posterior = nodo;
				ONodo = nodo;
				return true;
			}
			catch
			{
				return false;
			}
		}

		public string Back()
		{
			string respuesta = "No"; 
			if(ONodo.Anterior != null)
			{
				respuesta = ONodo.Anterior.Nombre;
				ONodo = ONodo.Anterior;
			}
			return respuesta;
		}

		public string Next()
		{
			string respuesta = "No";
			if (ONodo.Posterior != null)
			{
				respuesta = ONodo.Posterior.Nombre;
				ONodo = ONodo.Posterior;
			}
			return respuesta;
		}
	}
}
