using Module7.Final.Server.Common.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Client.Scripts.Visual
{
    internal class Delivers

    {
        static sbyte pickButton;
        internal static void PrintDelivers()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите 0 для возврата в меню");
                Console.WriteLine("Выберите способ доставки:");
                Console.WriteLine();

                Console.WriteLine("1 - доставка на дом");
                Console.WriteLine("2 - доставка курьером ");
                Console.WriteLine("3 - доставка в определенную точку");
                pickButton = Checks.CheckPickWayDelivers();
                SwitchPick(ref pickButton);
                if (pickButton == 0)
                {
                    return;
                }
            }

        }


        static void SwitchPick(ref sbyte num)
        {
            switch (num)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        } 
    }
}
