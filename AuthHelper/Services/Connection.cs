using AuthHelper.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AuthHelper.Services
{
    public class Connection
    {
        public async Task<OAuthResponseModel> Authenticate(ConnectionConfigModel config)
        {
            OAuthResponseModel returnModel = new OAuthResponseModel();

            if (string.IsNullOrEmpty(config.Username) || string.IsNullOrEmpty(config.Password))
            {
                returnModel.Error = "Provide tour Username and Password";
                return returnModel;
            }
            else
            {
                //key values for getting access token from mobile api
                var keyValues = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("username",config.Username),
                    new KeyValuePair<string, string>("password",config.Password),
                    new KeyValuePair<string, string>("grant_type","password")
                };
                //initializing request
                var request = new HttpRequestMessage(HttpMethod.Post, config.BaseUrl);
                request.Content = new FormUrlEncodedContent(keyValues);
                var client = new HttpClient();
                try
                {
                    //sending request
                    var response = await client.SendAsync(request);
                    var content = await response.Content.ReadAsStringAsync();
                    returnModel = JsonConvert.DeserializeObject<OAuthResponseModel>(content);

                    if (!string.IsNullOrEmpty(returnModel.Error))
                    {
                        returnModel.Error = "Invalid Username or Password";
                        return returnModel;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(returnModel.AccessToken))
                            return returnModel;
                        else
                        {
                            returnModel.Error = "Problem Encountered connecting the provider, Token not Found";
                            return returnModel;
                        }
                    }
                }
                catch (Exception e)
                {
                    returnModel.Error = "Problem Encountered connecting the provider";
                    return returnModel;
                }
            }
        }
    }
}
