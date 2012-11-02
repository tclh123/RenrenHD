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
using Windows.Storage;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;
using RenrenCore.Constants;
using RenrenCore.Helper;
using Windows.Devices.Geolocation;

namespace RenrenCore.Apis
{
    public partial class API
    {
        public async Task<RenRenResponseArg<CommonReultEntity>> UploadHead(string sessionKey, string secretKey, StorageFile file, string caption, int from)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("method", "photos.uploadHead"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("caption", caption));
            parameters.Add(new RequestParameterEntity("from", from.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseMpHandler<CommonReultEntity, RenRenResponseArg<CommonReultEntity>>(parameters, ConstantValue.PostMethod, new Uri("http://api.m.renren.com/api", UriKind.Absolute), file);
            return result;
        }

        /// <summary>
        /// 发送图片 using multi-part
        /// </summary>
        /// <param name="sessionKey"></param>
        /// <param name="userSecretKey"></param>
        /// <param name="basedata"></param>
        public async Task<RenRenResponseArg<UploadPhotoEntity>> UploadPhotoMPart(string sessionKey, string userSecretKey, StorageFile file, long albumId, string caption)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("method", "photos.uploadbin"));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            if (albumId != -1)
                parameters.Add(new RequestParameterEntity("aid", albumId.ToString()));
            if (caption != null)
                parameters.Add(new RequestParameterEntity("caption", caption));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, userSecretKey)));

            var result = await agentReponseMpHandler<UploadPhotoEntity, RenRenResponseArg<UploadPhotoEntity>>(parameters, ConstantValue.PostMethod, new Uri("http://api.m.renren.com/api", UriKind.Absolute), file);
            return result;
        }

        public async Task<RenRenResponseArg<UploadPhotoEntity>> UploadPhotoMPart(string sessionKey, string secretKey, StorageFile file, long albumId, string caption, PoiListEntity place, Geoposition pos)
        {

            long lon = (long)(pos.Coordinate.Longitude * 1000000.0);
            long lat = (long)(pos.Coordinate.Latitude * 1000000.0);

            // get the poi list
            var info = place.PoiInfo;

            string temp = string.Format(_placeFormat, info.Longitude, info.Latitude, lon, lat, info.PoiName);
            string placeData = "{" + temp + "}";
            var response = await UploadPhotoMPart(sessionKey, secretKey, file, albumId, caption, placeData);
            return response;
        }

        const string _placeFormat = "\"place_longitude\":{0},\"place_latitude\":{1},\"gps_longitude\":{2},\"gps_latitude\":{3},\"d\":1,\"locate_type\":0,\"place_name\":\"{4}\",\"privacy\":2,\"source_type\":4";
        /// <summary>
        /// 发布带LBS的照片
        /// </summary>
        /// <param name="sessionKey"></param>
        /// <param name="userSecretKey"></param>
        /// <param name="file"></param>
        /// <param name="albumId"></param>
        /// <param name="caption"></param>
        /// <param name="place_data"></param>
        /// <returns></returns>
        public async Task<RenRenResponseArg<UploadPhotoEntity>> UploadPhotoMPart(string sessionKey, string userSecretKey, StorageFile file, long albumId, string caption, string place_data = null)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("method", "photos.uploadbin"));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            if (albumId != -1)
                parameters.Add(new RequestParameterEntity("aid", albumId.ToString()));
            if (caption != null)
                parameters.Add(new RequestParameterEntity("caption", caption));

            if (!string.IsNullOrEmpty(place_data) && !string.IsNullOrWhiteSpace(place_data))
            {
                parameters.Add(new RequestParameterEntity("place_data", place_data));
            }

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, userSecretKey)));

            var result = await agentReponseMpHandler<UploadPhotoEntity, RenRenResponseArg<UploadPhotoEntity>>(parameters, ConstantValue.PostMethod, new Uri("http://api.m.renren.com/api", UriKind.Absolute), file);
            return result;
        }

        public async Task<RenRenResponseArg<AlbumListEntity>> GetAlbumList(string sessionKey, string userSecretKey, int userId, long aid, int exclude_list, int page, int pageSize)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetAlbums));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("exclude_list", exclude_list.ToString()));
            parameters.Add(new RequestParameterEntity("aid ", aid.ToString()));

            if (userId != -1)
                parameters.Add(new RequestParameterEntity("uid", userId.ToString()));
            if (page != -1)
                parameters.Add(new RequestParameterEntity("page", page.ToString()));
            if (pageSize != -1)
                parameters.Add(new RequestParameterEntity("page_size", pageSize.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, userSecretKey)));

            var result = await agentReponseHandler<AlbumListEntity, RenRenResponseArg<AlbumListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        public async Task<RenRenResponseArg<PhotoListEntity>> GetNewUploadedPhotos(string sessionKey, string userSecretKey, int userId, long aid, int exclude_list, int page, int pageSize)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetNewUploaded));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("exclude_list", exclude_list.ToString()));
            parameters.Add(new RequestParameterEntity("aid ", aid.ToString()));

            if (userId != -1)
                parameters.Add(new RequestParameterEntity("uid", userId.ToString()));
            if (page != -1)
                parameters.Add(new RequestParameterEntity("page", page.ToString()));
            if (pageSize != -1)
                parameters.Add(new RequestParameterEntity("page_size", pageSize.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, userSecretKey)));

            var result = await agentReponseHandler<PhotoListEntity, RenRenResponseArg<PhotoListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        #region Response handler
        static private async Task<ArgType> agentReponseMpHandler<EntityType, ArgType>(ICollection<RequestParameterEntity> args, string method, Uri uri, StorageFile file)
        {
            EntityType entity = default(EntityType);
            ErrorEntity error = null;
            ArgType result = default(ArgType);
            try
            {
                var agent = new HttpMPRequestAgent();
                agent.Method = method;

                foreach (var parameter in args)
                {
                    agent.AddParameters(parameter.Name, parameter.Values);
                }

                string response = await agent.DownloadString(uri, file);
                entity = (EntityType)JsonUtility.DeserializeObj(new MemoryStream(Encoding.UTF8.GetBytes(response)),
                                                                         typeof(EntityType));
                error = (ErrorEntity)JsonUtility.DeserializeObj(new MemoryStream(Encoding.UTF8.GetBytes(response)),
                                                                         typeof(ErrorEntity));

                if (error != null && error.Error_msg != null)
                {
                    result = (ArgType)Activator.CreateInstance(typeof(ArgType), error);
                }
                else if (entity != null)
                {
                    result = (ArgType)Activator.CreateInstance(typeof(ArgType), entity);
                }
                else
                {
                    result = (ArgType)Activator.CreateInstance(typeof(ArgType), new ArgumentException());
                }
            }
            catch (Exception ex)
            {
                result = (ArgType)Activator.CreateInstance(typeof(ArgType), ex);
            }

            return result;
        }

        #endregion
    }
}