using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherApp
{
    [XmlRoot(ElementName = "astro")]
    public class Astro
    {
        [XmlElement(ElementName = "sunrise")]
        public string Sunrise { get; set; }
        [XmlElement(ElementName = "sunset")]
        public string Sunset { get; set; }
        [XmlElement(ElementName = "moonrise")]
        public string Moonrise { get; set; }
        [XmlElement(ElementName = "moonset")]
        public string Moonset { get; set; }
    }
}
