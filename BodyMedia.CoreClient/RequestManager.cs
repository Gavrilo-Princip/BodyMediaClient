using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace BodyMedia.CoreClient
{
    public class RequestManager : IRequestManager
    {
        private readonly OAuthManager _oauthManager;
        public RequestManager(OAuthManager oauthManager)
        {
            _oauthManager = oauthManager;
        }

        public string GetApiKey()
        {
            var result = _oauthManager["api_key"];
            return result;
        }
        public string GetResponse(string uri, string method)
        {
            string authHeader = _oauthManager.GenerateAuthzHeader(uri, method);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = method;
            request.ServicePoint.Expect100Continue = false;
            request.Headers["Authorization"] = authHeader;
            using (var response = GetResponse(request))
            {
                using (var responseStrm = response.GetResponseStream())
                {
                    using (var responseReader = new System.IO.StreamReader(responseStrm))
                    {
                        var responseBody = responseReader.ReadToEnd();
                        return responseBody;
                    }
                }
            }
        }
        private HttpWebResponse GetResponse(HttpWebRequest request)
        {
            try
            {
                var result = (HttpWebResponse)request.GetResponse();
                return result;
            }
            catch (WebException e)
            {
                var result = (HttpWebResponse)e.Response;
                return result;
            }
        }
    }
}
