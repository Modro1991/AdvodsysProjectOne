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
    public class Sagsliste
    {
        public SagCollection sager { get; set; }

        public async Task HentSager(int egne, string filter, int max)
        {
            // Dan dictionary med parametre
            var dictParam = new SortedDictionary<string, string>();
            dictParam.Add("egne", egne.ToString());
            dictParam.Add("filter", filter);
            dictParam.Add("max", max.ToString());

            // Kald web service og vent på svar
            string result = await WebServiceKald.GetData("HentSagslisteOgKoderV2", dictParam);

            // Udtræk sagsliste fra xml struktur
            XmlSerializer ser = new XmlSerializer(typeof(SagCollection));
            using (XmlReader xmlReader = XmlReader.Create(new StringReader(result)))
            {
                sager = (SagCollection)(ser.Deserialize(xmlReader));
            }
        }
    }
}
    

