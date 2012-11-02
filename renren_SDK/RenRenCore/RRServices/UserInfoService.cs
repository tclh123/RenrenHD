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
    public sealed class UserInfoService : RRServiceBase<int, UserInfoEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static UserInfoService Instance
        {
            get { return _instance; }
        }
        private static readonly UserInfoService _instance = new UserInfoService();

        /// <summary>
        /// Request and update self user info
        /// The wrapped convient method provided for outside call
        /// </summary>
        /// <returns>The info result</returns>
        public async Task<RenRenResponseArg<UserInfoEntity>> RequestMyUserInfo()
        { 
            RenRenResponseArg<UserInfoEntity> resp = await Request();
            return resp;
        }

        /// <summary>
        /// Request and update the user info by uid
        /// The wrapped convient method provided for outside call
        /// </summary>
        /// <returns></returns>
        public async Task<RenRenResponseArg<UserInfoEntity>> RequestUserInfoByUid(int uid)
        {
            RenRenResponseArg<UserInfoEntity> resp = await RequestById(uid);
            return resp;
        }

        protected async override Task<RenRenResponseArg<UserInfoEntity>> DoRequest(params object[] args)
        {
            string access_token = Constants.ConstantValue.access_token;
            string secrectKey = Constants.ConstantValue.SecretKey;
            RenRenResponseArg<UserInfoEntity> resp = await API.Renren3GApi.GetUserInfo(access_token, secrectKey);
            return resp;
        }

        protected async override Task<RenRenResponseArg<UserInfoEntity>> DoRequestById(int id, params object[] args)
        {
            string access_token = Constants.ConstantValue.access_token;
            string secrectKey = Constants.ConstantValue.SecretKey;
            RenRenResponseArg<UserInfoEntity> resp = await API.Renren3GApi.GetUserInfo(access_token, secrectKey, id);

            //string seesionKey = LoginService.Instance.Model.Session_key;
            //string secrectKey = LoginService.Instance.Model.Secret_key;
            //RenRenResponseArg<UserInfoEntity> resp = await API.Renren3GApi.GetUserInfo(seesionKey, secrectKey, id);
            return resp;
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
        private UserInfoService()
        { 
        }
    }
}
