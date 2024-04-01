using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Client.Scripts.Visual
{ /// <summary>
/// Console.WriteLine("Hell World");
/// </summary>
    internal static class Welcome
    {
        internal static void Print() => Console.WriteLine($"Добро пожаловать {Server.User.User.clientUser.GetUserName()}");

    }
}
