using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Client.Scripts.Visual
{
    /// <summary>
    /// Прощание к клиентом
    /// </summary>
    internal class Farewell
    {
        
        public static void Print()
        {
            Console.Clear();
            Console.WriteLine($"Спасибо что был с нами {ServerUser.clientUser.GetUserName()}");
            Console.WriteLine($"Будем ждать твоего возвращения!");
            Console.ReadKey();  
        }
    }
}
