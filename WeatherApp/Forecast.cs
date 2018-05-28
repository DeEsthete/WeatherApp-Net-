using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherApp
{
    public class Forecast
    {
        [XmlElement(ElementName = "forecastday")]
        public List<Forecastday> Forecastday { get; set; }
    }
}
