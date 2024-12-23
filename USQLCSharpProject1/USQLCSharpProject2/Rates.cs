using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace USQLCSharpProject2
{
    public class Rates
    {
        public static decimal SumRate(int t, decimal V, int k)
        {
            return (V * t * k + V);
        }

    }
}