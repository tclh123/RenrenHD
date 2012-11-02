using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSFeedsService : RRServiceBase<string, LBSFeedListEntity>
    {
        public async Task<RenRenResponseArg<LBSFeedListEntity>> RequestFeedsByPid(string pid, int page = 1, int page_size = 10, int ubb = 0)
        {
            RenRenResponseArg<LBSFeedListEntity> resp = await RequestById(pid, page, page_size, ubb);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSFeedListEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }
        protected async override Task<RenRenResponseArg<LBSFeedListEntity>> DoRequestById(string id, params object[] args)
        {
            if (string.IsNullOrEmpty(id))
                return null;
            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            string pid = id;
            int page = (int)args[0];
            int page_size = (int)args[1];
            int ubb = (int)args[2];

            RenRenResponseArg<LBSFeedListEntity> resp = await Apis.API.Renren3GApi.GetFeedsByPid(_seesionKey, _secrectKey, pid, page,
                page_size, ubb);

            return resp;
        }

        protected override void DoReset()
        {
            return;
        }

        protected override void DoResetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
