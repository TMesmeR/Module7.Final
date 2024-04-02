using Module7.Final.Client.Scripts.Visual.Delivers.PickPointDelivery;
using Module7.Final.Server.Abstract.Classes;
using Module7.Final.Server.Delivers;
using Module7.Final.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Order
{
    internal static class Order
    {

        internal static EnumTypeDelivers enumType = EnumTypeDelivers.HomeDelivery;
      

        internal static string GetCourierName() => Сourier.GetName(); //Возвращает рандомное имя из класса курьеров

        internal static Dictionary <int,(string,int)> GetBasketUser()
        {
            if (BasketUser._basketUser != null)
                return BasketUser._basketUser;              
            return null;

        }

        internal static int GetSumm() => BasketUser.GetSummOrder();

        internal static string GetNameDeliveres<T>(T nameDeliveres) where T :abstractDeliver
        {
            
            return nameDeliveres.GetDeliveryPointName();

        }

        internal static string GetAddressDeliveres<T>(T addressDeliveres) where T: abstractDeliver
        {
            return addressDeliveres.GetAddressDelivery();
        }
       
    }
}
