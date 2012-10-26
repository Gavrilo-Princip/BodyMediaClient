using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    [Serializable]
    [XmlType("step")]
    public class Step : IXmlEntity
    {
        public Step()
        {
            StepDays = new StepDay[] { };
        }

        [XmlIgnore]
        public virtual DateTime StartDate { get; set; }

        [XmlIgnore]
        public virtual DateTime EndDate { get; set; }
        
        [XmlAttribute("averageSteps")]
        public virtual int AverageSteps { get; set; }

        [XmlAttribute("totalSteps")]
        public virtual int TotalSteps { get; set; }

        [XmlElement("lastSync")]
        public virtual SyncInformation LastSync { get; set; }

        [XmlArray("days")]
        [XmlArrayItem("stepDay")]
        public virtual StepDay[] StepDays { get; set; }


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
