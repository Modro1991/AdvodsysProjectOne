using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

namespace WebKaldTest
{
    public static class WebServiceKald
    {
        const string advosysUrl = "https://uwa.unik.dk/Mobil/AdvosysService/";
        const string userId = "APPTESTVEJLE,xxx,Android,1.0,1.0";

        public static async Task<string> GetData(string funktionsnavn, SortedDictionary<string, string> dictParam)
        {
            HttpClient client = new HttpClient();
            StringContent queryString = new StringContent(bodyFromParamCollection(funktionsnavn, dictParam), Encoding.UTF8, "text/xml");
            HttpResponseMessage response = await client.PostAsync(new Uri(advosysUrl + funktionsnavn), queryString);
            string responseBody = await response.Content.ReadAsStringAsync();
            return cleanResponse(responseBody);
        }
		public static async Task SetData(string funktionsnavn, SortedDictionary<string, string> dictParam)
		{
			HttpClient client = new HttpClient();
			StringContent queryString = new StringContent(bodyFromParamCollection(funktionsnavn, dictParam), Encoding.UTF8, "text/xml");
			await client.PostAsync(new Uri(advosysUrl + funktionsnavn), queryString);              
		}

        // Dan query body fra collection af parametre
        private static string bodyFromParamCollection(string funktionsnavn, SortedDictionary<string, string> dictParam)
        {
            // Dan <xxxxxxParam> tekst ud fra funktionsnavn
            string funkparam;
            switch (funktionsnavn)
            {
                case "HentSagslisteOgKoderV2":
                    funkparam = "HentSagslisteParamV2";
                    break;
                case "TidsregistrerV2":
                    funkparam = "TidsregistrerParamV2";
                    break;
                case "TidsregRet":
                case "TidsregSlet":
                    funkparam = "TidsregRetParam";
                    break;
                case "HentMinTidsregDag":
                case "TidsregTekstforslag":
                case "AfleverDataFangst":
                    funkparam = funktionsnavn + "Param";
                    break;
                default:
                    funkparam = (dictParam.Count == 0 ? "IdParam" : "HentSagParamV2");
                    break;
            }

            // Dan body tekst
            string body = string.Format("<{0} xmlns=\"http://schemas.datacontract.org/2004/07/WcfRestAdvosys\">", funkparam);
            dictParam.Add("id", userId);     // Tilføj id parameter
            // Indsæt parametre i body i alfabetisk rækkefølge
            foreach (KeyValuePair<string, string> p in dictParam)
            {
                body += string.Format("<{0}>{1}</{2}>", p.Key, p.Value, p.Key);
            }
            body += string.Format("</{0}>", funkparam);
            return body;
        }

        // Rens response, så det lettere kan deserialiseres af .net
        private static string cleanResponse(string resp)
        {
            // Fjern xmlns-information fra root tag (fra første mellemrum til slut på root-tag)
            return resp.Remove(resp.IndexOf(" "), resp.IndexOf(">") - resp.IndexOf(" "));
        }
    }
}