using Module7.Final.Server.Common.Scripts;
using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Client.Scripts.Visual
{
    /// <summary>
    /// Визуальная часть корзины
    /// </summary>
    internal static class Basket
    {
        static Dictionary<int, (string,int)> BasketDictionary;

        /// <summary>
        /// выводит количество товаров в корзине в меню
        /// </summary>
        /// <returns></returns>
        internal static int PrintCount() => BasketUser._basketUser.Count; 
        
        internal static void PrintBasket()
        {
            while (true)
            {

                if (BasketUser._basketUser.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Корзина пуста");
                    return;
                }
                else
                {
                    Console.Clear();

                    BasketDictionary = DictionaryOf.CreateADictionaryBasket(BasketUser._basketUser);
                    
                    Console.WriteLine("В корзине:");
                    foreach (var Product in BasketDictionary)
                    {
                        Console.WriteLine($"{Product.Key} - {Product.Value.Item1} - {Product.Value.Item2}");
                    }
                    Console.WriteLine ($"Общая сумма покупки {BasketUser.GetSummOrder()}");

                    Console.WriteLine("Введите номер продукта, если хотите его удалить.");
                    Console.WriteLine("Введите 0 для возврата в меню");
                    sbyte pick = Checks.CheckPick(BasketDictionary);
                    if (pick == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                        BasketUser.RemoveInBasketUser(pick, BasketDictionary);
                }
            }
        }

    }
}
