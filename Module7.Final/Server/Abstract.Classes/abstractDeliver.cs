using Module7.Final.Server.Delivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Abstract.Classes
{
    internal abstract class abstractDeliver
    {
        
       
        private protected  string AddressDelivery { get; set; }
        

        internal string GetAddressDelivery() => AddressDelivery;
        internal abstract string GetDeliveryPointName();
    }
}

