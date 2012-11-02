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
    public class LBSFriendEntity:PropertyChangedBase
    {
        /// <summary>
        /// 1-add time
        /// </summary>
        [DataMember]
        private Int64 add_time = 0;
        public Int64 Add_Time
        {
            get 
            { 
                return add_time; 
            }
            set
            {
                add_time = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Add_Time);
            }
        }


        /// <summary>
        /// 2-Data type
        /// </summary>
        [DataMember]
        private Int32 data_type = 0;
        public Int32 Data_Type
        {
            get
            {
                return data_type;
            }
            set
            {
                data_type = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Data_Type);
            }
        }

        /// <summary>
        /// 3-Distance
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
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Distance);
            }
        }

        /// <summary>
        ///4- head url
        /// </summary>
        [DataMember]
        private string head_url = "";
        public string Head_Url
        {
            get
            {
                return head_url;
            }
            set
            {
                head_url = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Head_Url);
            }
        }

        ///<summary>
        ///5-latitude_gps
        ///</summary>
        [DataMember]
        private Int64 latitude_gps = 0;
        public Int64 Latitude_GPS
        {
            get
            {
                return latitude_gps;
            }
            set
            {
                latitude_gps = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Latitude_GPS);
            }
        }

        ///<summary>
        ///6-latitude_poi
        ///</summary>
        [DataMember]
        private Int64 latitude_poi = 0;
        public Int64 Latitude_POI
        {
            get
            {
                return latitude_poi;
            }
            set
            {
                latitude_poi = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.latitude_poi);
            }
        }


        ///<summary>
        /// 7-locate_type
        ///</summary>
        [DataMember]
        private Int64 locate_type = 0;
        public Int64 Locate_Type
        {
            get
            {
                return locate_type;
            }
            set
            {
                locate_type = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Locate_Type);
            }
        }

        ///<summary>
        /// 8-longitude_gps
        ///</summary>
        [DataMember]
        private Int64 longitude_gps = 0;
        public Int64 Longitude_GPS
        {
            get
            {
                return longitude_gps;
            }
            set
            {
                longitude_gps = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Longitude_GPS);
            }
        }


        ///<summary>
        /// 9-longitude_poi
        ///</summary>
        [DataMember]
        private Int64 longitude_poi = 0;
        public Int64 Longitude_POI
        {
            get
            {
                return longitude_poi;
            }
            set
            {
                longitude_poi = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Longitude_POI);
            }
        }

        ///<summary>
        /// 10-main_url
        ///</summary>
        [DataMember]
        private string main_url = "";
        public string Main_Url
        {
            get
            {
                return main_url;
            }
            set
            {
                main_url = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Main_Url);
            }
        }

        ///<summary>
        /// 11-user_name
        ///</summary>
        [DataMember]
        private string user_name = "";
        public string User_Name
        {
            get
            {
                return user_name;
            }
            set
            {
                user_name = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.User_Name);
            }
        }

        ///<summary>
        /// 12-pid
        ///</summary>
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
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Pid);
            }
        }

        
        ///<summary>
        /// 13-poi_address
        ///</summary>
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
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Poi_Address);
            }
        }

        ///<summary>
        /// 14-poi_name
        ///</summary>
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
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Poi_Name);
            }
        }

        ///<summary>
        /// 15-poi_phone
        ///</summary>
        [DataMember]
        private string poi_phone = "";
        public string Poi_Phone
        {
            get
            {
                return poi_phone;
            }
            set
            {
                poi_phone = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Poi_Phone);
            }
        }

      
        ///<summary>
        /// 16-privacy
        ///</summary>
        [DataMember]
        private Int32 privacy = 0;
        public Int32 Privacy
        {
            get
            {
                return privacy;
            }
            set
            {
                privacy = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Privacy);
            }
        }

        ///<summary>
        /// 17-status_text
        ///</summary>
        [DataMember]
        private string status_text = "";
        public string Status_Text
        {
            get
            {
                return status_text;
            }
            set
            {
                status_text = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Status_Text);
            }
        }

        ///<summary>
        /// 18-tiny_url
        ///</summary>
        [DataMember]
        private string tiny_url = "";
        public string Tiny_Url
        {
            get
            {
                return tiny_url;
            }
            set
            {
                tiny_url = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Tiny_Url);
            }
        }


     
        ///<summary>
        /// 19-user_id
        ///</summary>
        [DataMember]
        private Int32 user_id = 0;
        public Int32 User_Id
        {
            get
            {
                return user_id;
            }
            set
            {
                user_id = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.User_Id);
            }
        }

        ///<summary>
        /// 20-lbs_id
        ///</summary>
        [DataMember]
        private Int64 lbs_id = 0;
        public Int64 LBS_Id
        {
            get   
            {
                return lbs_id;
            }
            set
            {
                lbs_id = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.LBS_Id);
            }
              
        }


        ///<summary>
        /// 21-source_id
        ///</summary>
        [DataMember]
        private Int64 source_id = 0;
        public Int64 Source_Id
        {
            get
            {
                return source_id;
            }
            set
            {
                source_id = value;
                this.NotifyPropertyChanged(lbsFriendEntity => lbsFriendEntity.Source_Id);
            }
        }


    }
}
