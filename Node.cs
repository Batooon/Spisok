using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisok
{
    class Node
    {
        Node next;
        public int data;
        public void SetNextNode(Node nextNode)
        {
            next = nextNode;
        }

    }
}
