using FAPrismGym.Core.EventAggregator;
using FAPrismGym.Core.Mvvm;
using FAPrismGym.Services.Interfaces.DataView;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace FAPrismGym.Module.Menu.ViewModels
{
	public class PUCPagosViewModel : VMBPS
	{
		int dniActual;
		IPagosView PagosView { get; set; }
		private string descripcion;
		public string Descripcion
		{
			get { return descripcion; }
			set { SetProperty(ref descripcion, value); }
		}
		private string importe;
		public string Importe
		{
			get { return importe; }
			set { SetProperty(ref importe, value); PagarCommand.RaiseCanExecuteChanged(); }
		}
		private string medioSelected;
		public string MedioSelected
		{
			get { return medioSelected; }
			set { SetProperty(ref medioSelected, value); }
		}
		public List<string> Lista { get; set; }
		#region Comandos
		private DelegateCommand pagarCommand;
		public DelegateCommand PagarCommand
		{
			get { return pagarCommand; }
			set { SetProperty(ref pagarCommand, value); }
		}
		private DelegateCommand cancelarCommand;
		public DelegateCommand CancelarCommand
		{
			get { return cancelarCommand; }
			set { SetProperty(ref cancelarCommand, value); }
		}
		#endregion
		public PUCPagosViewModel(IEventAggregator _event,IPagosView repoPagos)
			:base(_event)
		{
			PagosView = repoPagos;
			Lista = PagosView.LMedios();
			aggregator.GetEvent<EADniSentEvent>().Subscribe(Cargar);
			aggregator.GetEvent<LoadPayEvent>().Publish();
			IniciarComandos();
		}
		#region Metodos
		public void Cargar (int dnicliente)
		{
			dniActual = dnicliente;
			Descripcion = PagosView.ClienteDescripcion(dnicliente);
		}

		public void IniciarComandos()
		{
			PagarCommand = new DelegateCommand(Pagar,CanPay);
			CancelarCommand = new DelegateCommand(Cancelar);
		}

		private void Pagar() 
		{
			PagosView.AddPay(dniActual, MedioSelected);

			Descripcion = "Pagado " + DateTime.Today.ToString();

		}

		private bool CanPay()
		{
			bool respuesta = false;

			try
			{
				double impActual = 0;

				impActual = Convert.ToDouble(Importe);

				PagosView.Importe = impActual;

				respuesta = impActual > 0;
			}
			catch {  respuesta = false; }

			return respuesta;
		}

		private void Cancelar() 
		{
			GoHome();
		}
		#endregion
	}
}
