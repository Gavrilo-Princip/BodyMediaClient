using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BodyMedia.CoreClient
{
    public interface IRequestManager
    {
        string GetApiKey();
        string GetResponse(string uri, string method);
    }
}
