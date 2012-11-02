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
    class PhotoCommentsService : RRServiceBase<long, PhotoCommentEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static PhotoCommentsService Instance
        {
            get { return _instance; }
        }
        private static readonly PhotoCommentsService _instance = new PhotoCommentsService();

        public async Task<RenRenResponseArg<PhotoCommentEntity>> RequestPhotoCommentsByPid(int userId, long albumId, long picId)
        {
            RenRenResponseArg<PhotoCommentEntity> resp = await RequestById(picId, userId, albumId);
            return resp;
        }

        protected override Task<RenRenResponseArg<PhotoCommentEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<PhotoCommentEntity>> DoRequestById(long id, params object[] args)
        {
            if (args.Length < 1) throw new ArgumentException();
            int uid = (int)args[0];
            long albumId = args.Length > 1 ? (long)args[1] : -1;
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;

            RenRenResponseArg<PhotoCommentEntity> resp = await API.Renren3GApi.GetPhotoComments(seesionKey, secrectKey, uid, albumId, id);
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
        private PhotoCommentsService() 
        { }
    }
}
