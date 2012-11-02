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
    public sealed class PlaceReplyListEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(placeReplyListEntity => placeReplyListEntity.Count);
            }
        }


        /// <summary>
        /// 2-comment_list
        /// </summary>
        [DataMember]
        private PlaceReplyListPCIEntity pci = new PlaceReplyListPCIEntity();
        public PlaceReplyListPCIEntity Pci
        {
            get
            {
                return pci;
            }
            set
            {
                pci = value;
                this.NotifyPropertyChanged(placeReplyListEntity => placeReplyListEntity.Pci);
            }
        }

        /// <summary>
        /// 3-reply_list
        /// </summary>
        [DataMember]
        private ObservableCollection<PlaceReplyItemEntity> reply_list = new ObservableCollection<PlaceReplyItemEntity>();
        public ObservableCollection<PlaceReplyItemEntity> Reply_List
        {
            get
            {
                return reply_list;
            }
            set
            {
                reply_list = value;
                this.NotifyPropertyChanged(placeReplyListEntity => placeReplyListEntity.Reply_List);
            }
        }
    }

    [DataContract]
    public sealed class PlaceReplyListPCIEntity : PropertyChangedBase
    {

    }

    [DataContract]
    public sealed class PlaceReplyItemEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(placeReplyItemEntity => placeReplyItemEntity.Id);
            }
        }


        /// <summary>
        /// 2-user_id
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
                this.NotifyPropertyChanged(placeReplyItemEntity => placeReplyItemEntity.User_Id);
            }
        }

        /// <summary>
        /// 3-content
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
                this.NotifyPropertyChanged(placeReplyItemEntity => placeReplyItemEntity.Content);
            }
        }


        /// <summary>
        /// 4-user_name
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
                this.NotifyPropertyChanged(placeReplyItemEntity => placeReplyItemEntity.User_Name);
            }
        }

        /// <summary>
        /// 5-time
        /// </summary>
        [DataMember]
        private Int64 time = 0;
        public Int64 Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                this.NotifyPropertyChanged(placeReplyItemEntity => placeReplyItemEntity.Time);
            }
        }

        /// <summary>
        /// 6-head_url
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
                this.NotifyPropertyChanged(placeReplyItemEntity => placeReplyItemEntity.Head_Url);
            }
        }
    }


}
