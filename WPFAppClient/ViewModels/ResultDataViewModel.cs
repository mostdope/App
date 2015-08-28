using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WPFAppClient.ClientCore;

namespace WPFAppClient.ViewModels
{
	public class ResultDataViewModel : ViewModelBase
	{
		private RelayCommand _refreshCommand;
		private readonly PlotServiceClient _client = new PlotServiceClient();

		public ResultDataViewModel()
		{		
			OnRefreshDataRequested();
		}
		public ObservableCollection<double> DataCollection { get; set; }

		public RelayCommand RefreshDataCommand
		{
			get { return _refreshCommand ?? 
				(_refreshCommand = new RelayCommand(OnRefreshDataRequested, CanRecieveData)); }
		}

		private void OnRefreshDataRequested()
		{
			using (_client)
			{
				DataCollection =
				new ObservableCollection<double>(_client.GetPlotData(100));
			}
		}

		private bool CanRecieveData()
		{
			return _client.State == CommunicationState.Opened;
		}
	}
}
