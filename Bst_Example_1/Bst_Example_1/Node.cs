using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bst_Example_1
{
    class Node
    {
        public int data;
        public Node left, right;
        public Node (int data)
        {
            this.data = data;
            right = left = null;
        }
    }
}
