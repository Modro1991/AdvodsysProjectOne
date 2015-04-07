using System;
using System.Text;
using System.Xml.Serialization;

namespace WebKaldTest
{
    public class Sag
    {
        [XmlElement("Nr")]
		public string nr;

        [XmlElement("Navn")]
		public string navn;

        [XmlElement("Adresse")]
		public string adresse;

        [XmlElement("Postnr")]
		public string postnr;

        [XmlElement("Vedr")]
		public string vedr;

		public string Summary {
			get{ return String.Format ("Nummer: {0}, Navn: {1}", nr, navn); }
		}

		public override string ToString ()
		{
			return String.Format ("{0}, {1}, {2}, {3} {4}", nr, navn, adresse, postnr, vedr);
		}
    }


    [XmlRoot("SagsListeOgKoder")]
    public class SagCollection
    {
        [XmlArray("Sager")]
        [XmlArrayItem("Sag", typeof(Sag))]
        public Sag[] Sag { get; set; }
    }
}