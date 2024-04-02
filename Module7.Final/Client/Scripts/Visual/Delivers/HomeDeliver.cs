using Module7.Final.Server.User;

namespace Module7.Final.Client.Scripts.Visual.Delivers.Delivers
{
    internal  class HomeDelivers
    {


        internal static void HomeDeliver()
        {
            Console.Clear();
            Console.WriteLine("Подробности заказа:");
            Console.Write($"{User.clientUser.GetUserName()}, ");
            Console.WriteLine("Ваш заказ будет доставлен на дом");
            Console.WriteLine($"Адрес доставки: {User.clientUser.GetUserAdress()}");
            Console.WriteLine($"Доставка будет осуществлена в течении часа");
            Console.WriteLine($"Чек вы получите на вашу почту: {User.clientUser.GetEmail()}");
            Console.WriteLine();
            Console.WriteLine("//--------------------------------------------------//");
            Console.WriteLine($"Имя курьера: {Server.Order.Order.GetCourierName()}");
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