using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;
using RenrenCore.RRServices.LBS;

namespace RenrenCore.RRServices
{
    public sealed class LBSGetEvaluationCommentsService : RRServiceBase<long, LBSGetEvaluationCommentListEntity>
    {

        public async Task<RenRenResponseArg<LBSGetEvaluationCommentListEntity>> GetEvaluationComments(long id, int user_id, int page = 1, int page_size = 20, int sort = 1, int exclude_list = 1, int with_evaluation = 1)
        {
            RenRenResponseArg<LBSGetEvaluationCommentListEntity> resp = await RequestById(id, user_id, page, page_size, sort, exclude_list, with_evaluation);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSGetEvaluationCommentListEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }
        
        protected async override Task<RenRenResponseArg<LBSGetEvaluationCommentListEntity>> DoRequestById(long id, params object[] args)
        {
            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            int user_id = (int)args[0];
            int page = (int)args[1];
            int page_size = (int)args[2];
            int sort = (int)args[3];
            int exclude_list = (int)args[4];
            int with_evaluation = (int)args[5];

            RenRenResponseArg<LBSGetEvaluationCommentListEntity> resp = await Apis.API.Renren3GApi.GetEvaluationComments(_seesionKey, _secrectKey, id, user_id, page, page_size, sort,
                exclude_list, with_evaluation);
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
