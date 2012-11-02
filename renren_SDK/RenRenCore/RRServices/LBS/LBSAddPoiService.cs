using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSAddPoiService : RRServiceBase<string, LBSAddPoiEntity>
    {
       
        private LBSAddPoiService() {}
        public static readonly LBSAddPoiService Instance = new LBSAddPoiService();

        /// <summary>
        /// 创建POI  
        /// </summary>
        /// <param name="request_time">请求时间</param>
        /// <param name="name">POI的名字</param>
        /// <param name="lat_gps">纬度</param>
        /// <param name="lon_gps">经度</param>
        /// <param name="address">POI的地址</param>
        /// <param name="type">POI的类型</param>
        /// <param name="d">使用的是否是真实经纬度</param>
        public async Task<RenRenResponseArg<LBSAddPoiEntity>> AddPoi(long request_time, string name, long lat_gps , long lon_gps ,string address = "", string type = "",  int d = 1)
        {
            RenRenResponseArg<LBSAddPoiEntity> resp = await Request(request_time,name,address,type,lat_gps,lon_gps,d);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSAddPoiEntity>> DoRequest(params object[] args)
        {

            string _secrectKey = Constants.ConstantValue.SecretKey;
            string _access_token = Constants.ConstantValue.access_token;

            long request_time = (long)args[0];
            string name = (string)args[1];
            string address = (string)args[2];
            string type = (string)args[3];
            long lat_gps = (long)args[4];
            long lon_gps = (long)args[5];
            int d = (int)args[6];

            RenRenResponseArg<LBSAddPoiEntity> resp = await Apis.API.Renren3GApi.AddPoi(_access_token, _secrectKey, request_time, name,  lat_gps,
                lon_gps, address, type, d);

            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSAddPoiEntity>> DoRequestById(string id, params object[] args)
        {
            throw new NotImplementedException();
        }
        
        protected override void DoReset()
        {
            return;
        }

        protected override void DoResetById(string id)
        {
            return;
        }
    }
}
