using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;

namespace BodyMedia.CoreClient.Entities
{
    [XmlType("activityDay")]
    public class ActivityDay
    {
        [XmlIgnore]
        public virtual DateTime Date { get; set; }

        [XmlElement("activity")]
        public virtual Activity[] Activities { get; set; }

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
