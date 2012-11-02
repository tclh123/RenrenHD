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
    public class PoiBaseInfoEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-pid
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
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Pid);
            }
        }


        /// <summary>
        /// 2-poi_name
        /// </summary>
        [DataMember]
        private string poi_name = "";
        public string Poi_Name
        {
            get
            {
                return poi_name;
            }
            set
            {
                poi_name = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Poi_Name);
            }
        }


        /// <summary>
        /// 3-poi_address
        /// </summary>
        [DataMember]
        private string poi_address = "";
        public string Poi_Address
        {
            get
            {
                return poi_address;
            }
            set
            {
                poi_address = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Poi_Address);
            }
        }

        /// <summary>
        /// 4-map_url
        /// </summary>
        [DataMember]
        private string map_url = "";
        public string Map_Url
        {
            get
            {
                return map_url;
            }
            set
            {
                map_url = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Map_Url);
            }
        }


        /// <summary>
        /// 5-visit_count
        /// </summary>
        [DataMember]
        private Int32 visit_count = 0;
        public Int32 Visit_Count
        {
            get
            {
                return visit_count;
            }
            set
            {
                visit_count = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Visit_Count);
            }
        }

        /// <summary>
        /// 6-activity_count 
        /// </summary>
        [DataMember]
        private Int32 activity_count = 0;
        public Int32 Activity_Count
        {
            get
            {
                return activity_count;
            }
            set
            {
                activity_count = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Activity_Count);
            }
        }


        /// <summary>
        /// 7-activity_count 
        /// </summary>
        [DataMember]
        private string activity_contents = "";
        public string Activity_Contents
        {
            get
            {
                return activity_contents;
            }
            set
            {
                activity_contents = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Activity_Contents);
            }
        }

        /// <summary>
        /// 8-nearby_activity_count 
        /// </summary>
        [DataMember]
        private Int32 nearby_activity_count = 0;
        public Int32 Nearby_Activity_Count
        {
            get
            {
                return nearby_activity_count;
            }
            set
            {
                nearby_activity_count = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Nearby_Activity_Count);
            }
        }

        /// <summary>
        /// 9-lat 
        /// </summary>
        [DataMember]
        private Int64 lat = 0;
        public Int64 Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Lat);
            }
        }

        /// <summary>
        /// 10-lon 
        /// </summary>
        [DataMember]
        private Int64 lon = 0;
        public Int64 Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Lon);
            }
        }

        

         /// <summary>
        /// 11-activity_url  
        /// </summary>
        [DataMember]
        private string activity_url  = "";
        public string Activity_Url
        {
            get
            {
                return activity_url;
            }
            set
            {
                activity_url = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Activity_Url);
            }
        }


        /// <summary>
        /// 11-activity_url  
        /// </summary>
        [DataMember]
        private string detail_address = "";
        public string Detail_Address 
        {
            get
            {
                return detail_address;
            }
            set
            {
                detail_address = value;
                this.NotifyPropertyChanged(poiBaseInfoEntity => poiBaseInfoEntity.Detail_Address);
            }
        }


    }
}
