using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using HttpWebRequestLibrary;
using System.Runtime.Serialization.Json;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.ViewManagement;
using System.Threading.Tasks;
using Windows.UI.Core;
using System.Reflection;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;
using RenrenCore.Constants;
using RenrenCore.Helper;

namespace RenrenCore.Apis
{
    public partial class API
    {
        public async Task<RenRenResponseArg<CommonReultEntity>> AddNotification(string sessionKey, string secretKey, string channelUrl, string expTime, string sub_uid)
        {
            List<RequestParameterEntity> parameters = new List<RequestParameterEntity>();
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.AddWin8Token));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("token", channelUrl));
            parameters.Add(new RequestParameterEntity("expired_time", expTime));
            if (!string.IsNullOrEmpty(sub_uid))
            {
                parameters.Add(new RequestParameterEntity("sub_user_id", sub_uid));
            }

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<CommonReultEntity, RenRenResponseArg<CommonReultEntity>>(parameters, ConstantValue.PostMethod, ConstantValue.TestingUri);
            return result;
        }
    }
}
