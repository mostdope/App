using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using App.Server.Core;
using App.Server.Services;

namespace App.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Startup();

	        var host = new ServiceHost(typeof (PlotDataService), new Uri("http://localhost:9999/plotservice", UriKind.Absolute));

			host.Opened += (s, e) => Console.WriteLine("Listening at: {0}", host.BaseAddresses.FirstOrDefault());
			host.Closed += (s, e) => Console.WriteLine("Closed connection. Press Any key to exit");
			host.Open();
	       
	        Console.Read();
        }
    }
}
