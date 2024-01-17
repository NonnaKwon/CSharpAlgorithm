using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public class PriorityQueue<TElement, TPriority> where TPriority : IComparable<TPriority>
    {
        private struct Node
        {
            public TElement element;
            public TPriority priority;

            public Node(TElement element, TPriority priority)
            {
                this.element = element;
                this.priority = priority;
            }
        }

        private List<Node> nodes;

        public PriorityQueue()
        {
            nodes = new List<Node>();
        }

        public void Enqueue(TElement element,TPriority priority) 
        { 
            Node newNode = new Node(element, priority);
            nodes.Add(newNode);
            int index = nodes.Count - 1;
            while(index > 0)
            {
                int parentIndex = (index - 1) / 2;
                Node parentNode = nodes[parentIndex];
                if(newNode.priority.CompareTo(parentNode.priority)<0)
                {
                    nodes[index] = parentNode;
                    index = parentIndex;
                }
                else
                {
                    break;
                }
                nodes[index] = newNode;
            }
        }

        public TElement Dequeue()
        {
            Node rootNode = nodes[0];

            //제거 작업
            Node lastNode = nodes[nodes.Count - 1]; //마지막 노드
            nodes[0] = lastNode;
            nodes.RemoveAt(nodes.Count - 1);

            //하강작업 진행
            int index = 0;
            while(index < nodes.Count)
            {
                //오른자식, 왼쪽자식중에 더 작은쪽으로 내려갈거임
                int leftIndex = 2 * index + 1;
                int rightIndex = 2 * index + 2;
                if (rightIndex < nodes.Count) //자식이 둘 다 있는 경우
                {
                    int lessIndex;
                    if (nodes[leftIndex].priority.CompareTo(nodes[rightIndex].priority) < 0)
                    {
                        lessIndex = leftIndex;
                    }
                    else
                    {
                        lessIndex = rightIndex;
                    }

                    Node lessNode = nodes[lessIndex];
                    if (nodes[index].priority.CompareTo(nodes[leftIndex].priority) > 0)
                    {
                        nodes[lessIndex]  = lessNode;
                        nodes[index] = lessNode;
                        index = lessIndex;
                    }else
                    {
                        break;
                    }
                } else if(leftIndex < nodes.Count) //자식이 하나만 있는 경우
                {
                    Node leftNode = nodes[leftIndex];
                    if (nodes[index].priority.CompareTo(nodes[leftIndex].priority) > 0))
                    {
                        nodes[leftIndex] = lastNode;
                        nodes[index] = leftNode;
                        index = leftIndex;

                    }
                }else //자식이 없는 경우
                {
                    break;
                }

            }


            return rootNode.element;
        }
    }
}
