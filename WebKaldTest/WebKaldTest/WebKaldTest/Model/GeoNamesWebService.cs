using System;
using System.Net.Http;

namespace WebKaldTest
{
	public class GeoNamesWebService
	{
		public GeoNamesWebService ()
		{
		}
		public async Task<Place[]> GetPlacesAsync()  
		{  
			var client = new System.Net.Http.HttpClient();  
			client.BaseAddress = new Uri("https://uwa.unik.dk/Mobil/AdvosysService/");  
			StringContent str = new StringContent("APPTESTVEJLE,xxx,Android,1.0,1.0", Encoding.UTF8, "application/x-www-form-urlencoded");  
			var response = await client.PostAsync(new Uri("https://uwa.unik.dk/Mobil/AdvosysService/HentSagslisteOgKoderV2"), str);  
			var placesJson = response.Content.ReadAsStringAsync().Result;  
			Placeobject placeobject = new Placeobject();  
			if(placesJson!="")  
			{  
				placeobject = JsonConvert.DeserializeObject<Placeobject>(placesJson);  
			}  
			return placeobject.places;  
		}

		public class Placeobject  
		{  
			[JsonProperty("postalcodes")]  
			public Place[] places { get; set; }  
		}  
		public class Place  
		{  
			public string placeName { get; set; }  
		} 
	}
}

