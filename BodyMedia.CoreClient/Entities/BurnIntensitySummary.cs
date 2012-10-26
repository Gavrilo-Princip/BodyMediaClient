using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    [XmlType("intensity")]
    public class BurnIntensitySummary
    {
        [XmlElement("moderate")]
        public virtual BurnIntensity Moderate { get; set; }

        [XmlElement("sedentary")]
        public virtual BurnIntensity Sedentary { get; set; }

        [XmlElement("vigorous")]
        public virtual BurnIntensity Vigorous { get; set; }
    }
}
