using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinariSearchTree
{
    /*Node Class consi*/
    class Node
    {
        public string info;
        public Node lchild;
        public Node rchild;

        //Construkstore for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; //intalizin root to null
        }
        

        public void find(string element, ref Node parent, ref Node currentnode)
        {
            currentnode = ROOT;
            parent = null;
            while((currentnode != null)&& (currentnode.info != null))
            {
                parent = currentnode;
                if (string.Compare(element, currentnode.info) < 0)
                    currentnode = currentnode.rchild;
                else
                    currentnode = currentnode.lchild;
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
        }
    }
}
