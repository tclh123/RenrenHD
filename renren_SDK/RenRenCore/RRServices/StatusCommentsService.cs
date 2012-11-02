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
    class StatusCommentsService : RRServiceBase<long, StatusCommentsEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static StatusCommentsService Instance
        {
            get { return _instance; }
        }
        private static readonly StatusCommentsService _instance = new StatusCommentsService();

        /// <summary>
        /// Request and update the status content by status comments id
        /// The wrapped convient method provided for outside call
        /// </summary>
        /// <param name="uid">user id</param>
        /// <param name="statusId">status id</param>
        /// <returns></returns>
        public async Task<RenRenResponseArg<StatusCommentsEntity>> RequestStatusCommentsByUid(int uid, long statusId)
        {
            RenRenResponseArg<StatusCommentsEntity> resp = await RequestById(statusId, uid);
            return resp;
        }

        /// <summary>
        /// Request and update the self status comments content
        /// </summary>
        /// <returns>the async result</returns>
        protected override Task<RenRenResponseArg<StatusCommentsEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Request and update the status comments content
        /// </summary>
        /// <returns>the async result</returns>
        protected async override Task<RenRenResponseArg<StatusCommentsEntity>> DoRequestById(long id, params object[] args)
        {
            if (args.Length < 1) throw new ArgumentException();
            int uid = (int)args[0];
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;

            RenRenResponseArg<StatusCommentsEntity> resp = await API.Renren3GApi.GetStatusComments(seesionKey, secrectKey, id, uid);
            return resp;
        }

        /// <summary>
        /// Reset overall models
        /// </summary>
        protected override void DoReset()
        {
        }

        protected override void DoResetById(long id)
        {
        }

        /// <summary>
        /// private construct to protected against the outside create
        /// </summary>
        private StatusCommentsService() 
        { }
    }
}
