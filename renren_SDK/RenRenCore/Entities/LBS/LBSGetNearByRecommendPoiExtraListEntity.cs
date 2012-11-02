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
    public sealed class LBSGetNearByRecommendPoiExtraListEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsGetNearByRecommendPoiExtraListEntity => lbsGetNearByRecommendPoiExtraListEntity.Count);
            }
        }


        /// <summary>
        /// 2-poiDataExtraList
        /// </summary>
        [DataMember]
        private ObservableCollection<LBSPoiDataExtraEntity> poiDataExtraList = null;
        public ObservableCollection<LBSPoiDataExtraEntity> PoiDataExtraList
        {
            get
            {
                return poiDataExtraList;
            }
            set
            {
                poiDataExtraList = value;
                this.NotifyPropertyChanged(lbsGetNearByRecommendPoiExtraListEntity => lbsGetNearByRecommendPoiExtraListEntity.PoiDataExtraList);
            }
        }
    }

    [DataContract]
    public sealed class LBSPoiDataExtraEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-id
        /// </summary>
        [DataMember]
        private Int64 id = -1;
        public Int64 Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Id);
            }
        }


        /// <summary>
        /// 2-pid
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
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Pid);
            }
        }

        /// <summary>
        /// 3-longitude
        /// </summary>
        [DataMember]
        private double longitude = -1;
        public double Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Longitude);
            }
        }


        /// <summary>
        /// 4-latitude
        /// </summary>
        [DataMember]
        private double latitude = -1;
        public double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Latitude);
            }
        }

        /// <summary>
        /// 5-longitudeGps
        /// </summary>
        [DataMember]
        private double longitudeGps = -1;
        public double LongitudeGps
        {
            get
            {
                return longitudeGps;
            }
            set
            {
                longitudeGps = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.LongitudeGps);
            }
        }

        /// <summary>
        /// 6-latitudeGps
        /// </summary>
        [DataMember]
        private double latitudeGps = -1;
        public double LatitudeGps
        {
            get
            {
                return latitudeGps;
            }
            set
            {
                latitudeGps = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.LatitudeGps);
            }
        }


        /// <summary>
        /// 7-name
        /// </summary>
        [DataMember]
        private string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Name);
            }
        }


        /// <summary>
        /// 8-address
        /// </summary>
        [DataMember]
        private string address = "";
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Address);
            }
        }

        /// <summary>
        /// 9-phone
        /// </summary>
        [DataMember]
        private string phone = "";
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Phone);
            }
        }


        /// <summary>
        /// 10-note
        /// </summary>
        [DataMember]
        private string note = "";
        public string Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Note);
            }
        }

        /// <summary>
        /// 11-country
        /// </summary>
        [DataMember]
        private string country = "";
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Country);
            }
        }

        /// <summary>
        /// 12-province
        /// </summary>
        [DataMember]
        private string province = "";
        public string Province
        {
            get
            {
                return province;
            }
            set
            {
                province = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Province);
            }
        }

        /// <summary>
        /// 13-city
        /// </summary>
        [DataMember]
        private string city = "";
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.City);
            }
        }


        /// <summary>
        /// 14-cityCode
        /// </summary>
        [DataMember]
        private string cityCode = "";
        public string CityCode
        {
            get
            {
                return cityCode;
            }
            set
            {
                cityCode = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.CityCode);
            }
        }

        /// <summary>
        /// 15-district
        /// </summary>
        [DataMember]
        private string district = "";
        public string District
        {
            get
            {
                return district;
            }
            set
            {
                district = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.District);
            }
        }


        /// <summary>
        /// 16-note
        /// </summary>
        [DataMember]
        private string street = "";
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Street);
            }
        }

        /// <summary>
        /// 17-sourceType
        /// </summary>
        [DataMember]
        private Int32 sourceType = -1;
        public Int32 SourceType
        {
            get
            {
                return sourceType;
            }
            set
            {
                sourceType = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.SourceType);
            }
        }

        /// <summary>
        /// 18-poiCaption
        /// </summary>
        [DataMember]
        private string poiCaption = "";
        public string PoiCaption
        {
            get
            {
                return poiCaption;
            }
            set
            {
                poiCaption = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.PoiCaption);
            }
        }



        /// <summary>
        /// 19-poiType
        /// </summary>
        [DataMember]
        private string poiType = "";
        public string PoiType
        {
            get
            {
                return poiType;
            }
            set
            {
                poiType = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.PoiType);
            }
        }

        /// <summary>
        /// 20-ugc
        /// </summary>
        [DataMember]
        private Int32 ugc = -1;
        public Int32 Ugc
        {
            get
            {
                return ugc;
            }
            set
            {
                ugc = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.Ugc);
            }
        }


        /// <summary>
        /// 21-friendsPointsCount
        /// </summary>
        [DataMember]
        private Int32 friendsPointsCount = -1;
        public Int32 FriendsPointsCount
        {
            get
            {
                return friendsPointsCount;
            }
            set
            {
                friendsPointsCount = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.FriendsPointsCount);
            }
        }

        /// <summary>
        /// 22-friendsPhotoCount
        /// </summary>
        [DataMember]
        private Int32 friendsPhotoCount = -1;
        public Int32 FriendsPhotoCount
        {
            get
            {
                return friendsPhotoCount;
            }
            set
            {
                friendsPhotoCount = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.FriendsPhotoCount);
            }
        }

        /// <summary>
        /// 23-friendsVisited
        /// </summary>
        [DataMember]
        private Int32 friendsVisited = -1;
        public Int32 FriendsVisited
        {
            get
            {
                return friendsVisited;
            }
            set
            {
                friendsVisited = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.FriendsVisited);
            }
        }

        /// <summary>
        /// 24-totalVistited
        /// </summary>
        [DataMember]
        private Int32 totalVistited = -1;
        public Int32 TotalVistited
        {
            get
            {
                return totalVistited;
            }
            set
            {
                totalVistited = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.TotalVistited);
            }
        }

        /// <summary>
        /// 25-hasActivity
        /// </summary>
        [DataMember]
        private Int32 hasActivity = -1;
        public Int32 HasActivity
        {
            get
            {
                return hasActivity;
            }
            set
            {
                hasActivity = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.HasActivity);
            }
        }

        /// <summary>
        /// 26-latestFriendsPhotosList
        /// </summary>
        [DataMember]
        private ObservableCollection<LBSLocationFlowLiteEntity> latestFriendsPhotosList = null;
        public ObservableCollection<LBSLocationFlowLiteEntity> LatestFriendsPhotosList
        {
            get 
            {
                return latestFriendsPhotosList;
            }
            set 
            {
                latestFriendsPhotosList = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.LatestFriendsPhotosList);
            }
        }

        /// <summary>
        /// 27-latestFriendsPointsList
        /// </summary>
        [DataMember]
        private ObservableCollection<LBSLocationFlowLiteEntity> latestFriendsPointsList = null;
        public ObservableCollection<LBSLocationFlowLiteEntity> LatestFriendsPointsList
        {
            get
            {
                return latestFriendsPointsList;
            }
            set
            {
                latestFriendsPointsList = value;
                this.NotifyPropertyChanged(lbsPoiDataExtraEntity => lbsPoiDataExtraEntity.LatestFriendsPointsList);
            }
        }

    }

    [DataContract]
    public sealed class LBSLocationFlowLiteEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-id
        /// </summary>
        [DataMember]
        private Int64 id = -1;
        public Int64 Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                this.NotifyPropertyChanged(lbsLocationFlowLiteEntity => lbsLocationFlowLiteEntity.Id);
            }
        }


        /// <summary>
        /// 2-user_id
        /// </summary>
        [DataMember]
        private Int32 userId = -1;
        public Int32 UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
                this.NotifyPropertyChanged(lbsLocationFlowLiteEntity => lbsLocationFlowLiteEntity.UserId);
            }
        }

        /// <summary>
        /// 3-userName
        /// </summary>
        [DataMember]
        private string userName = "";
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                this.NotifyPropertyChanged(lbsLocationFlowLiteEntity => lbsLocationFlowLiteEntity.UserName);
            }
        }


        /// <summary>
        /// 4-srcId
        /// </summary>
        [DataMember]
        private Int64 srcId = 0;
        public Int64 SrcId
        {
            get
            {
                return srcId;
            }
            set
            {
                srcId = value;
                this.NotifyPropertyChanged(lbsLocationFlowLiteEntity => lbsLocationFlowLiteEntity.SrcId);
            }
        }

        /// <summary>
        /// 5-content
        /// </summary>
        [DataMember]
        private string content = "";
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                this.NotifyPropertyChanged(lbsLocationFlowLiteEntity => lbsLocationFlowLiteEntity.Content);
            }
        }

        /// <summary>
        /// 6-bizType
        /// </summary>
        [DataMember]
        private Int32 bizType = -1;
        public Int32 BizType
        {
            get
            {
                return bizType;
            }
            set
            {
                bizType = value;
                this.NotifyPropertyChanged(lbsLocationFlowLiteEntity => lbsLocationFlowLiteEntity.BizType);
            }
        }

    }
}
