using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Apis;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    class PageInfoService : RRServiceBase<int, PageInfoEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static PageInfoService Instance
        {
            get { return _instance; }
        }
        private static readonly PageInfoService _instance = new PageInfoService();


        /// <summary>
        /// Request and update the user info by uid
        /// The wrapped convient method provided for outside call
        /// </summary>
        /// <returns></returns>
        public async Task<RenRenResponseArg<PageInfoEntity>> RequestUserInfoByUid(int uid)
        {
            RenRenResponseArg<PageInfoEntity> resp = await RequestById(uid);
            return resp;
        }


        protected async override Task<RenRenResponseArg<PageInfoEntity>> DoRequestById(int id, params object[] args)
        {
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;
            RenRenResponseArg<PageInfoEntity> resp = await API.Renren3GApi.GetPageInfo(seesionKey, secrectKey, id);
            return resp;
        }

        protected override Task<RenRenResponseArg<PageInfoEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected override void DoResetById(int id)
        {
        }

        protected override void DoReset()
        {
        }

        /// <summary>
        /// private construct to protected against the outside create
        /// </summary>
        private PageInfoService() 
        { }
    }
}
