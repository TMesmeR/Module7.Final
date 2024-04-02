using Module7.Final.Client.Scripts.Visual.Delivers.PickPointDelivery;
using Module7.Final.Client.Scripts.Visual.Delivers.ShopDeliverys;
using Module7.Final.Server.Delivers;
using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module7.Final.Client.Scripts.Visual
{
    internal static class Order
    {
        
       internal static void Print()
        {
            if (Server.Order.Order.enumType == EnumTypeDelivers.HomeDelivery)
                Visual.Delivers.Delivers.HomeDelivers.HomeDeliver();
            else if (Server.Order.Order.enumType == EnumTypeDelivers.PickPointDelivery)
                PickPointDeliverys.PickPointDelivery();
            else
                ShopDeliverys.ShopDelivery();
        }

    

      

        

    }
}
