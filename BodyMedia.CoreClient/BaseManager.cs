using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient
{
    public abstract class BaseManager
    {
        private IRequestManager _requestManager;
        public BaseManager(IRequestManager requestManager)
        {
            _requestManager = requestManager;
        }

        protected string GetApiKey()
        {
            var result = _requestManager.GetApiKey();
            return result;
        }

        protected T GetResponse<T>(string uri, string method) where T : class
        {
            var resp = _requestManager.GetResponse(uri, method);

            T result;
            var ser = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(resp))
            {
                result = ser.Deserialize(reader) as T;
            }

            var xmlEntity = result as IXmlEntity;
            if (xmlEntity != null)
            {
                xmlEntity.Xml = resp;
            }

            return result;
        }
    }
}
