using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    interface IGenericQueue<T>
    {
        void Enqueue(T Data);
        T Dequeue();

        bool IsEmpty { get; }
        int Size { get; }
    }
}
