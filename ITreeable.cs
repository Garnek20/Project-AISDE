using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    interface ITreeable<D,K>:IKolejkaable<D>, IComparable
    {
        //metods
        void insert(D objekt, K key);
        
    }
}
