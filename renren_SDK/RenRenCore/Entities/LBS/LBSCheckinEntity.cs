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
    public sealed class LBSCheckInEntity :PropertyChangedBase
    {
        /// <summary>
        /// 1-lat_gps
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
                this.NotifyPropertyChanged(lbsCheckinEntity => lbsCheckinEntity.Lat_Gps);
            }
        }


        /// <summary>
        /// 2-lon_gps
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
                this.NotifyPropertyChanged(lbsCheckinEntity => lbsCheckinEntity.Lon_Gps);
            }
        }

        /// <summary>
        /// 3-need2deflect
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
                this.NotifyPropertyChanged(lbsCheckinEntity => lbsCheckinEntity.Need2deflect);
            }
        }


        /// <summary>
        /// 4-result
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
                this.NotifyPropertyChanged(lbsCheckinEntity => lbsCheckinEntity.Result);
            }
        }
    }
}
