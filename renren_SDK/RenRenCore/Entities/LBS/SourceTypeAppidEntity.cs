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
   public sealed class SourceTypeAppidEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-app_id
        /// </summary>
        [DataMember]
        private Int32 app_id = 0;
        public Int32 App_Id
        {
            get
            {
                return app_id;
            }
            set
            {
                app_id = value;
                this.NotifyPropertyChanged(sourceTypeAppidEntity => sourceTypeAppidEntity.App_Id);
            }
        }

        /// <summary>
        /// 2-source_type
        /// </summary>
        [DataMember]
        private Int32 source_type = 0;
        public Int32 Source_Type
        {
            get
            {
                return source_type;
            }
            set
            {
                source_type = value;
                this.NotifyPropertyChanged(sourceTypeAppidEntity => sourceTypeAppidEntity.Source_Type);
            }
        }

        /// <summary>
        /// 3-source_url 
        /// </summary>
        [DataMember]
        private string source_url = "";
        public string Source_Url
        {
            get
            {
                return source_url;
            }
            set
            {
                source_url = value;
                this.NotifyPropertyChanged(sourceTypeAppidEntity => sourceTypeAppidEntity.Source_Url);
            }
        }

        /// <summary>
        /// 4-feed_reply_type 
        /// </summary>
        [DataMember]
        private Int32 feed_reply_type = 0;
        public Int32 Feed_Reply_Type
        {
            get
            {
                return feed_reply_type;
            }
            set
            {
                feed_reply_type = value;
                this.NotifyPropertyChanged(sourceTypeAppidEntity => sourceTypeAppidEntity.Feed_Reply_Type);
            }
        }

        /// <summary>
        /// 5-source_name
        /// </summary>
        [DataMember]
        private string source_name = "";
        public string Source_Name
        {
            get
            {
                return source_name;
            }
            set
            {
                source_name = value;
                this.NotifyPropertyChanged(sourceTypeAppidEntity => sourceTypeAppidEntity.Source_Name);
            }
        }
    }
}
