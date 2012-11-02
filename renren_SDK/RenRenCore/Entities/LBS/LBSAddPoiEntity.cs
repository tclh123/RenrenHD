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
    public sealed class LBSAddPoiEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-base_info
        /// </summary>
        [DataMember]
        private PoiBaseInfoEntity base_info = new PoiBaseInfoEntity();
        public PoiBaseInfoEntity Base_Info
        {
            get
            {
                return base_info;
            }
            set
            {
                base_info = value;
                this.NotifyPropertyChanged(lbsAddPoiEntity => lbsAddPoiEntity.Base_Info);
            }
        }


        /// <summary>
        /// 2-distance
        /// </summary>
        [DataMember]
        private Int32 distance = 0;
        public Int32 Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                this.NotifyPropertyChanged(lbsAddPoiEntity => lbsAddPoiEntity.Distance);
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
                this.NotifyPropertyChanged(lbsAddPoiEntity => lbsAddPoiEntity.Lat_Gps);
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
                this.NotifyPropertyChanged(lbsAddPoiEntity => lbsAddPoiEntity.Lon_Gps);
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
                this.NotifyPropertyChanged(lbsAddPoiEntity => lbsAddPoiEntity.Need2deflect);
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
                this.NotifyPropertyChanged(lbsAddPoiEntity => lbsAddPoiEntity.Locate_Type);
            }
        }


    }
}
