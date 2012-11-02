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
    class AlbumListService : RRServiceBase<int, AlbumListEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static AlbumListService Instance
        {
            get { return _instance; }
        }
        private static readonly AlbumListService _instance = new AlbumListService();

        public async Task<RenRenResponseArg<AlbumListEntity>> RequestAlbumListByUid(int uid, int page, int pageSize)
        {
            RenRenResponseArg<AlbumListEntity> resp = await RequestById(uid, page, pageSize);
            return resp;
        }

        protected override Task<RenRenResponseArg<AlbumListEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<AlbumListEntity>> DoRequestById(int id, params object[] args)
        {
            int page = args.Length > 0 ? (int)args[0] : -1;
            int pageSize = args.Length > 1 ? (int)args[1] : -1;
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;

            RenRenResponseArg<AlbumListEntity> resp = await API.Renren3GApi.GetAlbumList(seesionKey, secrectKey, id, page, pageSize);
            return resp;
        }

        /// <summary>
        /// Reset overall models
        /// </summary>
        protected override void DoReset()
        {
        }

        protected override void DoResetById(int id)
        {
        }

        /// <summary>
        /// private construct to protected against the outside create
        /// </summary>
        private AlbumListService() 
        { }
 
    }
}
