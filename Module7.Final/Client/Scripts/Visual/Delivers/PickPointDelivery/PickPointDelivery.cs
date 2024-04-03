﻿using Module7.Final.Server.Delivers;
using Module7.Final.Server.Order;
using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orders = Module7.Final.Server.Order.Order;

namespace Module7.Final.Client.Scripts.Visual.Delivers.PickPointDelivery
{
    internal class PickPointDeliverys
    {
        private static int discount = ServerOrders.extensionOrder.GetDiscount();
        private static int sumDiscount = ServerOrders.extensionOrder.GetSummDiscount();
        internal static void PickPointDelivery()
        {
            Console.Clear();
            Console.WriteLine("Подробности заказа:");
            Console.Write($"{User.clientUser.GetUserName()}, ");
            Console.WriteLine($"Ваш заказ будет доставлен в магазин {ServerOrders.GetNameDeliveres(PickPointDeliveres.PointDeliveres )}");
            Console.WriteLine($"Адрес магазина: {ServerOrders.GetAddressDeliveres(PickPointDeliveres.PointDeliveres)}");
            Console.WriteLine($"Доставка будет осуществлена в течении часа");
            Console.WriteLine($"Пожалуйста заберите заказ в течении 2 дней по времени работы магазина");
            Console.WriteLine($"Чек вы получите на вашу почту: {User.clientUser.GetEmail()}");
            Console.WriteLine();
            Console.WriteLine("//--------------------------------------------------//");
            Console.WriteLine("Ваш заказ:");
            BasketUser.PrintBasket(ServerOrders.GetBasketUser());
            Console.WriteLine();
            Console.WriteLine($"Сумма заказа:{ServerOrders.GetSumm()}");
            Console.WriteLine();
            Console.Write("Ваша скидка: ");
            Console.WriteLine(discount);
            if (discount != 0) Console.WriteLine($"Сумма покупки с учетом скидки равна : {sumDiscount}");
            Console.WriteLine("Для возврата в меню введите Enter...");
            Console.ReadLine();
            Console.Clear();
            
        }





    }

}
