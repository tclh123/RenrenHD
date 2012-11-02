using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
   public sealed class LBSNearbyFeedListService : RRServiceBase<int, LBSNearbyFeedListEntity>
    {
        private LBSNearbyFeedListService() { }
        public static readonly  LBSNearbyFeedListService Intance = new LBSNearbyFeedListService();


        /// <summary>
        /// 获取某个poi或者某个经纬度附近的新鲜事,按poi取的时候不包括此poi信息 
        /// </summary>
        /// <param name="lat_gps">纬度</param>
        /// <param name="lon_gps">经度</param>
        /// <param name="pid">pid</param>
        /// <param name="page">分页页码</param>
        /// <param name="page_size">每页的数据量</param>
        /// <param name="ubb">返回值ubb转换</param> 
        /// <param name="radius">判断附近的半径,单位为公里</param>
        /// <param name="d">使用的是否是真实经纬度</param> 
       public async Task<RenRenResponseArg<LBSNearbyFeedListEntity>> RequestNearbyFeed(long lat_gps, long lon_gps, string pid, int page = 1, int page_size = 10, int ubb = 0, int radius = 2, int d = 0)
        {
            RenRenResponseArg<LBSNearbyFeedListEntity> resp = await Request(lat_gps,lon_gps,pid,page,page_size,ubb,radius,d);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSNearbyFeedListEntity>> DoRequest(params object[] args)
        {

            string _access_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;

            long lat_gps = (long)args[0];
            long lon_gps = (long)args[1];

            string pid = (string)args[2];

            int page = (int)args[3];
            int page_size = (int)args[4];

            int ubb = (int)args[5];
            int radius = (int)args[6];
            int d = (int)args[7];

            RenRenResponseArg<LBSNearbyFeedListEntity> resp = await Apis.API.Renren3GApi.GetNearByFeeds(_access_token, _secrectKey, lat_gps, lon_gps, pid, page, page_size,
                ubb, radius, d);

            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSNearbyFeedListEntity>> DoRequestById(int id, params object[] args)
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
