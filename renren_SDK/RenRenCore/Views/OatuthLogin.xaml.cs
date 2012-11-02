using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RenrenCore.Entities;
using RenrenCore.RRServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RenrenCore.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OatuthLogin : Page
    {

        private bool _login = true;

        //cancel-Url
        private string cancel_url = @"https://login.renren.com/mlogin/auth/";
        
        public OatuthLogin()
        {
            this.InitializeComponent();

            this.Loaded += OatuthLogin_Loaded;
        }

        void OatuthLogin_Loaded(object sender, RoutedEventArgs e)
        {
            this.wb.NavigationFailed += wb_NavigationFailed;
            this.wb.LoadCompleted += wb_LoadCompleted;
            this.wb.ScriptNotify += wb_ScriptNotify;

        }

        void wb_ScriptNotify(object sender, NotifyEventArgs e)
        {
          string s =   e.Value.ToString();
          System.Diagnostics.Debug.WriteLine(s);
        }

        void wb_LoadCompleted(object sender, NavigationEventArgs e)
        {

            //login
            if (_login)
            {
                //cancel
                if (e.Uri.AbsoluteUri == cancel_url)
                {
                    var _frame = Window.Current.Content as Frame;
                    _frame.GoBack();
                }
                
                //get token
                else if (!string.IsNullOrEmpty(GetQueryString(e.Uri, "access_token")))
                {
                    login(e.Uri);
                }

                // //requesting token or other status
                else
                {
                    return;
                }

            }
            
            //logout
            else
            {
                logout();
            }

        }

        void wb_NavigationFailed(object sender, WebViewNavigationFailedEventArgs e)
        {
            string s = e.ToString();
            System.Diagnostics.Debug.WriteLine(s);

            OauthService.Instance.NotifyOauthLoginResult(false);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Uri wbUri = null;
            string requestUri = string.Empty;
            
            string param = (string)e.Parameter;

            if (param == "logout")
            {
                requestUri = @"https://login.renren.com/mlogin/auth/swipe";

                _login = false;
            }
            else
            {
                 requestUri = @"https://login.renren.com/mlogin/auth/auth?" + param + @"&&response_type=token";

                 _login = true;
            }

            wbUri = new Uri(requestUri);

            this.wb.Navigate(wbUri);
        }

        /// <summary>
        /// 不区分大小写,获得querysring中的值
        /// </summary>
        /// <param name="url"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private string GetQueryString(Uri url, string key)
        {
            string retVal = "";
            string query = "";
            string abUrl = url.Fragment;

            if (abUrl != "")
            {
                abUrl = Uri.UnescapeDataString(abUrl);
                query = abUrl.Replace("#", "");
            }
            else
            {
                abUrl = url.AbsoluteUri;
                abUrl = Uri.UnescapeDataString(abUrl);
                query = abUrl.Substring(abUrl.IndexOf("?") + 1);
                query = query.Replace("?", "");
            }

            string[] querys = query.Split('&');
            foreach (string qu in querys)
            {
                string[] vals = qu.Split('=');
                if (vals[0].ToString().ToLower() == key.ToLower())
                {
                    retVal = vals[1].ToString();
                    break;
                }
            }
            return retVal;
        }


        private void login(Uri _uri)
        {
            string access_token = GetQueryString(_uri, "access_token");
            string expires_in = string.Empty;
            string refresh_token = string.Empty;
            string scope = string.Empty;

            if (!string.IsNullOrEmpty(access_token))
            {
                expires_in = GetQueryString(_uri, "expires_in");

                scope = GetQueryString(_uri, "scope");

                Constants.ConstantValue.access_token = access_token;
                Constants.ConstantValue.expires_in = expires_in;
                Constants.ConstantValue.scope = scope;

                //store data
                ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
                ApplicationDataCompositeValue compositeValue = new ApplicationDataCompositeValue();
                compositeValue[Constants.ConstantValue.access_token_key] = Constants.ConstantValue.access_token;
                compositeValue[Constants.ConstantValue.expires_in_key] = Constants.ConstantValue.expires_in;
                compositeValue[Constants.ConstantValue.scope_key] = Constants.ConstantValue.scope;

                localSettings.Values[Constants.ConstantValue.oauth_key] = compositeValue;

                var _frame = Window.Current.Content as Frame;
                _frame.GoBack();

                OauthService.Instance.NotifyOauthLoginResult(true);
            }

         
        }

        private void logout()
        {
            Constants.ConstantValue.access_token = string.Empty;
            Constants.ConstantValue.expires_in = string.Empty;

            Constants.ConstantValue.scope = string.Empty;

            var _frame = Window.Current.Content as Frame;
            _frame.GoBack();
            
            OauthService.Instance.NotifyOauthLogoutResult(true);

        }


    }
}