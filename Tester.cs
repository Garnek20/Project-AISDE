using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Kolejka
{
    class Tester 
    {
        public void testujListe()
        {
            Console.WriteLine("A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("M:");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("B:");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("N:");
            int N = int.Parse(Console.ReadLine());

            Random random = new Random();
            int los ;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            ListaPosortowana<int, int> lista = new ListaPosortowana<int, int>();

            for (int i = 0; i < A; i++)
            {
                los = random.Next(1, M); //zmienna okreslajaca klucz
                lista.dodaj(i, los);
            }

            /*
                        for (int i = 0; i < A; i++)
                        {
                            Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
                        }

                        Console.WriteLine("'///'");
            */
            for (int i = 0; i < B; i++)
            {
                lista.usun();
            }
            /*
           for (int i = 0; i < lista.zwrocRozmiar(); i++)
            {
                Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
            }
            
           Console.WriteLine("///");
            */
            Random random2 = new Random();
            los = random2.Next(1, N);

            lista.dodaj(4, los);
            /*
            for (int i = 0; i < lista.zwrocRozmiar(); i++)
            {
                Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
            }
            
            Console.WriteLine("///");
             * */
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);

             Console.ReadLine();
        }

             public void testujDrzewo()
             {
                 DrzewoTurniejowe<int, int> lista = new DrzewoTurniejowe<int, int>();

                 Console.WriteLine("A:");
                 int A = int.Parse(Console.ReadLine());

                 Console.WriteLine("M:");
                 int M = int.Parse(Console.ReadLine());

                 Console.WriteLine("B:");
                 int B = int.Parse(Console.ReadLine());

                 Console.WriteLine("N:");
                 int N = int.Parse(Console.ReadLine());

                 Stopwatch stopWatch = new Stopwatch();
                 stopWatch.Start();

                 Random random = new Random();
                 int los;
                 for (int i = 0; i < A; i++)
                 {
                     los = random.Next(1, M); //zmienna okreslajaca klucz
                     lista.dodaj(i, los);
                 }

  /*              
                 for (int i = 0; i < A; i++)
                 {
                     Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
                 }
*/
                 Console.WriteLine("///");


                                  for (int i = 0; i < B; i++)
                                  {
                                      lista.usun();
                                  }
          /*       
                                  for (int i = 0; i < lista.zwrocRozmiar(); i++)
                                  {
                                      Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
                                  }
          */      
                                  Console.WriteLine("///");
    
                                  Random random2 = new Random();
                                  los = random2.Next(1, N);

                                  lista.dodaj(4, los);
  /*               
                                  for (int i = 0; i < lista.zwrocRozmiar(); i++)
                                  {
                                     Console.WriteLine("Dane - {0}, klucz - {1} ", lista.dane(i), lista.klucz(i));
                                  }
  */               
                                  Console.WriteLine("///");
                                    
                                  stopWatch.Stop();
                                  TimeSpan ts = stopWatch.Elapsed;

                                  string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                  ts.Hours, ts.Minutes, ts.Seconds,
                                  ts.Milliseconds / 10);

                                  Console.WriteLine("RunTime " + elapsedTime);

                                  
                 Console.ReadLine();
             }
    }
}
