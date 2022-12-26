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
        public void insert(string element) // insert a root the binary
        {
            Node tmp, parent = null, currentnode = null;
            find(element, ref parent, ref currentnode);
            if (currentnode != null)
            {
                Console.WriteLine("duplicat words not allowed");
                return;
            }
            else // if the specified node is not present
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.lchild = tmp;
                }
                else
                {
                    parent.rchild = tmp;
                }
            }
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
        public void inorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("tree is empty");
                return;
            }
            if(ptr != null)
            {
                inorder(ptr.lchild);
                Console.WriteLine(ptr.info + "");
                inorder(ptr.rchild);
            }
        }
        public void preorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("tree empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + "");
                preorder(ptr.lchild);
                preorder(ptr.rchild);
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
