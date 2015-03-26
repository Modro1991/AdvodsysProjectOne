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
    }

    [XmlRoot("SagsListeOgKoder")]
    public class SagCollection
    {
        [XmlArray("Sager")]
        [XmlArrayItem("Sag", typeof(Sag))]
        public Sag[] Sag { get; set; }
    }
}