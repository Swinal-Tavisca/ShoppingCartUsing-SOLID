using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_SOLID
{
    public class ActiveItem :IActiveitem
    {
        Items Items = new Items();
        public void addItems(int id)
        {
            Items.item++;
            Items.amount++;
            totalItems(id);
        }
        public void removeItems(int id)
        {
            Items.item--;
            Items.amount--;
            totalItems(id);
        }
        public void totalItems(int id)
        {
            Console.WriteLine("TOTAL ITEMS " + Items.item);
        }
        public void clear(int uid)
        {
            Items.item = 0;
            Items.amount = 0;
        }


    }
}
