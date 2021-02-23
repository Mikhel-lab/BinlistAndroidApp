using BinlistAndroidApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BinlistAndroidApp.Helper
{
	public class BinlistWebApiService
	{
		HttpClient client;

		public BinlistResponseModel models { get; set; }

		public string WebApiUrl { get; set; }

		public BinlistWebApiService()
		{
			client = new HttpClient();
		}

		public async Task<BinlistResponseModel> GetNinDetails(string cardNo)
		{
			WebApiUrl = $"https://lookup.binlist.net/{cardNo}";

			var uri = new Uri(WebApiUrl);
			try
			{
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					models = JsonConvert.DeserializeObject<BinlistResponseModel>(content);
					return models;
				}
			}
			catch (Exception)
			{
			}
			return null;
		}
	}
}
