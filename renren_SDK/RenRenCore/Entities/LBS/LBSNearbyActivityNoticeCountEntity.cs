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
    public sealed class LBSNearbyActivityNoticeCountEntity : PropertyChangedBase 
    {
        [DataMember]
        private Int32 count;
        public Int32 Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                this.NotifyPropertyChanged(lbsNearbyActivityNoticeCountEntity => lbsNearbyActivityNoticeCountEntity.Count);
            }
        }


        [DataMember]
        private Int32 need2deflect;
        public Int32 Need2deflect
        {
            get
            {
                return need2deflect;
            }
            set
            {
                need2deflect = value;
                this.NotifyPropertyChanged(lbsNearbyActivityNoticeCountEntity => lbsNearbyActivityNoticeCountEntity.Need2deflect);
            }
        }


        [DataMember]
        private Int32 locate_type;
        public Int32 Locate_Type
        {
            get
            {
                return locate_type;
            }
            set
            {
                locate_type = value;
                this.NotifyPropertyChanged(lbsNearbyActivityNoticeCountEntity => lbsNearbyActivityNoticeCountEntity.Locate_Type);
            }
        }

        [DataMember]
        private Int64 lat_gps;
        public Int64 Lat_Gps
        {
            get
            {
                return lat_gps;
            }
            set
            {
                lat_gps = value;
                this.NotifyPropertyChanged(lbsNearbyActivityNoticeCountEntity => lbsNearbyActivityNoticeCountEntity.Lat_Gps);
            }
        }

        [DataMember]
        private Int64 lon_gps;
        public Int64 Lon_Gps
        {
            get
            {
                return lon_gps;
            }
            set
            {
                lon_gps = value;
                this.NotifyPropertyChanged(lbsNearbyActivityNoticeCountEntity => lbsNearbyActivityNoticeCountEntity.Lon_Gps);
            }
        }

        [DataMember]
        private Int64 lat_deflect;
        public Int64 Lat_Deflect
        {
            get
            {
                return lat_deflect;
            }
            set
            {
                lat_deflect = value;
                this.NotifyPropertyChanged(lbsNearbyActivityNoticeCountEntity => lbsNearbyActivityNoticeCountEntity.Lat_Deflect);
            }
        }

        [DataMember]
        private Int64 lon_deflect;
        public Int64 Lon_Deflect
        {
            get
            {
                return lon_deflect;
            }
            set
            {
                lon_deflect = value;
                this.NotifyPropertyChanged(lbsNearbyActivityNoticeCountEntity => lbsNearbyActivityNoticeCountEntity.Lon_Deflect);
            }
        }







    }
}
