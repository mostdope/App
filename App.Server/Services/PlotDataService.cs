using App.Infrastructure.Contracts;
using App.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Server.Services
{
    public class PlotDataService : IPlotDataService
    {
        public IEnumerable<double> GetRandomPlotData(int count)
        {
            using(var ctx = new DataContext())
            {
                return ctx.GetPlotData(count);
            }
        }

	    public async Task<IEnumerable<double>> GetRandomPlotDataAsync(int count)
	    {
		    using (var ctx = new DataContext())
		    {
			    return await ctx.GetPlotDataAsync(count);
		    }
	    }
    }
}
