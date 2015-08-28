using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Server.Data
{
    public class DataContext : IDisposable
    {
        public DataContext()
        {
	       
        }

        public IQueryable<double> GetPlotData(int count)
        {
            var random = new Random();
            var query = (from d in Enumerable.Range(0, count)
                         let num = random.NextDouble()
                         orderby num
                         select num ).AsQueryable();
            return query;
        }

        public void Dispose()
        {
           
        }

	    public async Task<IEnumerable<double>> GetPlotDataAsync(int count)
	    {
		    return await Task.FromResult(GetPlotData(count));
	    }

	    
    }
}
