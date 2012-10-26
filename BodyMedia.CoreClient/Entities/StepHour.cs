using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    public class StepHour
    {
        [XmlAttribute("totalSteps")]
        public virtual int TotalSteps { get; set; }
    }
}
