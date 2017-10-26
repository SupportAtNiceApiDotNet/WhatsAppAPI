using System;
using System.Net;
using System.Net.Http;
using System.IO;

namespace WhatsAppAPI_CS
{
    class WhatApp
    {
        private String APPIID;

        public WhatApp(String appid)
        {
            this.APPIID = appid;
        }

        public bool Send(String mobileNo, String message) 
        {
            try
            {
                string url = "https://NiceApi.net/API";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers.Add("X-APIId", APPIID);
                request.Headers.Add("X-APIMobile", mobileNo);
                using (StreamWriter streamOut = new StreamWriter(request.GetRequestStream()))
                {
                    streamOut.Write(message);
                }
                using (StreamReader streamIn = new StreamReader(request.GetResponse().GetResponseStream()))
                {
                    return streamIn.ReadToEnd().Equals("queued");
                }
            }
            catch 
            {
            }
            return false;
        }
    }
}
