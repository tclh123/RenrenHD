using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
   public sealed class LBSFeedListService :  RRServiceBase<int, LBSFeedListEntity>
    {
        private LBSFeedListService() { }
        public LBSFeedListService Instance = new LBSFeedListService();


        public async Task<RenRenResponseArg<LBSFeedListEntity>> RequestFeedListByPid(string pid, int page = 1, int page_size = 10, int biz_type = 3)
        {
            RenRenResponseArg<LBSFeedListEntity> resp = await Request(pid, page, page_size, biz_type);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSFeedListEntity>> DoRequest(params object[] args)
        {
            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            string pid = (string)args[0];
            int page = (int)args[1];
            int page_size = (int)args[2];
            int biz_type = (int)args[3];

            RenRenResponseArg<LBSFeedListEntity> resp = await Apis.API.Renren3GApi.GetFeedListByPid(_seesionKey, _secrectKey, pid, page, 
                page_size, biz_type);

            return resp;
        }
        protected async override Task<RenRenResponseArg<LBSFeedListEntity>> DoRequestById(int id, params object[] args)
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
