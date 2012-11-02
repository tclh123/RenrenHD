using RenrenCore.RRServices;
#region General Header
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#endregion
// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace RenrenHD
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            storyboard_welcome.Begin();


            OauthService.Instance.OauthLoginResult += Instance_OauthResult;

        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        //oauth 授权完成事件通知
        async void Instance_OauthResult(object sender, bool result)
        {
            OauthService.Instance.OauthLoginResult -= Instance_OauthResult;

            if (!result)
            {
                //this.btn_login.Content = @"Failed to oauth login!";
                return;
            }
            #region 获取经纬度信息
            //this.btn_login.Content = @"Get LBS Info...";

            ////获取经纬度信息
            //Geolocator _geoImpl = null;

            //Geoposition pos = null;
            //try
            //{
            //    if (null == _geoImpl)
            //    {
            //        _geoImpl = new Geolocator();
            //    }

            //    //异步获取经纬度信息
            //    pos = await _geoImpl.GetGeopositionAsync();
            //}
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Debug.WriteLine(ex.Message);
            //    this.btn_login.Content = @"Failed to get LBS Info !";

            //}

            //if (pos != null)
            //{
            //    App.lat = (long)(pos.Coordinate.Latitude * 1000000.0);
            //    App.lon = (long)(pos.Coordinate.Longitude * 1000000.0);
            //}
            //else
            //{
            //    App.lat = (long)39960335;
            //    App.lon = (long)116430938;
            //}
            #endregion

            //页面跳转
            //var _frame = Window.Current.Content as Frame;
            //_frame.Navigate(typeof(HomePage));
            this.Frame.Navigate(typeof(Views.HomePage));
        }
        private void LoginHandler(object sender, RoutedEventArgs e)
        {
            //OauthService.Instance.ClearToken();
            // Oauth-login
            OauthService.Instance.Login(App.api_key, App.SecretKey, App.redirect_uri, App.scope);
        }
    }
}
