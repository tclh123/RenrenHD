using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSCheckInService : RRServiceBase<string, LBSCheckInEntity>
    {

        private LBSCheckInService() { }
        public static readonly LBSCheckInService Instance = new LBSCheckInService();

        
        public async Task<RenRenResponseArg<LBSCheckInEntity>> CheckIn(string pid, string status = "", long lat_gps = 0,
            long lon_gps = 0, int privacy = 1, string poi_name = "", string poi_address = "", string poi_type = "")
        {
            RenRenResponseArg<LBSCheckInEntity> resp = await RequestById(pid, status, lat_gps, lon_gps, privacy, poi_name, poi_address, poi_type);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSCheckInEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<LBSCheckInEntity>> DoRequestById(string id, params object[] args)
        {
            if (string.IsNullOrEmpty(id))
                return null;

         //   string _seesionKey = LoginService.Instance.Model.Session_key;
         //   string _secrectKey = LoginService.Instance.Model.Secret_key;

            string _access_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;

            string pid = id;
            string status = (string)args[0];
            long lat_gps = (long)args[1];
            long lon_gps = (long)args[2];
            int privacy = (int)args[3];
            string poi_name = (string)args[4];
            string poi_address = (string)args[5];
            string poi_type = (string)args[6];

            RenRenResponseArg<LBSCheckInEntity> resp = await Apis.API.Renren3GApi.CheckIn(_access_token, _secrectKey, pid, status, lat_gps, lon_gps, privacy,
                poi_name, poi_address, poi_type);
            return resp;
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
