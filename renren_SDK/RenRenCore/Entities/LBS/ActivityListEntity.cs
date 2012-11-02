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
    public sealed class ActivityListEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(activityListEntity => activityListEntity.Count);
            }
        }


        /// <summary>
        /// 2-activity_list
        /// </summary>
        [DataMember]
        private ObservableCollection<ActivityEntity> activity_list = new ObservableCollection<ActivityEntity>();
        public ObservableCollection<ActivityEntity> Activity_List
        {
            get
            {
                return activity_list;
            }
            set
            {
                activity_list = value;
                this.NotifyPropertyChanged(activityListEntity => activityListEntity.Activity_List);
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
                this.NotifyPropertyChanged(activityListEntity => activityListEntity.Page_Size);
            }
        }






    }
}
    