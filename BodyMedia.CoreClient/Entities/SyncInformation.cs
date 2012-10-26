using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    [XmlType]
    public class SyncInformation
    {
        [XmlIgnore]
        public virtual DateTime TimeStamp { get; set; }

        [XmlAttribute("type")]
        public virtual string Type { get; set; }

        #region for serialization
        [XmlAttribute("dateTime")]
        public virtual string XmlStartDate
        {
            get { return TimeStamp.ToString("yyyyMMdd"); }
            set { TimeStamp = value.ToDateTime(); }
        }
        #endregion
    }
}
