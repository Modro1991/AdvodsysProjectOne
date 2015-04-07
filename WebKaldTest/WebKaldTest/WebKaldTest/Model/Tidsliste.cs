using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using WebKaldTest;

namespace WebKaldTest
{
	public class Tidsliste
	{
		public TidCollection tider { get; set; }

		public async Task HentTider(string dato)
		{
			// Dan dictionary med parametre
			var dictParam = new SortedDictionary<string, string>();            
			dictParam.Add("dato", dato.ToString());

			// Kald web service og vent på svar
			string result = await WebServiceKald.GetData("HentMinTidsregDag", dictParam);

			// Udtræk sagsliste fra xml struktur
			XmlSerializer ser = new XmlSerializer(typeof(TidCollection));
			using (XmlReader xmlReader = XmlReader.Create(new StringReader(result)))
			{
				tider = (TidCollection)(ser.Deserialize(xmlReader));
			}
		}

		public async Task RegistrerTid(string aktkode, string beskrivelse, int dato, int fraklokken, int minutter, int sagsnr)
		{
			var dictParam = new SortedDictionary<string, string>();
			dictParam.Add("aktkode", aktkode);
			dictParam.Add("beskrivelse", beskrivelse);
			dictParam.Add("dato", dato.ToString());
			dictParam.Add("fraKlokken", fraklokken.ToString());
			dictParam.Add("minutter", minutter.ToString());
			dictParam.Add("sagsnr", sagsnr.ToString());

			await WebServiceKald.SetData("TidsregistrerV2", dictParam);

		}
	}
}