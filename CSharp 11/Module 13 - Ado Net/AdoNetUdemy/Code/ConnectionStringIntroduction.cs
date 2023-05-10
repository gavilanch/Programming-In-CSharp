using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetUdemy.Code
{
    internal class ConnectionStringIntroduction
    {
        public void TheCode()
        {
            // You must use your own connection string. I leave mine here as a reference.
            
            // Windows Authentication
            var connectionString = "Data Source=LAPTOP-4KBFRF57;Database=AdoNetDemo;Integrated Security=True;TrustServerCertificate=True";

            // SQL Server account
            //var connectionString2 = "Data Source=LAPTOP-4KBFRF57;Database=AdoNetDemo;Integrated Security=False;User Id=myUser;Password=MyPassword";
        }
    }
}
