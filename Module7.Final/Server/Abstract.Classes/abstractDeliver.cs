using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Abstract.Classes
{
    internal abstract class abstractDeliver
    {
        private protected abstract string NameDelivery { get; set; }
        private protected abstract string AddressDelivery { get; set; }
        private protected abstract Dictionary<int,string> BasketDelivery { get; set; }
        private protected abstract float CoastDelivery { get; set; } 

    }
}
