using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    public class SleepPeriod
    {
        [XmlAttribute("duration")]
        public virtual int Duration { get; set; }

        [XmlAttribute("minuteIndex")]
        public virtual int MinuteIndex { get; set; }
        
        [XmlIgnore]
        public virtual SleepState State { get; set; }

        #region for serialization
        [XmlAttribute("state")]
        public virtual string XmlState
        {
            get
            {
                switch (State)
                {
                    case SleepState.Asleep:
                        return "ASLEEP";
                    case SleepState.Lying:
                        return "LYING";
                    default:
                        throw new ApplicationException("Unknown sleep state.");
                }
            }
            set
            {
                switch (value)
                {
                    case "ASLEEP":
                        State = SleepState.Asleep;
                        break;
                    case "LYING":
                        State = SleepState.Lying;
                        break;
                    default:
                        throw new ApplicationException("Unknown sleep state.");
                }
            }
        }
        #endregion
    }
}
