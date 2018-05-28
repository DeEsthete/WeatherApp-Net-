using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherApp
{
    public class Forecastday
    {
        [XmlElement(ElementName = "date")]
        public string Date { get; set; }
        [XmlElement(ElementName = "date_epoch")]
        public string Date_epoch { get; set; }
        [XmlElement(ElementName = "day")]
        public Day Day { get; set; }
        [XmlElement(ElementName = "astro")]
        public Astro Astro { get; set; }
    }
}
