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
        
        Unsorted_list()
        {
               capacity = 100;
               length = 0;
               
        }
       
        public void insert(D item)
        {
            if (length >= capacity)
            {
                throw new StackOverflowException();
            }
            else
            {
                _item[length] = item;
                length++;
            }

        }

        public D delete(int number)
        {
            if(number < 0 || number > length -1 || length <= 0)
                throw new StackOverflowException();
            else
            {
                length--;
                return _item[length];
            }

       }

       public int count()
       {
            return length;
       }
    }


}
