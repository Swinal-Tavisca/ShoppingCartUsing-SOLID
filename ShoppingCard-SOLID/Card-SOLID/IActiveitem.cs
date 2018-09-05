using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_SOLID
{
    interface IActiveitem
    {
        void addItems(int id);
        void removeItems(int id);
        void totalItems(int id);
        void clear(int id);

    }
}
