using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    public class BurnIntensity
    {
        [XmlAttribute("averageCalories")]
        public virtual int AverageCalories { get; set; }

        [XmlAttribute("averageMinutes")]
        public virtual int AverageMinutes { get; set; }

        [XmlAttribute("totalCalories")]
        public virtual int TotalCalories { get; set; }

        [XmlAttribute("totalMinutes")]
        public virtual int TotalMinutes { get; set; }
    }
}
