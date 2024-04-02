using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Delivers
{
    internal static class Сourier
    {
        
        private static string Name { get; set; }
        private static int rnd;
        static Сourier()
        {
            rnd = Random.Shared.Next(1,4);

            if (rnd == 1) 
                Name = "Tomas";
            if (rnd == 2)
                Name = "Alex";
            if (rnd == 3)
                Name = "Alisa";

        }

        internal static string GetName() => Name;

    }
}
