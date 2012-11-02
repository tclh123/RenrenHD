using System;
using System.Net;
using System.Runtime.Serialization;
using RenrenCore.Models;

namespace RenrenCore.Entities
{
    [DataContract]
    public class AcceptFriendEntity : PropertyChangedBase
    {
        /// <summary>
        /// 为“1”表示成功
        /// </summary>
        [DataMember]
        //public string result { get; set; }

        private string result;
        public string Result 
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                this.NotifyPropertyChanged(acceptFriendEntity => acceptFriendEntity.Result);
            }
        }
    }
}
