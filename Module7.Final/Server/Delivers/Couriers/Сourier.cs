using Module7.Final.Server.Delivers.Couriers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Delivers.Couriers
{
   

        internal class Courier
        {
            private string Name { get; set; }
            private CarCourier car;

            internal Courier(string name, CarCourier car)
            {
                Name = name;
                this.car = car;
            }

            internal string GetName() => Name;
            internal CarCourier GetCar() => car;
        }

    
}
