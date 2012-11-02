using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Runtime.Serialization;
using RenrenCore.Models;

namespace RenrenCore.Entities
{
    [DataContract]
    public class PlaceInfoEntity : PropertyChangedBase
    {
        [DataMember]
        private long lon;
        public long Longitude
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Longitude);
            }
        }

        [DataMember]
        private long lat;
        public long Latitude
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Latitude);
            }
        }

        [DataMember]
        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Address);
            }
        }

        [DataMember]
        private string county;
        public string County
        {
            get
            {
                return county;
            }
            set
            {
                county = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.County);
            }
        }

        [DataMember]
        private string province;
        public string Province
        {
            get
            {
                return province;
            }
            set
            {
                province = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Province);
            }
        }

        [DataMember]
        private string street_name;
        public string Street_name
        {
            get
            {
                return street_name;
            }
            set
            {
                street_name = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Street_name);
            }
        }

        [DataMember]
        private string nation;
        public string Nation
        {
            get
            {
                return nation;
            }
            set
            {
                nation = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Nation);
            }
        }

        [DataMember]
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.City);
            }
        }

        [DataMember]
        private string poi_name;
        public string PoiName
        {
            get
            {
                return poi_name;
            }
            set
            {
                poi_name = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.PoiName);
            }
        }

        [DataMember]
        private Int32 distance;
        public Int32 Distance 
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Distance);
            }
        }



        [DataMember]
        private string phone;
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Phone);
            }
        }

        [DataMember]
        private float weight;
        public float Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Weight);
            }
        }


        [DataMember]
        private string pid;
        public string Pid
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Pid);
            }
        }

        [DataMember]
        private string activity_caption;
        public string Activity_Caption 
        {
            get
            {
                return activity_caption;
            }
            set
            {
                activity_caption = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Activity_Caption);
            }
        }


        [DataMember]
        private Int32 activity_count;
        public Int32 Activity_Count
        {
            get
            {
                return activity_count;
            }
            set
            {
                activity_count = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Activity_Count);
            }
        }

        [DataMember]
        private Int32 nearby_activity_count;
        public Int32 Nearby_Activity_Count
        {
            get
            {
                return nearby_activity_count;
            }
            set
            {
                nearby_activity_count = value;
                this.NotifyPropertyChanged(placeInfoEntity => placeInfoEntity.Nearby_Activity_Count);
            }
        }




    }
}
