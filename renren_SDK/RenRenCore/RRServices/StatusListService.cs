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
    /// <summary>
    /// Id stands for the user id
    /// </summary>
    class StatusListService : RRServiceBase<int, StatusListEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static StatusListService Instance
        {
            get { return _instance; }
        }
        private static readonly StatusListService _instance = new StatusListService();

        /// <summary>
        /// Request and update the status list by status id
        /// The wrapped convient method provided for outside call
        /// </summary>
        /// <returns></returns>
        public async Task<RenRenResponseArg<StatusListEntity>> RequestStatusListByUid(int userId, int page, int pageSize)
        {
            RenRenResponseArg<StatusListEntity> resp = await RequestById(userId, page, pageSize);
            return resp;
        }

        /// <summary>
        /// Request and update the self status content
        /// </summary>
        /// <returns>the async result</returns>
        protected override Task<RenRenResponseArg<StatusListEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Request and update the status content
        /// </summary>
        /// <returns>the async result</returns>
        protected async override Task<RenRenResponseArg<StatusListEntity>> DoRequestById(int userId, params object[] args)
        {
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;
            int page = args.Length > 0 ? (int)args[0] : 1; // by default, page is 1
            int pageSize = args.Length > 1 ? (int)args[1] : 10; // by default, page size is 10
            RenRenResponseArg<StatusListEntity> resp = await API.Renren3GApi.GetStatusList(seesionKey, secrectKey, userId, page, pageSize);
            return resp;
        }

        /// <summary>
        /// Reset overall models
        /// </summary>
        protected override void DoReset()
        {
        }

        protected override void DoResetById(int userId)
        {
        }

        /// <summary>
        /// private construct to protected against the outside create
        /// </summary>
        private StatusListService() 
        { }
    }
}
