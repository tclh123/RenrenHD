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
    public sealed class LBSGetEvaluationCommentListEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsGetEvaluationCommentListEntity => lbsGetEvaluationCommentListEntity.Count);
            }
        }


        /// <summary>
        /// 2-comment_list
        /// </summary>
        [DataMember]
        private ObservableCollection<LBSGetEvaluationCommentEntity> comment_list = new ObservableCollection<LBSGetEvaluationCommentEntity>();
        public ObservableCollection<LBSGetEvaluationCommentEntity> Comment_List
        {
            get
            {
                return comment_list;
            }
            set
            {
                comment_list = value;
                this.NotifyPropertyChanged(lbsGetEvaluationCommentListEntity => lbsGetEvaluationCommentListEntity.Comment_List);
            }
        }

        /// <summary>
        /// 3-content
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
                this.NotifyPropertyChanged(lbsGetEvaluationCommentListEntity => lbsGetEvaluationCommentListEntity.Page_Size);
            }
        }


        /// <summary>
        /// 4-evaluation
        /// </summary>
        [DataMember]
        private LBSGetEvaluationEntity evaluation = new LBSGetEvaluationEntity();
        public LBSGetEvaluationEntity Evaluation
        {
            get
            {
                return evaluation;
            }
            set
            {
                evaluation = value;
                this.NotifyPropertyChanged(lbsGetEvaluationCommentListEntity => lbsGetEvaluationCommentListEntity.Evaluation);
            }
        }
    }

    [DataContract]
    public sealed class LBSGetEvaluationCommentEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsGetEvaluationCommentEntity => lbsGetEvaluationCommentEntity.Id);
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
                this.NotifyPropertyChanged(lbsGetEvaluationCommentEntity => lbsGetEvaluationCommentEntity.User_Id);
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
                this.NotifyPropertyChanged(lbsGetEvaluationCommentEntity => lbsGetEvaluationCommentEntity.Content);
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
                this.NotifyPropertyChanged(lbsGetEvaluationCommentEntity => lbsGetEvaluationCommentEntity.User_Name);
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
                this.NotifyPropertyChanged(lbsGetEvaluationCommentEntity => lbsGetEvaluationCommentEntity.Time);
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
                this.NotifyPropertyChanged(lbsGetEvaluationCommentEntity => lbsGetEvaluationCommentEntity.Head_Url);
            }
        }

    }
}
