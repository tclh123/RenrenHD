using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSGetStaticMapByPidService : RRServiceBase<string, LBSGetStaticMapEntity>
    {
        private LBSGetStaticMapByPidService() { }
        public static readonly LBSGetStaticMapByPidService Instance = new LBSGetStaticMapByPidService();


        /// <summary>
        /// 根据PID获取静态地图的URL
        /// </summary>
        /// <param name="pid">pid</param>
        /// <param name="pointName">标注的名称</param>
        /// <param name="height">地图的高度，单位为像素</param>
        /// <param name="width">地图的宽度，单位为像素</param>
        /// <param name="zoom">地图的zoom值(1-11)</param>
        public async Task<RenRenResponseArg<LBSGetStaticMapEntity>> GetStaticMapByPid(string pid,
            string pointName = "", int height = 320, int width = 240, int zoom = 11)
        {
            RenRenResponseArg<LBSGetStaticMapEntity> resp = await RequestById(pid,pointName,height,width,zoom);
            return resp;
        }
        
        protected async override Task<RenRenResponseArg<LBSGetStaticMapEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }
        
        protected async override Task<RenRenResponseArg<LBSGetStaticMapEntity>> DoRequestById(string id, params object[] args)
        {

            string _access_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;

            string pid = id;
            string pointName = (string)args[0];
            int height = (int)args[1];
            int width = (int)args[2];
            int zoom = (int)args[3];

            RenRenResponseArg<LBSGetStaticMapEntity> resp = await Apis.API.Renren3GApi.GetStaticMapByPid(_access_token, _secrectKey, pid,
                pointName, height, width, zoom);
            return resp;
        }
        
        protected override void DoReset()
        {
            return;
        }

        protected override void DoResetById(string id)
        {
            return;
        }
    }
}
