﻿using Module7.Final.Server.Common.Scripts;
using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Client.Scripts.Visual
{
    /// <summary>
    /// Меню - оно и в Африке меню
    /// </summary>
    internal class Menu
    {
        static sbyte pickButton;
        internal static void PrintMenu()
        {
            while (true)
            {
                
                Console.WriteLine($"Вас счет: {User.clientUser.GetWallet()}.р");
                Console.WriteLine("Пожалуйста, выберите дальнейшее действие:");
                Console.WriteLine();
                Console.WriteLine("1 - Посмотреть группы товаров");
                Console.WriteLine($"2 - Просмотр корзины. В корзине товаров: {Basket.PrintCount()}");
                Console.WriteLine("3 - Выбор способа получения товара");
                Console.WriteLine("4 - Просмотр состояния заказа");
                Console.WriteLine("0 - Выход из программы");

                pickButton = Checks.CheckPickMenu();
                SwitchPick(ref pickButton);

                if (pickButton == 0)
                {
                    return;
                }
                    

            }
        }

        static void SwitchPick(ref sbyte pickButton)
        {
            switch (pickButton)
            {
                case 1:
                    ViewGroupProducts.PrintCategories();
                    break;
                case 2:
                    Basket.PrintBasket();
                    break;
                case 3:
                    Delivers.PrintDelivers();
                    break;
                case 4:
                    break;
            }
        }
    }
}
