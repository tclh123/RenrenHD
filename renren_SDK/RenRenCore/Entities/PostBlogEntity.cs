﻿using System;
using System.Net;
using System.Runtime.Serialization;
using RenrenCore.Models;

namespace RenrenCore.Entities
{
    [DataContract]
    public class PostBlogEntity : PropertyChangedBase
    {
        /// <summary>
        /// 日志id
        /// </summary>
        [DataMember]
        //public long id { get; set; }

        private long id;
        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                this.NotifyPropertyChanged(postBlogEntity => postBlogEntity.Id);
            }
        }
    }
}
