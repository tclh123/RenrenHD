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
    public class LBSSavePoiDataEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-pid
        /// </summary>
        [DataMember]
        private string pid = "";
        public string Pid
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
                this.NotifyPropertyChanged(lbsSavePoiDataEntity => lbsSavePoiDataEntity.Pid);
            }
        }


        /// <summary>
        /// 2-code
        /// </summary>
        [DataMember]
        private string code = "";
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
                this.NotifyPropertyChanged(lbsSavePoiDataEntity => lbsSavePoiDataEntity.Code);
            }
        }

        /// <summary>
        /// 3-msg
        /// </summary>
        [DataMember]
        private string msg = "";
        public string Msg
        {
            get
            {
                return msg;
            }
            set
            {
                msg = value;
                this.NotifyPropertyChanged(lbsSavePoiDataEntity => lbsSavePoiDataEntity.Msg);
            }
        }


    }
}
