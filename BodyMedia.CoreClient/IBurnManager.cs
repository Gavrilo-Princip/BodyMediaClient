using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyMediaApi.Entities;

namespace BodyMediaApi
{
    public interface IBurnManager
    {
        Burn GetData(DateTime date);
        Burn GetSummary(DateTime date);
        Burn GetSummary(DateTime startDate, DateTime endDate);
    }
}
