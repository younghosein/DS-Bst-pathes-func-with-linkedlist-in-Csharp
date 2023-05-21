using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bst_Example_1_1
{
    class Bst
    {
        public Node root;

        #region With Recur
        public bool hp(Node r,List<int> a, int n)
        {
            if (r == null)
            {
                return false;
            }

            a.Add(r.data);

            if (r.data == n)
            {
                return true;
            }

            if (hp(r.left, a, n) || hp(r.right, a, n))
            {
                return true;
            }
   
            a.RemoveAt(a.Count - 1);
            return false;
        }

        public void printP(Node root, int x)
        {
            List<int> arr = new List<int>();

            if (hp(root, arr, x))
            {
                for (int i = 0; i < arr.Count - 1; i++)
                    Console.Write($"[ {arr[i]} ] -> ");
                Console.Write($"[ {arr[arr.Count - 1]} ] ");
            }
            else
            {
                Console.Write("No Path");
            }
        }
        #endregion

        #region without Recur
        public void printTB(Node bn, Dictionary<Node, Node> p)
        {
            Stack<Node> s = new Stack<Node>();

            while (bn != null)
            {
                s.Push(bn);
                bn = p[bn];
            }
            while (s.Count != 0)
            {
                bn = s.Pop();
                Console.Write($"[ {bn.data} ] -> ");
            }
            Console.WriteLine("\n");
        }
        public void printRL(Node r)
        {
            if (r == null)
            {
                return;
            }

            Stack<Node> ns = new Stack<Node>();
            ns.Push(r);

            Dictionary<Node, Node> pr = new Dictionary<Node, Node>();

            pr.Add(r, null);

            while (ns.Count != 0)
            {
                Node cn = ns.Pop();

                if (cn.left == null && cn.right == null)
                {
                    printTB(cn, pr);
                }

                if (cn.right != null)
                {
                    pr.Add(cn.right, cn);
                    ns.Push(cn.right);
                }
                if (cn.left != null)
                {
                    pr.Add(cn.left, cn);
                    ns.Push(cn.left);
                }
            }
        }
        #endregion
    }
}
