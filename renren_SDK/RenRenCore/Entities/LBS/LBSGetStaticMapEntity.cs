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
    public sealed class LBSGetStaticMapEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-static_MapUrl
        /// </summary>
        [DataMember]
        private string static_MapUrl= "";
        public string Static_MapUrl
        {
            get
            {
                return static_MapUrl;
            }
            set
            {
                static_MapUrl = value;
                this.NotifyPropertyChanged(lbsGetStaticMapEntity => lbsGetStaticMapEntity.Static_MapUrl);
            }
        }


        /// <summary>
        /// 2-latitude
        /// </summary>
        [DataMember]
        private double latitude = -1;
        public double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
                this.NotifyPropertyChanged(lbsGetStaticMapEntity => lbsGetStaticMapEntity.Latitude);
            }
        }


        /// <summary>
        /// 3-longitude
        /// </summary>
        [DataMember]
        private double longitude = -1;
        public double Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
                this.NotifyPropertyChanged(lbsGetStaticMapEntity => lbsGetStaticMapEntity.Longitude);
            }
        }





    }
}
