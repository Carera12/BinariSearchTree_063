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
    class Program
    {
        
        static void Main(string[] args)
        {
        }
    }
}
