using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;

namespace BodyMedia.CoreClient.Entities
{
    [XmlType("activity")]
    public class Activity
    {
        [XmlIgnore]
        public virtual DateTime StartDate { get; set; }

        [XmlIgnore]
        public virtual DateTime EndDate { get; set; }

        [XmlAttribute("calories")]
        public virtual int Calories { get; set; }

        [XmlAttribute("type")]
        public virtual string Type { get; set; }


        #region for serialization
        [XmlAttribute("startDate")]
        public virtual string XmlStartDate
        {
            get { return StartDate.ToString("yyyyMMdd"); }
            set { StartDate = value.ToDateTime(); }
        }

        [XmlAttribute("endDate")]
        public virtual string XmlEndDate
        {
            get { return EndDate.ToString("yyyyMMdd"); }
            set { EndDate = value.ToDateTime(); }
        }
        #endregion
    }
}
