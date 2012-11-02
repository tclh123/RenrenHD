using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Models;

namespace RenrenCore.Entities
{
    public sealed class OauthResultEntity : PropertyChangedBase
    {
        private string access_token = "";
        public string Access_Token
        {
            get { return access_token; }
            set 
            {
                access_token = value; 
                
                this.NotifyPropertyChanged(oauthResultEntity => oauthResultEntity.Access_Token);
            }
        }

        private string expires_in = "";
        public string Expires_In
        {
            get { return expires_in; }
            set 
            { 
                expires_in = value;

                this.NotifyPropertyChanged(oauthResultEntity => oauthResultEntity.Expires_In);
            }
        }

        private string refresh_token = "";
        public string Refresh_Token
        {
            get { return refresh_token; }
            set 
            { 
                refresh_token = value;

                this.NotifyPropertyChanged(oauthResultEntity => oauthResultEntity.Refresh_Token);
            }
        }

        private string scope = "";
        public string Scope
        {
            get { return scope; }
            set 
            { 
                scope = value;

                this.NotifyPropertyChanged(oauthResultEntity => oauthResultEntity.Scope);
            }
        }
    }
    public sealed class OauthRequestEntity
    {
        public string api_key { get; set; }

        public string redirect_uri { get; set; }

        public string scope { get; set; }

        public int switchUser { get; set; }

        public string cancel_url { get; set; }

        public int show_header { get; set; }
    }


}
