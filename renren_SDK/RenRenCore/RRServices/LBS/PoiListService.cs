using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Apis;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;


namespace RenrenCore.RRServices
{
   public sealed class  PoiListService : RRServiceBase<long, PoiListEntity>
    {

       private PoiListService() { }
       public static readonly PoiListService Instance = new PoiListService();


       /// <summary>
       /// 获取poi列表 
       /// </summary>
       /// <param name="_lat">纬度</param>
       /// <param name="_lon">经度</param>
       /// <param name="_radius">查找半径</param>
       /// <param name="_d">使用的是否是真实经纬度</param>
       /// <param name="_page">分页值</param>
       /// <param name="_pagesize">分页信息条目数</param>
       /// <param name="keyword">查询的关键字</param>
       public async Task<RenRenResponseArg<PoiListEntity>> RequestPoiList(long _lat,long _lon,int _radius,int _d=1,int _page=1,int _pagesize = 10,string keyword = "",string data_type="")
        {
            RenRenResponseArg<PoiListEntity> resp = await Request(_lat,_lon,_radius,_d,_page,_pagesize,keyword,data_type);
            return resp;
        }

        protected async override Task<RenRenResponseArg<PoiListEntity>> DoRequest(params object[] args)
        {

            string _acess_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;
         
            long _lat = (long)args[0];
            long _lon = (long)args[1];

            int _radius = (int)args[2];
            int _d = (int)args[3];

            int _page = args.Length > 5 ? (int)args[4] : 1;
            int _pagesize = args.Length > 6 ? (int)args[5] : 10;

            string keyword = args.Length > 7 ?(string)args[6]:"";
            string data_type = args.Length > 8 ? (string)args[7] : "";

            RenRenResponseArg<PoiListEntity> resp = await API.Renren3GApi.GetPoiList(_acess_token, _secrectKey, _lat, _lon, _radius, _d, _page, _pagesize,keyword,data_type);
            return resp;
        }

     protected async override Task<RenRenResponseArg<PoiListEntity>> DoRequestById(long id, params object[] args)
     {

        throw new NotImplementedException();
     }

     protected override void DoReset()
     {
         return;
     }
        
     protected override void DoResetById(long id) 
     {
         throw new NotImplementedException();
     }


    }
}
