using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Runtime.Serialization;
using RenrenCore.Models;

namespace RenrenCore.Entities
{
    [DataContract]
    public class PoiListEntity : PropertyChangedBase
    {
        [DataMember]
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                this.NotifyPropertyChanged(entity => entity.Count);
            }
        }

        [DataMember]
        private PlaceInfoEntity info;
        public PlaceInfoEntity PoiInfo
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
                this.NotifyPropertyChanged(entity => entity.PoiInfo);
            }
        }

        [DataMember]
        private ObservableCollection<PlaceInfoEntity> poi_list;
        public ObservableCollection<PlaceInfoEntity> Poi_List
        {
            get
            {
                return poi_list;
            }
            set
            {
                poi_list = value;
                this.NotifyPropertyChanged(entity => entity.Poi_List);
            }
        }

        [DataMember]
        private Int32 page_size;
        public Int32 Page_Size
        {
            get
            {
                return page_size;
            }
            set
            {
                page_size = value;
                this.NotifyPropertyChanged(entity => entity.Page_Size);
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
                this.NotifyPropertyChanged(entity => entity.Lat_Gps);
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
                this.NotifyPropertyChanged(entity => entity.Lon_Gps);
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
                this.NotifyPropertyChanged(entity => entity.Need2deflect);
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
                this.NotifyPropertyChanged(entity => entity.Locate_Type);
            }
        }

    }
}
