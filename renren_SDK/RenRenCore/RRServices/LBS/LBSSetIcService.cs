using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSSetIcService : RRServiceBase<string, LBSSubmitEntity>
    {
        private LBSSetIcService() {}
        public static readonly LBSSetIcService Instance = new LBSSetIcService();


        public async Task<RenRenResponseArg<LBSSubmitEntity>> SetIc(string rlct)
        {
            RenRenResponseArg<LBSSubmitEntity> resp = await RequestById(rlct);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSSubmitEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<LBSSubmitEntity>> DoRequestById(string id, params object[] args)
        {
            //throw new NotImplementedException();
            if (string.IsNullOrEmpty(id))
                return null;

            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            string rlct = id;

            RenRenResponseArg<LBSSubmitEntity> resp = await Apis.API.Renren3GApi.SetIc(_seesionKey, _secrectKey, rlct);
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
