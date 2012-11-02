using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class NearbyActivityNoticeCountService : RRServiceBase<int, LBSNearbyActivityNoticeCountEntity>
    {
        public static readonly NearbyActivityNoticeCountService Instance = new NearbyActivityNoticeCountService();
        private NearbyActivityNoticeCountService() { }



        /// <summary>
        /// 返回附近的活动或好友活动的数量 
        /// </summary>
        /// <param name="lat_gps">纬度</param>
        /// <param name="lon_gps">经度</param>
        /// <param name="_radius">判断附近的半径,单位为公里</param>
        /// <param name="_d">使用的是否是真实经纬度</param>
        public async Task<RenRenResponseArg<LBSNearbyActivityNoticeCountEntity>> RequestNearbyActivityNoticeCount(long lat_gps, long lon_gps, int radius = 1, int d = 0)
        {
            RenRenResponseArg<LBSNearbyActivityNoticeCountEntity> resp = await Request(lat_gps, lon_gps, radius, d);
            return resp;
        }


        protected async override Task<RenRenResponseArg<LBSNearbyActivityNoticeCountEntity>> DoRequest(params object[] args)
        {
            string _access_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;

            long lat_gps = (long)args[0];
            long lon_gps = (long)args[1];

            int radius = (int)args[2];
            int d = (int)args[3];

            RenRenResponseArg<LBSNearbyActivityNoticeCountEntity> resp = await Apis.API.Renren3GApi.GetNearbyActivityNoticeCount(_access_token, _secrectKey, lat_gps, lon_gps, radius, d);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSNearbyActivityNoticeCountEntity>> DoRequestById(int id, params object[] args)
        {

            throw new NotImplementedException();
        }

        protected override void DoReset()
        {
            return;
        }

        protected override void DoResetById(int id)
        {
            return;
        }


    }
}
