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
    public sealed class LBSGetEvaluationEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsGetEvaluationEntity => lbsGetEvaluationEntity.Id);
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
                this.NotifyPropertyChanged(lbsGetEvaluationEntity => lbsGetEvaluationEntity.User_Id);
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
                this.NotifyPropertyChanged(lbsGetEvaluationEntity => lbsGetEvaluationEntity.Content);
            }
        }


        /// <summary>
        /// 4-comment_count
        /// </summary>
        [DataMember]
        private Int32 comment_count = 0;
        public Int32 Comment_Count
        {
            get
            {
                return comment_count;
            }
            set
            {
                comment_count = value;
                this.NotifyPropertyChanged(lbsGetEvaluationEntity => lbsGetEvaluationEntity.Comment_Count);
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
                this.NotifyPropertyChanged(lbsGetEvaluationEntity => lbsGetEvaluationEntity.Time);
            }
        }


    }
}
