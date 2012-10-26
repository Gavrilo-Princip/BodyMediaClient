using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BodyMedia.CoreClient.Entities
{
    public class EnergyMinute
    {
        [XmlIgnore]
        public virtual MetsActivityType ActivityType { get; set; }
 
        [XmlAttribute("cals")]
        public virtual double Calories { get; set; }

        [XmlAttribute("mets")]
        public virtual double Mets { get; set; }

        [XmlIgnore]
        public virtual EnergySource Source { get; set; }

        #region for serialization
        [XmlAttribute("iType")]
        public virtual string XmlActivityType
        {
            get
            {
                switch (ActivityType)
                {
                    case MetsActivityType.VigorousActivity:
                        return "V";
                    case MetsActivityType.Sedentaryactivity:
                        return "S";
                    case MetsActivityType.ModerateActivity:
                        return "M";
                    default:
                        throw new ApplicationException("Unknown activity type.");
                }
            }
            set
            {
                switch (value)
                {
                    case "V":
                        ActivityType = MetsActivityType.VigorousActivity;
                        break;
                    case "S":
                        ActivityType = MetsActivityType.Sedentaryactivity;
                        break;
                    case "M":
                        ActivityType = MetsActivityType.ModerateActivity;
                        break;
                    default:
                        throw new ApplicationException("Unknown activity type.");
                }
            }
        }

        [XmlAttribute("source")]
        public virtual string XmlSource
        {
            get
            {
                switch (Source)
                {
                    case EnergySource.ArmbandEstimate:
                        return "A";
                    case EnergySource.ObtainedFromDevice:
                        return "D";
                    case EnergySource.GoalEstimate:
                        return "G";
                    case EnergySource.Estimate:
                        return "E";
                    case EnergySource.User:
                        return "U";
                    case EnergySource.SameAsEstimate:
                        return "S";
                    case EnergySource.UnusedEstimate:
                        return "UE";
                    case EnergySource.Null:
                        return "X";
                    default:
                        throw new ApplicationException("Unknown energy source.");
                }
            }
            set
            {
                switch (value)
                {
                    case "A":
                        Source = EnergySource.ArmbandEstimate;
                        break;
                    case "D":
                        Source = EnergySource.ObtainedFromDevice;
                        break;
                    case "G":
                        Source = EnergySource.GoalEstimate;
                        break;
                    case "E":
                        Source = EnergySource.Estimate;
                        break;
                    case "U":
                        Source = EnergySource.User;
                        break;
                    case "S":
                        Source = EnergySource.SameAsEstimate;
                        break;
                    case "UE":
                        Source = EnergySource.UnusedEstimate;
                        break;
                    case "X":
                        Source = EnergySource.Null;
                        break;
                    default:
                        throw new ApplicationException("Unknown energy source.");
                }
            }
        }
        #endregion
    }
}
