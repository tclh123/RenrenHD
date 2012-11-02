using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
   public sealed class CalculateDistanceService : RRServiceBase<int, PlaceDistanceEntity>
    {
        private CalculateDistanceService() { }
        public static readonly CalculateDistanceService Instance = new CalculateDistanceService();

        /// <summary>
        /// 计算某个gps位置与某个pid之间的距离  
        /// </summary>
        /// <param name="lat_gps">纬度</param>
        /// <param name="lon_gps">经度</param>
        /// <param name="pid">pid</param>
        /// <param name="radius">是否过远的半径，单位为公里</param>
        /// <param name="d">使用的是否是真实经纬度</param>
       public async Task<RenRenResponseArg<PlaceDistanceEntity>> CalculateDistance(long lat_gps, long lon_gps, string pid, int radius = 2, int d = 0)
        {
            RenRenResponseArg<PlaceDistanceEntity> resp = await Request(lat_gps,lon_gps,pid,radius,d);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<PlaceDistanceEntity>> DoRequest(params object[] args)
        {

            string _access_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;

            long lat_gps = (long)args[0];
            long lon_gps = (long)args[1];
            string pid = (string)args[2];
            int radius = (int)args[3];
            int d = (int)args[4];

            RenRenResponseArg<PlaceDistanceEntity> resp = await Apis.API.Renren3GApi.CalculateDistance(_access_token, _secrectKey, lat_gps, lon_gps, pid, radius, d);
            return resp;
        }

        protected async override Task<RenRenResponseArg<PlaceDistanceEntity>> DoRequestById(int id, params object[] args)
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
