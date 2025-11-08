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
            public Node Prev;
            public Node Next;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node Head;
        private Node Current;
        public int Count { get; set; }
        public int Capacity { get; set; }
        public bool CanUndo => Current?.Prev != null;
        public bool CanRendo => Current?.Next != null;

        public HistoryList(T inicialstate)
        {
            Head = Current = new Node(inicialstate);
            Count = 1;
        }

        public void Push (T value)
        {
            var newNode = new Node(value);
            if (Current.Next != null) 
            {
                Current.Next.Prev = null;
                Current.Next = null;
            }

            newNode.Prev = Current;
            Current.Next = newNode;
            Current = newNode;
            Count++;

        }



    }
}
