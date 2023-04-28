using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDataTypes.Code
{
    internal class Enums
    {
        internal enum SalesStatus
        {
            Successful = 1,
            PendingOfPayment = 2,
            Cancelled = 3
        }

        public void TheCode()
        {
            var statusOfTheSaleOfATshirt = SalesStatus.Successful;
            var status = (int)statusOfTheSaleOfATshirt;
            Console.WriteLine(status);

            var status3 = 3;
            var status3Enum = (SalesStatus)status3;
            Console.WriteLine(status3Enum);

            switch (statusOfTheSaleOfATshirt)
            {
                case SalesStatus.Successful:
                    Console.WriteLine("The sale was successful");
                    break;
                case SalesStatus.PendingOfPayment:
                    Console.WriteLine("The client must pay");
                    break;
                case SalesStatus.Cancelled:
                    Console.WriteLine("How could this happen to me?");
                    break;
            }

            Console.WriteLine("The end");
        }
    }
}
