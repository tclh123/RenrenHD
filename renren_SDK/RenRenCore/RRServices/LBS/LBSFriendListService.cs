using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;

namespace RenrenCore.RRServices
{
    public sealed class LBSFriendListService:RRServiceBase<int,LBSFriendListEntity>
    {
        public static readonly LBSFriendListService Instance = new LBSFriendListService();

        private LBSFriendListService() { }


        /// <summary>
        /// 获取好友列表 
        /// </summary>
        /// <param name="_lat">纬度</param>
        /// <param name="_lon">经度</param>
        /// <param name="_d">使用的是否是真实经纬度</param>
        /// <param name="_page">分页值</param>
        /// <param name="_pagesize">分页信息条目数</param>
        /// <param name="_ordertype">time(时间倒序)/distance（距离正序)</param>
        /// <param name="_datatype">all(所有数据)/near（附近的数据)</param>
        /// <param name="_radius">判断附近的半径,单位为公里</param>
        /// <param name="_exclude_list">是否包含commentlist 为1时表示不包含</param>
        public async Task<RenRenResponseArg<LBSFriendListEntity>> RequestFriendList(long _lat, long _lon, int _d, int _page=1, int _pagesize = 10, string _ordertype = "time", string _datatype="all", int _radius= 1, int _exclude_list = 0)
        {
            RenRenResponseArg<LBSFriendListEntity> resp = await Request(_lat, _lon,  _d, _page, _pagesize,_ordertype,_datatype,_radius,_exclude_list);
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSFriendListEntity>> DoRequest(params object[] args)
        {
            string _access_token = Constants.ConstantValue.access_token;
            string _secrectKey = Constants.ConstantValue.SecretKey;

            long _lat = (long)args[0];
            long _lon = (long)args[1];

            int _d = (int)args[2];
            int _page = (int)args[3];
            int _pagesize = (int)args[4];

            string _ordertype = (string)args[5];
            string  _datatype = (string)args[6];

            int _radius = (int)args[7];
            int _exclude_list = (int)args[8];

            RenRenResponseArg<LBSFriendListEntity> resp = await Apis.API.Renren3GApi.GetLBSFriendList(_access_token, _secrectKey, _lat, _lon, _d, _page, _pagesize, _ordertype,
                _datatype, _radius, _exclude_list);
            
            return resp;
        }

        protected async override Task<RenRenResponseArg<LBSFriendListEntity>> DoRequestById(int id, params object[] args)
        {

            throw new NotImplementedException();
        }

        protected override void DoReset()
        {
            return;
        }

        protected override void DoResetById(int id)
        {
            //throw new NotImplementedException();
            return;
        }
    }
}
