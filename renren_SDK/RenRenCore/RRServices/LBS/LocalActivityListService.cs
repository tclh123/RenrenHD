using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LocalActivityListService : RRServiceBase<int, ActivityListEntity>
    {
        public static readonly LocalActivityListService Instance = new LocalActivityListService();
        private LocalActivityListService() { }


        public async Task<RenRenResponseArg<ActivityListEntity>> RequestLocalActivityListByPid(string pid, int page, int page_size = 20, int exclude_list = 0)
        {
            RenRenResponseArg<ActivityListEntity> resp = await Request(pid,page,page_size,exclude_list);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<ActivityListEntity>> DoRequest(params object[] args)
        {
            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            string pid = (string)args[0];
            int page = (int)args[1];
            int page_size = (int)args[2];
            int exclude_list = (int)args[3];

            RenRenResponseArg<ActivityListEntity> resp = await Apis.API.Renren3GApi.GetLocalActivityListByPid(_seesionKey,_secrectKey,pid,page,page_size,exclude_list);

            return resp;
        }

        protected async override Task<RenRenResponseArg<ActivityListEntity>> DoRequestById(int id, params object[] args)
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
