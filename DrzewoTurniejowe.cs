using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    class DrzewoTurniejowe<D, K> : IKolejkaable<D, K> where K : IComparable
    {
        private Element<D, K>[] element { get; set; }
        private int wskaznik { get; set; }
        private int pojemnosc { get; set; }

        public DrzewoTurniejowe()
        {
            wskaznik = 0;
            pojemnosc = 1000;
            element = new Element<D, K>[1000];
        }
        public DrzewoTurniejowe(int wielkosc)
        {
             wskaznik = 0;
            pojemnosc = wielkosc;
            element = new Element<D, K>[wielkosc];
        }
        public void dodaj(D dan, K klu)
        {
            wskaznik++;
            Element<D, K> nowy = new Element<D, K>( dan,  klu);
            
            if(wskaznik == 1)
            {
                element[0] = nowy;
            }
            if(wskaznik == pojemnosc)
            {
                element = new Element<D, K>[2 * pojemnosc];

                if(element[wskaznik-2].zwrocKlucz().CompareTo(nowy.zwrocKlucz()) < 0)
                {
                    Element<D, K> tmp;
                    tmp = element[wskaznik -1];
                    element[wskaznik - 1] = nowy;
                    nowy = tmp;
                }
                else
                {
                    element[wskaznik - 1] = nowy;
                }
            }
            if(wskaznik > 1 && wskaznik < pojemnosc)
            {
                element[wskaznik - 1] = nowy;
                if (element[wskaznik - 2].zwrocKlucz().CompareTo(element[wskaznik - 1].zwrocKlucz()) > 0)
                {
                    Element<D, K> tmp;
                    tmp = element[wskaznik - 2];
                    element[wskaznik - 2] = element[wskaznik - 1];
                    element[wskaznik - 1] = tmp;
                }
                else
                {
                    element[wskaznik - 1] = nowy;
                }
            }
        }
        public void usun()
        {
            if (wskaznik == 0)
            {
                Console.WriteLine("Lista jest pusta, nie moge nic usunac");
            }
            else
            {
                wskaznik--;
                for(int i = wskaznik -2; i >=0; i--)
                {
                    if (element[i+1].zwrocKlucz().CompareTo(element[i+2].zwrocKlucz()) > 0)
                    {
                        Element<D,K> tmp;
                        tmp = element[i+2];
                        element[i+2] = element[i+1];
                        element[i+1] = tmp;
                    }
                    
                }

            }
        }



        public int zwrocRozmiar()
        {
            return wskaznik;
        }
        public K klucz(int i)
        {
            return element[i].zwrocKlucz();
        }
        public D dane(int i)
        {
            return element[i].zwrocDane();
        }

    }
}
