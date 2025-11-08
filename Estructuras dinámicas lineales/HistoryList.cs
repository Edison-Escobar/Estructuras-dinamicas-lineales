using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_dinámicas_lineales
{
    public class HistoryList<T>
    {
        public class Node
        {
            public T Value;
            public Node prev;
            public Node Next;

            public Node(T value)
            {
                Value = value;
            }
        }
    }
}
