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
    public sealed class LbsFeedInfoEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-user_id
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
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.User_Id);
            }
        }

        /// <summary>
        /// 2-user_name
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
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.User_Name);
            }
        }

        /// <summary>
        /// 3-gender 
        /// </summary>
        [DataMember]
        private string gender = "";
        public string Gender 
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Gender);
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
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Head_Url);
            }
        }

        /// <summary>
        /// 5-reply_count
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
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Reply_Count);
            }
        }

        /// <summary>
        /// 6-ugc_type
        /// </summary>
        [DataMember]
        private Int32 ugc_type = 0;
        public Int32 Ugc_Type
        {
            get
            {
                return ugc_type;
            }
            set
            {
                ugc_type = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Ugc_Type);
            }
        }

        /// <summary>
        /// 7-ugc_id
        /// </summary>
        [DataMember]
        private Int32 ugc_id = 0;
        public Int32 Ugc_Id
        {
            get
            {
                return ugc_id;
            }
            set
            {
                ugc_id = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Ugc_Id);
            }
        }

        /// <summary>
        /// 8-pid
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
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Pid);
            }
        }

        /// <summary>
        /// 9-longitude 
        /// </summary>
        [DataMember]
        private double longitude = 0;
        public double Longitude 
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Longitude);
            }
        }

        /// <summary>
        /// 10-latitude 
        /// </summary>
        [DataMember]
        private double latitude = 0;
        public double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Latitude);
            }
        }

        /// <summary>
        /// 11-location_name 
        /// </summary>
        [DataMember]
        private string location_name = "";
        public string Location_Name
        {
            get
            {
                return location_name;
            }
            set
            {
                location_name = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Location_Name);
            }
        }

        /// <summary>
        /// 12-biz_type 
        /// </summary>
        [DataMember]
        private Int32 biz_type = 0;
        public Int32 Biz_Type
        {
            get
            {
                return biz_type;
            }
            set
            {
                biz_type = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Biz_Type);
            }
        }


        /// <summary>
        /// 13-biz_type 
        /// </summary>
        [DataMember]
        private Int32 biz_sub_type = 0;
        public Int32 Biz_Sub_Type
        {
            get
            {
                return biz_sub_type;
            }
            set
            {
                biz_sub_type = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Biz_Sub_Type);
            }
        }

        /// <summary>
        /// 14-src_id 
        /// </summary>
        [DataMember]
        private Int64 src_id = 0;
        public Int64 Src_Id
        {
            get
            {
                return src_id;
            }
            set
            {
                src_id = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Src_Id);
            }
        }

        /// <summary>
        /// 15-loc_type 
        /// </summary>
        [DataMember]
        private Int32 loc_type = 0;
        public Int32 Loc_Type
        {
            get
            {
                return loc_type;
            }
            set
            {
                loc_type = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Loc_Type);
            }
        }

        /// <summary>
        /// 16-content 
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
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Content);
            }
        }

        /// <summary>
        /// 17-ubb_content 
        /// </summary>
        [DataMember]
        private string ubb_content = "";
        public string Ubb_Content
        {
            get
            {
                return ubb_content;
            }
            set
            {
                ubb_content = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Ubb_Content);
            }
        }

        /// <summary>
        /// 18-location_flow_photo 
        /// </summary>
        [DataMember]
        private LocationFlowPhotoEntity location_flow_photo = new LocationFlowPhotoEntity();
        public LocationFlowPhotoEntity Location_Flow_Photo
        {
            get
            {
                return location_flow_photo;
            }
            set
            {
                location_flow_photo = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Location_Flow_Photo);
            }
        }

        /// <summary>
        /// 19-doing_info 
        /// </summary>
        [DataMember]
        private DoingInfoEntity doing_info = new DoingInfoEntity();
        public DoingInfoEntity Doing_Info
        {
            get
            {
                return doing_info;
            }
            set
            {
                doing_info = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Doing_Info);
            }
        }

        /// <summary>
        /// 20-privacy 
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
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Privacy);
            }
        }

        /// <summary>
        /// 21-grid_id2 
        /// </summary>
        [DataMember]
        private Int32 grid_id2 = 0;
        public Int32 Grid_Id2
        {
            get
            {
                return grid_id2;
            }
            set
            {
                grid_id2 = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Grid_Id2);
            }
        }

        /// <summary>
        /// 22-grid_id3 
        /// </summary>
        [DataMember]
        private Int32 grid_id3 = 0;
        public Int32 Grid_Id3
        {
            get
            {
                return grid_id3;
            }
            set
            {
                grid_id3 = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Grid_Id3);
            }
        }

        /// <summary>
        /// 23-grid_id4 
        /// </summary>
        [DataMember]
        private Int32 grid_id4 = 0;
        public Int32 Grid_Id4
        {
            get
            {
                return grid_id4;
            }
            set
            {
                grid_id4 = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Grid_Id4);
            }
        }


        /// <summary>
        /// 24-src_time 
        /// </summary>
        [DataMember]
        private Int64 src_time = 0;
        public Int64 Src_Time
        {
            get
            {
                return src_time;
            }
            set
            {
                src_time = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Src_Time);
            }
        }

        /// <summary>
        /// 25-add_time 
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
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Add_Time);
            }
        }

        /// <summary>
        /// 26-add_user_id 
        /// </summary>
        [DataMember]
        private Int32 add_user_id = 0;
        public Int32 Add_User_Id
        {
            get
            {
                return add_user_id;
            }
            set
            {
                add_user_id = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Add_User_Id);
            }
        }

        /// <summary>
        /// 27-modify_time 
        /// </summary>
        [DataMember]
        private Int64 modify_time = 0;
        public Int64 Modify_Time
        {
            get
            {
                return modify_time;
            }
            set
            {
                modify_time = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Modify_Time);
            }
        }

        /// <summary>
        /// 28-modify_user_id 
        /// </summary>
        [DataMember]
        private Int32 modify_user_id = 0;
        public Int32 Modify_User_Id
        {
            get
            {
                return modify_user_id;
            }
            set
            {
                modify_user_id = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Modify_User_Id);
            }
        }

        /// <summary>
        /// 29-remark  
        /// </summary>
        [DataMember]
        private string remark = "";
        public string Remark 
        {
            get
            {
                return remark;
            }
            set
            {
                remark = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Remark);
            }
        }


        /// <summary>
        /// 30-source_type_appid 
        /// </summary>
        [DataMember]
        private SourceTypeAppidEntity source_type_appid = new SourceTypeAppidEntity();
        public SourceTypeAppidEntity Source_Type_Appid
        {
            get
            {
                return source_type_appid;
            }
            set
            {
                source_type_appid = value;
                this.NotifyPropertyChanged(lbsFeedInfoEntity => lbsFeedInfoEntity.Source_Type_Appid);
            }
        }

    }
}
