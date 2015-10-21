using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kolejka
{
    public class Unsorted_list<D>:IKolejkaable<D>
    {
        //table with data
        D[] _item;
        
        //pointer using to find elements
        int _pointer;
        //lists capacity
        int capacity;

        public int _length;

        public Unsorted_list(int size)
        {
               _pointer = 0;
               capacity = size;
               //_length = size;
               D[] _item = new D[capacity];
               
        }
       
        public void insert(D item)
        {
            if ( _pointer >= capacity)
            {
                throw new StackOverflowException();
            }
            else
            {
                _item[_pointer] = item;
                _pointer++;
            }

        }

        public object delete(int number)
        {
            if(number < 0 || number > _length -1 || _length <= 0)
                throw new StackOverflowException();
            else
            {
                _length--;
                return _item[_length];
            }
            
       }

        public object show(int n)
        {
            return _item[n];
        }

        public int count()
        {
            return _length;
        }
    }


}
