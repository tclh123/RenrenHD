using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;
using RenrenCore.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Windows.Storage;

namespace RenrenCore.RRServices
{
    public sealed class OauthService 
    {
        private OauthService() { }
        public static readonly OauthService Instance = new OauthService();


        #region event
        public delegate void OauthLoginResultHandler(object sender, bool result);
        public event OauthLoginResultHandler OauthLoginResult;

        internal void NotifyOauthLoginResult (bool result)
        {
            if(OauthLoginResult != null )
             {
                 OauthLoginResult(this,result);
             }
        }

        public delegate void OauthLogoutResultHandler(object sender,bool result);
        public event OauthLogoutResultHandler OauthLogoutResult;

        internal void NotifyOauthLogoutResult(bool result)
        {
            if (OauthLogoutResult != null)
            {
                OauthLogoutResult(this,result);
            }
        }
        #endregion

        public bool IsLogin()
        {
            return ( !string.IsNullOrEmpty(Constants.ConstantValue.access_token) );
        }

        /// <summary>
        /// get stored setting from local
        /// </summary>
        /// <returns></returns>
        private bool StoredToken()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            return localSettings.Values.ContainsKey(Constants.ConstantValue.oauth_key);
        }

        private void RestoreToken() //???
        {
            if (StoredToken())
            {
                ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
                ApplicationDataCompositeValue compositeValue = null;

                compositeValue = localSettings.Values[Constants.ConstantValue.oauth_key] as ApplicationDataCompositeValue;

                if (compositeValue == null)
                    return;

                Constants.ConstantValue.access_token = compositeValue[Constants.ConstantValue.access_token_key].ToString();
                Constants.ConstantValue.expires_in = compositeValue[Constants.ConstantValue.expires_in_key].ToString();
                Constants.ConstantValue.scope = compositeValue[Constants.ConstantValue.scope_key].ToString();

            }
        }

        public void ClearToken()
        {
            if (StoredToken())
            {
                ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
                localSettings.Values.Remove(Constants.ConstantValue.oauth_key);
            }

            Constants.ConstantValue.access_token = string.Empty;
            Constants.ConstantValue.expires_in = string.Empty;
            Constants.ConstantValue.scope = string.Empty;
        }

        /// <summary>
        /// Oauth2.0 logout
        /// </summary>
        public  void Logout()
        {
            string requestparam = @"logout";
            Navi(requestparam);
        }

        private void Navi(string requestparam)
        {
            var _frame = Window.Current.Content as Frame;
            _frame.Navigate(typeof(OatuthLogin), requestparam);

            return;
        }

        /// <summary>
        /// save keys
        /// </summary>
        /// <param name="api_key"></param>
        /// <param name="SecretKey"></param>
        /// <returns>if successed then return true.</returns>
        private bool SaveKeys(string api_key,string SecretKey)
        {
            if ((string.IsNullOrEmpty(api_key)) || (string.IsNullOrEmpty(SecretKey)))
                return false;
            else
            {
                Constants.ConstantValue.ApiKey = api_key;
                Constants.ConstantValue.SecretKey = SecretKey;
                return true;
            }

        }

        /// <summary>
        /// 强制更新Access-Token 
        /// </summary>
        /// <param name="api_key">API_KEY</param>
        /// <param name="SecretKey">SecretKey</param>
        /// <param name="redirect_uri">指向重定向服务器，能够解析OAuth服务器返回的code</param>
        /// <param name="scope">申请的API权限</param>
        /// <param name="switchUser">选择是否更改用户</param>
        /// <param name="cancel_url">用户取消授权时的跳转页面</param>
        /// <param name="show_header">查询的是否隐藏头像</param>
        public void UpdateToken(string api_key,string SecretKey, string redirect_uri, List<string> scope, int switchUser= 0, string cancel_url = "",int show_header = 1)
        {

            if (!SaveKeys(api_key, SecretKey))
                return ;

            string strScope = string.Empty;
            if (scope.Count > 0)
            {
                StringBuilder sbscope = new StringBuilder(scope.Count);
                foreach (string strRecord in scope)
                {
                    sbscope.Append(strRecord);
                    sbscope.Append(",");
                }

                sbscope.Remove(sbscope.Length-1, 1);
                strScope = sbscope.ToString();
            }

            string requestparam = string.Format("client_id={0}&scope={1}&redirect_uri={2}&switchUser={3}&cancel_url={4}&show_header={5}",
                api_key, strScope, redirect_uri, switchUser, cancel_url, show_header);

            Navi(requestparam);

            return;
        }

        /// <summary>
        /// Oauth2.0 Login
        /// </summary>
        /// <param name="api_key">API_KEY</param>
        /// <param name="SecretKey">SecretKey</param>
        /// <param name="redirect_uri">指向重定向服务器，能够解析OAuth服务器返回的code</param>
        /// <param name="scope">申请的API权限</param>
        /// <param name="switchUser">选择是否更改用户</param>
        /// <param name="cancel_url">用户取消授权时的跳转页面</param>
        /// <param name="show_header">查询的是否隐藏头像</param>
        public  void Login(string api_key, string SecretKey, string redirect_uri, List<string> scope, int switchUser = 0, string cancel_url = "", int show_header = 1)
        {
        
            if (StoredToken())
            {
                if (!SaveKeys(api_key, SecretKey))
                    return;

                RestoreToken();

                this.NotifyOauthLoginResult(true);
            }
            else
            {
                 UpdateToken(api_key,SecretKey,redirect_uri,scope,switchUser,cancel_url,show_header);
            }
        }


    }
}
