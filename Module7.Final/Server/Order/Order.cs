using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Order
{
    internal static class Order
    {

        private static int Summ;
        static Order()
        {
            Summ = User.BasketUser.GetSummOrder();
        }

        internal static int GetSumm() => Summ;


    }
}
