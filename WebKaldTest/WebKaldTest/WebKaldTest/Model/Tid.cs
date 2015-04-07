using System;
using System.Text;
using System.Xml.Serialization;

namespace WebKaldTest
{
	public class Tid
	{
		[XmlElement("Sag")]
		public string sag;

		[XmlElement("Aktivitet")]
		public string aktivitet;

		[XmlElement("Tekst")]
		public string tekst;

		[XmlElement("FraKlokken")]
		public string fraklokken;

		[XmlElement("Forbrugt")]
		public string forbrugt;

		[XmlElement("Deb")]
		public string deb;

		[XmlElement("Rediger")]
		public string rediger;        
	}

	[XmlRoot("MinTidsregDag")]
	public class TidCollection
	{
		[XmlArray("Poster")]
		[XmlArrayItem("Post", typeof(Tid))]
		public Tid[] Tid { get; set; }
	}
}