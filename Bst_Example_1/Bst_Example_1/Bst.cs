using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bst_Example_1
{
    class Bst
    {
        public Node root;
        public int h, lh, rh, c;
        public Node t;

        public int height(Node root)
        {
            if (root == null)
                return 0;
            int lht = height(root.left);
            int rht = height(root.right);

            // update the answer, because diameter of a
            // tree is nothing but maximum value of
            // (left_height + right_height + 1) for each node
            if (h < 1 + lht + rht)
            {
                h = 1 + lht + rht;

                // save the root, this will help us finding the
                //  left and the right part of the diameter
                t = root;

                // save the height of left & right subtree as well.
                lh = lht;
                rh = rht;
            }
            return 1 + Math.Max(lht, rht);

        }

        // prints the root to leaf path
        public void printA(int[] a, int l)
        {
            int i;

            // print left part of the path in reverse order
            if (c == 0)
            {
                for (i = l - 1; i >= 0; i--)
                {
                    Console.Write($"[ {a[i]} ] -> ");
                }
            }
            else if (c == 1)
            {
                for (i = 0; i < l; i++)
                {
                    Console.Write($"[ {a[i]} ] -> ");
                }
            }
        }

        // this function finds out all the root to leaf paths
        public void printPR(Node n, int[] b, int i, int mx)
        {
            if (n == null)
                return;
            // append this node to the path array
            b[i] = n.data;
            i++;

            // If it's a leaf, so print the path that led to here
            if (n.left == null && n.right == null)
            {

                // print only one path which is equal to the
                // height of the tree.
                if (i == mx && (c == 0 || c == 1))
                {
                    printA(b, i);
                    c = 2;
                }
            }
            else
            {

                // otherwise try both subtrees
                printPR(n.left, b, i, mx);
                printPR(n.right, b, i, mx);
            }
        }

        // Computes the diameter of a binary tree with given root.
        public void diameter(Node r)
        {
            if (r == null)
                return;

            // lh will store height of left subtree
            // rh will store height of right subtree
            h = Int32.MinValue;
            lh = 0;
            rh = 0;

            // f is a flag whose value helps in printing
            // left & right part of the diameter only once
            c = 0;
            int ht = height(r);


            int[] z = new int[100];
            int j = 0 * ht;

            // print the left part of the diameter
            printPR(t.left, z, j, lh);
            Console.Write($"[ {t.data} ] --> ");
            int[] v = new int[100];
            c = 1;

            // print the right part of the diameter
            printPR(t.right, v, j, rh);
        }
    }
}
