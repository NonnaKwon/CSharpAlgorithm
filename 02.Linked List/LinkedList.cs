using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        private int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public LinkedListNode<T> First { get { return head; } }
        public LinkedListNode<T> Last { get { return tail; } }

        public LinkedListNode<T> AddFirst(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            if (head == null)
            {
                InsertNodeToEmptyList(newNode);
            }
            else
            {
                InsertNodeBefore(head, newNode);
            }
            return newNode;
        }

        public LinkedListNode<T> AddBefore(LinkedListNode<T> node,T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            
            InsertNodeBefore(node, newNode);
            return newNode;
        }

        public LinkedListNode<T> AddLast(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            if (head == null)
            {
                InsertNodeToEmptyList(newNode);
            }
            else
            {
                InsertNodeBefore(tail, newNode);
            }
            return newNode;
        }

        public LinkedListNode<T> AddAfter(LinkedListNode<T> node,T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            InsertNodeAfter(node, newNode);
            return newNode;
        }

        public bool Remove(T value)
        {
            LinkedListNode<T> findNode = Find(value);
            if(findNode != null)
            {
                RemoveNode(findNode);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Remove(LinkedListNode<T> node)
        {
            RemoveNode(node);
        }

        public void RemoveFirst()
        {
            RemoveNode(head);
        }

        public void RemoveLast()
        {
            RemoveNode(tail);
        }


        public LinkedListNode<T> Find(T value)
        {
            for (LinkedListNode<T> node = First; node != null; node = node.Next)
            {
                if (value.Equals(node.Value))
                    return node;
            }
            return null;
        }

        private void InsertNodeBefore(LinkedListNode<T> node,LinkedListNode<T> newNode)
        {
            LinkedListNode<T> prevNode = node.prev;

            //1. newNode의 prev를 node의 prev로
            newNode.prev = prevNode;

            //2. newNode의 next를 node로
            newNode.next = node;

            //3-1. head를 newNode로
            if(node == head)
            {
                head = newNode;
            }else //3-2. node의 prev의 next를 newNode로
            {
                prevNode.next = newNode;
            }

            //4. node의 prev를 newNode로
            node.prev = newNode;

            count++;
        }

        private void InsertNodeAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            newNode.prev = node;
            newNode.next = node.next;

            if(node == tail)
            {
                tail = newNode;
            }else
            {
                node.next.prev = newNode;
            }
            node.next = newNode;
            count++;
        }

        private void InsertNodeToEmptyList(LinkedListNode<T> newNode)
        {
            head = newNode;
            tail = newNode;
            count++;
        }


        private void RemoveNode(LinkedListNode<T> node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            if (head == node)
                head = node.next;
            if (tail == node)
                tail = node.prev;

            if (node.prev != null)
                node.prev.next = node.next;
            if (node.next != null)
                node.next.prev = node.prev;

            count--;
        }

    }

    public class LinkedListNode<T>
    {
        private T value;

        public LinkedListNode<T> prev;
        public LinkedListNode<T> next;

        public LinkedListNode(T value)
        {
            this.value = value;
            this.prev = null;
            this.next = null;
        }


        public LinkedListNode(T value, LinkedListNode<T> prev, LinkedListNode<T> next)
        {
            this.value = value;
            this.prev = prev;
            this.next = next;
        }

        public LinkedListNode<T> Prev { get { return prev; } }
        public LinkedListNode<T> Next { get { return next; } }
        public T Value { get { return value; } set { this.value = value; } }
    }
}
