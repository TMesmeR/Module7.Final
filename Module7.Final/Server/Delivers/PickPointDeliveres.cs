using Module7.Final.Server.Abstract.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Delivers
{
    internal class PickPointDeliveres:abstractDeliver
    {
        internal static Delivers.PickPointDelivers  pointDeliveres;
        internal static PickPointDeliveres PointDeliveres = new PickPointDeliveres();
        private string DeliveryPointName { get; set; }
        public PickPointDeliveres() 
        {

            if(pointDeliveres == PickPointDelivers.Pyatoroshka)
            {
                DeliveryPointName = "\"Пяторочка\"";
                base.AddressDelivery = "Здание музея \"Изнакурнож\"";
            }
            if (pointDeliveres == PickPointDelivers.Perekrestok)
            {
                DeliveryPointName = "\"Перекресток\"";
                base.AddressDelivery = "Бывшее здание \"ИИЧАВО\"";

            }
            if (pointDeliveres == PickPointDelivers.Lenta)
            {
                DeliveryPointName = "\"Лента\"";
                base.AddressDelivery = "ул. Рога и Копыта. д.13/13";

            }

        }

        internal override string GetDeliveryPointName() => DeliveryPointName;

    }
}
