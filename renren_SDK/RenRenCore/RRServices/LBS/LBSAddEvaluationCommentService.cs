using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSAddEvaluationCommentService : RRServiceBase<long, LBSAddEvaluationCommentEntity>
    {
        public async Task<RenRenResponseArg<LBSAddEvaluationCommentEntity>> AddEvaluationComment(long id, string content, int owner_id, int rid = -1, int privacy = 1)
        {
            RenRenResponseArg<LBSAddEvaluationCommentEntity> resp = await RequestById(id,content,owner_id,rid,privacy);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSAddEvaluationCommentEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<LBSAddEvaluationCommentEntity>> DoRequestById(long id, params object[] args)
        {
            if (id <= -1)
                return null;

            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            string content = (string)args[0];
            int owner_id = (int)args[1];
            int rid = (int)args[2];
            int privacy = (int)args[3];

            RenRenResponseArg<LBSAddEvaluationCommentEntity> resp = await Apis.API.Renren3GApi.AddEvaluationComment(_seesionKey, _secrectKey, id, content, owner_id, rid, privacy);
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
