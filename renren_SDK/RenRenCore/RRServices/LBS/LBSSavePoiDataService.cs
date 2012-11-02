using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.AsyncArgs;
using RenrenCore.Entities;
using RenrenCore.RRServices.LBS;

namespace RenrenCore.RRServices
{
   public sealed  class LBSSavePoiDataService :RRServiceBase<string,LBSSavePoiDataEntity>
    {
       private LBSSavePoiDataService() { }
       public static readonly LBSSavePoiDataService  Instance = new LBSSavePoiDataService();


       public async  Task<RenRenResponseArg<LBSSavePoiDataEntity>> SavePoiData(long longitudeProvider, long latitudeProvider,
            string name, string providerId, string address = "", string phone = "", string country = "", string province = "", string city = "", string district = "",
                string street = "", string note = "", string poiType = "")
       {
           RenRenResponseArg<LBSSavePoiDataEntity> resp = await RequestById(providerId,longitudeProvider,latitudeProvider,name,address,phone,country,province,city,
              district,street,note,poiType);

           return resp;
       }
       
       
       protected async override Task<RenRenResponseArg<LBSSavePoiDataEntity>> DoRequest(params object[] args)
       {
           throw new NotImplementedException();
       }
       
       protected async override Task<RenRenResponseArg<LBSSavePoiDataEntity>> DoRequestById(string id, params object[] args)
       {
           //throw new NotImplementedException();
           string _seesionKey = LoginService.Instance.Model.Session_key;
           string _secrectKey = LoginService.Instance.Model.Secret_key;

           string providerId = id;
           long longitudeProvider = (long)args[0];
           long latitudeProvider = (long)args[1];
           string name = (string)args[2];
           string address = (string)args[3];
           string phone = (string)args[4];
           string country = (string)args[5];
           string province = (string)args[6];
           string city = (string)args[7];

           string district = (string)args[8];
           string street = (string)args[9];
           string note = (string)args[10];
           string poiType = (string)args[11];

           RenRenResponseArg<LBSSavePoiDataEntity> resp = await Apis.API.Renren3GApi.SavePoiData(_seesionKey, _secrectKey, longitudeProvider, latitudeProvider,
               name, providerId, address, phone, country, province, city, district, street, note, poiType);

           return resp;    
       }
       
       protected override void DoReset()
       {
           return;
       }

       protected override void DoResetById(string id)
       {
           return;
       }


    }
}
