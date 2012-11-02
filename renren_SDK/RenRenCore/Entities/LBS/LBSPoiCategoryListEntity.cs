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
    public sealed class LBSPoiCategoryListEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsPoiCategoryListEntity => lbsPoiCategoryListEntity.Count);
            }
        }


        /// <summary>
        /// 2-category_list
        /// </summary>
        [DataMember]
        private ObservableCollection<LBSPoiCategoryEntity> category_list = new ObservableCollection<LBSPoiCategoryEntity>();
        public ObservableCollection<LBSPoiCategoryEntity> Category_List
        {
            get
            {
                return category_list;
            }
            set
            {
                category_list = value;
                this.NotifyPropertyChanged(lbsPoiCategoryListEntity => lbsPoiCategoryListEntity.Category_List);
            }
        }
    }

    [DataContract]
    public sealed class LBSPoiCategoryEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(lbsPoiCategoryEntity => lbsPoiCategoryEntity.Id);
            }
        }


        /// <summary>
        /// 2-name
        /// </summary>
        [DataMember]
        private string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                this.NotifyPropertyChanged(lbsPoiCategoryEntity => lbsPoiCategoryEntity.Name);
            }
        }



    }
}
