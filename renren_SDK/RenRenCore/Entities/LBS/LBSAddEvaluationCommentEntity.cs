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
    public sealed class LBSAddEvaluationCommentEntity : PropertyChangedBase
    {
        /// <summary>
        /// 1-result
        /// </summary>
        [DataMember]
        private Int32 result = 0;
        public Int32 Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                this.NotifyPropertyChanged(lbsAddEvaluationCommnetEntity => lbsAddEvaluationCommnetEntity.Result);
            }
        }
    }
}
