using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Apis;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    /// <summary>
    /// id means the video url
    /// </summary>
    class VideoService : RRServiceBase<string, VideoGetEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static VideoService Instance
        {
            get { return _instance; }
        }
        private static readonly VideoService _instance = new VideoService();

        public async Task<RenRenResponseArg<VideoGetEntity>> RequestVideoByUrl(string url)
        {
            RenRenResponseArg<VideoGetEntity> resp = await RequestById(url);
            return resp;
        }

        protected override Task<RenRenResponseArg<VideoGetEntity>> DoRequest(params object[] args)
        {
            throw new NotImplementedException();
        }

        protected async override Task<RenRenResponseArg<VideoGetEntity>> DoRequestById(string url, params object[] args)
        {
            string videoUrl = url;
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;
            RenRenResponseArg<VideoGetEntity> resp = await API.Renren3GApi.VideoGet(seesionKey, secrectKey, videoUrl);
            return resp;
        }

        /// <summary>
        /// Reset overall models
        /// </summary>
        protected override void DoReset()
        {
        }

        protected override void DoResetById(string url)
        {
        }

        /// <summary>
        /// private construct to protected against the outside create
        /// </summary>
        private VideoService() 
        { }
    }
}
