using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSGetNearByRecommendPoiExtraListService : RRServiceBase<int, LBSGetNearByRecommendPoiExtraListEntity>
    {
        private LBSGetNearByRecommendPoiExtraListService() { }
        public static readonly LBSGetNearByRecommendPoiExtraListService Instance = new LBSGetNearByRecommendPoiExtraListService();


        public async Task<RenRenResponseArg<LBSGetNearByRecommendPoiExtraListEntity>> GetNearByRecommendPoiExtraList(long lon_gps, long lat_gps, int d = 0, int radius = 2000, int page = 1, int page_size = 10, int type = -1)
        {
            RenRenResponseArg<LBSGetNearByRecommendPoiExtraListEntity> resp = await Request(lon_gps,lat_gps,d,radius,page,page_size,type);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSGetNearByRecommendPoiExtraListEntity>> DoRequest(params object[] args)
        {
            //throw new NotImplementedException();
            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            long lon_gps = (long)args[0];
            long lat_gps = (long)args[1];
            int d = (int)args[2];
            int radius = (int)args[3];
            int page = (int)args[4];
            int page_size = (int)args[5];
            int type = (int)args[6];

            RenRenResponseArg<LBSGetNearByRecommendPoiExtraListEntity> resp = await Apis.API.Renren3GApi.GetNearByRecommendPoiExtraList(_seesionKey, _secrectKey, lon_gps, lat_gps, d, radius, page, page_size, type);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSGetNearByRecommendPoiExtraListEntity>> DoRequestById(int id, params object[] args)
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
