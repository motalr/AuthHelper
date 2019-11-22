using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthHelper.Models
{
    public class OAuthResponseModel
    {
        //for success OAuth authentication
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresInMilliseconds { get; set; }

        [JsonProperty(PropertyName = "userName")]
        public string Username { get; set; }
        [JsonProperty(PropertyName = ".issued")]
        public DateTimeOffset? IssuedOn { get; set; }
        [JsonProperty(PropertyName = ".expires")]
        public DateTimeOffset? ExpiresOn { get; set; }

        //for success OAuth authentication
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }
    }
}
