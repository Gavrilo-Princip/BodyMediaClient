using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyMediaApi.Entities;

namespace BodyMediaApi
{
    public interface ISleepManager
    {
        Sleep GetData(DateTime date);
        Sleep GetSummary(DateTime date);
        Sleep GetSummary(DateTime startDate, DateTime endDate);
    }
}
