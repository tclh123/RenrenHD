using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSGetPoiCategoryService : RRServiceBase<int, LBSPoiCategoryListEntity>
    {
        private LBSGetPoiCategoryService() { }
        public static readonly LBSGetPoiCategoryService Instance = new LBSGetPoiCategoryService();


        /// <summary>
        /// 获取poi类型
        /// </summary>
        /// <param name="data_type">为compression的时候，返回值做gzip加密</param>
        public async Task<RenRenResponseArg<LBSPoiCategoryListEntity>> GetPoiCategory(string data_type = "compression")
        {
            RenRenResponseArg<LBSPoiCategoryListEntity> resp = await Request(data_type);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSPoiCategoryListEntity>> DoRequest(params object[] args)
        {

            string _access_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;

            string data_type = (string)args[0];

            RenRenResponseArg<LBSPoiCategoryListEntity> resp = await Apis.API.Renren3GApi.getPoiCategory(_access_token, _secrectKey, data_type);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSPoiCategoryListEntity>> DoRequestById(int id, params object[] args)
        {
            throw new NotImplementedException();
        }
        
        
        protected override void DoReset()
        {
            return;
        }

        protected override void DoResetById(int id)
        {
            return;
        }
    }
}
