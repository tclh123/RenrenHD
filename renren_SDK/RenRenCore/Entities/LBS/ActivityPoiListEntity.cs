using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Models;

namespace RenrenCore.Entities
{
    [DataContract]
   public class ActivityPoiListEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-count
        /// </summary>
        [DataMember]
        private Int32 count = 0;
        public Int32 Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                this.NotifyPropertyChanged(activityPoiListEntity => activityPoiListEntity.Count);
            }
        }

        
        /// <summary>
        /// 2-poi_list
        /// </summary>
        [DataMember]
        private ObservableCollection<ActivityPoiEntity> poi_list = new ObservableCollection<ActivityPoiEntity>();
        public ObservableCollection<ActivityPoiEntity> Poi_List
        {
            get
            {
                return poi_list;
            }
            set
            {
                poi_list = value;
                this.NotifyPropertyChanged(activityPoiListEntity => activityPoiListEntity.Poi_List);
            }
        }


        /// <summary>
        /// 5-page_size
        /// </summary>
        [DataMember]
        private Int32 page_size = 0;
        public Int32 Page_Size
        {
            get
            {
                return page_size;
            }
            set
            {
                page_size = value;
                this.NotifyPropertyChanged(activityPoiListEntity => activityPoiListEntity.Page_Size);
            }
        }

        /// <summary>
        /// 6-need2deflect
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
                this.NotifyPropertyChanged(activityPoiListEntity => activityPoiListEntity.Need2deflect);
            }
        }


        /// <summary>
        /// 7-locate_type
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
                this.NotifyPropertyChanged(activityPoiListEntity => activityPoiListEntity.Locate_Type);
            }
        }

        /// <summary>
        /// 8-lat_gps
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
                this.NotifyPropertyChanged(activityPoiListEntity => activityPoiListEntity.Lat_Gps);
            }
        }
              
        /// <summary>
        /// 9-lon_gps
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
                this.NotifyPropertyChanged(activityPoiListEntity => activityPoiListEntity.Lon_Gps);
            }
        }

    }
}
