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
    //internal partial class API
    public partial class API
    {
        //place.poiList
        internal async Task<RenRenResponseArg<PoiListEntity>> GetPoiList(string access_token, string secretKey, long lat, long lon, int radius, int d, int page = 1, int page_size = 10, string keyword = "", string data_type = "compression")
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetPoilist));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));
            parameters.Add(new RequestParameterEntity("lon_gps", lon.ToString()));
            parameters.Add(new RequestParameterEntity("lat_gps", lat.ToString()));
            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));
            parameters.Add(new RequestParameterEntity("d", d.ToString()));
            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", page_size.ToString()));

            if(keyword != "")
                parameters.Add(new RequestParameterEntity("k",keyword));

            if (data_type == "compression")
                parameters.Add(new RequestParameterEntity("data_type",data_type));


            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<PoiListEntity, RenRenResponseArg<PoiListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }
        
        
        //place.poiListByEventId
        internal async Task<RenRenResponseArg<PoiListEntity>> GetPoiListByEventId(string sessionKey, string secretKey, long eventId, int page, int pagesize)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey) );
            parameters.Add(new RequestParameterEntity("method", Method.GetPoilistByEventId));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("event_id", eventId.ToString()));
            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", pagesize.ToString()));


            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<PoiListEntity, RenRenResponseArg<PoiListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }


        //place.getPoiBaseInfoByPid
        internal async Task<RenRenResponseArg<PoiBaseInfoEntity>> GetPoiBaseInfoByPid(string access_token, string secretKey, string pid, int ubb = 0, int radius = 1)
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetPoiBaseInfoByPid));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));
            parameters.Add(new RequestParameterEntity("pid", pid));

            parameters.Add(new RequestParameterEntity("ubb", ubb.ToString()));
            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<PoiBaseInfoEntity, RenRenResponseArg<PoiBaseInfoEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.getPoiBaseInfoByLbsId
        internal async Task<RenRenResponseArg<PoiBaseInfoEntity>> GetPoiBaseInfoByLbsId(string sessionKey, string secretKey, long lbs_id, int ubb = 0, int radius = 1)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetPoiBaseInfoByLbsId));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("lbs_id", lbs_id.ToString() ));

            parameters.Add(new RequestParameterEntity("ubb", ubb.ToString()));
            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<PoiBaseInfoEntity, RenRenResponseArg<PoiBaseInfoEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        
        //Place.friendList
        internal async Task<RenRenResponseArg<LBSFriendListEntity>> GetLBSFriendList(string access_token, string secretKey, long lat_gps, long lon_gps, int d, int page, int page_size, string order_type, string data_type, int radius, int exclude_list)
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetFriendList));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));
            parameters.Add(new RequestParameterEntity("lat_gps", lat_gps.ToString() ));
            parameters.Add(new RequestParameterEntity("lon_gps", lon_gps.ToString()));
            parameters.Add(new RequestParameterEntity("d", d.ToString()));

            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", page_size.ToString()));
            parameters.Add(new RequestParameterEntity("order_type", order_type));

            parameters.Add(new RequestParameterEntity("data_type", data_type));
            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));
            parameters.Add(new RequestParameterEntity("exclude_list", exclude_list.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSFriendListEntity, RenRenResponseArg<LBSFriendListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }


        //Place.nearbyActivityListByPid
        internal async Task<RenRenResponseArg<ActivityPoiListEntity>> GetNearbyActivityListByPid(string sessionKey, string secretKey, string pid ,int page,int page_size = 20,int radius = 1, int exclude_list=0)
        { 
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.NearbyActivityListByPid));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("pid", pid));
            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", page_size.ToString()));
            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));
            parameters.Add(new RequestParameterEntity("exclude_list", exclude_list.ToString()));
            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<ActivityPoiListEntity, RenRenResponseArg<ActivityPoiListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.nearbyActivityListByLatLon
        /*
         * event_type=1优惠券；event_type=2团购；event_type=3活动；event_type=4 全部
         * */
        internal async Task<RenRenResponseArg<ActivityPoiListEntity>> GetNearbyActivityListByLatLon(string access_token, string secretKey, long lat_gps,
            long lon_gps, int page, int page_size=20, int radius=1, int exclude_list=0, int d = 0, int event_type = 4, string poitype = "")
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.NearbyActivityListByLatLon));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));
            parameters.Add(new RequestParameterEntity("lat_gps", lat_gps.ToString() ));
            parameters.Add(new RequestParameterEntity("lon_gps", lon_gps.ToString()));
            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", page_size.ToString()));
            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));
            parameters.Add(new RequestParameterEntity("exclude_list", exclude_list.ToString()));

            parameters.Add(new RequestParameterEntity("d", d.ToString()));
            parameters.Add(new RequestParameterEntity("event_type", event_type.ToString()));
            parameters.Add(new RequestParameterEntity("poiType", poitype));
            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<ActivityPoiListEntity, RenRenResponseArg<ActivityPoiListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.getNearbyActivityNoticeCount
        internal async Task<RenRenResponseArg<LBSNearbyActivityNoticeCountEntity>> GetNearbyActivityNoticeCount(string access_token, string secretKey, long lat_gps,
            long lon_gps, int radius = 1, int d = 0)
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetNearbyActivityNoticeCount));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));
            parameters.Add(new RequestParameterEntity("lat_gps", lat_gps.ToString()));
            parameters.Add(new RequestParameterEntity("lon_gps", lon_gps.ToString()));
            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));
            parameters.Add(new RequestParameterEntity("d", d.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSNearbyActivityNoticeCountEntity, RenRenResponseArg<LBSNearbyActivityNoticeCountEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }



        //Place.getLocalActivityListByPid
        internal async Task<RenRenResponseArg<ActivityListEntity>> GetLocalActivityListByPid(string sessionKey, string secretKey, string pid, int page, int page_size = 20, int exclude_list = 0)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetLocalActivityListByPid));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("pid", pid));
            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", page_size.ToString()));
            parameters.Add(new RequestParameterEntity("exclude_list", exclude_list.ToString()));
            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<ActivityListEntity, RenRenResponseArg<ActivityListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.calculateDistance
        internal async Task<RenRenResponseArg<PlaceDistanceEntity>> CalculateDistance(string access_token, string secretKey, long lat_gps, long lon_gps, string pid, int radius = 2, int d = 0)
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.CalculateDistance));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));
            parameters.Add(new RequestParameterEntity("pid", pid));

            parameters.Add(new RequestParameterEntity("lat_gps", lat_gps.ToString() ));
            parameters.Add(new RequestParameterEntity("lon_gps", lon_gps.ToString()));

            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));
            parameters.Add(new RequestParameterEntity("d", d.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<PlaceDistanceEntity, RenRenResponseArg<PlaceDistanceEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.getFeedListByPid
        /*
         * biz_type=3 得到的是签到列表；biz_type=4 得到的是评论列表。缺省值为3
         * */
        internal async Task<RenRenResponseArg<LBSFeedListEntity>> GetFeedListByPid(string sessionKey, string secretKey, string pid, int page = 1, int page_size = 10, int biz_type = 3)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetFeedListByPid));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("pid", pid));
            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", page_size.ToString()));
            parameters.Add(new RequestParameterEntity("biz_type", biz_type.ToString()));
            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSFeedListEntity, RenRenResponseArg<LBSFeedListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.getFeedsByPid
        internal async Task<RenRenResponseArg<LBSFeedListEntity>> GetFeedsByPid(string sessionKey, string secretKey, string pid, int page = 1, int page_size = 10, int ubb = 0)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetFeedsByPid));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));
            parameters.Add(new RequestParameterEntity("pid", pid));
            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", page_size.ToString()));
            parameters.Add(new RequestParameterEntity("ubb", ubb.ToString()));
            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSFeedListEntity, RenRenResponseArg<LBSFeedListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.getNearByFeeds
        internal async Task<RenRenResponseArg<LBSNearbyFeedListEntity>> GetNearByFeeds(string access_token, string secretKey, long lat_gps, long lon_gps, string pid, int page = 1,int page_size=10,int ubb = 0,int radius = 2, int d = 0)
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetNearByFeeds));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));
          

            parameters.Add(new RequestParameterEntity("lat_gps", lat_gps.ToString()));
            parameters.Add(new RequestParameterEntity("lon_gps", lon_gps.ToString()));

            parameters.Add(new RequestParameterEntity("pid", pid));

            parameters.Add(new RequestParameterEntity("page", page.ToString()));
            parameters.Add(new RequestParameterEntity("page_size", page_size.ToString()));

            parameters.Add(new RequestParameterEntity("ubb",ubb.ToString() ));

            parameters.Add(new RequestParameterEntity("radius", radius.ToString()));
            parameters.Add(new RequestParameterEntity("d", d.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSNearbyFeedListEntity, RenRenResponseArg<LBSNearbyFeedListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.addEvaluation
        /*
         * 
        privacy。缺省值为1 ；0为自己可见，1为好友可见，2为所有人可见 
         * */
        internal async Task<RenRenResponseArg<LBSAddEvaluationEntity>> AddEvaluation(string sessionKey, string secretKey,string pid,long request_time,string content,long lat_gps=0,long lon_gps=0,
            int privacy=1,string poi_name= "",string poi_address= "",string poi_type = "")
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.AddEvaluation));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("pid",pid));
            parameters.Add(new RequestParameterEntity("request_time",request_time.ToString()  ));
            parameters.Add(new RequestParameterEntity("content",content));
            parameters.Add(new RequestParameterEntity("lat_gps",lat_gps.ToString()));
            parameters.Add(new RequestParameterEntity("lon_gps",lon_gps.ToString()));
            parameters.Add(new RequestParameterEntity("privacy",privacy.ToString() ));
            parameters.Add(new RequestParameterEntity("poi_name",poi_name));
            parameters.Add(new RequestParameterEntity("poi_address",poi_address));
            parameters.Add(new RequestParameterEntity("poi_type",poi_type));


            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSAddEvaluationEntity, RenRenResponseArg<LBSAddEvaluationEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.addEvaluationComment
        /*
        * 
         privacy。缺省值为1 ；0为自己可见，1为好友可见，2为所有人可见 
        * */
        internal async Task<RenRenResponseArg<LBSAddEvaluationCommentEntity>> AddEvaluationComment(string sessionKey, string secretKey,long id,string content,int owner_id,int rid = -1,int privacy = 1)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.AddEvaluationComment));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("id",id.ToString() ));
            parameters.Add(new RequestParameterEntity("content",content));
            parameters.Add(new RequestParameterEntity("own_id",owner_id.ToString() ));

            parameters.Add(new RequestParameterEntity("rid",rid.ToString() ));
            parameters.Add(new RequestParameterEntity("privacy",privacy.ToString() ));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSAddEvaluationCommentEntity, RenRenResponseArg<LBSAddEvaluationCommentEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.getEvaluation
        internal async Task<RenRenResponseArg<LBSGetEvaluationEntity>> GetEvaluation(string sessionKey, string secretKey, long id, int owner_id, int reply_id = -1)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetEvaluation));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("id", id.ToString()));

            parameters.Add(new RequestParameterEntity("own_id", owner_id.ToString()));

            parameters.Add(new RequestParameterEntity("reply_id", reply_id.ToString()));


            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSGetEvaluationEntity, RenRenResponseArg<LBSGetEvaluationEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.getEvaluationComments
        /*
         * sort:sort=1为倒序 
         * exclude_list:是否包含列表，1为不包含 
         * with_evaluation:是否包含点评详细信息，1为包含 
         */
        internal async Task<RenRenResponseArg<LBSGetEvaluationCommentListEntity>> GetEvaluationComments(string sessionKey, string secretKey, long id, int user_id, int page = 1, int page_size = 20, int sort = 1, int exclude_list = 1, int with_evaluation=1)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetEvaluationComments));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("id", id.ToString()));
            parameters.Add(new RequestParameterEntity("user_id",user_id.ToString() ));
            parameters.Add(new RequestParameterEntity("page",page.ToString() ));
            parameters.Add(new RequestParameterEntity("page_size",page_size.ToString() ));
            parameters.Add(new RequestParameterEntity("sort",sort.ToString() ));
            parameters.Add(new RequestParameterEntity("exclude_list",exclude_list.ToString() ));
            parameters.Add(new RequestParameterEntity("with_evaluation", with_evaluation.ToString() ));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSGetEvaluationCommentListEntity, RenRenResponseArg<LBSGetEvaluationCommentListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.addPoi
        internal async Task<RenRenResponseArg<LBSAddPoiEntity>> AddPoi(string access_token, string secretKey, long request_time, string name, long lat_gps, long lon_gps,string address = "", string type = "",  int d = 1)
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.AddPoi));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));

            parameters.Add(new RequestParameterEntity("request_time",request_time.ToString()  ));
            parameters.Add(new RequestParameterEntity("name",name));
            parameters.Add(new RequestParameterEntity("address",address));
            parameters.Add(new RequestParameterEntity("type",type));


            parameters.Add(new RequestParameterEntity("lat_gps", lat_gps.ToString()));
            parameters.Add(new RequestParameterEntity("lon_gps", lon_gps.ToString()));
            parameters.Add(new RequestParameterEntity("d", d.ToString()));
      

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSAddPoiEntity, RenRenResponseArg<LBSAddPoiEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.checkin
        internal async Task<RenRenResponseArg<LBSCheckInEntity>> CheckIn(string access_token, string secretKey, string pid, string status = "", long lat_gps = 0,
            long lon_gps = 0,int privacy = 1,string poi_name = "",string poi_address = "",string poi_type = "")
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.Checkin));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));

            parameters.Add(new RequestParameterEntity("pid",pid));
            parameters.Add(new RequestParameterEntity("status",status));
            parameters.Add(new RequestParameterEntity("lat_gps",lat_gps.ToString() ));
            parameters.Add(new RequestParameterEntity("lon_gps",lon_gps.ToString() ));
            parameters.Add(new RequestParameterEntity("privacy",privacy.ToString() ));
            parameters.Add(new RequestParameterEntity("poi_name",poi_name));
            parameters.Add(new RequestParameterEntity("poi_address",poi_address));
            parameters.Add(new RequestParameterEntity("poi_type",poi_type));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSCheckInEntity, RenRenResponseArg<LBSCheckInEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.addCheckinComment
        internal async Task<RenRenResponseArg<LBSAddCheckinCommentEntity>> AddCheckinComment(string sessionKey, string secretKey, long cid,int uid,int rid,string content)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.AddCheckinComment));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("cid",cid.ToString() ));
            parameters.Add(new RequestParameterEntity("uid", uid.ToString()));
            parameters.Add(new RequestParameterEntity("rid", rid.ToString()));

            parameters.Add(new RequestParameterEntity("content",content));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSAddCheckinCommentEntity, RenRenResponseArg<LBSAddCheckinCommentEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //Place.getCheckinComments
        /*
         * sort:列表时间排序方式（0：时间递减，1：时间递增）
         * exclude_list:是否排除列表（1：只取数，不取列表） 
         * with_pci:是否包含checkin信息（1：包含）
         * */
        internal async Task<RenRenResponseArg<PlaceReplyListEntity>> GetCheckinComments(string sessionKey, string secretKey, long id,int uid,
            int page = 1,int page_size = 10,int sort = 0,int exclude_list= 0,int with_pci = 1)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetCheckinComments));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("id",id.ToString() ));
            parameters.Add(new RequestParameterEntity("uid", uid.ToString() ));
            parameters.Add(new RequestParameterEntity("page",page.ToString() ));
            parameters.Add(new RequestParameterEntity("page_size",page_size.ToString() ));
            parameters.Add(new RequestParameterEntity("sort",sort.ToString() ));
            parameters.Add(new RequestParameterEntity("exclude_list",exclude_list.ToString() ));
            parameters.Add(new RequestParameterEntity("with_pci",with_pci.ToString() ));


            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<PlaceReplyListEntity, RenRenResponseArg<PlaceReplyListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //place.getPoiCategory 
        internal async Task<RenRenResponseArg<LBSPoiCategoryListEntity>> getPoiCategory(string access_token, string secretKey, string data_type = "compression")
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetPoiCategory));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));

            parameters.Add(new RequestParameterEntity("data_type",data_type));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSPoiCategoryListEntity, RenRenResponseArg<LBSPoiCategoryListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //place.lc 
        internal async Task<RenRenResponseArg<LBSSubmitEntity>> SetIc(string sessionKey, string secretKey, string rlct)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.SetIc));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("rlct", rlct));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSSubmitEntity, RenRenResponseArg<LBSSubmitEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //place.savePoiData 
        internal async Task<RenRenResponseArg<LBSSavePoiDataEntity>> SavePoiData(string sessionKey, string secretKey, long longitudeProvider, long latitudeProvider,
            string name,string providerId,string address="",string phone="",string country="",string province = "",string city = "",string district = "",
                string street = "", string note = "",string poiType = "")
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.SavePoiData));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("longitudeProvider", longitudeProvider.ToString() ));
            parameters.Add(new RequestParameterEntity("latitudeProvider", latitudeProvider.ToString()));

            parameters.Add(new RequestParameterEntity("name",name));
            parameters.Add(new RequestParameterEntity("proverderId",providerId));
            parameters.Add(new RequestParameterEntity("address",address));
            parameters.Add(new RequestParameterEntity("phone",phone));
            parameters.Add(new RequestParameterEntity("country",country));
            parameters.Add(new RequestParameterEntity("province",province));
            parameters.Add(new RequestParameterEntity("city",city));
            parameters.Add(new RequestParameterEntity("district",district));
            parameters.Add(new RequestParameterEntity("street",street));
            parameters.Add(new RequestParameterEntity("note",note));
            parameters.Add(new RequestParameterEntity("poiType",poiType));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSSavePoiDataEntity, RenRenResponseArg<LBSSavePoiDataEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }


        //place.getNearByRecommendPoiExtraList 
        /*
         * d:使用的是否是真实经纬度，若是，则设1，若已经使用的是偏转过的经纬度，则设为0 
         * radius:查找半径，单位为米,缺省值为2000 
         * type:类型，默认为-1; -1=全部 1=吃饭 2=聚会玩乐 3=逛街 4=酒吧夜店 5=聊天小坐 6=旅游 7=住宿 
         * */
        internal async Task<RenRenResponseArg<LBSGetNearByRecommendPoiExtraListEntity>> GetNearByRecommendPoiExtraList(string sessionKey, string secretKey, 
            long lon_gps,long lat_gps,int d = 0,int radius = 2000,int page = 1,int page_size = 10,int type = -1)
        {
            var parameters = ApiHelper.GetBaseParameters(sessionKey).Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetNearByRecommendPoiExtraList));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("session_key", sessionKey));

            parameters.Add(new RequestParameterEntity("lon_gps", lon_gps.ToString() ));
            parameters.Add(new RequestParameterEntity("lat_gps", lat_gps.ToString() ));
            parameters.Add(new RequestParameterEntity("d",d.ToString() ));
            parameters.Add(new RequestParameterEntity("radius",radius.ToString() ));
            parameters.Add(new RequestParameterEntity("page",page.ToString() ));
            parameters.Add(new RequestParameterEntity("page_size",page_size.ToString() ));
            parameters.Add(new RequestParameterEntity("type",type.ToString() ));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSGetNearByRecommendPoiExtraListEntity, RenRenResponseArg<LBSGetNearByRecommendPoiExtraListEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }

        //place.getStaticMapByPid 
        /*
         * zoom:地图的zoom值，尺寸，1-11，默认11 
         * */
        internal async Task<RenRenResponseArg<LBSGetStaticMapEntity>> GetStaticMapByPid(string access_token, string secretKey, string pid,
            string pointName= "",int height = 320,int width = 240,int zoom = 11)
        {
            var parameters = ApiHelper.GetBaseParameters().Result;
            parameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            parameters.Add(new RequestParameterEntity("method", Method.GetStaticMapByPid));
            parameters.Add(new RequestParameterEntity("call_id", ApiHelper.GenerateTime()));
            parameters.Add(new RequestParameterEntity("v", "1.0"));
            parameters.Add(new RequestParameterEntity("access_token", access_token));

            parameters.Add(new RequestParameterEntity("pid", pid));
            parameters.Add(new RequestParameterEntity("pointName",pointName));
            parameters.Add(new RequestParameterEntity("height",height.ToString() ));
            parameters.Add(new RequestParameterEntity("width",width.ToString() ));
            parameters.Add(new RequestParameterEntity("zoom", zoom.ToString()));

            parameters.Add(new RequestParameterEntity("sig", ApiHelper.GenerateSig(parameters, secretKey)));

            var result = await agentReponseHandler<LBSGetStaticMapEntity, RenRenResponseArg<LBSGetStaticMapEntity>>(parameters, ConstantValue.PostMethod);
            return result;
        }


    }
}
