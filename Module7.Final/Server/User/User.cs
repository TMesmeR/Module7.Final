using Module7.Final.Server.Abstract.Classes;
using Module7.Final.Server.Common.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.User
{
    /// <summary>
    /// Готовый User
    /// </summary>
    internal class User : abstractUser
    {
        public static User clientUser = new User();
        public User()
        {
            UserName = "Гарри";
            Email = "Potter3000@voland.mort";
            UserAddress = "Косой переулок, где-то некий чулан под лестницей.1Г";
            Birthday = new DateTime(1980, 7, 31);

           
        }

       
    }
}
