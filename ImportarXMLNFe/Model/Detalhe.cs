using System.Xml.Serialization;

namespace ImportarXMLNFe.Model
{
    public class Detalhe
    {
        [XmlAttribute("nItem")]
        public int nItem { get; set; }

        [XmlElement("prod")]
        public Produto Produto { get; set; }
    }
}