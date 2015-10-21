using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the size of list, please:");
            int size = int.Parse(Console.ReadLine());

            Unsorted_list<int> lista = new Unsorted_list<int>(size);
            lista.insert(4);
            lista.insert(3);

            for(int n = 0; n < lista._length; n++)
            {
                System.Console.WriteLine(lista.show(n));
            }



        }
    }
}
