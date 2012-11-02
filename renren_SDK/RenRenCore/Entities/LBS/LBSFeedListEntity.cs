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
    public sealed class LBSFeedListEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsFeedListEntity => lbsFeedListEntity.Count);
            }
        }

        /// <summary>
        /// 2-lbsFeedInfoList
        /// </summary>
        [DataMember]
        private ObservableCollection<LbsFeedInfoEntity> lbsFeedInfoList = new ObservableCollection<LbsFeedInfoEntity>();
        public ObservableCollection<LbsFeedInfoEntity> LbsFeedInfoList
        {
            get
            {
                return lbsFeedInfoList;
            }
            set
            {
                lbsFeedInfoList = value;
                this.NotifyPropertyChanged(lbsFeedListEntity => lbsFeedListEntity.LbsFeedInfoList);
            }
        }
    }
}
