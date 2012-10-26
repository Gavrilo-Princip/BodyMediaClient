using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient
{
    public class BurnManager : BaseManager, IManager<Burn>
    {
        public BurnManager(IRequestManager requestManager) : base(requestManager) { }

        public Burn GetData(DateTime date)
        {
            const string urlFormat = "http://api.bodymedia.com/v2/burn/day/minute/intensity/{0}?api_key={1}";
            var apiKey = GetApiKey();
            var dateString = date.ToString("yyyyMMdd");
            var url = string.Format(urlFormat, dateString, apiKey);

            var result = GetResponse<Burn>(url, "GET");
            return result;
        }

        public Burn GetSummary(DateTime date)
        {
            const string urlFormat = "http://api.bodymedia.com/v2/burn/intensity/{0}?api_key={1}";
            var apiKey = GetApiKey();
            var dateString = date.ToString("yyyyMMdd");
            var url = string.Format(urlFormat, dateString, apiKey);
            
            var result = GetResponse<Burn>(url, "GET");
            return result;
        }

        public Burn GetSummary(DateTime startDate, DateTime endDate)
        {
            const string urlFormat = "http://api.bodymedia.com/v2/burn/day/intensity/{0}/{1}?api_key={2}";
            var apiKey = GetApiKey();
            var date1String = startDate.ToString("yyyyMMdd");
            var date2String = endDate.ToString("yyyyMMdd");
            var url = string.Format(urlFormat, date1String, date2String, apiKey);

            var result = GetResponse<Burn>(url, "GET");
            return result;
        }
    }
}
