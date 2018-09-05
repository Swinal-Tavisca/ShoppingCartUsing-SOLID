using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_SOLID
{
    public class Payment :Ipayment
    {
       
        public void paymentMethod(int id)
        {
            Console.WriteLine("1. CASH");
            Console.WriteLine("2. ONLINE");
            int method = Console.Read();
            if(method==1)
            {
                displayPayment(id);
            }
            else
            {
                displayPayment(id);
            }
        }
        public void displayPayment(int id)
        {
            Console.WriteLine("TOTAL PAYMENT =" );
        }
      

    }
}
