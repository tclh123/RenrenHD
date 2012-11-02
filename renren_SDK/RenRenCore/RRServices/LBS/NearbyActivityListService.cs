using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
   public sealed class NearbyActivityListService : RRServiceBase<int, ActivityPoiListEntity>
    {
       private enum RequestType
       {
           enum_pid = 0,
           enum_latlon = 1
       }
       
       public static readonly NearbyActivityListService Instance = new NearbyActivityListService();
       private NearbyActivityListService() { }

       //public async Task<RenRenResponseArg<ActivityPoiListEntity>> RequestNearbyActivityListByPid(string pid, int page, int page_size = 20, int radius = 1, int exclude_list = 0)
       //{
       //    RenRenResponseArg<ActivityPoiListEntity> resp = await Request( RequestType.enum_pid,pid,page,page_size,radius,exclude_list );
       //    return resp;
       //}

       /// <summary>
       /// 返回某个经纬度周边的活动poi列表; 如果该地点有一个活动，则返回该活动URL地址；如果该地点有多个活动，则返回地点map，活动列表URL
       /// </summary>
       /// <param name="lat_gps">纬度</param>
       /// <param name="lon_gps">经度</param>
       /// <param name="page">分页页码</param>
       /// <param name="page_size">每页的数据量</param>
       /// <param name="radius">判断附近的半径，单位为公里</param>
       /// <param name="exclude_list">是否不返回活动列表数据</param>
       /// <param name="d">传的经纬度是否需要偏转</param>
       /// <param name="event_type">活动的类型：event_type=1优惠券；event_type=2团购；event_type=3活动；event_type=4 全部</param>
       /// <param name="poitype">地点分类。包括美食、娱乐、生活、购物、运动、酒店、其他，取全部分类时传空即可</param>
       public async Task<RenRenResponseArg<ActivityPoiListEntity>> RequestNearbyActivityListByLatlon(long lat_gps,long lon_gps, int page, int page_size = 20, int radius = 1, int exclude_list = 0, int d = 0, int event_type = 4, string poitype = "")
       {
           RenRenResponseArg<ActivityPoiListEntity> resp = await Request(RequestType.enum_latlon, lat_gps,lon_gps,page,page_size,radius,exclude_list,
               d, event_type, poitype);
           return resp;
       }



       protected async override Task<RenRenResponseArg<ActivityPoiListEntity>> DoRequest(params object[] args)
       {

           string _secrectKey = Constants.ConstantValue.SecretKey;
           string _access_token = Constants.ConstantValue.access_token;

           RequestType _type = (RequestType)args[0];
           if (_type == RequestType.enum_pid)
           {
               string pid = (string)args[1];
               int page = (int)args[2];
               int page_size = (int)args[3];

               int radius = (int)args[4];
               int exclude_list = (int)args[5];

               RenRenResponseArg<ActivityPoiListEntity> resp = await Apis.API.Renren3GApi.GetNearbyActivityListByPid(_access_token, _secrectKey, pid, page, page_size, radius, exclude_list);
               return resp;
           }
           else if(_type == RequestType.enum_latlon)
           {
               long lat_gps = (long)args[1];
               long lon_gps = (long)args[2];

               int page = (int)args[3];
               int page_size = (int)args[4];

               int radius = (int)args[5];
               int exclude_list = (int)args[6];

               int d = (int)args[7];
               int event_type = (int)args[8];
               string poitype = (string)args[9];

               RenRenResponseArg<ActivityPoiListEntity> resp = await Apis.API.Renren3GApi.GetNearbyActivityListByLatLon(_access_token, _secrectKey, lat_gps, lon_gps, page,
                   page_size, radius,exclude_list, d, event_type,poitype);
              
               return resp;
           }


           else
           {
               Debug.WriteLine("RequestType Error!");
               return null;
           }

       }

       protected async override Task<RenRenResponseArg<ActivityPoiListEntity>> DoRequestById(int id, params object[] args)
       {

           throw new NotImplementedException();
       }

       protected override void DoReset()
       {
           return;
       }

       protected override void DoResetById(int id)
       {
           throw new NotImplementedException();
       }
    }
}
