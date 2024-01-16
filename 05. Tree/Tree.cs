using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Tree
{
    public class TreeNode<T>
    {
        public T item;

        public TreeNode<T> parent;
        public List<TreeNode<T>> children;
    }

    public class BinaryNode<T>
    {
        public T item;
        public TreeNode<T> parent;
        public TreeNode<T> left;
        public TreeNode<T> right;
    }

    internal class Tree
    {
        
    }
}
