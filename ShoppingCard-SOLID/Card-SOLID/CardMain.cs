using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_SOLID
{
    class CardMain
    {
        static void Main(string[] args)
        {
            int f = 0;
            List<Items> item = new List<Items>();
            ActiveItem activeItem = new ActiveItem();
            Payment payment = new Payment();

            do
            {
                
                Console.WriteLine("ENTER USER ID");
                int uid = Console.Read();

                Console.WriteLine("1. ADD ITEMS");
                Console.WriteLine("2. REMOVE ITEMS");
                Console.WriteLine("3. DO PAYMENT");
                Console.WriteLine("4. TOTAL ITEMS");
                Console.WriteLine("5. CLEAR CARD");
                Console.WriteLine("6. DISPLAY PAYMENT DETAILS");
                Console.WriteLine("7.EXIT");
                int opt = Console.Read();
                if(opt==1)
                {
                    activeItem.addItems(uid);
                }
                else if(opt==2)
                {
                    activeItem.removeItems(uid);
                }
                else if(opt==3)
                {
                    payment.paymentMethod(uid);
                }
                else if(opt==4)
                {
                    activeItem.totalItems(uid);
                }
                else if(opt==5)
                {
                    activeItem.clear(uid);
                }
                else if(opt==6)
                {
                    payment.displayPayment(uid);
                }
                else if(opt==7)
                {
                    f = 1;
                }
                
            } while (f == 0);
           

        }
    }
}
