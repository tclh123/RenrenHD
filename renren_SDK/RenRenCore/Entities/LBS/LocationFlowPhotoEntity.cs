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
    public sealed class LocationFlowPhotoEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-photo_id
        /// </summary>
        [DataMember]
        private Int64 photo_id = 0;
        public Int64 Photo_Id
        {
            get
            {
                return photo_id;
            }
            set
            {
                photo_id = value;
                this.NotifyPropertyChanged(locationFlowPhotoEntity => locationFlowPhotoEntity.Photo_Id);
            }
        }

        /// <summary>
        /// 2-album_id
        /// </summary>
        [DataMember]
        private Int64 album_id = 0;
        public Int64 Album_Id
        {
            get
            {
                return album_id;
            }
            set
            {
                album_id = value;
                this.NotifyPropertyChanged(locationFlowPhotoEntity => locationFlowPhotoEntity.Album_Id);
            }
        }

        /// <summary>
        /// 3-album_name 
        /// </summary>
        [DataMember]
        private string album_name = "";
        public string Album_Name
        {
            get
            {
                return album_name;
            }
            set
            {
                album_name = value;
                this.NotifyPropertyChanged(locationFlowPhotoEntity => locationFlowPhotoEntity.Album_Name);
            }
        }

        /// <summary>
        /// 4-title 
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
                this.NotifyPropertyChanged(locationFlowPhotoEntity => locationFlowPhotoEntity.Title);
            }
        }

        /// <summary>
        /// 5-large_url
        /// </summary>
        [DataMember]
        private string large_url = "";
        public string Large_Url
        {
            get
            {
                return large_url;
            }
            set
            {
                large_url = value;
                this.NotifyPropertyChanged(locationFlowPhotoEntity => locationFlowPhotoEntity.Large_Url);
            }
        }

        /// <summary>
        /// 6-main_url
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
                this.NotifyPropertyChanged(locationFlowPhotoEntity => locationFlowPhotoEntity.Main_Url);
            }
        }

        /// <summary>
        /// 7-head_url
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
                this.NotifyPropertyChanged(locationFlowPhotoEntity => locationFlowPhotoEntity.Head_Url);
            }
        }

        /// <summary>
        /// 8-tiny_url
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
                this.NotifyPropertyChanged(locationFlowPhotoEntity => locationFlowPhotoEntity.Tiny_Url);
            }
        }
    }
}
