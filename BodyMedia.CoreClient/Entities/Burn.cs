using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    [Serializable]
    [XmlType("burn")]
    public class Burn : IXmlEntity
    {
        public Burn()
        {
            BurnDays = new BurnDay[] { };
        }

        [XmlIgnore]
        public virtual DateTime StartDate { get; set; }

        [XmlIgnore]
        public virtual DateTime EndDate { get; set; }

        [XmlAttribute("averageCalories")]
        public virtual int AverageCalories { get; set; }

        [XmlAttribute("totalCalories")]
        public virtual int TotalCalories { get; set; }

        [XmlElement("lastSync")]
        public virtual SyncInformation LastSync { get; set; }

        [XmlElement("intensity")]
        public virtual BurnIntensitySummary Intensity { get; set; }

        [XmlArray("days")]
        [XmlArrayItem("burnDay")]
        public virtual BurnDay[] BurnDays { get; set; }


        [XmlIgnore]
        public virtual string Xml { get; set; }

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
