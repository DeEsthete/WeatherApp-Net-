using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherApp
{
    public class Current
    {
        [XmlElement(ElementName = "last_updated_epoch")]
        public string Last_updated_epoch { get; set; }
        [XmlElement(ElementName = "last_updated")]
        public string Last_updated { get; set; }
        [XmlElement(ElementName = "temp_c")]
        public string Temp_c { get; set; }
        [XmlElement(ElementName = "temp_f")]
        public string Temp_f { get; set; }
        [XmlElement(ElementName = "is_day")]
        public string Is_day { get; set; }
        [XmlElement(ElementName = "condition")]
        public Condition Condition { get; set; }
        [XmlElement(ElementName = "wind_mph")]
        public string Wind_mph { get; set; }
        [XmlElement(ElementName = "wind_kph")]
        public string Wind_kph { get; set; }
        [XmlElement(ElementName = "wind_degree")]
        public string Wind_degree { get; set; }
        [XmlElement(ElementName = "wind_dir")]
        public string Wind_dir { get; set; }
        [XmlElement(ElementName = "pressure_mb")]
        public string Pressure_mb { get; set; }
        [XmlElement(ElementName = "pressure_in")]
        public string Pressure_in { get; set; }
        [XmlElement(ElementName = "precip_mm")]
        public string Precip_mm { get; set; }
        [XmlElement(ElementName = "precip_in")]
        public string Precip_in { get; set; }
        [XmlElement(ElementName = "humidity")]
        public string Humidity { get; set; }
        [XmlElement(ElementName = "cloud")]
        public string Cloud { get; set; }
        [XmlElement(ElementName = "feelslike_c")]
        public string Feelslike_c { get; set; }
        [XmlElement(ElementName = "feelslike_f")]
        public string Feelslike_f { get; set; }
        [XmlElement(ElementName = "vis_km")]
        public string Vis_km { get; set; }
        [XmlElement(ElementName = "vis_miles")]
        public string Vis_miles { get; set; }
    }
}
