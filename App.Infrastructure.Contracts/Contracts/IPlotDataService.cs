using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace App.Infrastructure.Contracts
{
    [ServiceContract]
    public interface IPlotDataService
    {
        [OperationContract]
        IEnumerable<double> GetRandomPlotData(int count);

		//[OperationContract]
		//Task<IEnumerable<double>> GetRandomPlotDataAsync(int count);
    }
}
