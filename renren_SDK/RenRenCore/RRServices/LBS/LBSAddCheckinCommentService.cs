using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSAddCheckinCommentService : RRServiceBase<long, LBSAddCheckinCommentEntity>
    {
        public async Task<RenRenResponseArg<LBSAddCheckinCommentEntity>> AddCheckinComment(long cid, int uid, int rid, string content)
        {
            RenRenResponseArg<LBSAddCheckinCommentEntity> resp = await RequestById(cid,uid,rid,content);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSAddCheckinCommentEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<LBSAddCheckinCommentEntity>> DoRequestById(long id, params object[] args)
        {
           
            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            long cid = id;
            int uid = (int)args[0];
            int rid = (int)args[1];
            string content = (string)args[2];

            RenRenResponseArg<LBSAddCheckinCommentEntity> resp = await Apis.API.Renren3GApi.AddCheckinComment(_seesionKey, _secrectKey, cid, uid, rid, content);
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
