using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class PoiBaseInfoService : RRServiceBase<long, PoiBaseInfoEntity>
    {
        private PoiBaseInfoService() { }
        public static readonly PoiBaseInfoService Instance = new PoiBaseInfoService();


        /// <summary>
        /// 返回某个poi的基本信息
        /// </summary>
        /// <param name="pid">pid</param>
        /// <param name="ubb">返回值ubb转换</param>
        /// <param name="radius">查找半径，单位为米</param>
        public async Task<RenRenResponseArg<PoiBaseInfoEntity>> RequestPoiBaseInfoByPid(string pid, int ubb = 0, int radius = 1)
        {
            RenRenResponseArg<PoiBaseInfoEntity> resp = await Request(pid,ubb,radius);
            return resp;
        }

        public async Task<RenRenResponseArg<PoiBaseInfoEntity>> RequestPoiBaseInfoByLbsId(long lbs_id, int ubb = 0, int radius = 1)
        {
            RenRenResponseArg<PoiBaseInfoEntity> resp = await RequestById(lbs_id,ubb,radius);
            return resp;
        }
    
        
        protected async override Task<RenRenResponseArg<PoiBaseInfoEntity>> DoRequest(params object[] args)
        {
            string _access_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;

            string pid = (string)args[0];
            int ubb = (int)args[1];
            int radius = (int)args[2];

            RenRenResponseArg<PoiBaseInfoEntity> resp = await Apis.API.Renren3GApi.GetPoiBaseInfoByPid(_access_token, _secrectKey, pid, ubb, radius);
            return resp;
        }


        protected async override Task<RenRenResponseArg<PoiBaseInfoEntity>> DoRequestById(long id, params object[] args)
        {
            string _seesionKey = LoginService.Instance.Model.Session_key;
            string _secrectKey = LoginService.Instance.Model.Secret_key;

            int ubb = (int)args[0];
            int radius = (int)args[1];

            RenRenResponseArg<PoiBaseInfoEntity> resp = await Apis.API.Renren3GApi.GetPoiBaseInfoByLbsId(_seesionKey, _secrectKey, id, ubb, radius);
            return resp;
            
        }

        protected override void DoReset()
        {
            return;
        }

        protected override void DoResetById(long id)
        {
            //throw new NotImplementedException();
            return;
        }
    }
}
