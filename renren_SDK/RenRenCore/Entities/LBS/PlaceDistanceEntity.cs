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
   public sealed class PlaceDistanceEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-pid   poi id
        /// </summary>
        [DataMember]
        private string pid = "";
        public string Pid
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
                this.NotifyPropertyChanged(placeDistanceEntity => placeDistanceEntity.Pid);
            }
        }


        /// <summary>
        /// 2-distance    距离结果，单位为m
        /// </summary>
        [DataMember]
        private double distance = 0;
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                this.NotifyPropertyChanged(placeDistanceEntity => placeDistanceEntity.Distance);
            }
        }


        /// <summary>
        /// 3-lat_gps    纬度
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
                this.NotifyPropertyChanged(placeDistanceEntity => placeDistanceEntity.Lat_Gps);
            }
        }


        /// <summary>
        /// 4-lon_gps    纬度
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
                this.NotifyPropertyChanged(placeDistanceEntity => placeDistanceEntity.Lon_Gps);
            }
        }

        /// <summary>
        /// 5-need2deflect    是否需要进行偏转
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
                this.NotifyPropertyChanged(placeDistanceEntity => placeDistanceEntity.Need2deflect);
            }
        }

        /// <summary>
        /// 6-is_too_far_away    是否超出默认半径
        /// </summary>
        [DataMember]
        private Int32 is_too_far_away = 0;
        public Int32 Is_Too_Far_Away
        {
            get
            {
                return is_too_far_away;
            }
            set
            {
                is_too_far_away = value;
                this.NotifyPropertyChanged(placeDistanceEntity => placeDistanceEntity.Is_Too_Far_Away);
            }
        }


        /// <summary>
        /// 7-locate_type    定位类型
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
                this.NotifyPropertyChanged(placeDistanceEntity => placeDistanceEntity.Locate_Type);
            }
        }

    }
}
