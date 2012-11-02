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
    class AlbumService : RRServiceBase<long, PhotoListEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static AlbumService Instance
        {
            get { return _instance; }
        }
        private static readonly AlbumService _instance = new AlbumService();

        public async Task<RenRenResponseArg<PhotoListEntity>> RequestPhotoListByAlbumId(int userId, long albumId, int page, int pageSize, string password)
        {
            RenRenResponseArg<PhotoListEntity> resp = await RequestById(albumId, userId, page, pageSize, password);
            return resp;
        }

        protected override Task<RenRenResponseArg<PhotoListEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<PhotoListEntity>> DoRequestById(long id, params object[] args)
        {
            if (args.Length < 1) throw new ArgumentException();
            int uid = (int)args[0];
            int page = args.Length > 1 ? (int)args[1] : -1;
            int pageSize = args.Length > 2 ? (int)args[2] : -1;
            string password = args.Length > 3 ? (string)args[3] : string.Empty;
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;

            var api = new API();
            RenRenResponseArg<PhotoListEntity> resp = await api.GetPhotoList(seesionKey, secrectKey, uid, id, page, pageSize, password);
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
        private AlbumService() 
        { }
    }
}
