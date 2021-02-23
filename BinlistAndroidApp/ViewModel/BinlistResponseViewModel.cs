using BinlistAndroidApp.Helper;
using BinlistAndroidApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BinlistAndroidApp.ViewModel
{
	public class BinlistResponseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public BinlistResponseModel responsemodels { set; get; }
		public BinlistRequestModel requestModels { set; get; }
		public BinlistWebApiService service;

		public void OnPropertyChanged([CallerMemberName] string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public BinlistResponseModel Binlist
		{
			get { return responsemodels; }
			set
			{
				responsemodels = value;
				OnPropertyChanged("Binlist");
			}
		}

		public BinlistRequestModel Binlistrequest
		{
			get { return requestModels; }
			set
			{
				requestModels = value;
				OnPropertyChanged("Binlistrequest");
			}
		}


		public BinlistResponseViewModel()
		
		{
			responsemodels = new BinlistResponseModel();
			requestModels = new BinlistRequestModel();
			service = new BinlistWebApiService();

		}

		//private void RaisepropertyChanged(string details)
		//{
		//	if (PropertyChanged != null)
		//		PropertyChanged.Invoke(this, new PropertyChangedEventArgs(details));
		//}

		public async Task<BinlistResponseModel> GetCardDetails(string cardNo)
		{
			return await service.GetNinDetails(cardNo);
		}
	}
}
