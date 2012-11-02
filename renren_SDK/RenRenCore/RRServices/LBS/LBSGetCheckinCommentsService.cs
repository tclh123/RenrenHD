using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSGetCheckinCommentsService : RRServiceBase<long, PlaceReplyListEntity>
    {

        public async Task<RenRenResponseArg<PlaceReplyListEntity>> RequestCheckinComments(long id, int uid,
            int page = 1, int page_size = 10, int sort = 0, int exclude_list = 0, int with_pci = 1)
        {
            RenRenResponseArg<PlaceReplyListEntity> resp = await RequestById(id,uid,page,page_size,sort,exclude_list,with_pci);
            return resp;
        }

        protected async override Task<RenRenResponseArg<PlaceReplyListEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<PlaceReplyListEntity>> DoRequestById(long id, params object[] args)
        {
            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            int uid = (int)args[0];
            int page = (int)args[1];
            int page_size = (int)args[2];
            int sort = (int)args[3];
            int exclude_list = (int)args[4];
            int with_pci = (int)args[5];

            RenRenResponseArg<PlaceReplyListEntity> resp = await Apis.API.Renren3GApi.GetCheckinComments(_seesionKey, _secrectKey, id, uid, page, page_size, sort, exclude_list, with_pci);
            return resp;
        }


        protected override void DoReset()
        {
            return;
        }

        protected override void DoResetById(long id)
        {
            return;
        }
    }
}
