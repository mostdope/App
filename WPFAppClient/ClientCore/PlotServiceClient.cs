using System.CodeDom;
using App.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace WPFAppClient.ClientCore
{
    public class PlotServiceClient : ClientBase<IPlotDataService>
    {
        public IEnumerable<double> GetPlotData(int count)
        {
            return Channel.GetRandomPlotData(count);
        }

		//public Task<IEnumerable<double>> GetPlotDataAsync(int count)
		//{
		//	return Channel.(count);
		//} 
    }
}
