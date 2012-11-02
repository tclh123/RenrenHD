using System;
using System.Net;

namespace RenrenCore.Constants
{
    internal class ConstantValue
    {

        internal    static string ApiKey = "";

        internal static string SecretKey = "";

        internal static Uri RequestUri = new Uri("http://api.m.renren.com/api", UriKind.Absolute);

  
        internal static Uri TestingUri = new Uri("http://mc1.test.renren.com/api", UriKind.Absolute);

        internal static string PostMethod = "POST";

        // Followings are used to compose the update info
        // For MS store
        internal static string ChannelId = "8001201";


        internal static string PublishDate = "20120413";
        internal static string OS = "Windows 8";
        internal static string AppID = "177807";
        internal static string AppName = "Renren Windows 8 HD";
        // 0:手动检查更新；1:自动检查更新
        internal static string UpdateType = "1";


        internal static string access_token = "";
        internal static string expires_in = "";
        internal static string scope = "";

        internal static readonly string access_token_key = "access_token";
        internal static readonly string expires_in_key = "expires_in";
        internal static readonly string scope_key = "scope";

        internal static readonly string oauth_key = "oauth_key";

    }
}
