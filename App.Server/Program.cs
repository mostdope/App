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

	    
	       
	        Console.Read();
        }
    }
}
