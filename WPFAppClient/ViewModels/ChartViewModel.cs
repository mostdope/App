using System.ServiceModel;
using App.Infrastructure.Contracts;
using GalaSoft.MvvmLight;
using WPFAppClient.ClientCore;


namespace WPFAppClient.ViewModels
{
    public class ChartViewModel : ViewModelBase
    {
	    private ClientBase<IPlotDataService> _service; 
	    public ChartViewModel(PlotServiceClient service)
	    {
		    _service = service;
	    }

    }
}
