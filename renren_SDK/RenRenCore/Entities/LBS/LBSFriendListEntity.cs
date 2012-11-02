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
    public class LBSFriendListEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Count);
            }
        }

        /// <summary>
        /// 2-friends_list
        /// </summary>
        [DataMember]
        private ObservableCollection<LBSFriendEntity> friends_list = new ObservableCollection<LBSFriendEntity>();
        public ObservableCollection<LBSFriendEntity> Friends_List
        {
            get
            {
                return friends_list;
            }
            set
            {
                friends_list = value;
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Friends_List);
            }
        }


        /// <summary>
        /// 3-lat_gps
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
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Lat_Gps);
            }
        }


        /// <summary>
        /// 4-lon_gps
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
                lon_gps =  value;
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Lon_Gps);
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
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Page_Size);
            }
        }


        /// <summary>
        /// 6-need2deflect
        /// </summary>
        [DataMember]
        private Int32 need2deflect = 0;
        public Int32 Need2Deflect
        {
            get
            {
                return need2deflect;
            }
            set
            {
                need2deflect = value;
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Need2Deflect);
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
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Locate_Type);
            }
        }

        /// <summary>
        /// 8-lat_deflect
        /// </summary>
        [DataMember]
        private Int64 lat_deflect = 0;
        public Int64 Lat_Deflect
        {
            get
            {
                return lat_deflect;
            }
            set
            {
                lat_deflect = value;
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Lat_Deflect);
            }
        }


        /// <summary>
        /// 9-lon_deflect
        /// </summary>
        [DataMember]
        private Int64 lon_deflect = 0;
        public Int64 Lon_Deflect
        {
            get
            {
                return lon_deflect;
            }
            set
            {
                lon_deflect = value;
                this.NotifyPropertyChanged(lbsFriendListEntity => lbsFriendListEntity.Lon_Deflect);
            }
        }

    }
}
