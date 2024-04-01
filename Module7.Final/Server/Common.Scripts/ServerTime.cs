using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Common.Scripts
{
    internal class ServerTime
    {


        private static DateTime serverTime = DateTime.Now;

        internal static DateTime GetServerTime() => serverTime;
    }
}
