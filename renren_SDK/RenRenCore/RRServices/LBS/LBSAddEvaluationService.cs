using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;
using RenrenCore.RRServices;

namespace RenrenCore.RRServiceslbsAddEvaluationEntity
{
    public sealed class LBSAddEvaluationService : RRServiceBase<string, LBSAddEvaluationEntity>
    {

        public async Task<RenRenResponseArg<LBSAddEvaluationEntity>> AddEvaluation(string pid, long request_time, string content, long lat_gps = 0, long lon_gps = 0,
            int privacy = 1, string poi_name = "", string poi_address = "", string poi_type = "")
        {
            RenRenResponseArg<LBSAddEvaluationEntity> resp = await RequestById(pid, request_time, content, lat_gps, lon_gps, privacy, poi_name, poi_address, poi_type);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSAddEvaluationEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<LBSAddEvaluationEntity>> DoRequestById(string id, params object[] args)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            long request_time = (long)args[0];
            string content = (string)args[1];
            long lat_gps = (long)args[2];
            long lon_gps = (long)args[3];
            int privacy = (int)args[4];
            string poi_name = (string)args[5];
            string poi_address = (string)args[6];
            string poi_type = (string)args[7];

            RenRenResponseArg<LBSAddEvaluationEntity> resp = await Apis.API.Renren3GApi.AddEvaluation(_seesionKey, _secrectKey, id, request_time, content, lat_gps,
                lon_gps, privacy, poi_name, poi_address, poi_type);
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
