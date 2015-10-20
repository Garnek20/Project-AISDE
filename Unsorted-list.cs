using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    class Unsorted_list<D>:IKolejkaable<D>
    {
        D[] _item;

        int capacity;
        int length;
       
        public void insert(D item)
        {
            if (length == 0)
            {
                _item[length] = item;
                length++;
            }

        }

        public void delete(Object objekt)
        {

        }
    }

}
