using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bst_Example_1_1
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
            //           1
            //         /   \    
            //        2     3
            //      /   \   /
            //     4     5
            //      \   / \
            //       8 6   7
            //      /
            //     9

            #region withRecur
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Please Enter A Data To Print Path From Root To Given Data In Tree : ");
            //int gn = int.Parse(Console.ReadLine());
            //Console.Write("\nThe Path Is : ");
            //b.printP(b.root, gn);
            //Console.ResetColor();
            //Console.WriteLine("\n");
            #endregion

            #region withoutRecur
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("All Pathes Are : \n");
            b.printRL(b.root);
            Console.ResetColor();
            Console.WriteLine("\n");
            #endregion

            Console.ReadKey();
        }
    }
}
