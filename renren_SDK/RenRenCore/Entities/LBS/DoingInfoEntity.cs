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
    public sealed class DoingInfoEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Id);
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
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.User_Id);
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
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Content);
            }
        }

        /// <summary>
        /// 4-new_content 
        /// </summary>
        [DataMember]
        private string new_content = "";
        public string New_Content
        {
            get
            {
                return new_content;
            }
            set
            {
                new_content = value;
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.New_Content);
            }
        }

        /// <summary>
        /// 5-root_content
        /// </summary>
        [DataMember]
        private string root_content = "";
        public string Root_Content
        {
            get
            {
                return root_content;
            }
            set
            {
                root_content = value;
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Root_Content);
            }
        }

        /// <summary>
        /// 6-html_new_content
        /// </summary>
        [DataMember]
        private string  html_new_content = "";
        public string Html_New_Content
        {
            get
            {
                return html_new_content;
            }
            set
            {
                html_new_content = value;
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Html_New_Content);
            }
        }

        /// <summary>
        /// 7-html_root_content
        /// </summary>
        [DataMember]
        private string html_root_content = "";
        public string Html_Root_Content
        {
            get
            {
                return html_root_content;
            }
            set
            {
                html_root_content = value;
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Html_Root_Content);
            }
        }

        /// <summary>
        /// 8-is_forward
        /// </summary>
        [DataMember]
        private string is_forward = "";
        public string Is_Forward
        {
            get
            {
                return is_forward;
            }
            set
            {
                is_forward = value;
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Is_Forward);
            }
        }

        /// <summary>
        /// 9-is_position 
        /// </summary>
        [DataMember]
        private string is_position = "";
        public string Is_Position
        {
            get
            {
                return is_position;
            }
            set
            {
                is_position = value;
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Is_Position);
            }
        }

        /// <summary>
        /// 10-root_doing_user_id 
        /// </summary>
        [DataMember]
        private Int32 root_doing_user_id = 0;
        public Int32 Root_Doing_User_Id
        {
            get
            {
                return root_doing_user_id;
            }
            set
            {
                root_doing_user_id = value;
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Root_Doing_User_Id);
            }
        }

        /// <summary>
        /// 11-location_name 
        /// </summary>
        [DataMember]
        private string root_doing_user_name = "";
        public string Root_Doing_User_Name
        {
            get
            {
                return root_doing_user_name;
            }
            set
            {
                root_doing_user_name = value;
                this.NotifyPropertyChanged(doingInfoEntity => doingInfoEntity.Root_Doing_User_Name);
            }
        }
    }
}
