using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    class Tester 
    {
        public void testujListe()
        {
            ListaPosortowana<int, int> lista = new ListaPosortowana<int,int>(0);

            Console.WriteLine("A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("M:");
            int M = int.Parse(Console.ReadLine());

            Random random = new Random();
            int los ;
            for (int i = 0; i < A; i++)
            {
                los = random.Next(1, M); //zmienna okreslajaca klucz
                lista.dodaj(i, los);
            }

            for (int i = 0; i < A; i++)
            {
                Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
            }

            Console.WriteLine("B:");
            int B = int.Parse(Console.ReadLine());

            for (int i = 0; i < B; i++)
            {
                lista.usun();
            }

           for (int i = 0; i < lista.zwrocRozmiar(); i++)
            {
                Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
            }

            Console.WriteLine("N:");
            int N = int.Parse(Console.ReadLine());

            Random random2 = new Random();
            los = random2.Next(1, N);

            lista.dodaj(4, los);

            for (int i = 0; i < lista.zwrocRozmiar(); i++)
            {
                Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
            }
            
             Console.ReadLine();
        }
    }
}
