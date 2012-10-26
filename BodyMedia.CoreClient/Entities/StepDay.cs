using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    public class StepDay
    {
        public StepDay()
        {
            StepHours = new StepHour[] { };
        }

        [XmlIgnore]
        public virtual DateTime Date { get; set; }

        [XmlAttribute("totalSteps")]
        public virtual int TotalSteps { get; set; }

        [XmlArray("hours")]
        [XmlArrayItem("hour")]
        public virtual StepHour[] StepHours { get; set; }

        #region for serialization
        [XmlAttribute("date")]
        public virtual string XmlDate
        {
            get { return Date.ToString("yyyyMMdd"); }
            set { Date = value.ToDateTime(); }
        }
        #endregion
    }
}
