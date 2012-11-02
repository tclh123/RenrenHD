using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
   public sealed class LBSGetEvaluationService : RRServiceBase<long, LBSGetEvaluationEntity>
    {

       public async Task<RenRenResponseArg<LBSGetEvaluationEntity>> GetEvaluation(long id, int owner_id, int reply_id = -1)
       {
           RenRenResponseArg<LBSGetEvaluationEntity> resp = await RequestById(id,owner_id,reply_id);
           return resp;
       }

       protected async override Task<RenRenResponseArg<LBSGetEvaluationEntity>> DoRequest(params object[] args)
       {
           throw new NotImplementedException();
       }

       protected async override Task<RenRenResponseArg<LBSGetEvaluationEntity>> DoRequestById(long id, params object[] args)
       {
           if (id <= -1)
               return null;

           string _seesionKey = LoginService.Instance.Model.Session_key;
           string _secrectKey = LoginService.Instance.Model.Secret_key;

           int owner_id = (int)args[0];
           int reply_id = (int)args[1];

           RenRenResponseArg<LBSGetEvaluationEntity> resp = await Apis.API.Renren3GApi.GetEvaluation(_seesionKey, _secrectKey, id, owner_id, reply_id);
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
