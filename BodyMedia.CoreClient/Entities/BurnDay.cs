using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    public class BurnDay
    {
        public BurnDay()
        {
            Minutes = new EnergyMinute[] { };
        }

        [XmlElement("intensity")]
        public virtual BurnIntensitySummary Intensity { get; set; }

        [XmlArray("minutes")]
        [XmlArrayItem("min")]
        public virtual EnergyMinute[] Minutes { get; set; }
    }
}
