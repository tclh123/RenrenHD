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
    /// LoginService
    /// In charge of the login page's control and data issues
    /// \note: this class is defined as singleton since it will be easily used in global
    /// </summary>
   public  class LoginService : RRServiceBase<int, UserEntity>
    {
        /// <summary>
        /// Singleton property
        /// </summary>
        public static LoginService Instance
        {
            get { return _instance; }
        }
        private static readonly LoginService _instance = new LoginService();

        /// <summary>
        /// User login interface
        /// The wrapped convient method provided for outside call
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="password">password</param>
        /// <returns>The aync error wrapped value</returns>
        public async Task<RenRenResponseArg<UserEntity>> Login(string userName, string password)
        {
            RenRenResponseArg<UserEntity> response = await Request(userName, password);
            return response;
        }

        protected async override Task<RenRenResponseArg<UserEntity>> DoRequest(params object[] args)
        {
            if (args.Length < 2) throw new ArgumentException();

            string userName = (string)args[0];
            string password = (string)args[1];
            RenRenResponseArg<UserEntity> response = await API.Renren3GApi.LogIn(userName, password);
            return response;
        }

        protected override Task<RenRenResponseArg<UserEntity>> DoRequestById(int id, params object[] args)
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
     //   privite LoginService() { }
        

         static LoginService() { }
    }
}
