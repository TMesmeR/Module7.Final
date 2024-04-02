using Module7.Final.Server.Delivers;
using Module7.Final.Server.Order;
using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders = Module7.Final.Server.Order.Order;

namespace Module7.Final.Client.Scripts.Visual.Delivers.ShopDeliverys
{
    internal class ShopDeliverys
    {
        internal static void ShopDelivery()
        {
            Console.Clear();
            Console.WriteLine("Подробности заказа:");
            Console.Write($"{User.clientUser.GetUserName()}, ");
            Console.WriteLine($"Ваш заказ будет доставлен в магазин {Orders.GetNameDeliveres(ShopDelivers.PointDeliveres)}");
            Console.WriteLine($"Адрес магазина: {Orders.GetAddressDeliveres(ShopDelivers.PointDeliveres)}");
            Console.WriteLine($"Заказ можно забрать в течении недели");
            Console.WriteLine($"Пожалуйста заберите заказ в течении 2 дней по времени работы магазина");
            Console.WriteLine($"Чек вы получите на вашу почту: {User.clientUser.GetEmail()}");
            Console.WriteLine();
            Console.WriteLine("//--------------------------------------------------//");
            Console.WriteLine("Ваш заказ:");
            BasketUser.PrintBasket(Server.Order.Order.GetBasketUser());
            Console.WriteLine();
            Console.WriteLine($"Сумма заказа:{Server.Order.Order.GetSumm()}");
            Console.WriteLine();
            Console.WriteLine("Для возврата в меню введите Enter...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
