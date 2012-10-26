using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient
{
    public interface IManager<T>
    {
        T GetData(DateTime date);
        T GetSummary(DateTime date);
        T GetSummary(DateTime startDate, DateTime endDate);
    }
}
