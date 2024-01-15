using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Stack<T>
    {
        private List<T> container;

        public Stack() 
        { 
            container = new List<T>();
        }

        public int Count { get { return container.Count; } }

        public void Push(T item)
        {
            container.Add(item);
        }

        public T Pop()
        {
            T item = container[container.Count - 1];
            container.RemoveAt(container.Count - 1);
            return item;
        }
    }
}
