using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Models;

namespace RenrenCore.Entities
{
    [DataContract]
    public sealed class ActivityEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-period_msg
        /// </summary>
        [DataMember]
        private string period_msg = "";
        public string Period_Msg
        {
            get
            {
                return period_msg;
            }
            set
            {
                period_msg = value;
                this.NotifyPropertyChanged(activityEntity => activityEntity.Period_Msg);
            }
        }


        /// <summary>
        /// 2-message
        /// </summary>
        [DataMember]
        private string message = "";
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                this.NotifyPropertyChanged(activityEntity => activityEntity.Message);
            }
        }

        /// <summary>
        /// 3-period_msg
        /// </summary>
        [DataMember]
        private string activity_icon = "";
        public string Activity_Icon
        {
            get
            {
                return activity_icon;
            }
            set
            {
                activity_icon = value;
                this.NotifyPropertyChanged(activityEntity => activityEntity.Activity_Icon);
            }
        }


        /// <summary>
        /// 4-message
        /// </summary>
        [DataMember]
        private string url = "";
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                this.NotifyPropertyChanged(activityEntity => activityEntity.Url);
            }
        }

        /// <summary>
        /// 5-type
        /// </summary>
        [DataMember]
        private Int32 type = 0;
        public Int32 Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                this.NotifyPropertyChanged(activityEntity => activityEntity.Type);
            }
        }


    }
}
