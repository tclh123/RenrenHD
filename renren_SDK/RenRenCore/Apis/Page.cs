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
using RenrenCore.Helper;
using RenrenCore.Entities;
using RenrenCore.Constants;

namespace RenrenCore.Apis
{
    public partial class API
    {
        public async Task<RenRenResponseArg<CommonReultEntity>> PageBecomeFan(string sessionKey, string secretKey, int page_id)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.PageBecomeFan));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("page_id", page_id.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<CommonReultEntity, RenRenResponseArg<CommonReultEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }
    }
}
