using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherApp
{
    public class Day
    {
        [XmlElement(ElementName = "maxtemp_c")]
        public string Maxtemp_c { get; set; }
        [XmlElement(ElementName = "maxtemp_f")]
        public string Maxtemp_f { get; set; }
        [XmlElement(ElementName = "mintemp_c")]
        public string Mintemp_c { get; set; }
        [XmlElement(ElementName = "mintemp_f")]
        public string Mintemp_f { get; set; }
        [XmlElement(ElementName = "avgtemp_c")]
        public string Avgtemp_c { get; set; }
        [XmlElement(ElementName = "avgtemp_f")]
        public string Avgtemp_f { get; set; }
        [XmlElement(ElementName = "maxwind_mph")]
        public string Maxwind_mph { get; set; }
        [XmlElement(ElementName = "maxwind_kph")]
        public string Maxwind_kph { get; set; }
        [XmlElement(ElementName = "totalprecip_mm")]
        public string Totalprecip_mm { get; set; }
        [XmlElement(ElementName = "totalprecip_in")]
        public string Totalprecip_in { get; set; }
        [XmlElement(ElementName = "avgvis_km")]
        public string Avgvis_km { get; set; }
        [XmlElement(ElementName = "avgvis_miles")]
        public string Avgvis_miles { get; set; }
        [XmlElement(ElementName = "avghumidity")]
        public string Avghumidity { get; set; }
        [XmlElement(ElementName = "condition")]
        public Condition Condition { get; set; }
        [XmlElement(ElementName = "uv")]
        public string Uv { get; set; }
    }
}
