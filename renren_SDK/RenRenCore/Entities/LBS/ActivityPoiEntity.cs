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
    public class ActivityPoiEntity : PropertyChangedBase
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
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Pid);
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
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Name);
            }
        }


        /// <summary>
        /// 3-activity_caption
        /// </summary>
        [DataMember]
        private string activity_caption = "";
        public string Activity_Caption
        {
            get
            {
                return activity_caption;
            }
            set
            {
                activity_caption = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Activity_Caption);
            }
        }


        /// <summary>
        /// 4-address
        /// </summary>
        [DataMember]
        private string address = "";
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Address);
            }
        }


        /// <summary>
        /// 5-url  关联关系中活动的wap端详情页url地址
        /// </summary>
        [DataMember]
        private string url = "";
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Url);
            }
        }


        /// <summary>
        /// 6-activity_contents  关联关系中活动的标题
        /// </summary>
        [DataMember]
        private string activity_contents = "";
        public string Activity_Contents
        {
            get
            {
                return activity_contents;
            }
            set
            {
                activity_contents = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Activity_Contents);
            }
        }


        /// <summary>
        /// 7-distance  
        /// </summary>
        [DataMember]
        private double distance = 0;
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Distance);
            }
        }

        /// <summary>
        /// 8-event_count 
        /// </summary>
        [DataMember]
        private Int32 event_count = 0;
        public Int32 Event_Count
        {
            get
            {
                return event_count;
            }
            set
            {
                event_count = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Count);
            }
        }

        /// <summary>
        /// 9-from
        /// </summary>
        [DataMember]
        private Int32 from = 0;
        public Int32 From
        {
            get
            {
                return from;
            }
            set
            {
                from = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.From);
            }
        }

        /// <summary>
        /// 10-event_type  关联关系中活动的类型
        /// </summary>
        [DataMember]
        private Int32 event_type = 0;
        public Int32 Event_Type
        {
            get
            {
                return event_type;
            }
            set
            {
                event_type = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Type);
            }
        }

        /// <summary>
        /// 11-broad_sdate  关联关系中活动的推广开始时间
        /// </summary>
        [DataMember]
        private Int64 broad_sdate = 0;
        public Int64 Broad_Sdate
        {
            get
            {
                return broad_sdate;
            }
            set
            {
                broad_sdate = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Broad_Sdate);
            }
        }


        /// <summary>
        /// 12-broad_edate  关联关系中活动的推广结束时间
        /// </summary>
        [DataMember]
        private Int64 broad_edate = 0;
        public Int64 Broad_Edate
        {
            get
            {
                return broad_edate;
            }
            set
            {
                broad_edate = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Broad_Edate);
            }
        }


        /// <summary>
        /// 13-event_sdate  关联关系中活动的开始时间
        /// </summary>
        [DataMember]
        private Int64 event_sdate = 0;
        public Int64 Event_Sdate
        {
            get
            {
                return event_sdate;
            }
            set
            {
                event_sdate = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Sdate);
            }
        }


        /// <summary>
        /// 14-event_edate  关联关系中活动的结束时间
        /// </summary>
        [DataMember]
        private Int64 event_edate = 0;
        public Int64 Event_Edate
        {
            get
            {
                return event_edate;
            }
            set
            {
                event_edate = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Edate);
            }
        }


        /// <summary>
        /// 15-event_source  关联关系中活动的来源标识
        /// </summary>
        [DataMember]
        private string event_source = "";
        public string Event_Source
        {
            get
            {
                return event_source;
            }
            set
            {
                event_source = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Source);
            }
        }

        /// <summary>
        /// 16-event_source_wapurl    关联关系中活动的来源wap地址 
        /// </summary>
        [DataMember]
        private string event_source_wapurl = "";
        public string Event_Source_Wapurl
        {
            get
            {
                return event_source_wapurl;
            }
            set
            {
                event_source_wapurl = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Source_Wapurl);
            }
        }


        /// <summary>
        /// 17-event_mobile_logourl  关联关系中活动的小图地址 
        /// </summary>
        [DataMember]
        private string event_mobile_logourl = "";
        public string Event_Mobile_Logourl
        {
            get
            {
                return event_mobile_logourl;
            }
            set
            {
                event_mobile_logourl = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Mobile_Logourl);
            }
        }

        /// <summary>
        /// 18-event_web_logourl    关联关系中的活动的大图地址 
        /// </summary>
        [DataMember]
        private string event_web_logourl = "";
        public string Event_Web_Logourl
        {
            get
            {
                return event_web_logourl;
            }
            set
            {
                event_web_logourl = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Web_Logourl);
            }
        }



        /// <summary>
        /// 19-longitude  关联关系中活动举行第的经度 
        /// </summary>
        [DataMember]
        private double longitude = 0;
        public double Longitude
        {   
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Longitude);
            }
        }


        /// <summary>
        /// 20-longitude  关联关系中活动举行地的维度 
        /// </summary>
        [DataMember]
        private double latitude = 0;
        public double Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Latitude);
            }
        }

        /// <summary>
        /// 21-description  关联关系中活动的描述 
        /// </summary>
        [DataMember]
        private string description = "";
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Description);
            }
        }

        /// <summary>
        /// 22-poi_type  关联关系中活动的地点类型 
        /// </summary>
        [DataMember]
        private string poi_type = "";
        public string Poi_Type
        {
            get
            {
                return poi_type;
            }
            set
            {
                poi_type = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Poi_Type);
            }
        }


        /// <summary>
        /// 23-group_buy_id  团购类型活动 ,对象唯一标识ID 
        /// </summary>
        [DataMember]
        private Int64 group_buy_id = 0;
        public Int64 Group_Buy_Id
        {
            get
            {
                return group_buy_id;
            }
            set
            {
                group_buy_id = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Group_Buy_Id);
            }
        }

        /// <summary>
        /// 24-group_buy_original_price  原价 ，适用于团购类型活动 
        /// </summary>
        [DataMember]
        private string group_buy_original_price = "";
        public string Group_Buy_Original_Price
        {
            get
            {
                return group_buy_original_price;
            }
            set
            {
                group_buy_original_price = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Group_Buy_Original_Price);
            }
        }


        /// <summary>
        /// 25-group_buy_current_price  现价 ，适用于团购类型活动 
        /// </summary>
        [DataMember]
        private string group_buy_current_price = "";
        public string Group_Buy_Current_Price
        {
            get
            {
                return group_buy_current_price;
            }
            set
            {
                group_buy_current_price = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Group_Buy_Current_Price);
            }
        }

        /// <summary>
        /// 26-group_buy_rate  折扣 ，适用于团购类型活动 
        /// </summary>
        [DataMember]
        private float group_buy_rate = 0;
        public float Group_Buy_Rate
        {
            get
            {
                return group_buy_rate;
            }
            set
            {
                group_buy_rate = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Group_Buy_Rate);
            }
        }

        /// <summary>
        /// 27-group_buy_spare 节省 ，适用于团购类型活动 
        /// </summary>
        [DataMember]
        private string group_buy_spare = "";
        public string Group_Buy_Spare
        {
            get
            {
                return group_buy_spare;
            }
            set
            {
                group_buy_spare = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Group_Buy_Spare);
            }
        }

        /// <summary>
        /// 28-event_id  
        /// </summary>
        [DataMember]
        private Int64 event_id = 0;
        public Int64 Event_Id
        {
            get
            {
                return event_id;
            }
            set
            {
                event_id = value;
                this.NotifyPropertyChanged(activityPoiEntity => activityPoiEntity.Event_Id);
            }
        }









    }
}
