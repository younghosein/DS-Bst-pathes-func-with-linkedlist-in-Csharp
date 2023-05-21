using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bst_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bst b = new Bst();
            b.root = new Node(1);
            b.root.left = new Node(2);
            b.root.right = new Node(3);
            b.root.left.left = new Node(4);
            b.root.left.right = new Node(5);
            b.root.left.right.left = new Node(6);
            b.root.left.right.right = new Node(7);
            b.root.left.left.right = new Node(8);
            b.root.left.left.right.left = new Node(9);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Longest Leaf To Leaf Path In A Tree Is : \n");
            b.diameter(b.root);
            Console.ResetColor();
            Console.WriteLine("\n");
            //           1
            //         /   \    
            //        2     3
            //      /   \  
            //     4     5
            //      \   / \
            //       8 6   7
            //      /
            //     9
            Console.ReadKey();
        }
    }
}
