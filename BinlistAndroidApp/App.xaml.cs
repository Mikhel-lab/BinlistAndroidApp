using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BinlistAndroidApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MajorPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
