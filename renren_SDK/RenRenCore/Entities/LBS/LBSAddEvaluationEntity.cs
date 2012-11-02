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
   public sealed class LBSAddEvaluationEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-result
        /// </summary>
        [DataMember]
        private Int32 result = 0;
        public Int32 Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                this.NotifyPropertyChanged(lbsAddEvaluationEntity => lbsAddEvaluationEntity.Result);
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
                this.NotifyPropertyChanged(lbsAddEvaluationEntity => lbsAddEvaluationEntity.Message);
            }
        }

        /// <summary>
        /// 3-lat_gps
        /// </summary>
        [DataMember]
        private Int64 lat_gps = 0;
        public Int64 Lat_Gps
        {
            get
            {
                return lat_gps;
            }
            set
            {
                lat_gps = value;
                this.NotifyPropertyChanged(lbsAddEvaluationEntity => lbsAddEvaluationEntity.Lat_Gps);
            }
        }


        /// <summary>
        /// 4-lon_gps
        /// </summary>
        [DataMember]
        private Int64 lon_gps = 0;
        public Int64 Lon_Gps
        {
            get
            {
                return lon_gps;
            }
            set
            {
                lon_gps = value;
                this.NotifyPropertyChanged(lbsAddEvaluationEntity => lbsAddEvaluationEntity.Lon_Gps);
            }
        }

        /// <summary>
        /// 5-need2deflect
        /// </summary>
        [DataMember]
        private Int32 need2deflect = 0;
        public Int32 Need2deflect
        {
            get
            {
                return need2deflect;
            }
            set
            {
                need2deflect = value;
                this.NotifyPropertyChanged(lbsAddEvaluationEntity => lbsAddEvaluationEntity.Need2deflect);
            }
        }

        /// <summary>
        /// 6-locate_type
        /// </summary>
        [DataMember]
        private Int32 locate_type = 0;
        public Int32 Locate_Type
        {
            get
            {
                return locate_type;
            }
            set
            {
                locate_type = value;
                this.NotifyPropertyChanged(lbsAddEvaluationEntity => lbsAddEvaluationEntity.Locate_Type);
            }
        }



    }
}
