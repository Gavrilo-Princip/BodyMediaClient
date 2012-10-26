using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    public class SleepDay
    {
        public SleepDay()
        {
            SleepPeriods = new SleepPeriod[] { };
        }

        [XmlIgnore]
        public virtual DateTime Date { get; set; }

        [XmlAttribute("totalLying")]
        public virtual int TotalLying { get; set; }
        
        [XmlAttribute("totalSleep")]
        public virtual int TotalSleep { get; set; }
        
        [XmlAttribute("efficiency")]
        public virtual double Efficiency { get; set; }

        [XmlArray("sleepPeriods")]
        [XmlArrayItem("period")]
        public virtual SleepPeriod[] SleepPeriods { get; set; }

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
