﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Apis;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    class NewsService : RRServiceBase<int, NewsCountEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static NewsService Instance
        {
            get { return _instance; }
        }
        private static readonly NewsService _instance = new NewsService();

        /// <summary>
        /// Request and update the self news count
        /// The wrapped convient method provided for outside call
        /// </summary>
        /// <returns></returns>
        public async Task<RenRenResponseArg<NewsCountEntity>> RequestMyNewsCount()
        {
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;
            RenRenResponseArg<NewsCountEntity> resp = await API.Renren3GApi.GetNewsCount(seesionKey, secrectKey);

            Model = resp.Result;
            return resp;
        }

        protected async override Task<RenRenResponseArg<NewsCountEntity>> DoRequest(params object[] args)
        {
            string seesionKey = LoginService.Instance.Model.Session_key;
            string secrectKey = LoginService.Instance.Model.Secret_key;
            RenRenResponseArg<NewsCountEntity> resp = await API.Renren3GApi.GetNewsCount(seesionKey, secrectKey);
            return resp;
        }

        protected override Task<RenRenResponseArg<NewsCountEntity>> DoRequestById(int id, params object[] args)
        {
            throw new NotImplementedException();
        }

        protected override void DoReset()
        {
        }

        protected override void DoResetById(int id)
        {
        }

        /// <summary>
        /// private construct to protected against the outside create
        /// </summary>
        private NewsService()
        { }
    }
}
