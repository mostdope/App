using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using App.Infrastructure.Contracts;
using App.Server.Core.Interfaces;
using App.Server.Logger;

namespace App.Server.Host
{
	public class Application
	{
		
		public AppServices Services { get; set; }
		public Application(ILogger logger)
		{
			
		}

		public void Run()
		{
			
		}

		
	}

	public class AppServices
	{
		private ILogger _logger;
		public AppServices(ILogger logger)
		{
			_logger = logger;
		}

		public AppServices() : this(new ConsoleLogger())
		{
			
		}
		private Dictionary<Type, ServiceHost> _services;

		public void AddService(Type serviceType, Uri address)
		{
			_services.Add(serviceType, new ServiceHost(serviceType, address));
		}

		public bool CheckIsActive(Type type)
		{
			if (type == null)
				throw new ArgumentNullException();
			return _services[type].State == CommunicationState.Opened;
		}

		public void RunAll()
		{
			if (_services.Count == 0)
				return;
			foreach (var host in _services.Values)
			{
				try
				{
					host.Open();
				}
				catch (ServiceActivationException exception)
				{

				}
				catch (Exception exception)
				{
					
				}
				finally
				{

				}
			}
		}
	}


	
}
