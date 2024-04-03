using Module7.Final.Server.Common.Scripts;
using Module7.Final.Server.Order;
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
        internal static void Print()
        {
            Console.WriteLine($"Добро пожаловать {ServerUser.clientUser.GetUserName()}");

            if (ServerUser.clientUser.GetBirthDay().Month == ServerTime.GetServerTime().Month
                && ServerUser.clientUser.GetBirthDay().Day == ServerTime.GetServerTime().Day)
            {
                Console.WriteLine($"{ServerUser.clientUser.GetUserName()} видим что вам исполнилось {ServerUser.clientUser.GetAge()}");
                Console.WriteLine($"Сегодня вы получите скидку в {ServerOrders.extensionOrder.GetDiscount()} процентов");
            }

        }
    }
}
