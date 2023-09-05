using FAPrismGym.Core.EventAggregator;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;

namespace FAPrismGym.Module.Menu.ViewModels
{
	public class PUCBuscarViewModel : BindableBase
	{
		IEventAggregator eventAggregator;
		private string clienteDescripcion;
		public string ClienteDescripcion
		{
			get { return clienteDescripcion; }
			set { SetProperty(ref clienteDescripcion, value); }
		}

		private string textoABuscar;
		public string TextoABuscar
		{
			get { return textoABuscar; }
			set { SetProperty(ref textoABuscar, value); }
		}

		private DelegateCommand buscarDniCommand;
		public DelegateCommand BuscarDniCommand
		{
			get { return buscarDniCommand; }
			set { SetProperty(ref buscarDniCommand, value); }
		}

		private DelegateCommand aceptarCommand;
		public DelegateCommand AceptarCommand
		{
			get { return aceptarCommand; }
			set { SetProperty(ref aceptarCommand, value); }
		}

		public PUCBuscarViewModel(IEventAggregator aggregator)
		{
			eventAggregator = aggregator;
			IniciarComandos();
		}

		private void IniciarComandos() 
		{
			BuscarDniCommand = new DelegateCommand(BuscarDni);
			AceptarCommand = new DelegateCommand(Aceptar);
		}

		private void BuscarDni() 
		{
			ClienteDescripcion = TextoABuscar;
			var num = Convert.ToInt32(TextoABuscar);
			eventAggregator.GetEvent<CDniSentEvent>().Publish(num);
		}
		private void Aceptar()
		{
			eventAggregator.GetEvent<AceptarBuscarEvent>().Publish();
		}
	}
}
