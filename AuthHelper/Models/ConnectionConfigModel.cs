using System;
using System.Collections.Generic;
using System.Text;

namespace AuthHelper.Models
{
    public class ConnectionConfigModel
    {
        public string BaseUrl { get; set; } //ex: sitename.com or http://192.168.12.7:45498


        //depends on your configuration in Startup.Auth
        //public string TokenEndpointPath { get; set; } //ex: /Token or /api/Token 
        public string Username { get; set; } 
        public string Password { get; set; }  
    }
}
