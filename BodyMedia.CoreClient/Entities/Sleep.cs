using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    [Serializable]
    [XmlType("sleep")]
    public class Sleep : IXmlEntity
    {
        public Sleep()
        {
            SleepDays = new SleepDay[] { };
        }

        [XmlIgnore]
        public virtual DateTime StartDate { get; set; }

        [XmlIgnore]
        public virtual DateTime EndDate { get; set; }

        [XmlAttribute("averageLying")]
        public virtual int AverageLying { get; set; }

        [XmlAttribute("averageSleep")]
        public virtual int AverageSleep { get; set; }

        [XmlAttribute("totalLying")]
        public virtual int TotalLying { get; set; }

        [XmlAttribute("totalSleep")]
        public virtual int TotalSleep { get; set; }

        [XmlAttribute("efficiency")]
        public virtual double Efficiency { get; set; }

        [XmlElement("lastSync")]
        public virtual SyncInformation LastSync { get; set; }

        [XmlArray("days")]
        [XmlArrayItem("sleepDay")]
        public virtual SleepDay[] SleepDays { get; set; }


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
