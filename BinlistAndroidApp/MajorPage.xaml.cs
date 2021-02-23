using BinlistAndroidApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BinlistAndroidApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MajorPage : ContentPage
	{
		public readonly BinlistResponseViewModel binlist;
		public MajorPage()
		{
			InitializeComponent();
			BindingContext = new BinlistResponseViewModel();
			binlist = new BinlistResponseViewModel();
		}

		private async void cardNumber_TextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				if (cardNumber.Text.Length < 6)
				{
					return;
				}
				binlist.responsemodels = await binlist.GetCardDetails(cardNumber.Text);
				
			}
			catch (Exception)
			{

				throw;
			}
		}

	
	}
}
