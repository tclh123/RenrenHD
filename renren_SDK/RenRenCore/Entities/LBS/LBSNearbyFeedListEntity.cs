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
    public sealed class LBSNearbyFeedListEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsNearbyFeedListEntity => lbsNearbyFeedListEntity.Count);
            }
        }

        /// <summary>
        /// 2-page_size
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
                this.NotifyPropertyChanged(lbsNearbyFeedListEntity => lbsNearbyFeedListEntity.Page_Size);
            }
        }

        /// <summary>
        /// 3-feed_list 
        /// </summary>
        [DataMember]
        private ObservableCollection<LBSNearbyFeedInfoEntity> feed_list = new ObservableCollection<LBSNearbyFeedInfoEntity>();
        public ObservableCollection<LBSNearbyFeedInfoEntity> Feed_List
        {
            get
            {
                return feed_list;
            }
            set
            {
                feed_list = value;
                this.NotifyPropertyChanged(lbsNearbyFeedListEntity => lbsNearbyFeedListEntity.Feed_List);
            }
        }

        /// <summary>
        /// 4-locate_type 
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
                this.NotifyPropertyChanged(lbsNearbyFeedListEntity => lbsNearbyFeedListEntity.Locate_Type);
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
                this.NotifyPropertyChanged(lbsNearbyFeedListEntity => lbsNearbyFeedListEntity.Need2deflect);
            }
        }

        /// <summary>
        /// 6-lat_gps
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
                this.NotifyPropertyChanged(lbsNearbyFeedListEntity => lbsNearbyFeedListEntity.Lat_Gps);
            }
        }

        /// <summary>
        /// 7-lon_gps
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
                this.NotifyPropertyChanged(lbsNearbyFeedListEntity => lbsNearbyFeedListEntity.Lon_Gps);
            }
        }

    }
    
    
    [DataContract]
    public sealed class LBSNearbyFeedInfoEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-add_time
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Add_Time);
            }
        }

        /// <summary>
        /// 2-data_type
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Data_Type);
            }
        }

        /// <summary>
        /// 3-distance 
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Distance);
            }
        }

        /// <summary>
        /// 4-head_url 
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Head_Url);
            }
        }

        /// <summary>
        /// 5-latitude_gps
        /// </summary>
        [DataMember]
        private Int64 latitude_gps = 0;
        public Int64 Latitude_Gps
        {
            get
            {
                return latitude_gps;
            }
            set
            {
                latitude_gps = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Latitude_Gps);
            }
        }

        /// <summary>
        /// 6-latitude_poi
        /// </summary>
        [DataMember]
        private Int64 latitude_poi = 0;
        public Int64 Latitude_Poi
        {
            get
            {
                return latitude_poi;
            }
            set
            {
                latitude_poi = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Latitude_Poi);
            }
        }

        /// <summary>
        /// 7-locate_type
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Locate_Type);
            }
        }

        /// <summary>
        /// 8-longitude_gps
        /// </summary>
        [DataMember]
        private Int64 longitude_gps = 0;
        public Int64 Longitude_Gps
        {
            get
            {
                return longitude_gps;
            }
            set
            {
                longitude_gps = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Longitude_Gps);
            }
        }

        /// <summary>
        /// 9-longitude_poi 
        /// </summary>
        [DataMember]
        private Int64 longitude_poi = 0;
        public Int64 Longitude_Poi
        {
            get
            {
                return longitude_poi;
            }
            set
            {
                longitude_poi = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Longitude_Poi);
            }
        }

        /// <summary>
        /// 10-main_url 
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Main_Url);
            }
        }

        /// <summary>
        /// 11-user_name 
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.User_Name);
            }
        }

        /// <summary>
        /// 12-pid 
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Pid);
            }
        }


        /// <summary>
        /// 13-poi_address 
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Poi_Address);
            }
        }

        /// <summary>
        /// 14-poi_name 
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Poi_Name);
            }
        }

        /// <summary>
        /// 15-poi_phone 
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Poi_Phone);
            }
        }

        /// <summary>
        /// 16-privacy 
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Privacy);
            }
        }

        /// <summary>
        /// 17-status_text 
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Status_Text);
            }
        }

        /// <summary>
        /// 18-tiny_url 
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Tiny_Url);
            }
        }

        /// <summary>
        /// 19-user_id 
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.User_Id);
            }
        }

        /// <summary>
        /// 20-reply_count 
        /// </summary>
        [DataMember]
        private Int32 reply_count = 0;
        public Int32 Reply_Count
        {
            get
            {
                return reply_count;
            }
            set
            {
                reply_count = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Reply_Count);
            }
        }

        /// <summary>
        /// 21-feed_image_url 
        /// </summary>
        [DataMember]
        private string feed_image_url = "";
        public string Feed_Image_Url
        {
            get
            {
                return feed_image_url;
            }
            set
            {
                feed_image_url = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Feed_Image_Url);
            }
        }

        /// <summary>
        /// 22-source_id 
        /// </summary>
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
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Source_Id);
            }
        }

        /// <summary>
        /// 23-status_forward  
        /// </summary>
        [DataMember]
        private FeedStatusForwardEntity status_forward = new FeedStatusForwardEntity();
        public FeedStatusForwardEntity Status_Forward
        {
            get
            {
                return status_forward;
            }
            set
            {
                status_forward = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Status_Forward);
            }
        }


        /// <summary>
        /// 24-origin_type 
        /// </summary>
        [DataMember]
        private Int32 origin_type = 0;
        public Int32 Origin_Type
        {
            get
            {
                return origin_type;
            }
            set
            {
                origin_type = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Origin_Type);
            }
        }

        /// <summary>
        /// 25-origin_title 
        /// </summary>
        [DataMember]
        private string origin_title = "";
        public string Origin_Title
        {
            get
            {
                return origin_title;
            }
            set
            {
                origin_title = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Origin_Title);
            }
        }

        /// <summary>
        /// 26-origin_url 
        /// </summary>
        [DataMember]
        private string origin_url = "";
        public string Origin_Url
        {
            get
            {
                return origin_url;
            }
            set
            {
                origin_url = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Origin_Url);
            }
        }

        /// <summary>
        /// 27-media_id 
        /// </summary>
        [DataMember]
        private Int64 media_id = 0;
        public Int64 Media_Id
        {
            get
            {
                return media_id;
            }
            set
            {
                media_id = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Media_Id);
            }
        }

        /// <summary>
        /// 28-attachement_list 
        /// </summary>
        [DataMember]
        private FeedAttachmentEntity attachement_list = new FeedAttachmentEntity();
        public FeedAttachmentEntity Attachement_List
        {
            get
            {
                return attachement_list;
            }
            set
            {
                attachement_list = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Attachement_List);
            }
        }

        /// <summary>
        /// 29-remark  
        /// </summary>
        [DataMember]
        private Int64 lbs_id = 0;
        public Int64 Lbs_Id
        {
            get
            {
                return lbs_id;
            }
            set
            {
                lbs_id = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Lbs_Id);
            }
        }


        /// <summary>
        /// 30-title 
        /// </summary>
        [DataMember]
        private string title = "";
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Title);
            }
        }

        /// <summary>
        /// 31-prefix 
        /// </summary>
        [DataMember]
        private string prefix = "";
        public string Prefix
        {
            get
            {
                return prefix;
            }
            set
            {
                prefix = value;
                this.NotifyPropertyChanged(lbsNearbyFeedInfoEntity => lbsNearbyFeedInfoEntity.Prefix);
            }
        }


    }

    [DataContract]
    public sealed class FeedStatusForwardEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-id
        /// </summary>
        [DataMember]
        private Int64 id = 0;
        public Int64 Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                this.NotifyPropertyChanged(feedStatusForwardEntity => feedStatusForwardEntity.Id);
            }
        }

        /// <summary>
        /// 2-user_name
        /// </summary>
        [DataMember]
        private string status = "";
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                this.NotifyPropertyChanged(feedStatusForwardEntity => feedStatusForwardEntity.Status);
            }
        }

        /// <summary>
        /// 3-gender 
        /// </summary>
        [DataMember]
        private Int32 owner_id = 0;
        public Int32 Owner_Id
        {
            get
            {
                return owner_id;
            }
            set
            {
                owner_id = value;
                this.NotifyPropertyChanged(feedStatusForwardEntity => feedStatusForwardEntity.Owner_Id);
            }
        }

        /// <summary>
        /// 4-owner_name
        /// </summary>
        [DataMember]
        private string owner_name = "";
        public string Owner_Name
        {
            get
            {
                return owner_name;
            }
            set
            {
                owner_name = value;
                this.NotifyPropertyChanged(feedStatusForwardEntity => feedStatusForwardEntity.Owner_Name);
            }
        }
    }


    [DataContract]
    public sealed class FeedAttachmentEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-url
        /// </summary>
        [DataMember]
        private string url = "";
        public string  Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                this.NotifyPropertyChanged(feedAttachmentEntity => feedAttachmentEntity.Url);
            }
        }

        /// <summary>
        /// 2-type
        /// </summary>
        [DataMember]
        private string type = "";
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                this.NotifyPropertyChanged(feedAttachmentEntity => feedAttachmentEntity.Type);
            }
        }

        /// <summary>
        /// 3-src 
        /// </summary>
        [DataMember]
        private string src = "";
        public string Src
        {
            get
            {
                return src;
            }
            set
            {
                src = value;
                this.NotifyPropertyChanged(feedAttachmentEntity => feedAttachmentEntity.Src);
            }
        }

        /// <summary>
        /// 4-head_url 
        /// </summary>
        [DataMember]
        private Int64 media_id = 0;
        public Int64 Media_Id
        {
            get
            {
                return media_id;
            }
            set
            {
                media_id = value;
                this.NotifyPropertyChanged(feedAttachmentEntity => feedAttachmentEntity.Media_Id);
            }
        }

        /// <summary>
        /// 5-reply_count
        /// </summary>
        [DataMember]
        private Int32 owner_id = 0;
        public Int32 Owner_Id
        {
            get
            {
                return owner_id;
            }
            set
            {
                owner_id = value;
                this.NotifyPropertyChanged(feedAttachmentEntity => feedAttachmentEntity.Owner_Id);
            }
        }

        /// <summary>
        /// 6-digest
        /// </summary>
        [DataMember]
        private string digest = "";
        public string Digest
        {
            get
            {
                return digest;
            }
            set
            {
                digest = value;
                this.NotifyPropertyChanged(feedAttachmentEntity => feedAttachmentEntity.Digest);
            }
        }

        /// <summary>
        /// 7-main_url
        /// </summary>
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
                this.NotifyPropertyChanged(feedAttachmentEntity => feedAttachmentEntity.Main_Url);
            }
        }



    }
}
